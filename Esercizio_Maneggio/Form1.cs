using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Esercizio_Maneggio
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        bool selezione = false;
        Cavallo[] maneggio = new Cavallo[10];
        int i = 0;
        List<Cavallo> Cavalli = new List<Cavallo>();
        string percorso = @"C:\Users\alesg\OneDrive\Desktop\Maneggio.txt";

        public struct Cavallo
        {
            public string Nome;
            public string Razza;
            public int Anno;
            public char Sesso;

            public Cavallo(string nome, string razza, int anno, char sesso)
            {
                Nome = nome;
                Razza = razza;
                Anno = anno;
                Sesso = sesso;
            }

           
        }
        public Form1()
        {
            InitializeComponent();
            pnlCerca.Visible = false;
        }

        private void txtBNome_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ' ')
            {
                e.KeyChar = (char)0;
            }
        }

        private void txtBRazza_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ' ')
            {
                e.KeyChar = (char)0;
            }
        }

        private void txtBAnno_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.KeyChar = (char)0;
            }
        }

        private void rdBM_CheckedChanged(object sender, EventArgs e)
        {
            selezione = true;
        }

        private void rdBF_CheckedChanged(object sender, EventArgs e)
        {
            selezione = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btnSalva_Click(object sender, EventArgs e)
        {
            if(Cavalli.Count <= 10)
            {
                string nome = txtBNome.Text;

                if (string.IsNullOrEmpty(nome))
                {
                    MessageBox.Show("Inserisci un nome valido");
                    return;
                }
                string razza = txtBRazza.Text;
                if (string.IsNullOrEmpty(razza))
                {
                    MessageBox.Show("Inserisci una razza valida");
                    return;
                }

                if (!int.TryParse(txtBAnno.Text, out int anno) || anno < 1995 || anno >= 2027)
                {
                    MessageBox.Show("Inserisci un anno tra il 1995 e il 2026");
                    return;
                }
                char sesso = ' ';
                if (selezione == true)
                {
                    if (rdBM.Checked)
                    {
                        sesso = 'M';
                    }
                    else
                    {
                        sesso = 'F';
                    }

                }
                else
                {
                    MessageBox.Show("Seleziona il sesso del cavallo");
                }
                Cavallo cavallo = new Cavallo(nome, razza, int.Parse(txtBAnno.Text), sesso);
                string cavalloString = $"Nome: {cavallo.Nome}, Razza: {cavallo.Razza}, Anno: {cavallo.Anno}, Sesso: {cavallo.Sesso}";
                maneggio[i] = cavallo;
                i++;
                lblStalle.Text = Cavalli.Count.ToString();
                lbCavalli.Items.Add(cavalloString.ToString());
               
                Cavalli.Add(cavallo);
                string[] righe = { $"{cavallo.Nome} ; {cavallo.Razza} ; {cavallo.Anno} ; {cavallo.Sesso}" };
                File.AppendAllLines(percorso, righe);

                MessageBox.Show("Cavallo salvato con successo");
                txtBAnno.Clear();
                txtBNome.Clear();
                txtBRazza.Clear();
            }
            else
            {
                MessageBox.Show("Il maneggio è al completo");
            }
            
        }

        private void btnRimuovi_Click(object sender, EventArgs e)
        {
            
            if (lbCavalli.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona un cavallo dalla lista");
                return;
            }

                
            int index = lbCavalli.SelectedIndex;
            Cavallo sCavallo = Cavalli[index];

            
            lbCavalli.Items.RemoveAt(index); //lo toglie dalla listbox grafica
            Cavalli.RemoveAt(index); //lo toglie dalla lista, per aggiornare il conto

           
            lblStalle.Text = Cavalli.Count.ToString();

            MessageBox.Show("Cavallo rimosso con successo");
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            pnlCerca.Visible = true;
        }

        private void txtCerca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ' ')
            {
                e.KeyChar = (char)0;
            }
        }

        private void btnCercaNome_Click(object sender, EventArgs e)
        {
           
            string nomecercato = txtCerca.Text;

            for (int i = 0; i < Cavalli.Count; i++)
            {
                if (nomecercato.ToLower() == Cavalli[i].Nome.ToLower())
                {
                    MessageBox.Show("Cavallo trovato");
                    MessageBox.Show($"Il nome del cavallo è: {Cavalli[i].Nome} \n La razza è: {Cavalli[i].Razza} \n L'anno di nascita del cavallo è: {Cavalli[i].Anno} \n Il sesso è: {Cavalli[i].Sesso}");
                }
            }
        }

        private void btnCambia_Click(object sender, EventArgs e)
        {

        }
    }
}
