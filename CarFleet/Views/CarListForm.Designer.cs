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
            this.DataGridViewVehicles.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewVehicles.Name = "DataGridViewVehicles";
            this.DataGridViewVehicles.Size = new System.Drawing.Size(1243, 342);
            this.DataGridViewVehicles.TabIndex = 0;
            this.DataGridViewVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewVehicles_CellContentClick);
            this.DataGridViewVehicles.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridViewVehicles_CellFormatting);
            // 
            // BtnAddNewVehicle
            // 
            this.BtnAddNewVehicle.Location = new System.Drawing.Point(51, 363);
            this.BtnAddNewVehicle.Name = "BtnAddNewVehicle";
            this.BtnAddNewVehicle.Size = new System.Drawing.Size(180, 23);
            this.BtnAddNewVehicle.TabIndex = 1;
            this.BtnAddNewVehicle.Text = "Add new vehicle";
            this.BtnAddNewVehicle.UseVisualStyleBackColor = true;
            this.BtnAddNewVehicle.Click += new System.EventHandler(this.BtnAddNewVehicle_Click);
            // 
            // CarListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1267, 396);
            this.Controls.Add(this.BtnAddNewVehicle);
            this.Controls.Add(this.DataGridViewVehicles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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