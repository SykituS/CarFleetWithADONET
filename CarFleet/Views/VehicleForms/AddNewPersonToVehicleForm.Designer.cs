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
            this.BtnAddUserToVehicle = new FontAwesome.Sharp.IconButton();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.DataGridViewAddPersonToVehicle = new System.Windows.Forms.DataGridView();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAddPersonToVehicle)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelWarning
            // 
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.ForeColor = System.Drawing.Color.Red;
            this.LabelWarning.Location = new System.Drawing.Point(765, 391);
            this.LabelWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(0, 16);
            this.LabelWarning.TabIndex = 24;
            // 
            // BtnAddUserToVehicle
            // 
            this.BtnAddUserToVehicle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAddUserToVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnAddUserToVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddUserToVehicle.ForeColor = System.Drawing.Color.White;
            this.BtnAddUserToVehicle.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.BtnAddUserToVehicle.IconColor = System.Drawing.Color.White;
            this.BtnAddUserToVehicle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddUserToVehicle.IconSize = 32;
            this.BtnAddUserToVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddUserToVehicle.Location = new System.Drawing.Point(517, 304);
            this.BtnAddUserToVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddUserToVehicle.Name = "BtnAddUserToVehicle";
            this.BtnAddUserToVehicle.Size = new System.Drawing.Size(163, 46);
            this.BtnAddUserToVehicle.TabIndex = 28;
            this.BtnAddUserToVehicle.Text = "Add user";
            this.BtnAddUserToVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddUserToVehicle.UseVisualStyleBackColor = false;
            this.BtnAddUserToVehicle.Click += new System.EventHandler(this.BtnAddPersonToVehicle_Click);
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
            this.BtnBack.Location = new System.Drawing.Point(267, 304);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(145, 46);
            this.BtnBack.TabIndex = 29;
            this.BtnBack.Text = "Back";
            this.BtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DataGridViewAddPersonToVehicle
            // 
            this.DataGridViewAddPersonToVehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewAddPersonToVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAddPersonToVehicle.Location = new System.Drawing.Point(5, 70);
            this.DataGridViewAddPersonToVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridViewAddPersonToVehicle.MultiSelect = false;
            this.DataGridViewAddPersonToVehicle.Name = "DataGridViewAddPersonToVehicle";
            this.DataGridViewAddPersonToVehicle.ReadOnly = true;
            this.DataGridViewAddPersonToVehicle.RowHeadersWidth = 51;
            this.DataGridViewAddPersonToVehicle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewAddPersonToVehicle.Size = new System.Drawing.Size(937, 185);
            this.DataGridViewAddPersonToVehicle.TabIndex = 30;
            // 
            // TbSearch
            // 
            this.TbSearch.Location = new System.Drawing.Point(347, 26);
            this.TbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(489, 22);
            this.TbSearch.TabIndex = 31;
            this.TbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Search employee:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnBack);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnAddUserToVehicle);
            this.panel1.Controls.Add(this.TbSearch);
            this.panel1.Controls.Add(this.DataGridViewAddPersonToVehicle);
            this.panel1.Location = new System.Drawing.Point(64, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 375);
            this.panel1.TabIndex = 33;
            // 
            // AddNewPersonToVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelWarning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddNewPersonToVehicleForm";
            this.Text = "AddNewPersonToVehicleForm";
            this.Load += new System.EventHandler(this.AddNewPersonToVehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAddPersonToVehicle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelWarning;
        private FontAwesome.Sharp.IconButton BtnAddUserToVehicle;
        private FontAwesome.Sharp.IconButton BtnBack;
        private System.Windows.Forms.DataGridView DataGridViewAddPersonToVehicle;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}