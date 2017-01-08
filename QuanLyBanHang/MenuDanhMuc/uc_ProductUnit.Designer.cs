namespace QuanLyBanHang.MenuDanhMuc
{
    partial class uc_ProductUnit
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
            this.pn_ThongTinSach = new System.Windows.Forms.Panel();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.txt_TenDonViTinh = new System.Windows.Forms.TextBox();
            this.lb_TenDonViTinh = new System.Windows.Forms.Label();
            this.txt_MaDonViTinh = new System.Windows.Forms.TextBox();
            this.lb_MaDonViTinh = new System.Windows.Forms.Label();
            this.pn_DieuHuong = new System.Windows.Forms.Panel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lb_Search = new System.Windows.Forms.Label();
            this.pic_Xoa = new System.Windows.Forms.PictureBox();
            this.pic_Sua = new System.Windows.Forms.PictureBox();
            this.pic_Them = new System.Windows.Forms.PictureBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_DanhMucDVTinh = new System.Windows.Forms.DataGridView();
            this.pn_ThongTinSach.SuspendLayout();
            this.pn_DieuHuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMucDVTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_ThongTinSach
            // 
            this.pn_ThongTinSach.AutoScroll = true;
            this.pn_ThongTinSach.Controls.Add(this.btn_CapNhat);
            this.pn_ThongTinSach.Controls.Add(this.txt_TenDonViTinh);
            this.pn_ThongTinSach.Controls.Add(this.lb_TenDonViTinh);
            this.pn_ThongTinSach.Controls.Add(this.txt_MaDonViTinh);
            this.pn_ThongTinSach.Controls.Add(this.lb_MaDonViTinh);
            this.pn_ThongTinSach.Controls.Add(this.pn_DieuHuong);
            this.pn_ThongTinSach.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_ThongTinSach.Location = new System.Drawing.Point(461, 0);
            this.pn_ThongTinSach.Name = "pn_ThongTinSach";
            this.pn_ThongTinSach.Size = new System.Drawing.Size(352, 376);
            this.pn_ThongTinSach.TabIndex = 4;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(229, 173);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(120, 41);
            this.btn_CapNhat.TabIndex = 14;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Visible = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // txt_TenDonViTinh
            // 
            this.txt_TenDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenDonViTinh.Location = new System.Drawing.Point(123, 141);
            this.txt_TenDonViTinh.Name = "txt_TenDonViTinh";
            this.txt_TenDonViTinh.ReadOnly = true;
            this.txt_TenDonViTinh.Size = new System.Drawing.Size(226, 26);
            this.txt_TenDonViTinh.TabIndex = 6;
            // 
            // lb_TenDonViTinh
            // 
            this.lb_TenDonViTinh.AutoSize = true;
            this.lb_TenDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_TenDonViTinh.Location = new System.Drawing.Point(6, 144);
            this.lb_TenDonViTinh.Name = "lb_TenDonViTinh";
            this.lb_TenDonViTinh.Size = new System.Drawing.Size(111, 20);
            this.lb_TenDonViTinh.TabIndex = 5;
            this.lb_TenDonViTinh.Text = "Tên đơn vị tính";
            // 
            // txt_MaDonViTinh
            // 
            this.txt_MaDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaDonViTinh.Location = new System.Drawing.Point(123, 106);
            this.txt_MaDonViTinh.Name = "txt_MaDonViTinh";
            this.txt_MaDonViTinh.ReadOnly = true;
            this.txt_MaDonViTinh.Size = new System.Drawing.Size(226, 26);
            this.txt_MaDonViTinh.TabIndex = 3;
            // 
            // lb_MaDonViTinh
            // 
            this.lb_MaDonViTinh.AutoSize = true;
            this.lb_MaDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_MaDonViTinh.Location = new System.Drawing.Point(6, 109);
            this.lb_MaDonViTinh.Name = "lb_MaDonViTinh";
            this.lb_MaDonViTinh.Size = new System.Drawing.Size(106, 20);
            this.lb_MaDonViTinh.TabIndex = 2;
            this.lb_MaDonViTinh.Text = "Mã đơn vị tính";
            // 
            // pn_DieuHuong
            // 
            this.pn_DieuHuong.Controls.Add(this.txt_Search);
            this.pn_DieuHuong.Controls.Add(this.lb_Search);
            this.pn_DieuHuong.Controls.Add(this.pic_Xoa);
            this.pn_DieuHuong.Controls.Add(this.pic_Sua);
            this.pn_DieuHuong.Controls.Add(this.pic_Them);
            this.pn_DieuHuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_DieuHuong.Location = new System.Drawing.Point(0, 0);
            this.pn_DieuHuong.Name = "pn_DieuHuong";
            this.pn_DieuHuong.Size = new System.Drawing.Size(352, 100);
            this.pn_DieuHuong.TabIndex = 0;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Search.Location = new System.Drawing.Point(118, 14);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(213, 26);
            this.txt_Search.TabIndex = 6;
            this.txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Search.Location = new System.Drawing.Point(34, 17);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(75, 20);
            this.lb_Search.TabIndex = 5;
            this.lb_Search.Text = "Thông tin";
            // 
            // pic_Xoa
            // 
            this.pic_Xoa.Image = global::QuanLyBanHang.Properties.Resources.del;
            this.pic_Xoa.Location = new System.Drawing.Point(241, 55);
            this.pic_Xoa.Name = "pic_Xoa";
            this.pic_Xoa.Size = new System.Drawing.Size(90, 36);
            this.pic_Xoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Xoa.TabIndex = 4;
            this.pic_Xoa.TabStop = false;
            this.pic_Xoa.Click += new System.EventHandler(this.pic_Xoa_Click);
            this.pic_Xoa.MouseLeave += new System.EventHandler(this.pic_Xoa_MouseLeave);
            this.pic_Xoa.MouseHover += new System.EventHandler(this.pic_Xoa_MouseHover);
            // 
            // pic_Sua
            // 
            this.pic_Sua.Image = global::QuanLyBanHang.Properties.Resources.edit;
            this.pic_Sua.Location = new System.Drawing.Point(139, 55);
            this.pic_Sua.Name = "pic_Sua";
            this.pic_Sua.Size = new System.Drawing.Size(90, 36);
            this.pic_Sua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Sua.TabIndex = 3;
            this.pic_Sua.TabStop = false;
            this.pic_Sua.Click += new System.EventHandler(this.pic_Sua_Click);
            this.pic_Sua.MouseLeave += new System.EventHandler(this.pic_Sua_MouseLeave);
            this.pic_Sua.MouseHover += new System.EventHandler(this.pic_Sua_MouseHover);
            // 
            // pic_Them
            // 
            this.pic_Them.BackColor = System.Drawing.Color.Transparent;
            this.pic_Them.Image = global::QuanLyBanHang.Properties.Resources.add;
            this.pic_Them.Location = new System.Drawing.Point(38, 55);
            this.pic_Them.Name = "pic_Them";
            this.pic_Them.Size = new System.Drawing.Size(90, 36);
            this.pic_Them.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Them.TabIndex = 2;
            this.pic_Them.TabStop = false;
            this.pic_Them.Click += new System.EventHandler(this.pic_Them_Click);
            this.pic_Them.MouseLeave += new System.EventHandler(this.pic_Them_MouseLeave);
            this.pic_Them.MouseHover += new System.EventHandler(this.pic_Them_MouseHover);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // dgv_DanhMucDVTinh
            // 
            this.dgv_DanhMucDVTinh.AllowUserToAddRows = false;
            this.dgv_DanhMucDVTinh.AllowUserToDeleteRows = false;
            this.dgv_DanhMucDVTinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhMucDVTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhMucDVTinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT});
            this.dgv_DanhMucDVTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhMucDVTinh.Location = new System.Drawing.Point(0, 0);
            this.dgv_DanhMucDVTinh.Name = "dgv_DanhMucDVTinh";
            this.dgv_DanhMucDVTinh.Size = new System.Drawing.Size(813, 376);
            this.dgv_DanhMucDVTinh.TabIndex = 5;
            this.dgv_DanhMucDVTinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhMucDVTinh_CellClick);
            this.dgv_DanhMucDVTinh.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_DanhMucDVTinh_RowPrePaint);
            // 
            // uc_ProductUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pn_ThongTinSach);
            this.Controls.Add(this.dgv_DanhMucDVTinh);
            this.Name = "uc_ProductUnit";
            this.Size = new System.Drawing.Size(813, 376);
            this.Load += new System.EventHandler(this.uc_ProductUnit_Load);
            this.pn_ThongTinSach.ResumeLayout(false);
            this.pn_ThongTinSach.PerformLayout();
            this.pn_DieuHuong.ResumeLayout(false);
            this.pn_DieuHuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMucDVTinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_ThongTinSach;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.TextBox txt_TenDonViTinh;
        private System.Windows.Forms.Label lb_TenDonViTinh;
        private System.Windows.Forms.TextBox txt_MaDonViTinh;
        private System.Windows.Forms.Label lb_MaDonViTinh;
        private System.Windows.Forms.Panel pn_DieuHuong;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.PictureBox pic_Xoa;
        private System.Windows.Forms.PictureBox pic_Sua;
        private System.Windows.Forms.PictureBox pic_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridView dgv_DanhMucDVTinh;
    }
}
