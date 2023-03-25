namespace CarFleet.Views.VehicleForms
{
    partial class AddOrEditInsurenceForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.DateTimePickerInsurenceEnd = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerInsurenceStart = new System.Windows.Forms.DateTimePicker();
            this.TBInsurer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAddInspection = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DateTimePickerInsurenceEnd);
            this.panel2.Controls.Add(this.DateTimePickerInsurenceStart);
            this.panel2.Controls.Add(this.TBInsurer);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(23, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 100);
            this.panel2.TabIndex = 18;
            // 
            // DateTimePickerInsurenceEnd
            // 
            this.DateTimePickerInsurenceEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerInsurenceEnd.Location = new System.Drawing.Point(157, 58);
            this.DateTimePickerInsurenceEnd.Name = "DateTimePickerInsurenceEnd";
            this.DateTimePickerInsurenceEnd.Size = new System.Drawing.Size(131, 20);
            this.DateTimePickerInsurenceEnd.TabIndex = 21;
            // 
            // DateTimePickerInsurenceStart
            // 
            this.DateTimePickerInsurenceStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerInsurenceStart.Location = new System.Drawing.Point(157, 32);
            this.DateTimePickerInsurenceStart.Name = "DateTimePickerInsurenceStart";
            this.DateTimePickerInsurenceStart.Size = new System.Drawing.Size(131, 20);
            this.DateTimePickerInsurenceStart.TabIndex = 20;
            // 
            // TBInsurer
            // 
            this.TBInsurer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBInsurer.Location = new System.Drawing.Point(157, 3);
            this.TBInsurer.Name = "TBInsurer";
            this.TBInsurer.Size = new System.Drawing.Size(131, 20);
            this.TBInsurer.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "End date of insurence";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Insurer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Start date of insurence";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(49, 171);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 20;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnAddInspection
            // 
            this.BtnAddInspection.Location = new System.Drawing.Point(173, 171);
            this.BtnAddInspection.Name = "BtnAddInspection";
            this.BtnAddInspection.Size = new System.Drawing.Size(75, 23);
            this.BtnAddInspection.TabIndex = 19;
            this.BtnAddInspection.Text = "Create";
            this.BtnAddInspection.UseVisualStyleBackColor = true;
            // 
            // AddOrEditInsurenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 214);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAddInspection);
            this.Controls.Add(this.panel2);
            this.Name = "AddOrEditInsurenceForm";
            this.Text = "AddOrEditInsurenceForm";
            this.Load += new System.EventHandler(this.AddOrEditInsurenceForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DateTimePicker DateTimePickerInsurenceEnd;
        public System.Windows.Forms.DateTimePicker DateTimePickerInsurenceStart;
        private System.Windows.Forms.TextBox TBInsurer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAddInspection;
    }
}