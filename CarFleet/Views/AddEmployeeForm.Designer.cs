namespace CarFleet.Views
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
            this.TbLastName = new System.Windows.Forms.TextBox();
            this.TbPhone = new System.Windows.Forms.TextBox();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnNewEmplyee = new FontAwesome.Sharp.IconButton();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.leftpanel = new System.Windows.Forms.Panel();
            this.rightpanel = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbFirstName
            // 
            this.TbFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbFirstName.Location = new System.Drawing.Point(174, 142);
            this.TbFirstName.Name = "TbFirstName";
            this.TbFirstName.Size = new System.Drawing.Size(100, 22);
            this.TbFirstName.TabIndex = 0;
            // 
            // TbLastName
            // 
            this.TbLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbLastName.Location = new System.Drawing.Point(174, 170);
            this.TbLastName.Name = "TbLastName";
            this.TbLastName.Size = new System.Drawing.Size(100, 22);
            this.TbLastName.TabIndex = 1;
            // 
            // TbPhone
            // 
            this.TbPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbPhone.Location = new System.Drawing.Point(174, 198);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.Size = new System.Drawing.Size(100, 22);
            this.TbPhone.TabIndex = 2;
            // 
            // TbEmail
            // 
            this.TbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbEmail.Location = new System.Drawing.Point(174, 226);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(100, 22);
            this.TbEmail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(71, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(71, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(49, 204);
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
            this.label4.Location = new System.Drawing.Point(102, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // BtnNewEmplyee
            // 
            this.BtnNewEmplyee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNewEmplyee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnNewEmplyee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewEmplyee.ForeColor = System.Drawing.Color.White;
            this.BtnNewEmplyee.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.BtnNewEmplyee.IconColor = System.Drawing.Color.Black;
            this.BtnNewEmplyee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNewEmplyee.IconSize = 32;
            this.BtnNewEmplyee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewEmplyee.Location = new System.Drawing.Point(52, 270);
            this.BtnNewEmplyee.Name = "BtnNewEmplyee";
            this.BtnNewEmplyee.Size = new System.Drawing.Size(145, 45);
            this.BtnNewEmplyee.TabIndex = 8;
            this.BtnNewEmplyee.Text = "New Employee";
            this.BtnNewEmplyee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNewEmplyee.UseVisualStyleBackColor = false;
            this.BtnNewEmplyee.Click += new System.EventHandler(this.BtnNewEmplyee_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.BtnBack.IconColor = System.Drawing.Color.Black;
            this.BtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBack.IconSize = 32;
            this.BtnBack.Location = new System.Drawing.Point(203, 270);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(145, 45);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.Text = "Back";
            this.BtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // leftpanel
            // 
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(200, 450);
            this.leftpanel.TabIndex = 10;
            // 
            // rightpanel
            // 
            this.rightpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightpanel.Location = new System.Drawing.Point(600, 0);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(200, 450);
            this.rightpanel.TabIndex = 11;
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.BtnBack);
            this.mainpanel.Controls.Add(this.TbFirstName);
            this.mainpanel.Controls.Add(this.label2);
            this.mainpanel.Controls.Add(this.TbLastName);
            this.mainpanel.Controls.Add(this.label1);
            this.mainpanel.Controls.Add(this.BtnNewEmplyee);
            this.mainpanel.Controls.Add(this.label3);
            this.mainpanel.Controls.Add(this.TbPhone);
            this.mainpanel.Controls.Add(this.TbEmail);
            this.mainpanel.Controls.Add(this.label4);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(200, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(400, 450);
            this.mainpanel.TabIndex = 12;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.leftpanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TbFirstName;
        private System.Windows.Forms.TextBox TbLastName;
        private System.Windows.Forms.TextBox TbPhone;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton BtnNewEmplyee;
        private FontAwesome.Sharp.IconButton BtnBack;
        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.Panel rightpanel;
        private System.Windows.Forms.Panel mainpanel;
    }
}