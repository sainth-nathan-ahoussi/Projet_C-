using System;
using System.IO;
using System.Windows.Forms;

namespace TP_Debogger
{
    public partial class frmFenetrePrincipale : Form
    {
        public frmFenetrePrincipale()
        {
            InitializeComponent();
            ofdFable.InitialDirectory = ".";
        }

        //Cette procédure événementielle doit être appelée par le clic sur le bouton à gauche de l'interface
        private void BtnOuvrir1_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofdFable.ShowDialog();
            if (dr == DialogResult.OK)
            {

                lireFichier();
            }
        }
        //Cette procédure événementielle doit être appelée par le changement de valeur dans la ComboBox.
        //Mais au fait? Combien de valeurs sont définies dans celle-ci?
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx = (ComboBox)sender;
            if (cbx.SelectedIndex == -1)
            {
                lireFichier();
            }
            else if (cbx.SelectedIndex == 1)
            {
                lblContenu.Text = lblContenu.Text.ToUpper();
            }
            else
            {
                lblContenu.Text = lblContenu.Text.ToLower();
            }
        }
        //Cette fonction doit compter le nombre de mots dans un texte en décomposant d'abord par ligne
        //grace à la fonction Split, puis en décomposant par mots.
        //Vous pouvez aller chercher dans la documentation comment marche la fonction Split
        private int wordCount(string text)
        {
            int count = 0;
            string[] lines = text.Split(' ');
            foreach (string line in lines)
            {
                string[] mots = line.Split('\n');
                count = mots.Length;
            }
            return count;
        }

        //Cette procédure doit lire le contenu du fichier et le met dans le Label
        private void lireFichier()
        {
            StreamReader sr = new StreamReader(ofdFable.OpenFile());
            lblFileName.Text = ofdFable.SafeFileName;
            lblContenu.Text = sr.ReadToEnd();
            lblWordCountValue.Text = wordCount(lblContenu.Text).ToString();

        }

        //Attention, ce code ne gère pas les exceptions !
        private void btnLoad_Click(object sender, EventArgs e)
        {
            FileStream fs = File.OpenRead(tbxFileName.Text);
            StreamReader sr = new StreamReader(fs);
            lblFileName.Text = ofdFable.SafeFileName;
            lblContenu.Text = sr.ReadToEnd();
            lblWordCountValue.Text = wordCount(lblContenu.Text).ToString();
        }
    }
}
