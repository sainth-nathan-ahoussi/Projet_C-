
namespace TP_Debogger
{
    partial class frmFenetrePrincipale
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
            this.pnlContenu = new System.Windows.Forms.Panel();
            this.lblContenu = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblWordCountValue = new System.Windows.Forms.Label();
            this.lblWordCountTitle = new System.Windows.Forms.Label();
            this.ofdFable = new System.Windows.Forms.OpenFileDialog();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.tbxFileName = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pnlContenu.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenu
            // 
            this.pnlContenu.AutoScroll = true;
            this.pnlContenu.BackColor = System.Drawing.Color.Black;
            this.pnlContenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenu.Controls.Add(this.lblContenu);
            this.pnlContenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlContenu.ForeColor = System.Drawing.Color.White;
            this.pnlContenu.Location = new System.Drawing.Point(374, 0);
            this.pnlContenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContenu.Name = "pnlContenu";
            this.pnlContenu.Size = new System.Drawing.Size(296, 184);
            this.pnlContenu.TabIndex = 1;
            // 
            // lblContenu
            // 
            this.lblContenu.AutoSize = true;
            this.lblContenu.ForeColor = System.Drawing.Color.White;
            this.lblContenu.Location = new System.Drawing.Point(7, 14);
            this.lblContenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContenu.Name = "lblContenu";
            this.lblContenu.Size = new System.Drawing.Size(0, 13);
            this.lblContenu.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblWordCountValue);
            this.pnlBottom.Controls.Add(this.lblWordCountTitle);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 265);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(670, 41);
            this.pnlBottom.TabIndex = 0;
            // 
            // lblWordCountValue
            // 
            this.lblWordCountValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWordCountValue.AutoSize = true;
            this.lblWordCountValue.Location = new System.Drawing.Point(480, 17);
            this.lblWordCountValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWordCountValue.Name = "lblWordCountValue";
            this.lblWordCountValue.Size = new System.Drawing.Size(0, 13);
            this.lblWordCountValue.TabIndex = 1;
            // 
            // lblWordCountTitle
            // 
            this.lblWordCountTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWordCountTitle.AutoSize = true;
            this.lblWordCountTitle.Location = new System.Drawing.Point(382, 17);
            this.lblWordCountTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWordCountTitle.Name = "lblWordCountTitle";
            this.lblWordCountTitle.Size = new System.Drawing.Size(93, 13);
            this.lblWordCountTitle.TabIndex = 0;
            this.lblWordCountTitle.Text = "Nombre de mots : ";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.comboBox1);
            this.pnlMenu.Controls.Add(this.lblFileName);
            this.pnlMenu.Controls.Add(this.lblMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(670, 81);
            this.pnlMenu.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Normal",
            "Majuscule",
            "Minuscule"});
            this.comboBox1.Location = new System.Drawing.Point(570, 50);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(380, 53);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 13);
            this.lblFileName.TabIndex = 1;
            // 
            // lblMenu
            // 
            this.lblMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(377, 7);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(207, 29);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Contenu du fichier";
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.tableLayoutPanel1);
            this.pnlCenter.Controls.Add(this.pnlContenu);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 81);
            this.pnlCenter.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(670, 184);
            this.pnlCenter.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnOuvrir, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbxFileName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLoad, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 184);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnOuvrir
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnOuvrir, 3);
            this.btnOuvrir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOuvrir.Location = new System.Drawing.Point(76, 110);
            this.btnOuvrir.Margin = new System.Windows.Forms.Padding(2);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(218, 32);
            this.btnOuvrir.TabIndex = 2;
            this.btnOuvrir.Text = "Ouvrir";
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.BtnOuvrir1_Click);
            // 
            // tbxFileName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbxFileName, 2);
            this.tbxFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxFileName.Location = new System.Drawing.Point(76, 38);
            this.tbxFileName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxFileName.Name = "tbxFileName";
            this.tbxFileName.Size = new System.Drawing.Size(144, 20);
            this.tbxFileName.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(224, 38);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(56, 19);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Ouvrir";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmFenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(670, 306);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlBottom);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmFenetrePrincipale";
            this.Text = "Lecteur de fichiers";
            this.pnlContenu.ResumeLayout(false);
            this.pnlContenu.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenu;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.OpenFileDialog ofdFable;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblContenu;
        private System.Windows.Forms.Label lblWordCountTitle;
        private System.Windows.Forms.Label lblWordCountValue;
        private System.Windows.Forms.TextBox tbxFileName;
        private System.Windows.Forms.Button btnLoad;
    }
}

