namespace CarFleet.Views.VehicleForms
{
    partial class ChangeVehicleStatusForm
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAddInspection = new System.Windows.Forms.Button();
            this.CBoxVehicleStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(71, 135);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnAddInspection
            // 
            this.BtnAddInspection.Location = new System.Drawing.Point(195, 135);
            this.BtnAddInspection.Name = "BtnAddInspection";
            this.BtnAddInspection.Size = new System.Drawing.Size(75, 23);
            this.BtnAddInspection.TabIndex = 2;
            this.BtnAddInspection.Text = "Create";
            this.BtnAddInspection.UseVisualStyleBackColor = true;
            this.BtnAddInspection.Click += new System.EventHandler(this.BtnAddInspection_Click);
            // 
            // CBoxVehicleStatus
            // 
            this.CBoxVehicleStatus.FormattingEnabled = true;
            this.CBoxVehicleStatus.Location = new System.Drawing.Point(87, 45);
            this.CBoxVehicleStatus.Name = "CBoxVehicleStatus";
            this.CBoxVehicleStatus.Size = new System.Drawing.Size(147, 21);
            this.CBoxVehicleStatus.TabIndex = 4;
            // 
            // ChangeVehicleStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 180);
            this.Controls.Add(this.CBoxVehicleStatus);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAddInspection);
            this.Name = "ChangeVehicleStatusForm";
            this.Text = "ChangeVehicleStatusForm";
            this.Load += new System.EventHandler(this.ChangeVehicleStatusForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAddInspection;
        private System.Windows.Forms.ComboBox CBoxVehicleStatus;
    }
}