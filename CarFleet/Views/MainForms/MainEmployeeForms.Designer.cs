namespace CarFleet.Views.MainForms
{
    partial class MainEmployeeForms
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
            this.menupanel = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.BtnCarHistory = new FontAwesome.Sharp.IconButton();
            this.BtnEmployeeList = new FontAwesome.Sharp.IconButton();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.BtnSize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.menupanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.headerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.menupanel.Controls.Add(this.iconPictureBox1);
            this.menupanel.Controls.Add(this.BtnCarHistory);
            this.menupanel.Controls.Add(this.BtnEmployeeList);
            this.menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menupanel.Location = new System.Drawing.Point(0, 0);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(244, 560);
            this.menupanel.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyUser;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 172;
            this.iconPictureBox1.Location = new System.Drawing.Point(34, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(172, 193);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // BtnCarHistory
            // 
            this.BtnCarHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnCarHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarHistory.ForeColor = System.Drawing.Color.White;
            this.BtnCarHistory.IconChar = FontAwesome.Sharp.IconChar.CarAlt;
            this.BtnCarHistory.IconColor = System.Drawing.Color.Black;
            this.BtnCarHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCarHistory.IconSize = 32;
            this.BtnCarHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCarHistory.Location = new System.Drawing.Point(3, 230);
            this.BtnCarHistory.Name = "BtnCarHistory";
            this.BtnCarHistory.Size = new System.Drawing.Size(244, 53);
            this.BtnCarHistory.TabIndex = 2;
            this.BtnCarHistory.Text = "CAR HISTORY";
            this.BtnCarHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCarHistory.UseVisualStyleBackColor = false;
            this.BtnCarHistory.Click += new System.EventHandler(this.btnCarList_Click);
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
            this.BtnEmployeeList.Location = new System.Drawing.Point(3, 289);
            this.BtnEmployeeList.Name = "BtnEmployeeList";
            this.BtnEmployeeList.Size = new System.Drawing.Size(244, 53);
            this.BtnEmployeeList.TabIndex = 1;
            this.BtnEmployeeList.Text = "EMPLOYEE LIST";
            this.BtnEmployeeList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEmployeeList.UseVisualStyleBackColor = false;
            this.BtnEmployeeList.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.headerpanel.Controls.Add(this.BtnMinimize);
            this.headerpanel.Controls.Add(this.BtnSize);
            this.headerpanel.Controls.Add(this.btnClose);
            this.headerpanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(244, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(893, 29);
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
            this.BtnMinimize.Location = new System.Drawing.Point(764, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(39, 29);
            this.BtnMinimize.TabIndex = 8;
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnSize
            // 
            this.BtnSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BtnSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSize.ForeColor = System.Drawing.Color.White;
            this.BtnSize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnSize.IconColor = System.Drawing.Color.White;
            this.BtnSize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSize.IconSize = 32;
            this.BtnSize.Location = new System.Drawing.Point(809, 0);
            this.BtnSize.Name = "BtnSize";
            this.BtnSize.Size = new System.Drawing.Size(39, 29);
            this.BtnSize.TabIndex = 7;
            this.BtnSize.UseVisualStyleBackColor = false;
            this.BtnSize.Click += new System.EventHandler(this.BtnSize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 32;
            this.btnClose.Location = new System.Drawing.Point(854, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(244, 29);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(893, 531);
            this.mainpanel.TabIndex = 2;
            // 
            // MainEmployeeForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1137, 560);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.menupanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainEmployeeForms";
            this.Text = "MainForms";
            this.menupanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.headerpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Panel mainpanel;
        private FontAwesome.Sharp.IconButton BtnEmployeeList;
        private FontAwesome.Sharp.IconButton BtnCarHistory;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton BtnSize;
        private FontAwesome.Sharp.IconButton BtnMinimize;
    }
}