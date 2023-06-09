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
    public partial class Form5 : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;
        IStocareEchipa stocareEchipa = (IStocareEchipa)new StocareFactory().GetTipStocare(typeof(Echipa));
        IStocareJucator stocareJucator = (IStocareJucator)new StocareFactory().GetTipStocare(typeof(Jucator));
        IStocareClasament stocareClasament = (IStocareClasament)new StocareFactory().GetTipStocare(typeof(Clasament));
        IStocareMeci stocareMeci= (IStocareMeci)new StocareFactory().GetTipStocare(typeof(Meci));
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f =new  Form1();
            f.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            IncarcaEchipe();
            AfiseazaCatalog();
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
                        cmbEchipa1.Items.Add(new ComboItem(ech.nume_echipa, (Int32)ech.id_echipa));
                        cmbEchipa2.Items.Add(new ComboItem(ech.nume_echipa, (Int32)ech.id_echipa));
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AfiseazaCatalog()
        {
            try
            {
                var meci = stocareMeci.getMeciuri();
                if (meci != null)
                {
                    string k;
                    string castigatoare;
                    dataGridEchipa.DataSource = meci.Select(m => new { m.id_meci, k= stocareEchipa.GetEchipa(m.echipa_gazda).nume_echipa, stocareEchipa.GetEchipa(m.echipa_ospete).nume_echipa, m.data_meciului, m.locatie, m.scor_final, m.arbitru_princiapl, castigatoare=ShowRezultatFinal(m)}).ToList();
                    dataGridEchipa.Columns["id_meci"].Visible = false;
                    dataGridEchipa.Columns["k"].HeaderText = "Echipa gazda";
                    dataGridEchipa.Columns["nume_echipa"].HeaderText = "Echipa Oaspete";
                    dataGridEchipa.Columns["locatie"].HeaderText = "Locatie";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

       private string ShowRezultatFinal(Meci m)
        {
            if (!m.rezultat_final)
                return stocareEchipa.GetEchipa(m.echipa_ospete).nume_echipa;
            else
                return stocareEchipa.GetEchipa(m.echipa_gazda).nume_echipa;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Meci meci = null;
            if(cmbEchipa1.SelectedIndex !=-1 && cmbEchipa1.SelectedIndex!=-1) 
                 meci = stocareMeci.getMeciDintre(((ComboItem)cmbEchipa1.SelectedItem).Value, ((ComboItem)cmbEchipa2.SelectedItem).Value);
            
            if (meci != null)
            {
                if (meci.rezultat_final)
                    label1.Text = stocareEchipa.GetEchipa(meci.echipa_gazda).nume_echipa;
                else
                    label1.Text = stocareEchipa.GetEchipa(meci.echipa_ospete).nume_echipa;
            }
            else
                label1.Text = "Meciul nu a avut loc";

        }
    }
}
