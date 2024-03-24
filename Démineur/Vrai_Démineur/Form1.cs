using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vrai_Démineur
{
    public partial class Form1 : Form
    {
        private const int SIZE_CELL = 20;
        private const int DEFAULT_BOARD = 10;
        private int currentBoard = DEFAULT_BOARD;
        private int numberBombe = 10;
        private int numberButton;
        private int[,] matriceBoard;
        private int height;
        private int width;
        private Panel p;
        private Label l;
        private Button b;
        private Label Bomblabel2;
        private Random posBomb = new Random();
        private int  timer = 40;


        public Form1()
        {
            InitializeComponent();
        }

        private void InitialisationNouvellePartie()
        {
            chrono.Start();
            chrono.Interval = 1000;
            while(GrilletableLayoutPanel1.Controls.Count > 0)
            {
                GrilletableLayoutPanel1.Controls[0].Dispose();
            }
            this.numberBombe = numberBombe;
            matriceBoard = new int[currentBoard, currentBoard]; 

            // Réinitialiser la grille
            GrilletableLayoutPanel1.Controls.Clear();
            GrilletableLayoutPanel1.RowCount = currentBoard;
            GrilletableLayoutPanel1.ColumnCount = currentBoard;
            GrilletableLayoutPanel1.RowStyles.Clear();
            GrilletableLayoutPanel1.ColumnStyles.Clear();
            for (int i = 0; i < currentBoard; i++)
            {
                GrilletableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, SIZE_CELL));
                GrilletableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, SIZE_CELL));
            }
            for (int i = 0; i < currentBoard; i++)
            {
                for (int j = 0; j < currentBoard; j++)
                {
                    Panel p = new Panel();
                    Button b = new Button();
                    Label l = new Label();
                    b.BackColor = Color.White;
                    p.Controls.Add(b);
                    p.Controls.Add(l);
                    b.Click += new EventHandler(clickButton);
                    GrilletableLayoutPanel1.Controls.Add(p, i, j);

                }
            }
         
            // Créer le panneau "Bomb" pour afficher le nombre de bombes
            Bombpanel1.Controls.Clear();
            Bomblabel2.Text = "Nb bombes : " + numberBombe.ToString();
            Bombpanel1.Controls.Add(Bomblabel2);

           
        }

        private void clickButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Panel p = (Panel)button.Parent;
            TableLayoutPanelCellPosition pos = GrilletableLayoutPanel1.GetCellPosition(p);
            int row = pos.Row;
            int column = pos.Column;
            //VerifieCellule(column,row);
        }

        /*
        private void VerifieCellule(int column, int row)
        {
            Panel panel = (Panel)GrilletableLayoutPanel1.GetControlFromPosition(column, row);
            Button button = (Button)panel.Controls[0];

            if (button.Enabled)
            {
                button.Enabled = false;

                if (matriceBoard[column, row] == 1)
                {
                    // Partie perdue, gérer en conséquence
                    MessageBox.Show("Boum ! Vous avez perdu !");
                    // Réinitialiser le jeu, si nécessaire
                    InitialisationNouvellePartie();
                    return;
                }
                else
                {
                    numberButton--;
                    if (numberButton == numberBombe)
                    {
                        // Partie gagnée, gérer en conséquence
                        MessageBox.Show("Félicitations ! Vous avez gagné !");
                        // Réinitialiser le jeu, si nécessaire
                        InitialisationNouvellePartie();
                        return;
                    }
                    else
                    {
                        int bombesVoisines = 0;
                        for (int i = Math.Max(0, column - 1); i <= Math.Min(currentBoard - 1, column + 1); i++)
                        {
                            for (int j = Math.Max(0, row - 1); j <= Math.Min(currentBoard - 1, row + 1); j++)
                            {
                                if (matriceBoard[i, j] == 1)
                                {
                                    bombesVoisines++;
                                }
                            }
                        }
                        if (bombesVoisines > 0)
                        {
                            button.Text = bombesVoisines.ToString();
                        }
                        else
                        {
                            for (int i = Math.Max(0, column - 1); i <= Math.Min(currentBoard - 1, column + 1); i++)
                            {
                                for (int j = Math.Max(0, row - 1); j <= Math.Min(currentBoard - 1, row + 1); j++)
                                {
                                    VerifieCellule(i, j);
                                }
                            }
                        }
                    }
                }
            }
        }
*/
     

        private void InitialisationMine()
        {
            int nbminerestantes = numberBombe;
            while(nbminerestantes > 0)
            {
                int i = posBomb.Next(currentBoard);
                int j = posBomb.Next(currentBoard);
                if (matriceBoard[i, j] != -1) {
                    matriceBoard[i, j] = -1;
                    nbminerestantes--; 
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitialisationNouvellePartie();

        }

        private void chrono_Tick(object sender, EventArgs e)
        {
            Timepanel1.Controls.Clear();
            chrono.Enabled = true;
            timer -= 1;
            Timelabel1.Text = Convert.ToString(timer);
            Timepanel1.Controls.Add(Timelabel1);

        }
    }
}
