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
    public partial class Form3 : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;
        IStocareClasament stocareClasament = (IStocareClasament)new StocareFactory().GetTipStocare(typeof(Clasament));
        IStocareEchipa stocareEchipa = (IStocareEchipa)new StocareFactory().GetTipStocare(typeof(Echipa));
        public Form3()
        {
            InitializeComponent();
            if (stocareClasament == null)
                MessageBox.Show("Eroare la initializare");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            AfiseazaCatalog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void AfiseazaCatalog()
        {
            try
            {
                var clasament = stocareClasament.GetClasamente();
                var dataSource = clasament.Select(m => new
                {
                    stocareEchipa.GetEchipa(m.id_echipa).nume_echipa, // Obțineți numele echipei utilizând metoda GetEchipa
                    m.puncte,
                    m.meciuri_jucate,
                    m.meciuri_castigate,
                    m.meciuri_egal,
                    m.meciuri_pierdute,
                    m.golaveraj
                }).ToList();

                if (clasament != null)
                {

                    dataGridClasament.DataSource = dataSource;
                    dataGridClasament.Columns["nume_echipa"].HeaderText = "Nume Echipa";
                    dataGridClasament.Columns["puncte"].HeaderText = "Puncte";
                    dataGridClasament.Columns["meciuri_jucate"].HeaderText = "J";
                    dataGridClasament.Columns["meciuri_castigate"].HeaderText = "C";
                    dataGridClasament.Columns["meciuri_egal"].HeaderText = "E";
                    dataGridClasament.Columns["meciuri_pierdute"].HeaderText = "P";
                    dataGridClasament.Columns["golaveraj"].HeaderText = "Golaveraj";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonForm1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void bttnCelMaiMicGolaveraj_Click(object sender, EventArgs e)
        {
            Echipa echipa = stocareEchipa.GetEchipa(stocareClasament.GetClasamentEchipaGolaveraj());
            textEchipaGolaveraj.Text = echipa.nume_echipa;
        }
    }
}
