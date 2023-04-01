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
            this.CBoxVehicleStatus = new System.Windows.Forms.ComboBox();
            this.BtnAddInspection = new FontAwesome.Sharp.IconButton();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBoxVehicleStatus
            // 
            this.CBoxVehicleStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBoxVehicleStatus.FormattingEnabled = true;
            this.CBoxVehicleStatus.Location = new System.Drawing.Point(87, 45);
            this.CBoxVehicleStatus.Name = "CBoxVehicleStatus";
            this.CBoxVehicleStatus.Size = new System.Drawing.Size(147, 21);
            this.CBoxVehicleStatus.TabIndex = 4;
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
            this.BtnAddInspection.Location = new System.Drawing.Point(164, 121);
            this.BtnAddInspection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAddInspection.Name = "BtnAddInspection";
            this.BtnAddInspection.Size = new System.Drawing.Size(122, 37);
            this.BtnAddInspection.TabIndex = 31;
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
            this.BtnBack.Location = new System.Drawing.Point(39, 121);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(109, 37);
            this.BtnBack.TabIndex = 32;
            this.BtnBack.Text = "Back";
            this.BtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LabelWarning
            // 
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.ForeColor = System.Drawing.Color.Red;
            this.LabelWarning.Location = new System.Drawing.Point(50, 87);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(73, 13);
            this.LabelWarning.TabIndex = 33;
            this.LabelWarning.Text = "LabelWarning";
            // 
            // ChangeVehicleStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 180);
            this.Controls.Add(this.LabelWarning);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnAddInspection);
            this.Controls.Add(this.CBoxVehicleStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeVehicleStatusForm";
            this.Text = "ChangeVehicleStatusForm";
            this.Load += new System.EventHandler(this.ChangeVehicleStatusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CBoxVehicleStatus;
        private FontAwesome.Sharp.IconButton BtnAddInspection;
        private FontAwesome.Sharp.IconButton BtnBack;
        private System.Windows.Forms.Label LabelWarning;
    }
}