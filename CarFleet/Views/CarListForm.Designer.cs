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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewVehicles
            // 
            this.DataGridViewVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewVehicles.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewVehicles.Name = "DataGridViewVehicles";
            this.DataGridViewVehicles.Size = new System.Drawing.Size(688, 342);
            this.DataGridViewVehicles.TabIndex = 0;
            // 
            // CarListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 366);
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
    }
}