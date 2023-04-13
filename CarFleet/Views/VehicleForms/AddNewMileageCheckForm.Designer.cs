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
            this.LabelWarning = new System.Windows.Forms.Label();
            this.BtnResetTextBox = new FontAwesome.Sharp.IconButton();
            this.BtnAddInspection = new FontAwesome.Sharp.IconButton();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDMileage)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericUDMileage
            // 
            this.NumericUDMileage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumericUDMileage.Location = new System.Drawing.Point(135, 20);
            this.NumericUDMileage.Margin = new System.Windows.Forms.Padding(4);
            this.NumericUDMileage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NumericUDMileage.Name = "NumericUDMileage";
            this.NumericUDMileage.Size = new System.Drawing.Size(160, 22);
            this.NumericUDMileage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mileage";
            // 
            // LabelWarning
            // 
            this.LabelWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.ForeColor = System.Drawing.Color.Red;
            this.LabelWarning.Location = new System.Drawing.Point(59, 69);
            this.LabelWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(0, 16);
            this.LabelWarning.TabIndex = 4;
            // 
            // BtnResetTextBox
            // 
            this.BtnResetTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnResetTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnResetTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetTextBox.ForeColor = System.Drawing.Color.White;
            this.BtnResetTextBox.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.BtnResetTextBox.IconColor = System.Drawing.Color.White;
            this.BtnResetTextBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnResetTextBox.IconSize = 20;
            this.BtnResetTextBox.Location = new System.Drawing.Point(302, 14);
            this.BtnResetTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnResetTextBox.Name = "BtnResetTextBox";
            this.BtnResetTextBox.Size = new System.Drawing.Size(107, 36);
            this.BtnResetTextBox.TabIndex = 5;
            this.BtnResetTextBox.Text = "Reset";
            this.BtnResetTextBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnResetTextBox.UseVisualStyleBackColor = false;
            this.BtnResetTextBox.Click += new System.EventHandler(this.BtnResetTextBox_Click);
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
            this.BtnAddInspection.Location = new System.Drawing.Point(234, 124);
            this.BtnAddInspection.Name = "BtnAddInspection";
            this.BtnAddInspection.Size = new System.Drawing.Size(163, 45);
            this.BtnAddInspection.TabIndex = 27;
            this.BtnAddInspection.Text = "Create";
            this.BtnAddInspection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddInspection.UseVisualStyleBackColor = false;
            this.BtnAddInspection.Click += new System.EventHandler(this.BtnAddInspection_Click_1);
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
            this.BtnBack.Location = new System.Drawing.Point(62, 124);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(145, 45);
            this.BtnBack.TabIndex = 28;
            this.BtnBack.Text = "Back";
            this.BtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // AddNewMileageCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 181);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnAddInspection);
            this.Controls.Add(this.BtnResetTextBox);
            this.Controls.Add(this.LabelWarning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericUDMileage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label LabelWarning;
        private FontAwesome.Sharp.IconButton BtnResetTextBox;
        private FontAwesome.Sharp.IconButton BtnAddInspection;
        private FontAwesome.Sharp.IconButton BtnBack;
    }
}