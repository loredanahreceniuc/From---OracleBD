using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Clasament
    {
        public int id_echipa { get; set; }
        public int meciuri_jucate { get; set; }
        public int meciuri_castigate { get; set; }
        public int meciuri_egal { get; set; }
        public double golaveraj { get; set; }
        public int puncte { get; set; }
        public int meciuri_pierdute { get; set; }

        public Clasament() { }

        public Clasament(int id_echipa, int meciuri_jucate, int meciuri_castigate, int meciuri_egal, double golaveraj, int meciuri_pierdute=0, int puncte=0)
        {
            this.id_echipa = id_echipa;
            this.meciuri_jucate = meciuri_jucate;
            this.meciuri_castigate = meciuri_castigate;
            this.meciuri_egal = meciuri_egal;
            this.golaveraj = golaveraj;
            this.meciuri_pierdute = meciuri_pierdute;
            this.puncte = puncte;
        }

        public Clasament(DataRow linieDB)
        {
            id_echipa = Convert.ToInt32(linieDB["id_echipa"].ToString());
            meciuri_jucate= Convert.ToInt32(linieDB["meciuri_jucate"].ToString());
            meciuri_castigate = Convert.ToInt32(linieDB["meciuri_castigate"].ToString());
            meciuri_egal = Convert.ToInt32(linieDB["meciuri_egal"].ToString());
            golaveraj = Convert.ToDouble(linieDB["golaveraj"].ToString());
            meciuri_pierdute = Convert.ToInt32(linieDB["meciuri_pierdute"].ToString());
            puncte = Convert.ToInt32(linieDB["puncte"].ToString());
        }
    }
}
