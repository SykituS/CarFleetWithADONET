namespace CarFleet.Views.EmployeeForms
{
    partial class EmployeeListForm
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
            this.DataGridViewEmployeeList = new System.Windows.Forms.DataGridView();
            this.BtnAddEmployee = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.menupanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.panelmain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEmployeeList)).BeginInit();
            this.mainpanel.SuspendLayout();
            this.menupanel.SuspendLayout();
            this.panelmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewEmployeeList
            // 
            this.DataGridViewEmployeeList.AllowUserToAddRows = false;
            this.DataGridViewEmployeeList.AllowUserToDeleteRows = false;
            this.DataGridViewEmployeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewEmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewEmployeeList.Location = new System.Drawing.Point(27, 48);
            this.DataGridViewEmployeeList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridViewEmployeeList.MultiSelect = false;
            this.DataGridViewEmployeeList.Name = "DataGridViewEmployeeList";
            this.DataGridViewEmployeeList.ReadOnly = true;
            this.DataGridViewEmployeeList.RowHeadersWidth = 51;
            this.DataGridViewEmployeeList.Size = new System.Drawing.Size(743, 494);
            this.DataGridViewEmployeeList.TabIndex = 6;
            this.DataGridViewEmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewEmployeeList_CellContentClick_1);
            // 
            // BtnAddEmployee
            // 
            this.BtnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.BtnAddEmployee.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.BtnAddEmployee.IconColor = System.Drawing.Color.Black;
            this.BtnAddEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddEmployee.IconSize = 32;
            this.BtnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddEmployee.Location = new System.Drawing.Point(5, 103);
            this.BtnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddEmployee.Name = "BtnAddEmployee";
            this.BtnAddEmployee.Size = new System.Drawing.Size(244, 53);
            this.BtnAddEmployee.TabIndex = 7;
            this.BtnAddEmployee.Text = "NEW EMPLOYEE";
            this.BtnAddEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddEmployee.UseVisualStyleBackColor = false;
            this.BtnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(797, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "123";
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.menupanel);
            this.mainpanel.Controls.Add(this.panelmain);
            this.mainpanel.Controls.Add(this.label1);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1067, 554);
            this.mainpanel.TabIndex = 6;
            // 
            // menupanel
            // 
            this.menupanel.Controls.Add(this.label3);
            this.menupanel.Controls.Add(this.label2);
            this.menupanel.Controls.Add(this.TbSearch);
            this.menupanel.Controls.Add(this.BtnAddEmployee);
            this.menupanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.menupanel.Location = new System.Drawing.Point(815, 0);
            this.menupanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(252, 554);
            this.menupanel.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search employee:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(5, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // TbSearch
            // 
            this.TbSearch.Location = new System.Drawing.Point(5, 207);
            this.TbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(244, 22);
            this.TbSearch.TabIndex = 9;
            this.TbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // panelmain
            // 
            this.panelmain.Controls.Add(this.DataGridViewEmployeeList);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(0, 0);
            this.panelmain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1067, 554);
            this.panelmain.TabIndex = 11;
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeeListForm";
            this.Text = "EmployeeListForm";
            this.Load += new System.EventHandler(this.EmployeeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEmployeeList)).EndInit();
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.menupanel.ResumeLayout(false);
            this.menupanel.PerformLayout();
            this.panelmain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewEmployeeList;
        private FontAwesome.Sharp.IconButton BtnAddEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}