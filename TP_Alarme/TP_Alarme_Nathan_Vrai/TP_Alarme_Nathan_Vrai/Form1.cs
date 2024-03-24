using System.Reflection;

namespace TP_Alarme_Nathan_Vrai
{
    public partial class frAlarme : Form
    {
        List<DateTime> _alarmes = new List<DateTime>();
        private bool isRinging = false;
        private bool isPlaying = false;
        Graphics horlogeGraphic;
        System.Media.SoundPlayer sonnerie = new System.Media.SoundPlayer(TP_Alarme_Nathan_Vrai.Properties.Resources.den_den_mushi__original_);
        public frAlarme()
        {
            InitializeComponent();
            
        }

        private void frAlarme_Load(object sender, EventArgs e)
        {
            tmrHorloge.Interval = 1000;
            tmrHorloge.Start();
            horlogeGraphic = horlogepanel.CreateGraphics();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void tmrHorloge_Tick(object sender, EventArgs e)
        {
            horlogeGraphic.Clear(DefaultBackColor);
            Pen pAlarme = new Pen(Color.Red, 3);
            Pen Standard= new Pen(Color.Black, 3);
            Pen p;
            int hour = System.DateTime.Now.Hour;
            int minutes = System.DateTime.Now.Minute;
            int second = System.DateTime.Now.Second;

            horlogeGraphic.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(90, 10));
            horlogeGraphic.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(180, 93));
            horlogeGraphic.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(95, 175));
            horlogeGraphic.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(10, 95));
            
            
            for (int i = heureListBox.Items.Count - 1; i >= 0; i--)
            {
               DateTime alarme = _alarmes[i];
               if(alarme.Hour == hour && alarme.Minute == minutes && alarme.Second == second)
               {
                    isRinging = true;
                }
            }

            if (isRinging)
            {
                p = pAlarme;
                if (!isPlaying)
                {
                    sonnerie.Play();
                    isPlaying = true;
                    
                }
               
            }
            else
            {
                p = Standard;
                sonnerie.Stop();
                isPlaying = false;
                        
                
            }

            
            
            Pen p1 = new Pen(Color.Black, 2);
            Pen p2 = new Pen(Color.Red, 1);
            Pen pheure = new Pen(Color.Red, 3);


            horlogeGraphic.DrawEllipse(p, new Rectangle(new Point(2, 2), new Size(200, 200)));
            int longueurTemps = 100;
            int longueurTemps2 = 92;
            for (int i = 0; i<13; i++)
            {
               
                double radian = Math.PI / 2 - i * Math.PI / 6;
                double x1 = 102 + Math.Cos(radian) * longueurTemps;
                double y1 = 102 - Math.Sin(radian) * longueurTemps;
                double x2 = 102 + Math.Cos(radian) * longueurTemps2;
                double y2 = 102 - Math.Sin(radian) * longueurTemps2;
                horlogeGraphic.DrawLine(pheure, new Point((int)x1, (int)y1), new Point((int)x2, (int)y2));
            }

            //Aiguille des secondes 
            int longueurAiguilleSecondes = 68;
            double radians = Math.PI / 2 - second * Math.PI / 30;
            double x = 102 + Math.Cos(radians) * longueurAiguilleSecondes;
            double y = 102 - Math.Sin(radians) * longueurAiguilleSecondes;
            horlogeGraphic.DrawLine(p, new Point(102, 102), new Point((int)x, (int)y));

            //Aiguille des Minutes
            int longueurAiguilleMinutes = 75;
            radians = Math.PI / 2 - minutes * Math.PI / 30;
            x = 102 + Math.Cos(radians) * longueurAiguilleMinutes;
            y = 102 - Math.Sin(radians) * longueurAiguilleMinutes;
            horlogeGraphic.DrawLine(p1, new Point(102, 102), new Point((int)x, (int)y));

            //Aiguille des heures
            int longueurAiguilleHeures = 50;
            radians = Math.PI / 2 - hour * Math.PI / 6 ;
            x = 102 + Math.Cos(radians) * longueurAiguilleHeures;
            y = 102 - Math.Sin(radians) * longueurAiguilleHeures;
            horlogeGraphic.DrawLine(p2, new Point(102, 102), new Point((int)x, (int)y));
        }

        private void Ajoutbutton_Click(object sender, EventArgs e)
        {
            DateTime heure = SelectTimePicker.Value;
            _alarmes.Add(heure);
            heureListBox.Items.Add(heure);

        }

        private void Suppbutton_Click(object sender, EventArgs e)
        {

            for(int i = heureListBox.Items.Count-1; i >= 0; i--)
            {
                //DateTime alarme = (DateTime)heureListBox.Items[i];
                if (heureListBox.GetItemChecked(i))
                {
                    _alarmes.RemoveAt(i);
                    heureListBox.Items.RemoveAt(i);
                }
            }
        }

        private void horlogepanel_Click(object sender, EventArgs e)
        {
            isRinging = false;
        
        }
    }
}