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
        List<string> Cavalli = new List<string>();
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
            
            if (!int.TryParse(txtBAnno.Text, out int anno) || anno < 1995|| anno >= 2027)
            {
                MessageBox.Show("Inserisci un anno tra il 1900 e il 2026");
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
            string  cavalloString = $"Nome: {cavallo.Nome}, Razza: {cavallo.Razza}, Anno: {cavallo.Anno}, Sesso: {cavallo.Sesso}";
            maneggio[i] = cavallo;
            i++;
           
            lbCavalli.Items.Add(cavalloString.ToString());
            string[] righe = {$"{cavallo.Nome} ; {cavallo.Razza} ; {cavallo.Anno} ; {cavallo.Sesso}"};
            File.AppendAllLines(percorso, righe);

            MessageBox.Show("Cavallo salvato con successo");
            txtBAnno.Clear();
            txtBNome.Clear();
            txtBRazza.Clear();
        }

        private void btnRimuovi_Click(object sender, EventArgs e)
        {

        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            pnlCerca.Visible = true;   
        }
    }
}
