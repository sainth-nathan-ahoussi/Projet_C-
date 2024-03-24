using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anagrammes
{
    public partial class Form1 : Form
    {
        public String[] tabMots;
        public String[] tabMotsTrouver;
        Random rnd = new Random();
        String MotChercher = "";
        StringBuilder MotMelanger = new StringBuilder();
        int NbEssaisMax = 5;
        int NbEssais = 5 ; 


        public Form1()
        {
            InitializeComponent();
        }

        private void initialisation()
        {
            // Instruction au démarrage du jeu et de la page.
            tabMots = new String[] {"Sérénité", "Tornade", "Lune" , "Aventure" , "Exubérance" ,"Victoire", "Prudence", "Océan", "Insouciance", "Effervescence", "Euphorie", "Conquête",
                                        "Fraternité", "Rébellion", "Enchantement", "Fusion", "Prodigieux", "Transcendance", "Défi", "Magie" };
            NbEssaisVrai.Text = + NbEssais + "/" + NbEssaisMax;
            EssaisPrécedentAffichage.Items.Clear();
            MotàTrouverVrai.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            initialisation();
        }

        private String melanger(String chaine)
        {
           
            foreach (char c in chaine)
            {
                int Index = rnd.Next(0, MotMelanger.Length + 1);
                MotMelanger.Insert(Index, c);

            }


            return MotMelanger.ToString() ;
        }

        private void nouvellePartie()
        {
            initialisation();
            int Index = rnd.Next(tabMots.Length);
            MotChercher = tabMots[Index];
            MotChercher = melanger(MotChercher);
            MotàTrouverVrai.Text = MotChercher;
                

        }

        private void motCorrect()
        {
           
        }

        private void motIncorrect()
        {
            NbEssais--;
            NbEssaisVrai.Text = + NbEssais + "/" + NbEssaisMax;
            MessageBox.Show("Votre mot est Incorrect, il vous reste donc "  + NbEssais + " ! Réesayer un nouveau ");
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void MotàTrouverVrai_Click(object sender, EventArgs e)
        {
            nouvellePartie();
            
        }

        private void NbEssaisVrai_Click(object sender, EventArgs e)
        {
         
        }

        private void Tester_Click(object sender, EventArgs e)
        {
            if (SaisieMot.Text != MotChercher)
            {
                motIncorrect();
                EssaisPrécedentAffichage.Items.Add(SaisieMot.Text);
            } else
            {

                motCorrect();
            }
            SaisieMot.Clear();
        }

        private void SaisieMot_TextChanged(object sender, EventArgs e)
        {

        }

        private void EssaisPrécedentAffichage_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonRejouer_Click(object sender, EventArgs e)
        {
            nouvellePartie();
        }
    }
}
