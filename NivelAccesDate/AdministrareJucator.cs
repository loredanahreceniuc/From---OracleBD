using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
namespace NivelAccesDate
{
    public class AdministrareJucator : IStocareJucator
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Jucator> GetJucatori()
        {
            var result = new List<Jucator>();
            var dsJucator = SqlDBHelper.ExecuteDataSet("select * from jucator_lh", CommandType.Text);
            foreach(DataRow linieDB in dsJucator.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Jucator(linieDB));
            }
            return result;
        }

        public Jucator getCelMaiTanarJucator()
        {
            Jucator result = null;
            var dsJucator = SqlDBHelper.ExecuteDataSet("select * from jucator_lh where data_nasterii = (select max(data_nasterii) from jucator_lh)", CommandType.Text);
            if (dsJucator.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsJucator.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Jucator(linieDB);
            }
            return result;
        }
        public Jucator GetJucator(int id)
        {
            Jucator result = null;
            var dsJucator = SqlDBHelper.ExecuteDataSet("select * from jucator_lh where id_jucator= :ID_JUCATOR", CommandType.Text,
                new OracleParameter(":ID_JUCATOR", OracleDbType.Int32, id, ParameterDirection.Input));
            if (dsJucator.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsJucator.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Jucator(linieDB);
            }
            return result;
        }

        public bool AddJucator(Jucator j)
        {
            return SqlDBHelper.ExecuteNonQuery("insert into jucator_lh values(jucator_id_sequence.nextval, :NUME, :PRENUME, :DATA_NASTERII, :ECHIPA, :POZITIE, :INALTIME, :GREUTATE)",
                CommandType.Text,
                new OracleParameter(":nUME", OracleDbType.NVarchar2, j.nume, ParameterDirection.Input),
                new OracleParameter(":PRENUME", OracleDbType.NVarchar2, j.prenume, ParameterDirection.Input),
                new OracleParameter(":DATA_NASTERII", OracleDbType.Date, j.data_nasterii, ParameterDirection.Input),
                new OracleParameter(":ECHIPA", OracleDbType.Int32, j.echipa, ParameterDirection.Input),
                new OracleParameter(":POZITIE", OracleDbType.NVarchar2, j.pozitie, ParameterDirection.Input),
                new OracleParameter(":INALTIME", OracleDbType.Int32, j.inaltime, ParameterDirection.Input),
                new OracleParameter(":GREUTATE", OracleDbType.Int32, j.greutate, ParameterDirection.Input)
                );
        }

        public bool DeleteJucator(int id)
        {
            return true;
        }
    }
}
