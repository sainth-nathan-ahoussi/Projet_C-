namespace Tp_Dynamique
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpGrille = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAffichage = new System.Windows.Forms.Panel();
            this.pnlBomb = new System.Windows.Forms.Panel();
            this.lblBomb = new System.Windows.Forms.Label();
            this.pnlTemp = new System.Windows.Forms.Panel();
            this.lblTemp = new System.Windows.Forms.Label();
            this.tmrTemp = new System.Windows.Forms.Timer(this.components);
            this.pnlAffichage.SuspendLayout();
            this.pnlBomb.SuspendLayout();
            this.pnlTemp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpGrille
            // 
            this.tlpGrille.AutoSize = true;
            this.tlpGrille.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpGrille.ColumnCount = 2;
            this.tlpGrille.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.5F));
            this.tlpGrille.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.5F));
            this.tlpGrille.Location = new System.Drawing.Point(153, 152);
            this.tlpGrille.Name = "tlpGrille";
            this.tlpGrille.RowCount = 2;
            this.tlpGrille.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGrille.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGrille.Size = new System.Drawing.Size(0, 0);
            this.tlpGrille.TabIndex = 0;
            this.tlpGrille.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpGrille_Paint);
            // 
            // pnlAffichage
            // 
            this.pnlAffichage.Controls.Add(this.pnlBomb);
            this.pnlAffichage.Controls.Add(this.pnlTemp);
            this.pnlAffichage.Location = new System.Drawing.Point(38, 22);
            this.pnlAffichage.Name = "pnlAffichage";
            this.pnlAffichage.Size = new System.Drawing.Size(405, 84);
            this.pnlAffichage.TabIndex = 1;
            // 
            // pnlBomb
            // 
            this.pnlBomb.Controls.Add(this.lblBomb);
            this.pnlBomb.Location = new System.Drawing.Point(217, 21);
            this.pnlBomb.Name = "pnlBomb";
            this.pnlBomb.Size = new System.Drawing.Size(169, 44);
            this.pnlBomb.TabIndex = 1;
            // 
            // lblBomb
            // 
            this.lblBomb.AutoSize = true;
            this.lblBomb.Location = new System.Drawing.Point(65, 15);
            this.lblBomb.Name = "lblBomb";
            this.lblBomb.Size = new System.Drawing.Size(38, 15);
            this.lblBomb.TabIndex = 0;
            this.lblBomb.Text = "label1";
            // 
            // pnlTemp
            // 
            this.pnlTemp.Controls.Add(this.lblTemp);
            this.pnlTemp.Location = new System.Drawing.Point(20, 21);
            this.pnlTemp.Name = "pnlTemp";
            this.pnlTemp.Size = new System.Drawing.Size(169, 44);
            this.pnlTemp.TabIndex = 0;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(57, 15);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(38, 15);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "label1";
            this.lblTemp.Click += new System.EventHandler(this.label1_Click);
            // 
            // tmrTemp
            // 
            this.tmrTemp.Interval = 1000;
            this.tmrTemp.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.pnlAffichage);
            this.Controls.Add(this.tlpGrille);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlAffichage.ResumeLayout(false);
            this.pnlBomb.ResumeLayout(false);
            this.pnlBomb.PerformLayout();
            this.pnlTemp.ResumeLayout(false);
            this.pnlTemp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tlpGrille;
        private Panel pnlAffichage;
        private Panel pnlBomb;
        private Panel pnlTemp;
        private Label lblTemp;
        private Label lblBomb;
        private System.Windows.Forms.Timer tmrTemp;
    }
}