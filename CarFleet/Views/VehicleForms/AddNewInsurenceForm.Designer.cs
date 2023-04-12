namespace CarFleet.Views.VehicleForms
{
    partial class AddNewInsurenceForm
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
            this.LabelWarning = new System.Windows.Forms.Label();
            this.BtnAddInsurence = new FontAwesome.Sharp.IconButton();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.DateTimePickerInsurenceEnd);
            this.panel2.Controls.Add(this.DateTimePickerInsurenceStart);
            this.panel2.Controls.Add(this.TBInsurer);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(13, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 123);
            this.panel2.TabIndex = 18;
            // 
            // DateTimePickerInsurenceEnd
            // 
            this.DateTimePickerInsurenceEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerInsurenceEnd.Location = new System.Drawing.Point(227, 71);
            this.DateTimePickerInsurenceEnd.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePickerInsurenceEnd.Name = "DateTimePickerInsurenceEnd";
            this.DateTimePickerInsurenceEnd.Size = new System.Drawing.Size(173, 22);
            this.DateTimePickerInsurenceEnd.TabIndex = 21;
            // 
            // DateTimePickerInsurenceStart
            // 
            this.DateTimePickerInsurenceStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerInsurenceStart.Location = new System.Drawing.Point(227, 39);
            this.DateTimePickerInsurenceStart.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePickerInsurenceStart.Name = "DateTimePickerInsurenceStart";
            this.DateTimePickerInsurenceStart.Size = new System.Drawing.Size(173, 22);
            this.DateTimePickerInsurenceStart.TabIndex = 20;
            this.DateTimePickerInsurenceStart.ValueChanged += new System.EventHandler(this.DateTimePickerInsurenceStart_ValueChanged);
            // 
            // TBInsurer
            // 
            this.TBInsurer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBInsurer.Location = new System.Drawing.Point(227, 4);
            this.TBInsurer.Margin = new System.Windows.Forms.Padding(4);
            this.TBInsurer.Name = "TBInsurer";
            this.TBInsurer.Size = new System.Drawing.Size(173, 22);
            this.TBInsurer.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "End date of insurence";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Insurer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Start date of insurence";
            // 
            // LabelWarning
            // 
            this.LabelWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.ForeColor = System.Drawing.Color.Red;
            this.LabelWarning.Location = new System.Drawing.Point(35, 155);
            this.LabelWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(0, 16);
            this.LabelWarning.TabIndex = 24;
            // 
            // BtnAddInsurence
            // 
            this.BtnAddInsurence.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAddInsurence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnAddInsurence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddInsurence.ForeColor = System.Drawing.Color.White;
            this.BtnAddInsurence.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.BtnAddInsurence.IconColor = System.Drawing.Color.White;
            this.BtnAddInsurence.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddInsurence.IconSize = 32;
            this.BtnAddInsurence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddInsurence.Location = new System.Drawing.Point(240, 178);
            this.BtnAddInsurence.Name = "BtnAddInsurence";
            this.BtnAddInsurence.Size = new System.Drawing.Size(163, 45);
            this.BtnAddInsurence.TabIndex = 30;
            this.BtnAddInsurence.Text = "Create";
            this.BtnAddInsurence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddInsurence.UseVisualStyleBackColor = false;
            this.BtnAddInsurence.Click += new System.EventHandler(this.BtnAddInsurence_Click_1);
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
            this.BtnBack.Location = new System.Drawing.Point(51, 178);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(145, 45);
            this.BtnBack.TabIndex = 31;
            this.BtnBack.Text = "Back";
            this.BtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // AddNewInsurenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 236);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnAddInsurence);
            this.Controls.Add(this.LabelWarning);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewInsurenceForm";
            this.Text = "AddOrEditInsurenceForm";
            this.Load += new System.EventHandler(this.AddOrEditInsurenceForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DateTimePicker DateTimePickerInsurenceEnd;
        public System.Windows.Forms.DateTimePicker DateTimePickerInsurenceStart;
        private System.Windows.Forms.TextBox TBInsurer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LabelWarning;
        private FontAwesome.Sharp.IconButton BtnAddInsurence;
        private FontAwesome.Sharp.IconButton BtnBack;
    }
}