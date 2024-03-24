
namespace TP_MVC_NATHAN.Implementation
{
     partial class CustomListView
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
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.Removebutton = new System.Windows.Forms.Button();
            this.ChangeViewButton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.AgetextBox = new System.Windows.Forms.TextBox();
            this.TowntextBox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Agelabel = new System.Windows.Forms.Label();
            this.Townlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxClient
            // 
            this.listBoxClient.FormattingEnabled = true;
            this.listBoxClient.ItemHeight = 15;
            this.listBoxClient.Location = new System.Drawing.Point(22, 26);
            this.listBoxClient.Name = "listBoxClient";
            this.listBoxClient.Size = new System.Drawing.Size(313, 319);
            this.listBoxClient.TabIndex = 0;
            // 
            // Removebutton
            // 
            this.Removebutton.Location = new System.Drawing.Point(140, 371);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(92, 40);
            this.Removebutton.TabIndex = 1;
            this.Removebutton.Text = "Remove";
            this.Removebutton.UseVisualStyleBackColor = true;
            // 
            // ChangeViewButton
            // 
            this.ChangeViewButton.Location = new System.Drawing.Point(670, 385);
            this.ChangeViewButton.Name = "ChangeViewButton";
            this.ChangeViewButton.Size = new System.Drawing.Size(106, 42);
            this.ChangeViewButton.TabIndex = 2;
            this.ChangeViewButton.Text = "Change View";
            this.ChangeViewButton.UseVisualStyleBackColor = true;
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(682, 84);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(81, 23);
            this.Addbutton.TabIndex = 3;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(486, 56);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(129, 23);
            this.NametextBox.TabIndex = 4;
            // 
            // AgetextBox
            // 
            this.AgetextBox.Location = new System.Drawing.Point(486, 85);
            this.AgetextBox.Name = "AgetextBox";
            this.AgetextBox.Size = new System.Drawing.Size(129, 23);
            this.AgetextBox.TabIndex = 5;
            // 
            // TowntextBox
            // 
            this.TowntextBox.Location = new System.Drawing.Point(486, 114);
            this.TowntextBox.Name = "TowntextBox";
            this.TowntextBox.Size = new System.Drawing.Size(129, 23);
            this.TowntextBox.TabIndex = 6;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Namelabel.Location = new System.Drawing.Point(429, 56);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(51, 20);
            this.Namelabel.TabIndex = 7;
            this.Namelabel.Text = "Name";
            // 
            // Agelabel
            // 
            this.Agelabel.AutoSize = true;
            this.Agelabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Agelabel.Location = new System.Drawing.Point(443, 88);
            this.Agelabel.Name = "Agelabel";
            this.Agelabel.Size = new System.Drawing.Size(37, 20);
            this.Agelabel.TabIndex = 8;
            this.Agelabel.Text = "Age";
            // 
            // Townlabel
            // 
            this.Townlabel.AutoSize = true;
            this.Townlabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Townlabel.Location = new System.Drawing.Point(433, 117);
            this.Townlabel.Name = "Townlabel";
            this.Townlabel.Size = new System.Drawing.Size(47, 20);
            this.Townlabel.TabIndex = 9;
            this.Townlabel.Text = "Town";
            // 
            // CustomListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Townlabel);
            this.Controls.Add(this.Agelabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.TowntextBox);
            this.Controls.Add(this.AgetextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.ChangeViewButton);
            this.Controls.Add(this.Removebutton);
            this.Controls.Add(this.listBoxClient);
            this.Name = "CustomListView";
            this.Text = "ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxClient;
        private Button Removebutton;
        private Button ChangeViewButton;
        private Button Addbutton;
        private TextBox NametextBox;
        private TextBox AgetextBox;
        private TextBox TowntextBox;
        private Label Namelabel;
        private Label Agelabel;
        private Label Townlabel;
    }
}