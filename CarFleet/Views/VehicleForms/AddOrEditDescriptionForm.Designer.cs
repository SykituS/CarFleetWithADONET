namespace CarFleet.Views.VehicleForms
{
    partial class AddOrEditDescriptionForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.RichTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAddOrEditDescritpion = new System.Windows.Forms.Button();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.RichTextBoxDescription);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 143);
            this.panel4.TabIndex = 20;
            // 
            // RichTextBoxDescription
            // 
            this.RichTextBoxDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RichTextBoxDescription.Location = new System.Drawing.Point(0, 16);
            this.RichTextBoxDescription.Name = "RichTextBoxDescription";
            this.RichTextBoxDescription.Size = new System.Drawing.Size(291, 127);
            this.RichTextBoxDescription.TabIndex = 15;
            this.RichTextBoxDescription.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(212, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Additional information: (max 500 characters)";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(50, 177);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 22;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnAddOrEditDescritpion
            // 
            this.BtnAddOrEditDescritpion.Location = new System.Drawing.Point(174, 177);
            this.BtnAddOrEditDescritpion.Name = "BtnAddOrEditDescritpion";
            this.BtnAddOrEditDescritpion.Size = new System.Drawing.Size(75, 23);
            this.BtnAddOrEditDescritpion.TabIndex = 21;
            this.BtnAddOrEditDescritpion.Text = "Create";
            this.BtnAddOrEditDescritpion.UseVisualStyleBackColor = true;
            this.BtnAddOrEditDescritpion.Click += new System.EventHandler(this.BtnAddOrEditDescription_Click);
            // 
            // LabelWarning
            // 
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.ForeColor = System.Drawing.Color.Red;
            this.LabelWarning.Location = new System.Drawing.Point(36, 158);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(73, 13);
            this.LabelWarning.TabIndex = 23;
            this.LabelWarning.Text = "LabelWarning";
            // 
            // AddOrEditDescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 203);
            this.Controls.Add(this.LabelWarning);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAddOrEditDescritpion);
            this.Controls.Add(this.panel4);
            this.Name = "AddOrEditDescriptionForm";
            this.Text = "AddOrEditDescriptionForm";
            this.Load += new System.EventHandler(this.AddOrEditDescriptionForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.RichTextBox RichTextBoxDescription;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAddOrEditDescritpion;
        private System.Windows.Forms.Label LabelWarning;
    }
}