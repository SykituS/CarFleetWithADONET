namespace CarFleet.Views.VehicleForms
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
            this.BtnAddNewVehicle = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewVehicles
            // 
            this.DataGridViewVehicles.AllowUserToAddRows = false;
            this.DataGridViewVehicles.AllowUserToDeleteRows = false;
            this.DataGridViewVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewVehicles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGridViewVehicles.Location = new System.Drawing.Point(16, 15);
            this.DataGridViewVehicles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridViewVehicles.MultiSelect = false;
            this.DataGridViewVehicles.Name = "DataGridViewVehicles";
            this.DataGridViewVehicles.ReadOnly = true;
            this.DataGridViewVehicles.RowHeadersWidth = 51;
            this.DataGridViewVehicles.Size = new System.Drawing.Size(1657, 421);
            this.DataGridViewVehicles.TabIndex = 0;
            this.DataGridViewVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewVehicles_CellContentClick);
            this.DataGridViewVehicles.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridViewVehicles_CellFormatting);
            // 
            // BtnAddNewVehicle
            // 
            this.BtnAddNewVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnAddNewVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddNewVehicle.ForeColor = System.Drawing.Color.White;
            this.BtnAddNewVehicle.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.BtnAddNewVehicle.IconColor = System.Drawing.Color.White;
            this.BtnAddNewVehicle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddNewVehicle.IconSize = 32;
            this.BtnAddNewVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddNewVehicle.Location = new System.Drawing.Point(32, 449);
            this.BtnAddNewVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddNewVehicle.Name = "BtnAddNewVehicle";
            this.BtnAddNewVehicle.Size = new System.Drawing.Size(224, 46);
            this.BtnAddNewVehicle.TabIndex = 32;
            this.BtnAddNewVehicle.Text = "Add new vehicle";
            this.BtnAddNewVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddNewVehicle.UseVisualStyleBackColor = false;
            this.BtnAddNewVehicle.Click += new System.EventHandler(this.BtnAddNewVehicle_Click);
            // 
            // CarListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1689, 506);
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
        private FontAwesome.Sharp.IconButton BtnAddNewVehicle;
        private System.Windows.Forms.DataGridView DataGridViewVehicles;
    }
}