using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Meci
    {
        public int id_meci { get; set; }
        public int echipa_gazda { get; set; }
        public int echipa_ospete { get; set; }
        public DateTime data_meciului { get; set; }
        public string locatie { get; set; }
        public string scor_final { get; set; }
        public string arbitru_princiapl { get; set; }
        public bool rezultat_final { get; set; }

        public Meci() { }

        public Meci(int echipa_gazda, int echipa_ospete, DateTime data_meciului,  string scor_final, string arbitru_princiapl, bool rezultat_final, int id_meci=0, string locatie="")
        {
            this.id_meci = id_meci;
            this.echipa_gazda = echipa_gazda;
            this.echipa_ospete = echipa_ospete;
            this.data_meciului = data_meciului;
            this.locatie = locatie;
            this.scor_final = scor_final;
            this.arbitru_princiapl = arbitru_princiapl;
            this.rezultat_final = rezultat_final;
        }

        public Meci(DataRow linieDB)
        {
            id_meci = Convert.ToInt32(linieDB["id_meci"].ToString());
            echipa_gazda = Convert.ToInt32(linieDB["echipa_gazda"].ToString());
            echipa_ospete = Convert.ToInt32(linieDB["echipa_oaspete"].ToString());
            data_meciului = Convert.ToDateTime(linieDB["data_meciului"].ToString());
            locatie = linieDB["locatie"].ToString();
            scor_final = linieDB["scor_final"].ToString();
            arbitru_princiapl = linieDB["arbitru_principal"].ToString();
            rezultat_final = Convert.ToBoolean(linieDB["rezultat_final"]);
        }
    }
}
