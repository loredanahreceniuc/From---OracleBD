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
    public partial class Form2 : Form
    {
        private const bool SUCCES = true;
        IStocareEchipa stocareEchipa= (IStocareEchipa)new StocareFactory().GetTipStocare(typeof(Echipa));
        IStocareJucator stocareJucator = (IStocareJucator)new StocareFactory().GetTipStocare(typeof(Jucator));
        IStocareClasament stocareClasament= (IStocareClasament)new StocareFactory().GetTipStocare(typeof(Clasament));
        public Form2()
        {
            InitializeComponent();
            if(stocareEchipa==null)
                MessageBox.Show("Eroare la initializare");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddEchipa_Click(object sender, EventArgs e)
        {
            try
            {
                var echipa = new Echipa(textNumeEchipa.Text, textOras.Text, textTara.Text, Convert.ToInt32(textAnulInf.Text), textAntPrincipal.Text);
                var rezultat = stocareEchipa.AddEchipa(echipa);
                if (rezultat == SUCCES)
                {
                    MessageBox.Show("Echipa adaugata");
                }
                else
                {
                    MessageBox.Show("Eroare la adaugare echipa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }

        private void buttonForm1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
        private void IncarcaEchipe()
        {
            try
            {
                cmbPozitie.Items.Clear();


                var echipa = stocareEchipa.GetEchipe();
                if (echipa != null && echipa.Any())
                {
                    foreach (var ech in echipa)
                    {
                        cmbEchipa.Items.Add(new ComboItem(ech.nume_echipa, (Int32)ech.id_echipa));
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void IncarcaPozitie()
        {
            try
            {
                cmbPozitie.Items.Clear();
                string[] pozitie = {"Centru", "Pivot", "Inter Stanga", "Extrema Stanga", "Inter Dreapta", "Extrema Dreapta", "Portar"};
                foreach (string poz in pozitie)
                {
                    cmbPozitie.Items.Add(poz);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            IncarcaEchipe();
            IncarcaPozitie();
        }

        private void buttonAddJucator_Click(object sender, EventArgs e)
        {
            try
            {
                var jucator = new Jucator(textNume.Text, textPrenume.Text, dateTimeDataNasterii.Value, ((ComboItem)cmbEchipa.SelectedItem).Value,
                    cmbPozitie.SelectedItem.ToString(), Convert.ToDouble(textInaltime.Text), Convert.ToInt32(textGreutate.Text));
                var rezultat = stocareJucator.AddJucator(jucator);
                if (rezultat == SUCCES)
                {
                    MessageBox.Show("Jucator adaugat");
                }
                else
                {
                    MessageBox.Show("Eroare la adaugare jucator");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }
    }
}
