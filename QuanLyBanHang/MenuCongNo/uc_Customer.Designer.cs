namespace QuanLyBanSach.MenuCongNo
{
    partial class uc_Customer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pn_Nav = new System.Windows.Forms.Panel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lb_Search = new System.Windows.Forms.Label();
            this.pn_Customer = new System.Windows.Forms.Panel();
            this.pic_Refresh = new System.Windows.Forms.PictureBox();
            this.pic_Them = new System.Windows.Forms.PictureBox();
            this.pn_Nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Them)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Nav
            // 
            this.pn_Nav.Controls.Add(this.pic_Refresh);
            this.pn_Nav.Controls.Add(this.txt_Search);
            this.pn_Nav.Controls.Add(this.lb_Search);
            this.pn_Nav.Controls.Add(this.pic_Them);
            this.pn_Nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Nav.Location = new System.Drawing.Point(0, 0);
            this.pn_Nav.Name = "pn_Nav";
            this.pn_Nav.Size = new System.Drawing.Size(730, 52);
            this.pn_Nav.TabIndex = 0;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Search.Location = new System.Drawing.Point(428, 8);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(299, 26);
            this.txt_Search.TabIndex = 22;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Search.Location = new System.Drawing.Point(346, 11);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(75, 20);
            this.lb_Search.TabIndex = 21;
            this.lb_Search.Text = "Thông tin";
            // 
            // pn_Customer
            // 
            this.pn_Customer.AutoScroll = true;
            this.pn_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Customer.Location = new System.Drawing.Point(0, 52);
            this.pn_Customer.Name = "pn_Customer";
            this.pn_Customer.Size = new System.Drawing.Size(730, 303);
            this.pn_Customer.TabIndex = 1;
            // 
            // pic_Refresh
            // 
            this.pic_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.pic_Refresh.Image = global::QuanLyBanSach.Properties.Resources.Refresh;
            this.pic_Refresh.Location = new System.Drawing.Point(105, 8);
            this.pic_Refresh.Name = "pic_Refresh";
            this.pic_Refresh.Size = new System.Drawing.Size(105, 36);
            this.pic_Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Refresh.TabIndex = 23;
            this.pic_Refresh.TabStop = false;
            this.pic_Refresh.Click += new System.EventHandler(this.pic_Refresh_Click);
            this.pic_Refresh.MouseLeave += new System.EventHandler(this.pic_Refresh_MouseLeave);
            this.pic_Refresh.MouseHover += new System.EventHandler(this.pic_Refresh_MouseHover);
            // 
            // pic_Them
            // 
            this.pic_Them.BackColor = System.Drawing.Color.Transparent;
            this.pic_Them.Image = global::QuanLyBanSach.Properties.Resources.add;
            this.pic_Them.Location = new System.Drawing.Point(9, 8);
            this.pic_Them.Name = "pic_Them";
            this.pic_Them.Size = new System.Drawing.Size(90, 36);
            this.pic_Them.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Them.TabIndex = 20;
            this.pic_Them.TabStop = false;
            this.pic_Them.Click += new System.EventHandler(this.pic_Them_Click);
            this.pic_Them.MouseLeave += new System.EventHandler(this.pic_Them_MouseLeave);
            this.pic_Them.MouseHover += new System.EventHandler(this.pic_Them_MouseHover);
            // 
            // uc_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pn_Customer);
            this.Controls.Add(this.pn_Nav);
            this.Name = "uc_Customer";
            this.Size = new System.Drawing.Size(730, 355);
            this.Load += new System.EventHandler(this.uc_Customer_Load);
            this.pn_Nav.ResumeLayout(false);
            this.pn_Nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Them)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Nav;
        private System.Windows.Forms.Panel pn_Customer;
        private System.Windows.Forms.PictureBox pic_Them;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.PictureBox pic_Refresh;
    }
}
