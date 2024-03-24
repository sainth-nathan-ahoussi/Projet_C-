namespace Anagrammes
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
            this.MotTrouver1 = new System.Windows.Forms.Label();
            this.MotàTrouverVrai = new System.Windows.Forms.Label();
            this.Proposition = new System.Windows.Forms.GroupBox();
            this.SaisieMot = new System.Windows.Forms.TextBox();
            this.Tester = new System.Windows.Forms.Button();
            this.Essais = new System.Windows.Forms.GroupBox();
            this.Essaisprécédents = new System.Windows.Forms.Label();
            this.NbRestantText = new System.Windows.Forms.Label();
            this.HistoriqueParties = new System.Windows.Forms.GroupBox();
            this.buttonRejouer = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.NbEssaisVrai = new System.Windows.Forms.Label();
            this.EssaisPrécedentAffichage = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.ListBox();
            this.Proposition.SuspendLayout();
            this.Essais.SuspendLayout();
            this.HistoriqueParties.SuspendLayout();
            this.SuspendLayout();
            // 
            // MotTrouver1
            // 
            this.MotTrouver1.AutoSize = true;
            this.MotTrouver1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotTrouver1.Location = new System.Drawing.Point(12, 9);
            this.MotTrouver1.Name = "MotTrouver1";
            this.MotTrouver1.Size = new System.Drawing.Size(109, 16);
            this.MotTrouver1.TabIndex = 0;
            this.MotTrouver1.Text = "Mot à deviner :";
            this.MotTrouver1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MotàTrouverVrai
            // 
            this.MotàTrouverVrai.AutoSize = true;
            this.MotàTrouverVrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotàTrouverVrai.Location = new System.Drawing.Point(12, 34);
            this.MotàTrouverVrai.Name = "MotàTrouverVrai";
            this.MotàTrouverVrai.Size = new System.Drawing.Size(97, 39);
            this.MotàTrouverVrai.TabIndex = 1;
            this.MotàTrouverVrai.Text = "MOT";
            this.MotàTrouverVrai.Click += new System.EventHandler(this.MotàTrouverVrai_Click);
            // 
            // Proposition
            // 
            this.Proposition.Controls.Add(this.SaisieMot);
            this.Proposition.Controls.Add(this.Tester);
            this.Proposition.Location = new System.Drawing.Point(19, 88);
            this.Proposition.Name = "Proposition";
            this.Proposition.Size = new System.Drawing.Size(353, 108);
            this.Proposition.TabIndex = 2;
            this.Proposition.TabStop = false;
            this.Proposition.Text = "Proposition";
            this.Proposition.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SaisieMot
            // 
            this.SaisieMot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SaisieMot.Location = new System.Drawing.Point(16, 49);
            this.SaisieMot.Name = "SaisieMot";
            this.SaisieMot.Size = new System.Drawing.Size(213, 20);
            this.SaisieMot.TabIndex = 3;
            this.SaisieMot.TextChanged += new System.EventHandler(this.SaisieMot_TextChanged);
            // 
            // Tester
            // 
            this.Tester.Location = new System.Drawing.Point(251, 37);
            this.Tester.Name = "Tester";
            this.Tester.Size = new System.Drawing.Size(86, 43);
            this.Tester.TabIndex = 0;
            this.Tester.Text = "Tester !";
            this.Tester.UseVisualStyleBackColor = true;
            this.Tester.Click += new System.EventHandler(this.Tester_Click);
            // 
            // Essais
            // 
            this.Essais.Controls.Add(this.EssaisPrécedentAffichage);
            this.Essais.Controls.Add(this.NbEssaisVrai);
            this.Essais.Controls.Add(this.Essaisprécédents);
            this.Essais.Controls.Add(this.NbRestantText);
            this.Essais.Location = new System.Drawing.Point(19, 215);
            this.Essais.Name = "Essais";
            this.Essais.Size = new System.Drawing.Size(353, 213);
            this.Essais.TabIndex = 3;
            this.Essais.TabStop = false;
            this.Essais.Text = "Essais";
            // 
            // Essaisprécédents
            // 
            this.Essaisprécédents.AutoSize = true;
            this.Essaisprécédents.Location = new System.Drawing.Point(6, 50);
            this.Essaisprécédents.Name = "Essaisprécédents";
            this.Essaisprécédents.Size = new System.Drawing.Size(102, 13);
            this.Essaisprécédents.TabIndex = 1;
            this.Essaisprécédents.Text = "Essais précédents : ";
            this.Essaisprécédents.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // NbRestantText
            // 
            this.NbRestantText.AutoSize = true;
            this.NbRestantText.Location = new System.Drawing.Point(6, 25);
            this.NbRestantText.Name = "NbRestantText";
            this.NbRestantText.Size = new System.Drawing.Size(133, 13);
            this.NbRestantText.TabIndex = 0;
            this.NbRestantText.Text = "Nombre d\'essais restants : ";
            this.NbRestantText.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // HistoriqueParties
            // 
            this.HistoriqueParties.Controls.Add(this.richTextBox1);
            this.HistoriqueParties.Location = new System.Drawing.Point(417, 96);
            this.HistoriqueParties.Name = "HistoriqueParties";
            this.HistoriqueParties.Size = new System.Drawing.Size(347, 211);
            this.HistoriqueParties.TabIndex = 4;
            this.HistoriqueParties.TabStop = false;
            this.HistoriqueParties.Text = "Historique des parties";
            this.HistoriqueParties.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // buttonRejouer
            // 
            this.buttonRejouer.Location = new System.Drawing.Point(434, 360);
            this.buttonRejouer.Name = "buttonRejouer";
            this.buttonRejouer.Size = new System.Drawing.Size(101, 52);
            this.buttonRejouer.TabIndex = 5;
            this.buttonRejouer.Text = "Rejouer";
            this.buttonRejouer.UseVisualStyleBackColor = true;
            this.buttonRejouer.Click += new System.EventHandler(this.buttonRejouer_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(645, 360);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(101, 52);
            this.buttonQuitter.TabIndex = 6;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            // 
            // NbEssaisVrai
            // 
            this.NbEssaisVrai.AutoSize = true;
            this.NbEssaisVrai.Location = new System.Drawing.Point(135, 25);
            this.NbEssaisVrai.Name = "NbEssaisVrai";
            this.NbEssaisVrai.Size = new System.Drawing.Size(35, 13);
            this.NbEssaisVrai.TabIndex = 4;
            this.NbEssaisVrai.Text = "label1";
            this.NbEssaisVrai.Click += new System.EventHandler(this.NbEssaisVrai_Click);
            // 
            // EssaisPrécedentAffichage
            // 
            this.EssaisPrécedentAffichage.FormattingEnabled = true;
            this.EssaisPrécedentAffichage.Location = new System.Drawing.Point(9, 79);
            this.EssaisPrécedentAffichage.Name = "EssaisPrécedentAffichage";
            this.EssaisPrécedentAffichage.Size = new System.Drawing.Size(328, 121);
            this.EssaisPrécedentAffichage.TabIndex = 7;
            this.EssaisPrécedentAffichage.SelectedIndexChanged += new System.EventHandler(this.EssaisPrécedentAffichage_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.FormattingEnabled = true;
            this.richTextBox1.Location = new System.Drawing.Point(17, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(312, 173);
            this.richTextBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonRejouer);
            this.Controls.Add(this.HistoriqueParties);
            this.Controls.Add(this.Essais);
            this.Controls.Add(this.Proposition);
            this.Controls.Add(this.MotàTrouverVrai);
            this.Controls.Add(this.MotTrouver1);
            this.Name = "Form1";
            this.Text = "Anagrammes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Proposition.ResumeLayout(false);
            this.Proposition.PerformLayout();
            this.Essais.ResumeLayout(false);
            this.Essais.PerformLayout();
            this.HistoriqueParties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MotTrouver1;
        private System.Windows.Forms.Label MotàTrouverVrai;
        private System.Windows.Forms.GroupBox Proposition;
        private System.Windows.Forms.TextBox SaisieMot;
        private System.Windows.Forms.Button Tester;
        private System.Windows.Forms.GroupBox Essais;
        private System.Windows.Forms.Label NbRestantText;
        private System.Windows.Forms.Label Essaisprécédents;
        private System.Windows.Forms.GroupBox HistoriqueParties;
        private System.Windows.Forms.Button buttonRejouer;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Label NbEssaisVrai;
        private System.Windows.Forms.ListBox EssaisPrécedentAffichage;
        private System.Windows.Forms.ListBox richTextBox1;
    }
}

