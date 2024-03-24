namespace Tp_Dynamique
{
    public partial class Form1 : Form
    {
        private const int SIZE_CELL = 35;
        private const int DEFAULT_BOARD = 10;
        private int[,] matriceBoard;
        private int currentBoard = DEFAULT_BOARD;
        private int numBomb;
        private int numButton;
        private Random PlacementBomb = new Random();
        private int timer;
        public Form1()
        {
            InitializeComponent();
        }
        private void clickButton(object sender, EventArgs e)
        {


            Button b = (Button)sender;
            Panel p = (Panel)b.Parent;
            TableLayoutPanelCellPosition pos = tlpGrille.GetCellPosition(p);
            int row = pos.Row;
            int col = pos.Column;

            if (matriceBoard[col, row] == -1)
            {

                b.BackColor = Color.Red;
                MessageBox.Show("BOOM! Vous avez cliqué sur une bombe.", "Démineur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                InitialisationNouvellePartie();
            }
            else
            {
                b.Visible = false;
                numButton--;
                b.BackColor = Color.FromArgb(255, 224, 192); // Couleur de fond orangée

                if (numButton == numBomb)
                {
                    MessageBox.Show("Félicitations! Vous avez gagné en "+timer, "Démineur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitialisationNouvellePartie();
                }
            }

        }
        private void InitialisationNouvellePartie()
        {

            while (tlpGrille.Controls.Count > 0)
            {
                tlpGrille.Controls[0].Dispose();
            }
            // Réinitialisez la grille et les variables
            numBomb = 1;
            tlpGrille.Controls.Clear();
            matriceBoard = new int[currentBoard, currentBoard];
            numButton = currentBoard * currentBoard;
            lblBomb.Text = numBomb.ToString();
            tlpGrille.RowCount = currentBoard;
            tlpGrille.ColumnCount = currentBoard;
            tlpGrille.RowStyles.Clear();
            tlpGrille.ColumnStyles.Clear();
            tmrTemp.Start();
            tmrTemp.Interval = 1000;
            InitialisationMine();



            for (int i = 0; i < currentBoard; i++)
            {
                tlpGrille.RowStyles.Add(new RowStyle(SizeType.Absolute, SIZE_CELL));
                tlpGrille.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, SIZE_CELL));
      
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
                    l.Text = matriceBoard[i,j].ToString();
                    p.Controls.Add(l);
                    b.Click += new EventHandler(clickButton);
                    tlpGrille.Controls.Add(p, i, j);
                    
                          // afficher les bombes
                        if(matriceBoard[i, j] == -1)
                        {
                            b.BackColor = Color.Red;

                        }
                    

                  
                }

            }
        }
        private void InitialisationMine()
        {
            while (numBomb > 0)
            {
                int i = PlacementBomb.Next(currentBoard);
                int j = PlacementBomb.Next(currentBoard);

                if (matriceBoard[i, j] != -1)
                {
                    matriceBoard[i, j] = -1;
                    numBomb--;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitialisationNouvellePartie();
        }

        private void tlpGrille_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tmrTemp.Enabled = true;            
            timer += 1;
            lblTemp.Text = Convert.ToString(timer);
        }
    }
}