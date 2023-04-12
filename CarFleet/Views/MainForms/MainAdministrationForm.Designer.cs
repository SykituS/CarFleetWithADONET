namespace CarFleet.Views.MainForms
{
    partial class MainAdministrationForm
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
            this.mainpanel = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.BtnSize = new FontAwesome.Sharp.IconButton();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.BtnEmployeeList = new FontAwesome.Sharp.IconButton();
            this.BtnCarList = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.menupanel = new System.Windows.Forms.Panel();
            this.headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.menupanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(243, 30);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1617, 667);
            this.mainpanel.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 32;
            this.btnClose.Location = new System.Drawing.Point(1576, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BtnSize
            // 
            this.BtnSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSize.ForeColor = System.Drawing.Color.White;
            this.BtnSize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnSize.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSize.IconSize = 32;
            this.BtnSize.Location = new System.Drawing.Point(1532, 0);
            this.BtnSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSize.Name = "BtnSize";
            this.BtnSize.Size = new System.Drawing.Size(39, 30);
            this.BtnSize.TabIndex = 6;
            this.BtnSize.UseVisualStyleBackColor = false;
            this.BtnSize.Click += new System.EventHandler(this.BtnSize_Click);
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.headerpanel.Controls.Add(this.BtnMinimize);
            this.headerpanel.Controls.Add(this.BtnSize);
            this.headerpanel.Controls.Add(this.btnClose);
            this.headerpanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(243, 0);
            this.headerpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(1617, 30);
            this.headerpanel.TabIndex = 1;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.ForeColor = System.Drawing.Color.White;
            this.BtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimize.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimize.IconSize = 32;
            this.BtnMinimize.Location = new System.Drawing.Point(1495, 0);
            this.BtnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(32, 30);
            this.BtnMinimize.TabIndex = 7;
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnEmployeeList
            // 
            this.BtnEmployeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnEmployeeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmployeeList.ForeColor = System.Drawing.Color.White;
            this.BtnEmployeeList.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.BtnEmployeeList.IconColor = System.Drawing.Color.Black;
            this.BtnEmployeeList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEmployeeList.IconSize = 32;
            this.BtnEmployeeList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmployeeList.Location = new System.Drawing.Point(0, 230);
            this.BtnEmployeeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEmployeeList.Name = "BtnEmployeeList";
            this.BtnEmployeeList.Size = new System.Drawing.Size(244, 53);
            this.BtnEmployeeList.TabIndex = 1;
            this.BtnEmployeeList.Text = "EMPLOYEE LIST";
            this.BtnEmployeeList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEmployeeList.UseVisualStyleBackColor = false;
            this.BtnEmployeeList.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // BtnCarList
            // 
            this.BtnCarList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnCarList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarList.ForeColor = System.Drawing.Color.White;
            this.BtnCarList.IconChar = FontAwesome.Sharp.IconChar.CarAlt;
            this.BtnCarList.IconColor = System.Drawing.Color.Black;
            this.BtnCarList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCarList.IconSize = 32;
            this.BtnCarList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCarList.Location = new System.Drawing.Point(0, 289);
            this.BtnCarList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCarList.Name = "BtnCarList";
            this.BtnCarList.Size = new System.Drawing.Size(244, 53);
            this.BtnCarList.TabIndex = 2;
            this.BtnCarList.Text = "CAR LIST";
            this.BtnCarList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCarList.UseVisualStyleBackColor = false;
            this.BtnCarList.Click += new System.EventHandler(this.btnCarList_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyUser;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 172;
            this.iconPictureBox1.Location = new System.Drawing.Point(35, 12);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(172, 193);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.menupanel.Controls.Add(this.iconPictureBox1);
            this.menupanel.Controls.Add(this.BtnCarList);
            this.menupanel.Controls.Add(this.BtnEmployeeList);
            this.menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menupanel.Location = new System.Drawing.Point(0, 0);
            this.menupanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(243, 697);
            this.menupanel.TabIndex = 0;
            // 
            // MainAdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1860, 697);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.menupanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainAdministrationForm";
            this.Text = "MainForms";
            this.headerpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.menupanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton BtnSize;
        private System.Windows.Forms.Panel headerpanel;
        private FontAwesome.Sharp.IconButton BtnEmployeeList;
        private FontAwesome.Sharp.IconButton BtnCarList;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel menupanel;
        private FontAwesome.Sharp.IconButton BtnMinimize;
    }
}