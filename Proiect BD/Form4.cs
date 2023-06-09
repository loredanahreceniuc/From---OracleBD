using LibrarieModele;
using NivelAccesDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_BD
{
    public partial class Form4 : Form
    {
        private const bool SUCCES = true;
        IStocareEchipa stocareEchipa = (IStocareEchipa)new StocareFactory().GetTipStocare(typeof(Echipa));
        IStocareJucator stocareJucator = (IStocareJucator)new StocareFactory().GetTipStocare(typeof(Jucator));
        public Form4()
        {
            InitializeComponent();
            if (stocareEchipa == null || stocareJucator == null)
                MessageBox.Show("Eroare la initializare");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            AfiseazaCatalog();

        }
        private void AfiseazaCatalog()
        {
            try
            {
                var clasament = stocareJucator.GetJucatori();
                var dataSource = clasament.Select(m => new
                {
                    m.id_jucator,
                    m.nume,
                    m.prenume,
                    m.data_nasterii,
                    stocareEchipa.GetEchipa(m.echipa).nume_echipa,
                    m.pozitie,
                    m.inaltime,
                    m.greutate
                }).ToList();

                if (clasament != null)
                {

                    dataGridJucatori.DataSource = dataSource;
                    dataGridJucatori.Columns["id_jucator"].Visible = false;
                    dataGridJucatori.Columns["nume"].HeaderText = "Nume";
                    dataGridJucatori.Columns["Prenume"].HeaderText = "Prenume";
                    dataGridJucatori.Columns["nume_echipa"].HeaderText = "Echipa";
                    dataGridJucatori.Columns["data_nasterii"].HeaderText = "Data nasterii";
                    dataGridJucatori.Columns["pozitie"].HeaderText = "Pozitie";
                    dataGridJucatori.Columns["inaltime"].HeaderText = "Inaltime";
                    dataGridJucatori.Columns["greutate"].HeaderText = "Greutate";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonJucatorTanar_Click(object sender, EventArgs e)
        {
            Jucator jucator = stocareJucator.getCelMaiTanarJucator();

            if (jucator != null)
            {
                textJucatorTanar.Text = jucator.nume + " " + jucator.prenume + " avand varsta de " + CalculeazaVarsta(jucator.data_nasterii);
            }
        }

        public string CalculeazaVarsta(DateTime dataNasterii)
        {
            DateTime dataCurenta = DateTime.Today;
            int varsta = dataCurenta.Year - dataNasterii.Year;

            // Verificăm dacă data de naștere a avut loc înainte de data curentă din acest an
            if (dataNasterii > dataCurenta.AddYears(-varsta))
            {
                varsta--;
            }

            return varsta.ToString();
        }

    }
}
