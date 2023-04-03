namespace CarFleet.Views.EmployeeForms
{
    partial class EditEmployeeForm
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
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.TbFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEditEmplyee = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TbPhone = new System.Windows.Forms.TextBox();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CbBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ChBoxActive = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbPass = new System.Windows.Forms.TextBox();
            this.TbConfirmPass = new System.Windows.Forms.TextBox();
            this.Lbpass = new System.Windows.Forms.Label();
            this.LbConfirmPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.BtnBack.Location = new System.Drawing.Point(214, 437);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(145, 45);
            this.BtnBack.TabIndex = 19;
            this.BtnBack.Text = "Back";
            this.BtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // TbFirstName
            // 
            this.TbFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbFirstName.Location = new System.Drawing.Point(396, 171);
            this.TbFirstName.Name = "TbFirstName";
            this.TbFirstName.Size = new System.Drawing.Size(100, 22);
            this.TbFirstName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(273, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Last Name:";
            // 
            // TbLastName
            // 
            this.TbLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbLastName.Location = new System.Drawing.Point(396, 199);
            this.TbLastName.Name = "TbLastName";
            this.TbLastName.Size = new System.Drawing.Size(100, 22);
            this.TbLastName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(273, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "First Name:";
            // 
            // BtnEditEmplyee
            // 
            this.BtnEditEmplyee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditEmplyee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnEditEmplyee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditEmplyee.ForeColor = System.Drawing.Color.White;
            this.BtnEditEmplyee.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.BtnEditEmplyee.IconColor = System.Drawing.Color.White;
            this.BtnEditEmplyee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditEmplyee.IconSize = 32;
            this.BtnEditEmplyee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditEmplyee.Location = new System.Drawing.Point(396, 437);
            this.BtnEditEmplyee.Name = "BtnEditEmplyee";
            this.BtnEditEmplyee.Size = new System.Drawing.Size(145, 45);
            this.BtnEditEmplyee.TabIndex = 18;
            this.BtnEditEmplyee.Text = "Edit";
            this.BtnEditEmplyee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditEmplyee.UseVisualStyleBackColor = false;
            this.BtnEditEmplyee.Click += new System.EventHandler(this.BtnNewEmployee_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(236, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Phone Number:";
            // 
            // TbPhone
            // 
            this.TbPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbPhone.Location = new System.Drawing.Point(396, 227);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.Size = new System.Drawing.Size(100, 22);
            this.TbPhone.TabIndex = 12;
            // 
            // TbEmail
            // 
            this.TbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbEmail.Location = new System.Drawing.Point(396, 255);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(100, 22);
            this.TbEmail.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(315, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(315, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Role:";
            // 
            // CbBox
            // 
            this.CbBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbBox.FormattingEnabled = true;
            this.CbBox.Location = new System.Drawing.Point(396, 286);
            this.CbBox.Name = "CbBox";
            this.CbBox.Size = new System.Drawing.Size(100, 24);
            this.CbBox.TabIndex = 22;
            this.CbBox.SelectedIndexChanged += new System.EventHandler(this.CbBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(211, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // ChBoxActive
            // 
            this.ChBoxActive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChBoxActive.AutoSize = true;
            this.ChBoxActive.ForeColor = System.Drawing.Color.White;
            this.ChBoxActive.Location = new System.Drawing.Point(396, 317);
            this.ChBoxActive.Name = "ChBoxActive";
            this.ChBoxActive.Size = new System.Drawing.Size(79, 20);
            this.ChBoxActive.TabIndex = 24;
            this.ChBoxActive.Text = "Is Active";
            this.ChBoxActive.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Is Disabled:";
            // 
            // TbPass
            // 
            this.TbPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbPass.Location = new System.Drawing.Point(396, 343);
            this.TbPass.Name = "TbPass";
            this.TbPass.PasswordChar = '*';
            this.TbPass.Size = new System.Drawing.Size(100, 22);
            this.TbPass.TabIndex = 26;
            // 
            // TbConfirmPass
            // 
            this.TbConfirmPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbConfirmPass.Location = new System.Drawing.Point(396, 371);
            this.TbConfirmPass.Name = "TbConfirmPass";
            this.TbConfirmPass.PasswordChar = '*';
            this.TbConfirmPass.Size = new System.Drawing.Size(100, 22);
            this.TbConfirmPass.TabIndex = 27;
            // 
            // Lbpass
            // 
            this.Lbpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbpass.AutoSize = true;
            this.Lbpass.Location = new System.Drawing.Point(266, 343);
            this.Lbpass.Name = "Lbpass";
            this.Lbpass.Size = new System.Drawing.Size(70, 16);
            this.Lbpass.TabIndex = 28;
            this.Lbpass.Text = "Password:";
            // 
            // LbConfirmPass
            // 
            this.LbConfirmPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbConfirmPass.AutoSize = true;
            this.LbConfirmPass.Location = new System.Drawing.Point(221, 368);
            this.LbConfirmPass.Name = "LbConfirmPass";
            this.LbConfirmPass.Size = new System.Drawing.Size(118, 16);
            this.LbConfirmPass.TabIndex = 29;
            this.LbConfirmPass.Text = "Confirm Password:";
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.LbConfirmPass);
            this.Controls.Add(this.Lbpass);
            this.Controls.Add(this.TbConfirmPass);
            this.Controls.Add(this.TbPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ChBoxActive);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.TbFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEditEmplyee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbPhone);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditEmployeeForm";
            this.Text = "EditEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnBack;
        private System.Windows.Forms.TextBox TbFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbLastName;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnEditEmplyee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbPhone;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ChBoxActive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbPass;
        private System.Windows.Forms.TextBox TbConfirmPass;
        private System.Windows.Forms.Label Lbpass;
        private System.Windows.Forms.Label LbConfirmPass;
    }
}