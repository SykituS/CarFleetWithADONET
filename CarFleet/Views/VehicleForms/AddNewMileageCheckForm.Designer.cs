namespace CarFleet.Views.VehicleForms
{
    partial class AddNewMileageCheckForm
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
            this.NumericUDMileage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAddInspection = new System.Windows.Forms.Button();
            this.LabelWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDMileage)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericUDMileage
            // 
            this.NumericUDMileage.Location = new System.Drawing.Point(99, 27);
            this.NumericUDMileage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NumericUDMileage.Name = "NumericUDMileage";
            this.NumericUDMileage.Size = new System.Drawing.Size(120, 20);
            this.NumericUDMileage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mileage";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(33, 107);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnAddInspection
            // 
            this.BtnAddInspection.Location = new System.Drawing.Point(157, 107);
            this.BtnAddInspection.Name = "BtnAddInspection";
            this.BtnAddInspection.Size = new System.Drawing.Size(75, 23);
            this.BtnAddInspection.TabIndex = 2;
            this.BtnAddInspection.Text = "Create";
            this.BtnAddInspection.UseVisualStyleBackColor = true;
            this.BtnAddInspection.Click += new System.EventHandler(this.BtnAddInspection_Click);
            // 
            // LabelWarning
            // 
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.ForeColor = System.Drawing.Color.Red;
            this.LabelWarning.Location = new System.Drawing.Point(42, 67);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(73, 13);
            this.LabelWarning.TabIndex = 4;
            this.LabelWarning.Text = "LabelWarning";
            // 
            // AddNewMileageCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 160);
            this.Controls.Add(this.LabelWarning);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAddInspection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericUDMileage);
            this.Name = "AddNewMileageCheckForm";
            this.Text = "AddNewMileageCheckForm";
            this.Load += new System.EventHandler(this.AddNewMileageCheckForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDMileage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumericUDMileage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAddInspection;
        private System.Windows.Forms.Label LabelWarning;
    }
}