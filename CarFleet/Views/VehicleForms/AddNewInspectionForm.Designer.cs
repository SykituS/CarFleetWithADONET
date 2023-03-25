namespace CarFleet.Views.VehicleForms
{
    partial class AddNewInspectionForm
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
            this.BtnAddInspection = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimePickerInspection = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerNextInspection = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAddInspection
            // 
            this.BtnAddInspection.Location = new System.Drawing.Point(198, 112);
            this.BtnAddInspection.Name = "BtnAddInspection";
            this.BtnAddInspection.Size = new System.Drawing.Size(75, 23);
            this.BtnAddInspection.TabIndex = 0;
            this.BtnAddInspection.Text = "Create";
            this.BtnAddInspection.UseVisualStyleBackColor = true;
            this.BtnAddInspection.Click += new System.EventHandler(this.BtnAddInspection_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(74, 112);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date of inspection";
            // 
            // DateTimePickerInspection
            // 
            this.DateTimePickerInspection.Location = new System.Drawing.Point(132, 12);
            this.DateTimePickerInspection.Name = "DateTimePickerInspection";
            this.DateTimePickerInspection.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerInspection.TabIndex = 4;
            this.DateTimePickerInspection.ValueChanged += new System.EventHandler(this.DateTimePickerInspection_ValueChanged);
            // 
            // DateTimePickerNextInspection
            // 
            this.DateTimePickerNextInspection.Location = new System.Drawing.Point(132, 49);
            this.DateTimePickerNextInspection.Name = "DateTimePickerNextInspection";
            this.DateTimePickerNextInspection.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerNextInspection.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date of next inspection";
            // 
            // AddNewInspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 165);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateTimePickerNextInspection);
            this.Controls.Add(this.DateTimePickerInspection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAddInspection);
            this.Name = "AddNewInspectionForm";
            this.Text = "AddNewInspectionForm";
            this.Load += new System.EventHandler(this.AddNewInspectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddInspection;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateTimePickerInspection;
        private System.Windows.Forms.DateTimePicker DateTimePickerNextInspection;
        private System.Windows.Forms.Label label2;
    }
}