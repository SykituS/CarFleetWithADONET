namespace CarFleet.Views
{
    partial class CarListForm
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
            this.DataGridViewVehicles = new System.Windows.Forms.DataGridView();
            this.BtnAddNewVehicle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewVehicles
            // 
            this.DataGridViewVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewVehicles.Location = new System.Drawing.Point(16, 15);
            this.DataGridViewVehicles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridViewVehicles.Name = "DataGridViewVehicles";
            this.DataGridViewVehicles.RowHeadersWidth = 51;
            this.DataGridViewVehicles.Size = new System.Drawing.Size(1657, 421);
            this.DataGridViewVehicles.TabIndex = 0;
            this.DataGridViewVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewVehicles_CellContentClick);
            this.DataGridViewVehicles.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridViewVehicles_CellFormatting);
            // 
            // BtnAddNewVehicle
            // 
            this.BtnAddNewVehicle.Location = new System.Drawing.Point(68, 447);
            this.BtnAddNewVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAddNewVehicle.Name = "BtnAddNewVehicle";
            this.BtnAddNewVehicle.Size = new System.Drawing.Size(240, 28);
            this.BtnAddNewVehicle.TabIndex = 1;
            this.BtnAddNewVehicle.Text = "Add new vehicle";
            this.BtnAddNewVehicle.UseVisualStyleBackColor = true;
            this.BtnAddNewVehicle.Click += new System.EventHandler(this.BtnAddNewVehicle_Click);
            // 
            // CarListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1689, 487);
            this.Controls.Add(this.BtnAddNewVehicle);
            this.Controls.Add(this.DataGridViewVehicles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CarListForm";
            this.Text = "CarListForm";
            this.Load += new System.EventHandler(this.CarListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVehicles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewVehicles;
        private System.Windows.Forms.Button BtnAddNewVehicle;
    }
}