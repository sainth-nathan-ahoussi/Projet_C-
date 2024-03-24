namespace TP_Alarme_Nathan_Vrai
{
    partial class frAlarme
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
            this.heureListBox = new System.Windows.Forms.CheckedListBox();
            this.Ajoutbutton = new System.Windows.Forms.Button();
            this.Suppbutton = new System.Windows.Forms.Button();
            this.SelectTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tmrHorloge = new System.Windows.Forms.Timer(this.components);
            this.horlogepanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // heureListBox
            // 
            this.heureListBox.FormattingEnabled = true;
            this.heureListBox.Location = new System.Drawing.Point(39, 77);
            this.heureListBox.Name = "heureListBox";
            this.heureListBox.Size = new System.Drawing.Size(286, 202);
            this.heureListBox.TabIndex = 0;
            // 
            // Ajoutbutton
            // 
            this.Ajoutbutton.Location = new System.Drawing.Point(39, 340);
            this.Ajoutbutton.Name = "Ajoutbutton";
            this.Ajoutbutton.Size = new System.Drawing.Size(110, 39);
            this.Ajoutbutton.TabIndex = 1;
            this.Ajoutbutton.Text = "Ajouter";
            this.Ajoutbutton.UseVisualStyleBackColor = true;
            this.Ajoutbutton.Click += new System.EventHandler(this.Ajoutbutton_Click);
            // 
            // Suppbutton
            // 
            this.Suppbutton.Location = new System.Drawing.Point(213, 340);
            this.Suppbutton.Name = "Suppbutton";
            this.Suppbutton.Size = new System.Drawing.Size(112, 39);
            this.Suppbutton.TabIndex = 2;
            this.Suppbutton.Text = "Supprimer";
            this.Suppbutton.UseVisualStyleBackColor = true;
            this.Suppbutton.Click += new System.EventHandler(this.Suppbutton_Click);
            // 
            // SelectTimePicker
            // 
            this.SelectTimePicker.CustomFormat = "";
            this.SelectTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.SelectTimePicker.Location = new System.Drawing.Point(39, 299);
            this.SelectTimePicker.Name = "SelectTimePicker";
            this.SelectTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectTimePicker.ShowUpDown = true;
            this.SelectTimePicker.Size = new System.Drawing.Size(286, 23);
            this.SelectTimePicker.TabIndex = 3;
            this.SelectTimePicker.Value = new System.DateTime(2023, 4, 14, 16, 22, 0, 0);
            // 
            // tmrHorloge
            // 
            this.tmrHorloge.Tick += new System.EventHandler(this.tmrHorloge_Tick);
            // 
            // horlogepanel
            // 
            this.horlogepanel.Location = new System.Drawing.Point(354, 77);
            this.horlogepanel.Name = "horlogepanel";
            this.horlogepanel.Size = new System.Drawing.Size(300, 300);
            this.horlogepanel.TabIndex = 4;
            this.horlogepanel.Click += new System.EventHandler(this.horlogepanel_Click);
            // 
            // frAlarme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.horlogepanel);
            this.Controls.Add(this.SelectTimePicker);
            this.Controls.Add(this.Suppbutton);
            this.Controls.Add(this.Ajoutbutton);
            this.Controls.Add(this.heureListBox);
            this.DoubleBuffered = true;
            this.Name = "frAlarme";
            this.Text = "frAlarme";
            this.Load += new System.EventHandler(this.frAlarme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox heureListBox;
        private Button Ajoutbutton;
        private Button Suppbutton;
        private DateTimePicker SelectTimePicker;
        private System.Windows.Forms.Timer tmrHorloge;
        private Panel horlogepanel;
    }
}