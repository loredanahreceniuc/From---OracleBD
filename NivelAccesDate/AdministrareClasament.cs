using LibrarieModele;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public class AdministrareClasament : IStocareClasament
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

       public List<Clasament> GetClasamente()
        {
            
                var result = new List<Clasament>();
                var dsClasament = SqlDBHelper.ExecuteDataSet("select * from clasament_lh order by puncte DESC", CommandType.Text);
                foreach (DataRow linieDB in dsClasament.Tables[0].Rows)
                {
                    result.Add(new Clasament(linieDB));
                }
                return result;

        }
        public Clasament GetClasament(int id)
        {
            Clasament result = null;
            var dsClasament = SqlDBHelper.ExecuteDataSet("select * from clasament_lh where id_echipa= :ID_ECHIPA", CommandType.Text,
                new OracleParameter(":ID_ECHIPA", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsClasament.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsClasament.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result= new Clasament(linieDB);
            }
            return result;
        }

        public int GetClasamentEchipaGolaveraj()
        {
            var dsClasament = SqlDBHelper.ExecuteDataSet("select id_echipa from clasament_lh where golaveraj= (Select min(golaveraj) from clasament_lh) AND ROWNUM=1", CommandType.Text);

            DataRow linieDB= dsClasament.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
            int result = Convert.ToInt32(linieDB["id_echipa"].ToString());
            return result;
        }

        public bool UpdateClasament(Clasament d)
        {
            var rezultat = true;
            return rezultat;
        }  
    }
}
