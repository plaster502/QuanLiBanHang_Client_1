namespace QuanLyBanSach.MenuCongNo
{
    partial class uc_CustomerInfo
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
            this.lb_TenKhachHang = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_SoDienThoai = new System.Windows.Forms.Label();
            this.lb_Mail = new System.Windows.Forms.Label();
            this.lb_No = new System.Windows.Forms.Label();
            this.pn_Nav = new System.Windows.Forms.Panel();
            this.pic_Xoa = new System.Windows.Forms.PictureBox();
            this.pic_Sua = new System.Windows.Forms.PictureBox();
            this.pn_Nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sua)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_TenKhachHang
            // 
            this.lb_TenKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_TenKhachHang.AutoSize = true;
            this.lb_TenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_TenKhachHang.Location = new System.Drawing.Point(3, 11);
            this.lb_TenKhachHang.Name = "lb_TenKhachHang";
            this.lb_TenKhachHang.Size = new System.Drawing.Size(137, 20);
            this.lb_TenKhachHang.TabIndex = 0;
            this.lb_TenKhachHang.Text = "Tên khách hàng";
            this.lb_TenKhachHang.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Location = new System.Drawing.Point(4, 44);
            this.lb_DiaChi.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(40, 13);
            this.lb_DiaChi.TabIndex = 1;
            this.lb_DiaChi.Text = "Địa chỉ";
            // 
            // lb_SoDienThoai
            // 
            this.lb_SoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_SoDienThoai.AutoSize = true;
            this.lb_SoDienThoai.Location = new System.Drawing.Point(4, 68);
            this.lb_SoDienThoai.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lb_SoDienThoai.Name = "lb_SoDienThoai";
            this.lb_SoDienThoai.Size = new System.Drawing.Size(70, 13);
            this.lb_SoDienThoai.TabIndex = 2;
            this.lb_SoDienThoai.Text = "Số điện thoại";
            // 
            // lb_Mail
            // 
            this.lb_Mail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Mail.AutoSize = true;
            this.lb_Mail.Location = new System.Drawing.Point(4, 91);
            this.lb_Mail.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lb_Mail.Name = "lb_Mail";
            this.lb_Mail.Size = new System.Drawing.Size(32, 13);
            this.lb_Mail.TabIndex = 3;
            this.lb_Mail.Text = "Email";
            // 
            // lb_No
            // 
            this.lb_No.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_No.AutoSize = true;
            this.lb_No.ForeColor = System.Drawing.Color.Red;
            this.lb_No.Location = new System.Drawing.Point(4, 111);
            this.lb_No.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lb_No.Name = "lb_No";
            this.lb_No.Size = new System.Drawing.Size(21, 13);
            this.lb_No.TabIndex = 4;
            this.lb_No.Text = "Nợ";
            // 
            // pn_Nav
            // 
            this.pn_Nav.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_Nav.Controls.Add(this.pic_Xoa);
            this.pn_Nav.Controls.Add(this.pic_Sua);
            this.pn_Nav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Nav.Location = new System.Drawing.Point(0, 0);
            this.pn_Nav.Name = "pn_Nav";
            this.pn_Nav.Size = new System.Drawing.Size(230, 132);
            this.pn_Nav.TabIndex = 5;
            this.pn_Nav.Visible = false;
            this.pn_Nav.MouseEnter += new System.EventHandler(this.uc_CustomerInfo_MouseEnter);
            this.pn_Nav.MouseLeave += new System.EventHandler(this.uc_CustomerInfo_MouseLeave);
            // 
            // pic_Xoa
            // 
            this.pic_Xoa.Image = global::QuanLyBanSach.Properties.Resources.del;
            this.pic_Xoa.Location = new System.Drawing.Point(119, 48);
            this.pic_Xoa.Name = "pic_Xoa";
            this.pic_Xoa.Size = new System.Drawing.Size(90, 36);
            this.pic_Xoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Xoa.TabIndex = 23;
            this.pic_Xoa.TabStop = false;
            this.pic_Xoa.Click += new System.EventHandler(this.pic_Xoa_Click);
            this.pic_Xoa.MouseLeave += new System.EventHandler(this.pic_Xoa_MouseLeave);
            this.pic_Xoa.MouseHover += new System.EventHandler(this.pic_Xoa_MouseHover);
            // 
            // pic_Sua
            // 
            this.pic_Sua.Image = global::QuanLyBanSach.Properties.Resources.edit;
            this.pic_Sua.Location = new System.Drawing.Point(17, 48);
            this.pic_Sua.Name = "pic_Sua";
            this.pic_Sua.Size = new System.Drawing.Size(90, 36);
            this.pic_Sua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Sua.TabIndex = 22;
            this.pic_Sua.TabStop = false;
            this.pic_Sua.Click += new System.EventHandler(this.pic_Sua_Click);
            this.pic_Sua.MouseLeave += new System.EventHandler(this.pic_Sua_MouseLeave);
            this.pic_Sua.MouseHover += new System.EventHandler(this.pic_Sua_MouseHover);
            // 
            // uc_CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pn_Nav);
            this.Controls.Add(this.lb_No);
            this.Controls.Add(this.lb_TenKhachHang);
            this.Controls.Add(this.lb_Mail);
            this.Controls.Add(this.lb_DiaChi);
            this.Controls.Add(this.lb_SoDienThoai);
            this.Name = "uc_CustomerInfo";
            this.Size = new System.Drawing.Size(230, 132);
            this.MouseEnter += new System.EventHandler(this.uc_CustomerInfo_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.uc_CustomerInfo_MouseLeave);
            this.pn_Nav.ResumeLayout(false);
            this.pn_Nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_TenKhachHang;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_SoDienThoai;
        private System.Windows.Forms.Label lb_Mail;
        private System.Windows.Forms.Label lb_No;
        private System.Windows.Forms.Panel pn_Nav;
        private System.Windows.Forms.PictureBox pic_Xoa;
        private System.Windows.Forms.PictureBox pic_Sua;
    }
}
