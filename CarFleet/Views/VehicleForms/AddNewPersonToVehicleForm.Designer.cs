namespace CarFleet.Views.VehicleForms
{
    partial class AddNewPersonToVehicleForm
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
            this.LabelWarning = new System.Windows.Forms.Label();
            this.BtnAddInspection = new FontAwesome.Sharp.IconButton();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelWarning
            // 
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.ForeColor = System.Drawing.Color.Red;
            this.LabelWarning.Location = new System.Drawing.Point(558, 330);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(73, 13);
            this.LabelWarning.TabIndex = 24;
            this.LabelWarning.Text = "LabelWarning";
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
            this.BtnAddInspection.Location = new System.Drawing.Point(342, 306);
            this.BtnAddInspection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAddInspection.Name = "BtnAddInspection";
            this.BtnAddInspection.Size = new System.Drawing.Size(122, 37);
            this.BtnAddInspection.TabIndex = 28;
            this.BtnAddInspection.Text = "Create";
            this.BtnAddInspection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddInspection.UseVisualStyleBackColor = false;
            this.BtnAddInspection.Click += new System.EventHandler(this.BtnAddInspection_Click);
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
            this.BtnBack.Location = new System.Drawing.Point(218, 306);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(109, 37);
            this.BtnBack.TabIndex = 29;
            this.BtnBack.Text = "Back";
            this.BtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(108, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 150);
            this.dataGridView1.TabIndex = 30;
            // 
            // AddNewPersonToVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnAddInspection);
            this.Controls.Add(this.LabelWarning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewPersonToVehicleForm";
            this.Text = "AddNewPersonToVehicleForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelWarning;
        private FontAwesome.Sharp.IconButton BtnAddInspection;
        private FontAwesome.Sharp.IconButton BtnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}