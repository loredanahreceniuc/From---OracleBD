using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibrarieModele
{
    public class Echipa
    {
        public int id_echipa { get; set; }
        public string nume_echipa { get; set; }
        public string oras { get;set; }
        public string tara { get; set; }
        public int anul_infiintarii { get; set; }
        public string antrenor_principal { get; set; }
        
        public Echipa() { }

        public Echipa(string nume_echipa, string oras, string tara, int anul_infiintarii, string antrenor_principal, int id_echipa=0)
        {
            this.id_echipa = id_echipa;
            this.nume_echipa = nume_echipa;
            this.oras = oras;
            this.tara = tara;
            this.anul_infiintarii = anul_infiintarii;
            this.antrenor_principal = antrenor_principal;
        }

        public Echipa(DataRow linieDB)
        {
            id_echipa = Convert.ToInt32(linieDB["id_echipa"].ToString());
            nume_echipa= linieDB["nume_echipa"].ToString();
            oras = linieDB["oras"].ToString();
            tara = linieDB["tara"].ToString();
            anul_infiintarii = Convert.ToInt32(linieDB["anul_infiintarii"].ToString());
            antrenor_principal = linieDB["antrenor_principal"].ToString();
        }
    }
}
