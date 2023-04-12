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
            this.LabelWarning = new System.Windows.Forms.Label();
            this.BtnAddOrEditDescritpion = new FontAwesome.Sharp.IconButton();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.RichTextBoxDescription);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(16, 15);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 176);
            this.panel4.TabIndex = 20;
            // 
            // RichTextBoxDescription
            // 
            this.RichTextBoxDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RichTextBoxDescription.Location = new System.Drawing.Point(0, 21);
            this.RichTextBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.RichTextBoxDescription.Name = "RichTextBoxDescription";
            this.RichTextBoxDescription.Size = new System.Drawing.Size(388, 155);
            this.RichTextBoxDescription.TabIndex = 15;
            this.RichTextBoxDescription.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(264, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Additional information: (max 500 characters)";
            // 
            // LabelWarning
            // 
            this.LabelWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.ForeColor = System.Drawing.Color.Red;
            this.LabelWarning.Location = new System.Drawing.Point(48, 194);
            this.LabelWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(0, 16);
            this.LabelWarning.TabIndex = 23;
            // 
            // BtnAddOrEditDescritpion
            // 
            this.BtnAddOrEditDescritpion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAddOrEditDescritpion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnAddOrEditDescritpion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddOrEditDescritpion.ForeColor = System.Drawing.Color.White;
            this.BtnAddOrEditDescritpion.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.BtnAddOrEditDescritpion.IconColor = System.Drawing.Color.White;
            this.BtnAddOrEditDescritpion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddOrEditDescritpion.IconSize = 32;
            this.BtnAddOrEditDescritpion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddOrEditDescritpion.Location = new System.Drawing.Point(226, 213);
            this.BtnAddOrEditDescritpion.Name = "BtnAddOrEditDescritpion";
            this.BtnAddOrEditDescritpion.Size = new System.Drawing.Size(163, 45);
            this.BtnAddOrEditDescritpion.TabIndex = 29;
            this.BtnAddOrEditDescritpion.Text = "Create";
            this.BtnAddOrEditDescritpion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddOrEditDescritpion.UseVisualStyleBackColor = false;
            this.BtnAddOrEditDescritpion.Click += new System.EventHandler(this.BtnAddOrEditDescription_Click);
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
            this.BtnBack.Location = new System.Drawing.Point(51, 213);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(145, 45);
            this.BtnBack.TabIndex = 30;
            this.BtnBack.Text = "Back";
            this.BtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // AddOrEditDescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 266);
            this.Controls.Add(this.BtnAddOrEditDescritpion);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LabelWarning);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label LabelWarning;
        private FontAwesome.Sharp.IconButton BtnAddOrEditDescritpion;
        private FontAwesome.Sharp.IconButton BtnBack;
    }
}