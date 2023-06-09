using LibrarieModele;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public class AdministrareMeci : IStocareMeci
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Meci> getMeciuri()
        {

            var rezultat= new List<Meci>();
            
            var dsMeci = SqlDBHelper.ExecuteDataSet("select * from meci_lh", CommandType.Text);
            foreach (DataRow linieDB in dsMeci.Tables[PRIMUL_TABEL].Rows)
            {
                rezultat.Add(new Meci(linieDB));
            }
            return rezultat;
        }

        public Meci getMeci(int id)
        {
            Meci rezultat = null;
            var dsMeci = SqlDBHelper.ExecuteDataSet("select * from meci_lh where id_meci= :ID_MECI", CommandType.Text,
                new OracleParameter(":ID_MECI", OracleDbType.Int32,id,ParameterDirection.Input));
            if (dsMeci.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                var linieDB = dsMeci.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                rezultat=new Meci(linieDB);
            }
            
            return rezultat;
        }

        public Meci getMeciDintre(int idA, int idB)
        {

            Meci rezultat = null;
            var dsMeci = SqlDBHelper.ExecuteDataSet("select * from meci_lh where echipa_gazda=:ID_GAZDA and echipa_oaspete= :ID_OASPETE", CommandType.Text,
                new OracleParameter(":ID_GAZDA", OracleDbType.Int32, idA, ParameterDirection.Input),
                new OracleParameter(":ID_OASTEPE", OracleDbType.Int32, idB, ParameterDirection.Input));
            if (dsMeci.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                var linieDB = dsMeci.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                rezultat = new Meci(linieDB);
            }

            return rezultat;
        }

    }
}
