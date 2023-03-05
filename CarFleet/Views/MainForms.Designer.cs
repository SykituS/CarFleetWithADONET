namespace CarFleet.Views
{
    partial class MainForms
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
            this.btnCarList = new FontAwesome.Sharp.IconButton();
            this.btnEmployeeList = new FontAwesome.Sharp.IconButton();
            this.headerpanel = new System.Windows.Forms.Panel();
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
            this.menupanel.Controls.Add(this.btnCarList);
            this.menupanel.Controls.Add(this.btnEmployeeList);
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
            // btnCarList
            // 
            this.btnCarList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnCarList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarList.ForeColor = System.Drawing.Color.White;
            this.btnCarList.IconChar = FontAwesome.Sharp.IconChar.CarAlt;
            this.btnCarList.IconColor = System.Drawing.Color.Black;
            this.btnCarList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCarList.IconSize = 32;
            this.btnCarList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarList.Location = new System.Drawing.Point(0, 289);
            this.btnCarList.Name = "btnCarList";
            this.btnCarList.Size = new System.Drawing.Size(244, 53);
            this.btnCarList.TabIndex = 2;
            this.btnCarList.Text = "CAR LIST";
            this.btnCarList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCarList.UseVisualStyleBackColor = false;
            this.btnCarList.Click += new System.EventHandler(this.btnCarList_Click);
            // 
            // btnEmployeeList
            // 
            this.btnEmployeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnEmployeeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeList.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeList.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnEmployeeList.IconColor = System.Drawing.Color.Black;
            this.btnEmployeeList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmployeeList.IconSize = 32;
            this.btnEmployeeList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeList.Location = new System.Drawing.Point(0, 230);
            this.btnEmployeeList.Name = "btnEmployeeList";
            this.btnEmployeeList.Size = new System.Drawing.Size(244, 53);
            this.btnEmployeeList.TabIndex = 1;
            this.btnEmployeeList.Text = "EMPLOYEE LIST";
            this.btnEmployeeList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeeList.UseVisualStyleBackColor = false;
            this.btnEmployeeList.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.headerpanel.Controls.Add(this.btnClose);
            this.headerpanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(244, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(893, 29);
            this.headerpanel.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // MainForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1137, 560);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.menupanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForms";
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
        private FontAwesome.Sharp.IconButton btnEmployeeList;
        private FontAwesome.Sharp.IconButton btnCarList;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}