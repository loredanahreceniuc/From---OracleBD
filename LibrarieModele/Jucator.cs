using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Jucator
    {
        public int id_jucator { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public DateTime data_nasterii { get; set; }
        public int echipa { get; set; }
        public string pozitie { get; set; }
        public double inaltime { get; set; }
        public int greutate { get; set; }

        public Jucator() { }

        public Jucator(string nume, string prenume, DateTime data_nasterii, int echipa, string pozitie, double inaltime, int greutate, int id_jucator=0)
        {
            this.id_jucator = id_jucator;
            this.nume = nume;
            this.prenume = prenume;
            this.data_nasterii = data_nasterii;
            this.echipa = echipa;
            this.pozitie = pozitie;
            this.inaltime = inaltime;
            this.greutate = greutate;
        }

        public Jucator(DataRow linieDB)
        {
            id_jucator = Convert.ToInt32(linieDB["id_jucator"].ToString());
            nume = linieDB["nume"].ToString();
            prenume = linieDB["prenume"].ToString();
            data_nasterii = Convert.ToDateTime(linieDB["data_nasterii"].ToString());
            echipa = Convert.ToInt32(linieDB["echipa"].ToString());
            pozitie = linieDB["pozitie"].ToString();
            inaltime = Convert.ToDouble(linieDB["inaltime"].ToString());
            greutate = Convert.ToInt32(linieDB["greutate"].ToString());
        }
    }
}
