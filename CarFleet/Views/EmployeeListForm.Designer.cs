﻿namespace CarFleet.Views
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
            this.BtnEditEmployee = new FontAwesome.Sharp.IconButton();
            this.BtnDeleteEmployee = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEmployeeList)).BeginInit();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewEmployeeList
            // 
            this.DataGridViewEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewEmployeeList.Location = new System.Drawing.Point(46, 50);
            this.DataGridViewEmployeeList.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridViewEmployeeList.Name = "DataGridViewEmployeeList";
            this.DataGridViewEmployeeList.RowHeadersWidth = 51;
            this.DataGridViewEmployeeList.Size = new System.Drawing.Size(697, 454);
            this.DataGridViewEmployeeList.TabIndex = 6;
            // 
            // BtnAddEmployee
            // 
            this.BtnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.BtnAddEmployee.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.BtnAddEmployee.IconColor = System.Drawing.Color.Black;
            this.BtnAddEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddEmployee.IconSize = 32;
            this.BtnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddEmployee.Location = new System.Drawing.Point(776, 62);
            this.BtnAddEmployee.Name = "BtnAddEmployee";
            this.BtnAddEmployee.Size = new System.Drawing.Size(244, 53);
            this.BtnAddEmployee.TabIndex = 7;
            this.BtnAddEmployee.Text = "NEW EMPLOYEE";
            this.BtnAddEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddEmployee.UseVisualStyleBackColor = false;
            this.BtnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click_1);
            // 
            // BtnEditEmployee
            // 
            this.BtnEditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditEmployee.ForeColor = System.Drawing.Color.White;
            this.BtnEditEmployee.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.BtnEditEmployee.IconColor = System.Drawing.Color.Black;
            this.BtnEditEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditEmployee.IconSize = 32;
            this.BtnEditEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditEmployee.Location = new System.Drawing.Point(776, 121);
            this.BtnEditEmployee.Name = "BtnEditEmployee";
            this.BtnEditEmployee.Size = new System.Drawing.Size(244, 53);
            this.BtnEditEmployee.TabIndex = 8;
            this.BtnEditEmployee.Text = "UPDATE EMPLOYEE";
            this.BtnEditEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditEmployee.UseVisualStyleBackColor = false;
            this.BtnEditEmployee.Click += new System.EventHandler(this.BtnEditEmployee_Click);
            // 
            // BtnDeleteEmployee
            // 
            this.BtnDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteEmployee.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.BtnDeleteEmployee.IconColor = System.Drawing.Color.Black;
            this.BtnDeleteEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDeleteEmployee.IconSize = 32;
            this.BtnDeleteEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeleteEmployee.Location = new System.Drawing.Point(776, 180);
            this.BtnDeleteEmployee.Name = "BtnDeleteEmployee";
            this.BtnDeleteEmployee.Size = new System.Drawing.Size(244, 53);
            this.BtnDeleteEmployee.TabIndex = 9;
            this.BtnDeleteEmployee.Text = "DELETE EMPLOYEE";
            this.BtnDeleteEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDeleteEmployee.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(798, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.label1);
            this.mainpanel.Controls.Add(this.BtnDeleteEmployee);
            this.mainpanel.Controls.Add(this.BtnEditEmployee);
            this.mainpanel.Controls.Add(this.BtnAddEmployee);
            this.mainpanel.Controls.Add(this.DataGridViewEmployeeList);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1067, 554);
            this.mainpanel.TabIndex = 6;
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeListForm";
            this.Text = "EmployeeListForm";
            this.Load += new System.EventHandler(this.EmployeeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEmployeeList)).EndInit();
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewEmployeeList;
        private FontAwesome.Sharp.IconButton BtnAddEmployee;
        private FontAwesome.Sharp.IconButton BtnEditEmployee;
        private FontAwesome.Sharp.IconButton BtnDeleteEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainpanel;
    }
}