namespace CarFleet.Views
{
    partial class LoginForm
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
            this.tBLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEmployeeList = new FontAwesome.Sharp.IconButton();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // tBLogin
            // 
            this.tBLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tBLogin.Location = new System.Drawing.Point(173, 69);
            this.tBLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBLogin.Name = "tBLogin";
            this.tBLogin.Size = new System.Drawing.Size(132, 30);
            this.tBLogin.TabIndex = 0;
            this.tBLogin.TextChanged += new System.EventHandler(this.tBLogin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(101, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(63, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnEmployeeList
            // 
            this.btnEmployeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnEmployeeList.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeList.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btnEmployeeList.IconColor = System.Drawing.Color.White;
            this.btnEmployeeList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmployeeList.IconSize = 32;
            this.btnEmployeeList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeList.Location = new System.Drawing.Point(106, 181);
            this.btnEmployeeList.Name = "btnEmployeeList";
            this.btnEmployeeList.Size = new System.Drawing.Size(199, 53);
            this.btnEmployeeList.TabIndex = 6;
            this.btnEmployeeList.Text = "LOGIN";
            this.btnEmployeeList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeeList.UseVisualStyleBackColor = false;
            // 
            // tBPassword
            // 
            this.tBPassword.BackColor = System.Drawing.Color.White;
            this.tBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tBPassword.Location = new System.Drawing.Point(173, 121);
            this.tBPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.PasswordChar = '*';
            this.tBPassword.Size = new System.Drawing.Size(132, 30);
            this.tBPassword.TabIndex = 1;
            this.tBPassword.TextChanged += new System.EventHandler(this.tBPassword_TextChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButton1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(326, -5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(50, 34);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 267);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnEmployeeList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBPassword);
            this.Controls.Add(this.tBLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnEmployeeList;
        private System.Windows.Forms.TextBox tBPassword;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

