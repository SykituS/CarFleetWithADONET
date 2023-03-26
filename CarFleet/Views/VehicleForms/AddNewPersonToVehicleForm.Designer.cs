namespace CarFleet.Views.VehicleForms
{
    partial class AddNewPersonToVehicleForm
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
            this.LabelWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(218, 278);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnAddInspection
            // 
            this.BtnAddInspection.Location = new System.Drawing.Point(342, 278);
            this.BtnAddInspection.Name = "BtnAddInspection";
            this.BtnAddInspection.Size = new System.Drawing.Size(75, 23);
            this.BtnAddInspection.TabIndex = 2;
            this.BtnAddInspection.Text = "Create";
            this.BtnAddInspection.UseVisualStyleBackColor = true;
            // 
            // LabelWarning
            // 
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.ForeColor = System.Drawing.Color.Red;
            this.LabelWarning.Location = new System.Drawing.Point(364, 219);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(73, 13);
            this.LabelWarning.TabIndex = 24;
            this.LabelWarning.Text = "LabelWarning";
            // 
            // AddNewPersonToVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelWarning);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAddInspection);
            this.Name = "AddNewPersonToVehicleForm";
            this.Text = "AddNewPersonToVehicleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAddInspection;
        private System.Windows.Forms.Label LabelWarning;
    }
}