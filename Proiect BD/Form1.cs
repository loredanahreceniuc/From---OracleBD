using LibrarieModele;
using NivelAccesDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_BD
{
    public partial class Form1 : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;
        IStocareEchipa stocareEchipa= (IStocareEchipa) new StocareFactory().GetTipStocare(typeof(Echipa));
        public Form1()
        {
            InitializeComponent();
            if (stocareEchipa == null)
                MessageBox.Show("Eroare la initializare");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaCatalog();
            IncarcaEchipe();
        }

        private void AfiseazaCatalog()
        {
            try
            {
                var echipa = stocareEchipa.GetEchipe();
                if (echipa != null)
                {

                    dataGridEchipa.DataSource = echipa.Select(m => new { m.id_echipa, m.nume_echipa, m.oras, m.tara, m.anul_infiintarii, m.antrenor_principal }).ToList();
                    dataGridEchipa.Columns["id_echipa"].Visible = false;
                    dataGridEchipa.Columns["nume_echipa"].HeaderText = "Nume echipa";
                    dataGridEchipa.Columns["oras"].HeaderText = "Oras";
                    dataGridEchipa.Columns["tara"].HeaderText = "Tara";
                    dataGridEchipa.Columns["anul_infiintarii"].HeaderText = "Anul Infiintarii";
                    dataGridEchipa.Columns["antrenor_principal"].HeaderText = "Antrenor Principal";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void IncarcaEchipe()
        {
            try
            {
                //se elimina itemii deja adaugati


                var echipa = stocareEchipa.GetEchipe();
                if (echipa != null && echipa.Any())
                {
                    foreach (var ech in echipa)
                    {
                        comboEchipe.Items.Add(new ComboItem(ech.nume_echipa, (Int32)ech.id_echipa));
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void buttonFormClasament_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }

        private void buttonFormJucatori_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }

        private void comboEchipe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFormMeciuri_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Hide();
        }
    }
}
