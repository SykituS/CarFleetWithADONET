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
            this.SuspendLayout();
            // 
            // CBoxVehicleStatus
            // 
            this.CBoxVehicleStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBoxVehicleStatus.FormattingEnabled = true;
            this.CBoxVehicleStatus.Location = new System.Drawing.Point(116, 55);
            this.CBoxVehicleStatus.Margin = new System.Windows.Forms.Padding(4);
            this.CBoxVehicleStatus.Name = "CBoxVehicleStatus";
            this.CBoxVehicleStatus.Size = new System.Drawing.Size(195, 24);
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
            this.BtnAddInspection.Location = new System.Drawing.Point(218, 149);
            this.BtnAddInspection.Name = "BtnAddInspection";
            this.BtnAddInspection.Size = new System.Drawing.Size(163, 45);
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
            this.BtnBack.Location = new System.Drawing.Point(52, 149);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(145, 45);
            this.BtnBack.TabIndex = 32;
            this.BtnBack.Text = "Back";
            this.BtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // ChangeVehicleStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 222);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnAddInspection);
            this.Controls.Add(this.CBoxVehicleStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangeVehicleStatusForm";
            this.Text = "ChangeVehicleStatusForm";
            this.Load += new System.EventHandler(this.ChangeVehicleStatusForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox CBoxVehicleStatus;
        private FontAwesome.Sharp.IconButton BtnAddInspection;
        private FontAwesome.Sharp.IconButton BtnBack;
    }
}