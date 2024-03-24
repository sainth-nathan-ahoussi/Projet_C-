namespace Vrai_Démineur
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Affichagepanel1 = new System.Windows.Forms.Panel();
            this.Bombpanel1 = new System.Windows.Forms.Panel();
            this.Bomblabel2 = new System.Windows.Forms.Label();
            this.Timepanel1 = new System.Windows.Forms.Panel();
            this.Timelabel1 = new System.Windows.Forms.Label();
            this.GrilletableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chrono = new System.Windows.Forms.Timer(this.components);
            this.Affichagepanel1.SuspendLayout();
            this.Bombpanel1.SuspendLayout();
            this.Timepanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Affichagepanel1
            // 
            this.Affichagepanel1.Controls.Add(this.Bombpanel1);
            this.Affichagepanel1.Controls.Add(this.Timepanel1);
            this.Affichagepanel1.Location = new System.Drawing.Point(3, 1);
            this.Affichagepanel1.Name = "Affichagepanel1";
            this.Affichagepanel1.Size = new System.Drawing.Size(242, 67);
            this.Affichagepanel1.TabIndex = 0;
            // 
            // Bombpanel1
            // 
            this.Bombpanel1.Controls.Add(this.Bomblabel2);
            this.Bombpanel1.Location = new System.Drawing.Point(118, 11);
            this.Bombpanel1.Name = "Bombpanel1";
            this.Bombpanel1.Size = new System.Drawing.Size(121, 47);
            this.Bombpanel1.TabIndex = 1;
            // 
            // Bomblabel2
            // 
            this.Bomblabel2.AutoSize = true;
            this.Bomblabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bomblabel2.Location = new System.Drawing.Point(3, 21);
            this.Bomblabel2.Name = "Bomblabel2";
            this.Bomblabel2.Size = new System.Drawing.Size(46, 18);
            this.Bomblabel2.TabIndex = 0;
            this.Bomblabel2.Text = "label2";
            // 
            // Timepanel1
            // 
            this.Timepanel1.Controls.Add(this.Timelabel1);
            this.Timepanel1.Location = new System.Drawing.Point(9, 11);
            this.Timepanel1.Name = "Timepanel1";
            this.Timepanel1.Size = new System.Drawing.Size(103, 47);
            this.Timepanel1.TabIndex = 0;
            // 
            // Timelabel1
            // 
            this.Timelabel1.AutoSize = true;
            this.Timelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelabel1.Location = new System.Drawing.Point(26, 8);
            this.Timelabel1.Name = "Timelabel1";
            this.Timelabel1.Size = new System.Drawing.Size(0, 39);
            this.Timelabel1.TabIndex = 0;
            // 
            // GrilletableLayoutPanel1
            // 
            this.GrilletableLayoutPanel1.AutoSize = true;
            this.GrilletableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GrilletableLayoutPanel1.ColumnCount = 2;
            this.GrilletableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GrilletableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GrilletableLayoutPanel1.Location = new System.Drawing.Point(3, 91);
            this.GrilletableLayoutPanel1.Name = "GrilletableLayoutPanel1";
            this.GrilletableLayoutPanel1.RowCount = 2;
            this.GrilletableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GrilletableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GrilletableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.GrilletableLayoutPanel1.TabIndex = 1;
            // 
            // chrono
            // 
            this.chrono.Interval = 300000;
            this.chrono.Tick += new System.EventHandler(this.chrono_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 450);
            this.Controls.Add(this.GrilletableLayoutPanel1);
            this.Controls.Add(this.Affichagepanel1);
            this.Name = "Form1";
            this.Text = "Démineur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Affichagepanel1.ResumeLayout(false);
            this.Bombpanel1.ResumeLayout(false);
            this.Bombpanel1.PerformLayout();
            this.Timepanel1.ResumeLayout(false);
            this.Timepanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Affichagepanel1;
        private System.Windows.Forms.Panel Bombpanel1;
        private System.Windows.Forms.Panel Timepanel1;
        private System.Windows.Forms.Label Timelabel1;
        private System.Windows.Forms.TableLayoutPanel GrilletableLayoutPanel1;
        private System.Windows.Forms.Timer chrono;
    }
}

