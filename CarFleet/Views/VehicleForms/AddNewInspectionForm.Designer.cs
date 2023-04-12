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
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimePickerInspection = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerNextInspection = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.BtnAddInspection = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date of inspection";
            // 
            // DateTimePickerInspection
            // 
            this.DateTimePickerInspection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTimePickerInspection.Location = new System.Drawing.Point(288, 15);
            this.DateTimePickerInspection.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePickerInspection.Name = "DateTimePickerInspection";
            this.DateTimePickerInspection.Size = new System.Drawing.Size(265, 22);
            this.DateTimePickerInspection.TabIndex = 4;
            this.DateTimePickerInspection.ValueChanged += new System.EventHandler(this.DateTimePickerInspection_ValueChanged);
            // 
            // DateTimePickerNextInspection
            // 
            this.DateTimePickerNextInspection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTimePickerNextInspection.Location = new System.Drawing.Point(288, 60);
            this.DateTimePickerNextInspection.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePickerNextInspection.Name = "DateTimePickerNextInspection";
            this.DateTimePickerNextInspection.Size = new System.Drawing.Size(265, 22);
            this.DateTimePickerNextInspection.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date of next inspection";
            // 
            // LabelWarning
            // 
            this.LabelWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.ForeColor = System.Drawing.Color.Red;
            this.LabelWarning.Location = new System.Drawing.Point(128, 106);
            this.LabelWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(0, 16);
            this.LabelWarning.TabIndex = 24;
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.BtnBack.IconColor = System.Drawing.Color.White;
            this.BtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBack.IconSize = 32;
            this.BtnBack.Location = new System.Drawing.Point(159, 146);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(163, 45);
            this.BtnBack.TabIndex = 25;
            this.BtnBack.Text = "Back";
            this.BtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnAddInspection
            // 
            this.BtnAddInspection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAddInspection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnAddInspection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddInspection.ForeColor = System.Drawing.Color.White;
            this.BtnAddInspection.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.BtnAddInspection.IconColor = System.Drawing.Color.White;
            this.BtnAddInspection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddInspection.IconSize = 32;
            this.BtnAddInspection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddInspection.Location = new System.Drawing.Point(376, 146);
            this.BtnAddInspection.Name = "BtnAddInspection";
            this.BtnAddInspection.Size = new System.Drawing.Size(163, 45);
            this.BtnAddInspection.TabIndex = 26;
            this.BtnAddInspection.Text = "Create";
            this.BtnAddInspection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddInspection.UseVisualStyleBackColor = false;
            this.BtnAddInspection.Click += new System.EventHandler(this.BtnAddInspection_Click_1);
            // 
            // AddNewInspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 203);
            this.Controls.Add(this.BtnAddInspection);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LabelWarning);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateTimePickerNextInspection);
            this.Controls.Add(this.DateTimePickerInspection);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewInspectionForm";
            this.Text = "AddNewInspectionForm";
            this.Load += new System.EventHandler(this.AddNewInspectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateTimePickerInspection;
        private System.Windows.Forms.DateTimePicker DateTimePickerNextInspection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelWarning;
        private FontAwesome.Sharp.IconButton BtnBack;
        private FontAwesome.Sharp.IconButton BtnAddInspection;
    }
}