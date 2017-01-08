namespace QuanLyBanSach.MenuCongNo
{
    partial class uc_ReceiptList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_ReceiptList));
            this.pn_Nav = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_ThongTinTimKiem = new System.Windows.Forms.Label();
            this.txt_ThongTinTimKiem = new System.Windows.Forms.TextBox();
            this.pic_Them = new System.Windows.Forms.PictureBox();
            this.dgv_DanhSachPhieuThu = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Fix = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_MaPhieuThu = new System.Windows.Forms.Label();
            this.lb_NgayThu = new System.Windows.Forms.Label();
            this.lb_KhachHang = new System.Windows.Forms.Label();
            this.txt_MaPhieuThu = new System.Windows.Forms.TextBox();
            this.txt_NhanVien = new System.Windows.Forms.TextBox();
            this.txt_KhachHang = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_SoTien = new System.Windows.Forms.TextBox();
            this.lb_SoTien = new System.Windows.Forms.Label();
            this.msk_NgayThu = new System.Windows.Forms.MaskedTextBox();
            this.lb_NhanVien = new System.Windows.Forms.Label();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.pn_Nav.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhieuThu)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Nav
            // 
            this.pn_Nav.Controls.Add(this.tableLayoutPanel1);
            this.pn_Nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Nav.Location = new System.Drawing.Point(0, 0);
            this.pn_Nav.Name = "pn_Nav";
            this.pn_Nav.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pn_Nav.Size = new System.Drawing.Size(842, 49);
            this.pn_Nav.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lb_ThongTinTimKiem, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_ThongTinTimKiem, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pic_Them, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(842, 44);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lb_ThongTinTimKiem
            // 
            this.lb_ThongTinTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_ThongTinTimKiem.AutoSize = true;
            this.lb_ThongTinTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_ThongTinTimKiem.Location = new System.Drawing.Point(193, 12);
            this.lb_ThongTinTimKiem.Name = "lb_ThongTinTimKiem";
            this.lb_ThongTinTimKiem.Size = new System.Drawing.Size(145, 20);
            this.lb_ThongTinTimKiem.TabIndex = 0;
            this.lb_ThongTinTimKiem.Text = "Thông tin phiếu thu";
            // 
            // txt_ThongTinTimKiem
            // 
            this.txt_ThongTinTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_ThongTinTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_ThongTinTimKiem.Location = new System.Drawing.Point(352, 9);
            this.txt_ThongTinTimKiem.Name = "txt_ThongTinTimKiem";
            this.txt_ThongTinTimKiem.Size = new System.Drawing.Size(304, 26);
            this.txt_ThongTinTimKiem.TabIndex = 1;
            this.txt_ThongTinTimKiem.TextChanged += new System.EventHandler(this.txt_ThongTinTimKiem_TextChanged);
            // 
            // pic_Them
            // 
            this.pic_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_Them.BackColor = System.Drawing.Color.Transparent;
            this.pic_Them.Image = global::QuanLyBanSach.Properties.Resources.add;
            this.pic_Them.Location = new System.Drawing.Point(46, 3);
            this.pic_Them.Name = "pic_Them";
            this.pic_Them.Size = new System.Drawing.Size(90, 36);
            this.pic_Them.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Them.TabIndex = 5;
            this.pic_Them.TabStop = false;
            this.pic_Them.Click += new System.EventHandler(this.pic_Them_Click);
            this.pic_Them.MouseLeave += new System.EventHandler(this.pic_Them_MouseLeave);
            this.pic_Them.MouseHover += new System.EventHandler(this.pic_Them_MouseHover);
            // 
            // dgv_DanhSachPhieuThu
            // 
            this.dgv_DanhSachPhieuThu.AllowUserToAddRows = false;
            this.dgv_DanhSachPhieuThu.AllowUserToDeleteRows = false;
            this.dgv_DanhSachPhieuThu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_DanhSachPhieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachPhieuThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Delete,
            this.Fix});
            this.dgv_DanhSachPhieuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachPhieuThu.Location = new System.Drawing.Point(0, 49);
            this.dgv_DanhSachPhieuThu.Name = "dgv_DanhSachPhieuThu";
            this.dgv_DanhSachPhieuThu.Size = new System.Drawing.Size(842, 184);
            this.dgv_DanhSachPhieuThu.TabIndex = 5;
            this.dgv_DanhSachPhieuThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachPhieuThu_CellClick);
            this.dgv_DanhSachPhieuThu.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_DanhSachPhieuThu_RowPrePaint);
            // 
            // STT
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle1;
            this.STT.FillWeight = 38.5323F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 113.6703F;
            this.Delete.HeaderText = "Xoá";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 60;
            // 
            // Fix
            // 
            this.Fix.FillWeight = 113.6703F;
            this.Fix.HeaderText = "Sửa";
            this.Fix.Image = ((System.Drawing.Image)(resources.GetObject("Fix.Image")));
            this.Fix.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Fix.Name = "Fix";
            this.Fix.Width = 60;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lb_MaPhieuThu, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_NgayThu, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_KhachHang, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_MaPhieuThu, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_NhanVien, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_KhachHang, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.msk_NgayThu, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_NhanVien, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_CapNhat, 5, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 233);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(842, 136);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // lb_MaPhieuThu
            // 
            this.lb_MaPhieuThu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_MaPhieuThu.AutoSize = true;
            this.lb_MaPhieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_MaPhieuThu.Location = new System.Drawing.Point(155, 12);
            this.lb_MaPhieuThu.Name = "lb_MaPhieuThu";
            this.lb_MaPhieuThu.Size = new System.Drawing.Size(101, 20);
            this.lb_MaPhieuThu.TabIndex = 0;
            this.lb_MaPhieuThu.Text = "Mã phiếu thu";
            // 
            // lb_NgayThu
            // 
            this.lb_NgayThu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_NgayThu.AutoSize = true;
            this.lb_NgayThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_NgayThu.Location = new System.Drawing.Point(441, 12);
            this.lb_NgayThu.Name = "lb_NgayThu";
            this.lb_NgayThu.Size = new System.Drawing.Size(72, 20);
            this.lb_NgayThu.TabIndex = 1;
            this.lb_NgayThu.Text = "Ngày thu";
            // 
            // lb_KhachHang
            // 
            this.lb_KhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_KhachHang.AutoSize = true;
            this.lb_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_KhachHang.Location = new System.Drawing.Point(430, 57);
            this.lb_KhachHang.Name = "lb_KhachHang";
            this.lb_KhachHang.Size = new System.Drawing.Size(94, 20);
            this.lb_KhachHang.TabIndex = 3;
            this.lb_KhachHang.Text = "Khách hàng";
            // 
            // txt_MaPhieuThu
            // 
            this.txt_MaPhieuThu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaPhieuThu.Enabled = false;
            this.txt_MaPhieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaPhieuThu.Location = new System.Drawing.Point(263, 9);
            this.txt_MaPhieuThu.Name = "txt_MaPhieuThu";
            this.txt_MaPhieuThu.Size = new System.Drawing.Size(154, 26);
            this.txt_MaPhieuThu.TabIndex = 4;
            // 
            // txt_NhanVien
            // 
            this.txt_NhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NhanVien.Location = new System.Drawing.Point(263, 54);
            this.txt_NhanVien.Name = "txt_NhanVien";
            this.txt_NhanVien.Size = new System.Drawing.Size(154, 26);
            this.txt_NhanVien.TabIndex = 5;
            // 
            // txt_KhachHang
            // 
            this.txt_KhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_KhachHang.Location = new System.Drawing.Point(537, 54);
            this.txt_KhachHang.Name = "txt_KhachHang";
            this.txt_KhachHang.Size = new System.Drawing.Size(151, 26);
            this.txt_KhachHang.TabIndex = 6;
            // 
            // panel1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel1, 4);
            this.panel1.Controls.Add(this.txt_SoTien);
            this.panel1.Controls.Add(this.lb_SoTien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(154, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 40);
            this.panel1.TabIndex = 7;
            // 
            // txt_SoTien
            // 
            this.txt_SoTien.Location = new System.Drawing.Point(109, 7);
            this.txt_SoTien.Name = "txt_SoTien";
            this.txt_SoTien.Size = new System.Drawing.Size(422, 26);
            this.txt_SoTien.TabIndex = 6;
            // 
            // lb_SoTien
            // 
            this.lb_SoTien.AutoSize = true;
            this.lb_SoTien.Location = new System.Drawing.Point(44, 10);
            this.lb_SoTien.Name = "lb_SoTien";
            this.lb_SoTien.Size = new System.Drawing.Size(59, 20);
            this.lb_SoTien.TabIndex = 3;
            this.lb_SoTien.Text = "Số tiền";
            // 
            // msk_NgayThu
            // 
            this.msk_NgayThu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msk_NgayThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.msk_NgayThu.Location = new System.Drawing.Point(537, 9);
            this.msk_NgayThu.Mask = "00/00/0000";
            this.msk_NgayThu.Name = "msk_NgayThu";
            this.msk_NgayThu.Size = new System.Drawing.Size(151, 26);
            this.msk_NgayThu.TabIndex = 8;
            this.msk_NgayThu.ValidatingType = typeof(System.DateTime);
            // 
            // lb_NhanVien
            // 
            this.lb_NhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_NhanVien.AutoSize = true;
            this.lb_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_NhanVien.Location = new System.Drawing.Point(166, 57);
            this.lb_NhanVien.Name = "lb_NhanVien";
            this.lb_NhanVien.Size = new System.Drawing.Size(79, 20);
            this.lb_NhanVien.TabIndex = 2;
            this.lb_NhanVien.Text = "Nhân viên";
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_CapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_CapNhat.Appearance.Options.UseFont = true;
            this.btn_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.Image")));
            this.btn_CapNhat.Location = new System.Drawing.Point(694, 48);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(118, 39);
            this.btn_CapNhat.TabIndex = 9;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // uc_ReceiptList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dgv_DanhSachPhieuThu);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.pn_Nav);
            this.Name = "uc_ReceiptList";
            this.Size = new System.Drawing.Size(842, 369);
            this.Load += new System.EventHandler(this.uc_ReceiptList_Load);
            this.pn_Nav.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhieuThu)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Nav;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pic_Them;
        private System.Windows.Forms.Label lb_ThongTinTimKiem;
        private System.Windows.Forms.TextBox txt_ThongTinTimKiem;
        private System.Windows.Forms.DataGridView dgv_DanhSachPhieuThu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lb_MaPhieuThu;
        private System.Windows.Forms.Label lb_NgayThu;
        private System.Windows.Forms.Label lb_NhanVien;
        private System.Windows.Forms.Label lb_KhachHang;
        private System.Windows.Forms.TextBox txt_MaPhieuThu;
        private System.Windows.Forms.TextBox txt_NhanVien;
        private System.Windows.Forms.TextBox txt_KhachHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_SoTien;
        private System.Windows.Forms.Label lb_SoTien;
        private System.Windows.Forms.MaskedTextBox msk_NgayThu;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Fix;
    }
}
