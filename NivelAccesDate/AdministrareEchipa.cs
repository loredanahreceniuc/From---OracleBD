using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.IO;

namespace NivelAccesDate
{
    public class AdministrareEchipa : IStocareEchipa
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Echipa> GetEchipe()
        {
            var result = new List<Echipa>();
            var dsTeams = SqlDBHelper.ExecuteDataSet("select * from echipa_lh", CommandType.Text);

            foreach (DataRow linieDB in dsTeams.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Echipa(linieDB));
            }
            return result;
        }

        public Echipa GetEchipa(int id)
        {
           
            Echipa result = null;
            var dsTeams = SqlDBHelper.ExecuteDataSet("select * from echipa_lh where id_echipa= :TEAM_ID", CommandType.Text,
                new OracleParameter(":TEAM_ID", OracleDbType.Int32,id, ParameterDirection.Input));

            if (dsTeams.Tables[0].Rows.Count > 0)
            {
                DataRow linieDB = dsTeams.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Echipa(linieDB);
            }
            return result;
            
        }


        public bool AddEchipa(Echipa team)
        {
            return SqlDBHelper.ExecuteNonQuery("insert into echipa_lh values(echipa_id_sequence.nextval, :NUME_ECHIPA, :ORAS, :TARA, : ANUL_INF, :ANT_PRINCIPAL)", CommandType.Text,
                new OracleParameter(":NUME_ECHIPA", OracleDbType.NVarchar2, team.nume_echipa, ParameterDirection.Input),
                new OracleParameter(":ORAS", OracleDbType.NVarchar2, team.oras, ParameterDirection.Input),
                new OracleParameter(":TARA", OracleDbType.NVarchar2, team.tara, ParameterDirection.Input),
                new OracleParameter(":ANUL_INF", OracleDbType.Int32, team.anul_infiintarii, ParameterDirection.Input),
                new OracleParameter(":ANT_PRINCIPAL", OracleDbType.NVarchar2, team.antrenor_principal, ParameterDirection.Input)
                );
        }

        public bool UpdateEchipa(Echipa team)
        {
            return true;
        }
    }
}
