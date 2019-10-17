namespace MegaDesk_Roper
{
    partial class ViewAllQuotes
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
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numQuotesLabel = new System.Windows.Forms.Label();
            this.dataGridViewAllQuotes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToMainMenu
            // 
            this.BackToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMainMenu.Location = new System.Drawing.Point(400, 36);
            this.BackToMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.BackToMainMenu.Name = "BackToMainMenu";
            this.BackToMainMenu.Size = new System.Drawing.Size(183, 33);
            this.BackToMainMenu.TabIndex = 7;
            this.BackToMainMenu.Text = "Back to Main Menu";
            this.BackToMainMenu.UseVisualStyleBackColor = true;
            this.BackToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 56);
            this.label1.TabIndex = 8;
            this.label1.Text = "View All Quotes";
            // 
            // numQuotesLabel
            // 
            this.numQuotesLabel.AutoSize = true;
            this.numQuotesLabel.Location = new System.Drawing.Point(61, 79);
            this.numQuotesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numQuotesLabel.Name = "numQuotesLabel";
            this.numQuotesLabel.Size = new System.Drawing.Size(35, 13);
            this.numQuotesLabel.TabIndex = 9;
            this.numQuotesLabel.Text = "label2";
            // 
            // dataGridViewAllQuotes
            // 
            this.dataGridViewAllQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllQuotes.Location = new System.Drawing.Point(32, 95);
            this.dataGridViewAllQuotes.Name = "dataGridViewAllQuotes";
            this.dataGridViewAllQuotes.Size = new System.Drawing.Size(495, 211);
            this.dataGridViewAllQuotes.TabIndex = 10;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridViewAllQuotes);
            this.Controls.Add(this.numQuotesLabel);
            this.Controls.Add(this.BackToMainMenu);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numQuotesLabel;
        private System.Windows.Forms.DataGridView dataGridViewAllQuotes;
    }
}