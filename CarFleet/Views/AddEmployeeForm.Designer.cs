﻿namespace CarFleet.Views
{
    partial class AddEmployeeForm
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
            this.TbFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnNewEmplyee = new FontAwesome.Sharp.IconButton();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbPhone = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbFirstName
            // 
            this.TbFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbFirstName.Location = new System.Drawing.Point(412, 136);
            this.TbFirstName.Name = "TbFirstName";
            this.TbFirstName.Size = new System.Drawing.Size(100, 22);
            this.TbFirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(303, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name:";
            // 
            // TbLastName
            // 
            this.TbLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbLastName.Location = new System.Drawing.Point(412, 164);
            this.TbLastName.Name = "TbLastName";
            this.TbLastName.Size = new System.Drawing.Size(100, 22);
            this.TbLastName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(303, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BtnNewEmplyee);
            this.panel1.Controls.Add(this.TbFirstName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnBack);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TbLastName);
            this.panel1.Controls.Add(this.TbEmail);
            this.panel1.Controls.Add(this.TbPhone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(266, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email:";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "LblMessage";
            // 
            // BtnNewEmplyee
            // 
            this.BtnNewEmplyee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNewEmplyee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnNewEmplyee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewEmplyee.ForeColor = System.Drawing.Color.White;
            this.BtnNewEmplyee.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.BtnNewEmplyee.IconColor = System.Drawing.Color.White;
            this.BtnNewEmplyee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNewEmplyee.IconSize = 32;
            this.BtnNewEmplyee.Location = new System.Drawing.Point(412, 248);
            this.BtnNewEmplyee.Name = "BtnNewEmplyee";
            this.BtnNewEmplyee.Size = new System.Drawing.Size(202, 45);
            this.BtnNewEmplyee.TabIndex = 11;
            this.BtnNewEmplyee.Text = "New Employee";
            this.BtnNewEmplyee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNewEmplyee.UseVisualStyleBackColor = false;
            this.BtnNewEmplyee.Click += new System.EventHandler(this.BtnNewEmplyee_Click_1);
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
            this.BtnBack.Location = new System.Drawing.Point(261, 248);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(145, 45);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.Text = "Back";
            this.BtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(266, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(347, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // TbEmail
            // 
            this.TbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbEmail.Location = new System.Drawing.Point(412, 220);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(100, 22);
            this.TbEmail.TabIndex = 3;
            // 
            // TbPhone
            // 
            this.TbPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbPhone.Location = new System.Drawing.Point(412, 192);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.Size = new System.Drawing.Size(100, 22);
            this.TbPhone.TabIndex = 2;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnNewEmplyee;
        private FontAwesome.Sharp.IconButton BtnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TbPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}