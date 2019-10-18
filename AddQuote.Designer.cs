namespace MegaDesk_Roper
{
    partial class AddQuotesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.SurfaceHelperText = new System.Windows.Forms.Label();
            this.DrawersHelperText = new System.Windows.Forms.Label();
            this.DepthHelperText = new System.Windows.Forms.Label();
            this.WidthHelperText = new System.Windows.Forms.Label();
            this.Depth = new System.Windows.Forms.NumericUpDown();
            this.NumDrawers = new System.Windows.Forms.NumericUpDown();
            this.Width = new System.Windows.Forms.NumericUpDown();
            this.CreateQuoteButton = new System.Windows.Forms.Button();
            this.RushDaysHelperText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CustomerNameHelperText = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RushDays = new System.Windows.Forms.ComboBox();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.CurrentDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDrawers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 56);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add New Quote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Depth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "# of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Surface Material";
            // 
            // SurfaceMaterial
            // 
            this.SurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMaterial.FormattingEnabled = true;
            this.SurfaceMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.SurfaceMaterial.Location = new System.Drawing.Point(256, 275);
            this.SurfaceMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.SurfaceMaterial.Name = "SurfaceMaterial";
            this.SurfaceMaterial.Size = new System.Drawing.Size(117, 30);
            this.SurfaceMaterial.TabIndex = 6;
            this.SurfaceMaterial.SelectedIndexChanged += new System.EventHandler(this.SurfaceMaterial_SelectedIndexChanged);
            // 
            // BackToMainMenu
            // 
            this.BackToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMainMenu.Location = new System.Drawing.Point(400, 19);
            this.BackToMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.BackToMainMenu.Name = "BackToMainMenu";
            this.BackToMainMenu.Size = new System.Drawing.Size(189, 44);
            this.BackToMainMenu.TabIndex = 9;
            this.BackToMainMenu.Text = "Back to Main Menu";
            this.BackToMainMenu.UseVisualStyleBackColor = true;
            this.BackToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // SurfaceHelperText
            // 
            this.SurfaceHelperText.AutoSize = true;
            this.SurfaceHelperText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceHelperText.Location = new System.Drawing.Point(377, 282);
            this.SurfaceHelperText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SurfaceHelperText.Name = "SurfaceHelperText";
            this.SurfaceHelperText.Size = new System.Drawing.Size(84, 17);
            this.SurfaceHelperText.TabIndex = 16;
            this.SurfaceHelperText.Text = "Choose one";
            // 
            // DrawersHelperText
            // 
            this.DrawersHelperText.AutoSize = true;
            this.DrawersHelperText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawersHelperText.Location = new System.Drawing.Point(309, 235);
            this.DrawersHelperText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DrawersHelperText.Name = "DrawersHelperText";
            this.DrawersHelperText.Size = new System.Drawing.Size(114, 17);
            this.DrawersHelperText.TabIndex = 15;
            this.DrawersHelperText.Text = "Between 0 and 7";
            // 
            // DepthHelperText
            // 
            this.DepthHelperText.AutoSize = true;
            this.DepthHelperText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthHelperText.Location = new System.Drawing.Point(309, 203);
            this.DepthHelperText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DepthHelperText.Name = "DepthHelperText";
            this.DepthHelperText.Size = new System.Drawing.Size(175, 17);
            this.DepthHelperText.TabIndex = 14;
            this.DepthHelperText.Text = "Between 12 and 48 inches";
            // 
            // WidthHelperText
            // 
            this.WidthHelperText.AutoSize = true;
            this.WidthHelperText.BackColor = System.Drawing.SystemColors.Control;
            this.WidthHelperText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthHelperText.Location = new System.Drawing.Point(309, 171);
            this.WidthHelperText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WidthHelperText.Name = "WidthHelperText";
            this.WidthHelperText.Size = new System.Drawing.Size(175, 17);
            this.WidthHelperText.TabIndex = 13;
            this.WidthHelperText.Text = "Between 24 and 96 inches";
            // 
            // Depth
            // 
            this.Depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depth.Location = new System.Drawing.Point(256, 197);
            this.Depth.Margin = new System.Windows.Forms.Padding(2);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(49, 28);
            this.Depth.TabIndex = 4;
            this.Depth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Depth.ValueChanged += new System.EventHandler(this.Depth_ValueChanged);
            // 
            // NumDrawers
            // 
            this.NumDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDrawers.Location = new System.Drawing.Point(256, 229);
            this.NumDrawers.Margin = new System.Windows.Forms.Padding(2);
            this.NumDrawers.Name = "NumDrawers";
            this.NumDrawers.Size = new System.Drawing.Size(49, 28);
            this.NumDrawers.TabIndex = 5;
            this.NumDrawers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumDrawers.ValueChanged += new System.EventHandler(this.NumDrawers_ValueChanged);
            // 
            // Width
            // 
            this.Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Width.Location = new System.Drawing.Point(256, 165);
            this.Width.Margin = new System.Windows.Forms.Padding(2);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(49, 28);
            this.Width.TabIndex = 3;
            this.Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Width.ValueChanged += new System.EventHandler(this.Width_ValueChanged);
            // 
            // CreateQuoteButton
            // 
            this.CreateQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateQuoteButton.Location = new System.Drawing.Point(256, 318);
            this.CreateQuoteButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateQuoteButton.Name = "CreateQuoteButton";
            this.CreateQuoteButton.Size = new System.Drawing.Size(120, 36);
            this.CreateQuoteButton.TabIndex = 8;
            this.CreateQuoteButton.Text = "Create Quote";
            this.CreateQuoteButton.UseVisualStyleBackColor = true;
            this.CreateQuoteButton.Click += new System.EventHandler(this.CreateQuoteButton_Click);
            // 
            // RushDaysHelperText
            // 
            this.RushDaysHelperText.AutoSize = true;
            this.RushDaysHelperText.BackColor = System.Drawing.SystemColors.Control;
            this.RushDaysHelperText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushDaysHelperText.Location = new System.Drawing.Point(310, 129);
            this.RushDaysHelperText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RushDaysHelperText.Name = "RushDaysHelperText";
            this.RushDaysHelperText.Size = new System.Drawing.Size(176, 17);
            this.RushDaysHelperText.TabIndex = 20;
            this.RushDaysHelperText.Text = "How soon do they need it?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Rush (days)";
            // 
            // CustomerNameHelperText
            // 
            this.CustomerNameHelperText.AutoSize = true;
            this.CustomerNameHelperText.BackColor = System.Drawing.SystemColors.Control;
            this.CustomerNameHelperText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameHelperText.Location = new System.Drawing.Point(381, 93);
            this.CustomerNameHelperText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerNameHelperText.Name = "CustomerNameHelperText";
            this.CustomerNameHelperText.Size = new System.Drawing.Size(81, 17);
            this.CustomerNameHelperText.TabIndex = 23;
            this.CustomerNameHelperText.Text = "Enter name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(83, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Customer Name";
            // 
            // RushDays
            // 
            this.RushDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushDays.FormattingEnabled = true;
            this.RushDays.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "14"});
            this.RushDays.Location = new System.Drawing.Point(256, 122);
            this.RushDays.Margin = new System.Windows.Forms.Padding(2);
            this.RushDays.Name = "RushDays";
            this.RushDays.Size = new System.Drawing.Size(50, 30);
            this.RushDays.TabIndex = 2;
            this.RushDays.SelectedIndexChanged += new System.EventHandler(this.RushDays_SelectedIndexChanged);
            // 
            // CustomerName
            // 
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(257, 90);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(119, 28);
            this.CustomerName.TabIndex = 1;
            this.CustomerName.TextChanged += new System.EventHandler(this.CustomerName_TextChanged);
            // 
            // CurrentDate
            // 
            this.CurrentDate.AutoSize = true;
            this.CurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDate.Location = new System.Drawing.Point(11, 330);
            this.CurrentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(36, 17);
            this.CurrentDate.TabIndex = 24;
            this.CurrentDate.Text = "date";
            // 
            // AddQuotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.CurrentDate);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.RushDays);
            this.Controls.Add(this.CustomerNameHelperText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RushDaysHelperText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CreateQuoteButton);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.NumDrawers);
            this.Controls.Add(this.Depth);
            this.Controls.Add(this.SurfaceHelperText);
            this.Controls.Add(this.DrawersHelperText);
            this.Controls.Add(this.DepthHelperText);
            this.Controls.Add(this.WidthHelperText);
            this.Controls.Add(this.BackToMainMenu);
            this.Controls.Add(this.SurfaceMaterial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuotesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Quote";
            this.Load += new System.EventHandler(this.AddQuotesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDrawers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SurfaceMaterial;
        private System.Windows.Forms.Button BackToMainMenu;
        private System.Windows.Forms.Label SurfaceHelperText;
        private System.Windows.Forms.Label DrawersHelperText;
        private System.Windows.Forms.Label DepthHelperText;
        private System.Windows.Forms.Label WidthHelperText;
        private System.Windows.Forms.NumericUpDown Depth;
        private System.Windows.Forms.NumericUpDown NumDrawers;
        private new System.Windows.Forms.NumericUpDown  Width;
        private System.Windows.Forms.Button CreateQuoteButton;
        private System.Windows.Forms.Label RushDaysHelperText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CustomerNameHelperText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox RushDays;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Label CurrentDate;
    }
}