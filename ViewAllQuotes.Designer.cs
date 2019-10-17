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
            this.dataGridViewAllQuotes = new System.Windows.Forms.DataGridView();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RushDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurfaceMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToMainMenu
            // 
            this.BackToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMainMenu.Location = new System.Drawing.Point(400, 36);
            this.BackToMainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // dataGridViewAllQuotes
            // 
            this.dataGridViewAllQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.RushDays,
            this.Price,
            this.SurfaceMaterial,
            this.Width,
            this.Depth,
            this.Drawers,
            this.OrderDate});
            this.dataGridViewAllQuotes.Location = new System.Drawing.Point(32, 112);
            this.dataGridViewAllQuotes.Name = "dataGridViewAllQuotes";
            this.dataGridViewAllQuotes.Size = new System.Drawing.Size(842, 375);
            this.dataGridViewAllQuotes.TabIndex = 10;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            // 
            // RushDays
            // 
            this.RushDays.DataPropertyName = "RushDays";
            this.RushDays.HeaderText = "Rush Days";
            this.RushDays.Name = "RushDays";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // SurfaceMaterial
            // 
            this.SurfaceMaterial.DataPropertyName = "SurfaceMaterial";
            this.SurfaceMaterial.HeaderText = "Surface Material";
            this.SurfaceMaterial.Name = "SurfaceMaterial";
            // 
            // Width
            // 
            this.Width.DataPropertyName = "Width";
            this.Width.HeaderText = "Width";
            this.Width.Name = "Width";
            // 
            // Depth
            // 
            this.Depth.DataPropertyName = "Depth";
            this.Depth.HeaderText = "Depth";
            this.Depth.Name = "Depth";
            // 
            // Drawers
            // 
            this.Drawers.DataPropertyName = "Drawers";
            this.Drawers.HeaderText = "Drawers";
            this.Drawers.Name = "Drawers";
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.Name = "OrderDate";
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 517);
            this.Controls.Add(this.dataGridViewAllQuotes);
            this.Controls.Add(this.BackToMainMenu);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAllQuotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RushDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurfaceMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
    }
}