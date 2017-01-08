namespace QuanLyBanSach.MenuXuatNhapKho
{
    partial class uc_OutInvenCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_OutInvenCreate));
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgv_DanhSachChiTiet = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_SoLuong = new System.Windows.Forms.Label();
            this.lb_MaSach = new System.Windows.Forms.Label();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.lb_TenSach = new System.Windows.Forms.Label();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.lb_DonGia = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.btn_AddBook = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.grb_ChiTietPhieu = new System.Windows.Forms.GroupBox();
            this.lb_MaHoaDon = new System.Windows.Forms.Label();
            this.txt_MaHoaDon = new System.Windows.Forms.TextBox();
            this.pn_Nav = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_NgayXuat = new System.Windows.Forms.Label();
            this.msk_NgayXuat = new System.Windows.Forms.MaskedTextBox();
            this.lb_NhanVien = new System.Windows.Forms.Label();
            this.txt_NhanVien = new System.Windows.Forms.TextBox();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.lb_KhachHang = new System.Windows.Forms.Label();
            this.pn_Money = new System.Windows.Forms.Panel();
            this.txt_ConLai = new System.Windows.Forms.TextBox();
            this.lb_ConLai = new System.Windows.Forms.Label();
            this.txt_DaThanhToan = new System.Windows.Forms.TextBox();
            this.lb_DaThanhToan = new System.Windows.Forms.Label();
            this.txt_KhachHang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachChiTiet)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grb_ChiTietPhieu.SuspendLayout();
            this.pn_Nav.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pn_Money.SuspendLayout();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Xoá";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgv_DanhSachChiTiet
            // 
            this.dgv_DanhSachChiTiet.AllowUserToAddRows = false;
            this.dgv_DanhSachChiTiet.AllowUserToDeleteRows = false;
            this.dgv_DanhSachChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Delete});
            this.dgv_DanhSachChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachChiTiet.Location = new System.Drawing.Point(0, 368);
            this.dgv_DanhSachChiTiet.Name = "dgv_DanhSachChiTiet";
            this.dgv_DanhSachChiTiet.Size = new System.Drawing.Size(761, 97);
            this.dgv_DanhSachChiTiet.TabIndex = 5;
            this.dgv_DanhSachChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachChiTiet_CellClick);
            this.dgv_DanhSachChiTiet.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_DanhSachChiTiet_RowPrePaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Luu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Luu.Appearance.Options.UseFont = true;
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.Location = new System.Drawing.Point(257, 3);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(126, 33);
            this.btn_Luu.TabIndex = 0;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 4);
            this.panel1.Controls.Add(this.btn_Luu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(45, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 37);
            this.panel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.5493F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.4507F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tableLayoutPanel2.Controls.Add(this.lb_SoLuong, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_MaSach, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_MaSach, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_TenSach, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_TenSach, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_DonGia, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_DonGia, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_SoLuong, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_AddBook, 3, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(664, 132);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lb_SoLuong
            // 
            this.lb_SoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_SoLuong.AutoSize = true;
            this.lb_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_SoLuong.Location = new System.Drawing.Point(28, 51);
            this.lb_SoLuong.Name = "lb_SoLuong";
            this.lb_SoLuong.Size = new System.Drawing.Size(72, 20);
            this.lb_SoLuong.TabIndex = 5;
            this.lb_SoLuong.Text = "Số lượng";
            // 
            // lb_MaSach
            // 
            this.lb_MaSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_MaSach.AutoSize = true;
            this.lb_MaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_MaSach.Location = new System.Drawing.Point(27, 10);
            this.lb_MaSach.Name = "lb_MaSach";
            this.lb_MaSach.Size = new System.Drawing.Size(73, 20);
            this.lb_MaSach.TabIndex = 1;
            this.lb_MaSach.Text = "Mã sách ";
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaSach.Location = new System.Drawing.Point(139, 7);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(158, 26);
            this.txt_MaSach.TabIndex = 2;
            this.txt_MaSach.TextChanged += new System.EventHandler(this.txt_MaSach_TextChanged);
            // 
            // lb_TenSach
            // 
            this.lb_TenSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_TenSach.AutoSize = true;
            this.lb_TenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_TenSach.Location = new System.Drawing.Point(317, 10);
            this.lb_TenSach.Name = "lb_TenSach";
            this.lb_TenSach.Size = new System.Drawing.Size(74, 20);
            this.lb_TenSach.TabIndex = 3;
            this.lb_TenSach.Text = "Tên sách";
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenSach.Location = new System.Drawing.Point(421, 7);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.Size = new System.Drawing.Size(223, 26);
            this.txt_TenSach.TabIndex = 4;
            this.txt_TenSach.TextChanged += new System.EventHandler(this.txt_TenSach_TextChanged);
            // 
            // lb_DonGia
            // 
            this.lb_DonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_DonGia.AutoSize = true;
            this.lb_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_DonGia.Location = new System.Drawing.Point(322, 51);
            this.lb_DonGia.Name = "lb_DonGia";
            this.lb_DonGia.Size = new System.Drawing.Size(64, 20);
            this.lb_DonGia.TabIndex = 7;
            this.lb_DonGia.Text = "Đơn giá";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_DonGia.Location = new System.Drawing.Point(421, 48);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(223, 26);
            this.txt_DonGia.TabIndex = 8;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SoLuong.Location = new System.Drawing.Point(139, 48);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(158, 26);
            this.txt_SoLuong.TabIndex = 6;
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_AddBook.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_AddBook.Appearance.Options.UseFont = true;
            this.btn_AddBook.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddBook.Image")));
            this.btn_AddBook.Location = new System.Drawing.Point(441, 90);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(220, 33);
            this.btn_AddBook.TabIndex = 8;
            this.btn_AddBook.Text = "Thêm sách vào hoá đơn";
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TongTien.Location = new System.Drawing.Point(178, 110);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(191, 26);
            this.txt_TongTien.TabIndex = 7;
            // 
            // grb_ChiTietPhieu
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.grb_ChiTietPhieu, 4);
            this.grb_ChiTietPhieu.Controls.Add(this.tableLayoutPanel2);
            this.grb_ChiTietPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_ChiTietPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_ChiTietPhieu.Location = new System.Drawing.Point(45, 165);
            this.grb_ChiTietPhieu.Name = "grb_ChiTietPhieu";
            this.grb_ChiTietPhieu.Size = new System.Drawing.Size(670, 157);
            this.grb_ChiTietPhieu.TabIndex = 8;
            this.grb_ChiTietPhieu.TabStop = false;
            this.grb_ChiTietPhieu.Text = "Chi tiết phiếu nhập";
            // 
            // lb_MaHoaDon
            // 
            this.lb_MaHoaDon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_MaHoaDon.AutoSize = true;
            this.lb_MaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_MaHoaDon.Location = new System.Drawing.Point(58, 14);
            this.lb_MaHoaDon.Name = "lb_MaHoaDon";
            this.lb_MaHoaDon.Size = new System.Drawing.Size(93, 20);
            this.lb_MaHoaDon.TabIndex = 0;
            this.lb_MaHoaDon.Text = "Mã hoá đơn";
            // 
            // txt_MaHoaDon
            // 
            this.txt_MaHoaDon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaHoaDon.Location = new System.Drawing.Point(174, 11);
            this.txt_MaHoaDon.Name = "txt_MaHoaDon";
            this.txt_MaHoaDon.Size = new System.Drawing.Size(198, 26);
            this.txt_MaHoaDon.TabIndex = 1;
            // 
            // pn_Nav
            // 
            this.pn_Nav.Controls.Add(this.tableLayoutPanel1);
            this.pn_Nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Nav.Location = new System.Drawing.Point(0, 0);
            this.pn_Nav.Name = "pn_Nav";
            this.pn_Nav.Size = new System.Drawing.Size(761, 368);
            this.pn_Nav.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lb_MaHoaDon, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_NgayXuat, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_MaHoaDon, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.msk_NgayXuat, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_NhanVien, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_NhanVien, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.grb_ChiTietPhieu, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_TongTien, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_KhachHang, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_TongTien, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pn_Money, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_KhachHang, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.05195F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.94805F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 368);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lb_NgayXuat
            // 
            this.lb_NgayXuat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_NgayXuat.AutoSize = true;
            this.lb_NgayXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_NgayXuat.Location = new System.Drawing.Point(403, 14);
            this.lb_NgayXuat.Name = "lb_NgayXuat";
            this.lb_NgayXuat.Size = new System.Drawing.Size(79, 20);
            this.lb_NgayXuat.TabIndex = 2;
            this.lb_NgayXuat.Text = "Ngày xuất";
            // 
            // msk_NgayXuat
            // 
            this.msk_NgayXuat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msk_NgayXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.msk_NgayXuat.Location = new System.Drawing.Point(539, 11);
            this.msk_NgayXuat.Mask = "00/00/0000";
            this.msk_NgayXuat.Name = "msk_NgayXuat";
            this.msk_NgayXuat.Size = new System.Drawing.Size(145, 26);
            this.msk_NgayXuat.TabIndex = 3;
            this.msk_NgayXuat.ValidatingType = typeof(System.DateTime);
            // 
            // lb_NhanVien
            // 
            this.lb_NhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_NhanVien.AutoSize = true;
            this.lb_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_NhanVien.Location = new System.Drawing.Point(65, 54);
            this.lb_NhanVien.Name = "lb_NhanVien";
            this.lb_NhanVien.Size = new System.Drawing.Size(79, 20);
            this.lb_NhanVien.TabIndex = 4;
            this.lb_NhanVien.Text = "Nhân viên";
            // 
            // txt_NhanVien
            // 
            this.txt_NhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NhanVien.Location = new System.Drawing.Point(174, 51);
            this.txt_NhanVien.Name = "txt_NhanVien";
            this.txt_NhanVien.Size = new System.Drawing.Size(198, 26);
            this.txt_NhanVien.TabIndex = 5;
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_TongTien.Location = new System.Drawing.Point(67, 113);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(75, 20);
            this.lb_TongTien.TabIndex = 6;
            this.lb_TongTien.Text = "Tổng tiền";
            // 
            // lb_KhachHang
            // 
            this.lb_KhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_KhachHang.AutoSize = true;
            this.lb_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_KhachHang.Location = new System.Drawing.Point(395, 54);
            this.lb_KhachHang.Name = "lb_KhachHang";
            this.lb_KhachHang.Size = new System.Drawing.Size(94, 20);
            this.lb_KhachHang.TabIndex = 10;
            this.lb_KhachHang.Text = "Khách hàng";
            // 
            // pn_Money
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pn_Money, 2);
            this.pn_Money.Controls.Add(this.txt_ConLai);
            this.pn_Money.Controls.Add(this.lb_ConLai);
            this.pn_Money.Controls.Add(this.txt_DaThanhToan);
            this.pn_Money.Controls.Add(this.lb_DaThanhToan);
            this.pn_Money.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Money.Location = new System.Drawing.Point(383, 88);
            this.pn_Money.Name = "pn_Money";
            this.pn_Money.Size = new System.Drawing.Size(332, 71);
            this.pn_Money.TabIndex = 13;
            // 
            // txt_ConLai
            // 
            this.txt_ConLai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_ConLai.Location = new System.Drawing.Point(129, 37);
            this.txt_ConLai.Name = "txt_ConLai";
            this.txt_ConLai.Size = new System.Drawing.Size(197, 26);
            this.txt_ConLai.TabIndex = 15;
            // 
            // lb_ConLai
            // 
            this.lb_ConLai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_ConLai.AutoSize = true;
            this.lb_ConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_ConLai.Location = new System.Drawing.Point(57, 40);
            this.lb_ConLai.Name = "lb_ConLai";
            this.lb_ConLai.Size = new System.Drawing.Size(57, 20);
            this.lb_ConLai.TabIndex = 16;
            this.lb_ConLai.Text = "Còn lại";
            // 
            // txt_DaThanhToan
            // 
            this.txt_DaThanhToan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DaThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_DaThanhToan.Location = new System.Drawing.Point(129, 5);
            this.txt_DaThanhToan.Name = "txt_DaThanhToan";
            this.txt_DaThanhToan.Size = new System.Drawing.Size(197, 26);
            this.txt_DaThanhToan.TabIndex = 14;
            this.txt_DaThanhToan.TextChanged += new System.EventHandler(this.txt_DaThanhToan_TextChanged);
            // 
            // lb_DaThanhToan
            // 
            this.lb_DaThanhToan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_DaThanhToan.AutoSize = true;
            this.lb_DaThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_DaThanhToan.Location = new System.Drawing.Point(3, 8);
            this.lb_DaThanhToan.Name = "lb_DaThanhToan";
            this.lb_DaThanhToan.Size = new System.Drawing.Size(111, 20);
            this.lb_DaThanhToan.TabIndex = 14;
            this.lb_DaThanhToan.Text = "Đã thanh toán";
            // 
            // txt_KhachHang
            // 
            this.txt_KhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_KhachHang.Location = new System.Drawing.Point(512, 51);
            this.txt_KhachHang.Name = "txt_KhachHang";
            this.txt_KhachHang.Size = new System.Drawing.Size(198, 26);
            this.txt_KhachHang.TabIndex = 12;
            // 
            // uc_OutInvenCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dgv_DanhSachChiTiet);
            this.Controls.Add(this.pn_Nav);
            this.Name = "uc_OutInvenCreate";
            this.Size = new System.Drawing.Size(761, 465);
            this.Load += new System.EventHandler(this.uc_OutInvenCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachChiTiet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.grb_ChiTietPhieu.ResumeLayout(false);
            this.pn_Nav.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pn_Money.ResumeLayout(false);
            this.pn_Money.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridView dgv_DanhSachChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_MaHoaDon;
        private System.Windows.Forms.Label lb_NgayXuat;
        private System.Windows.Forms.TextBox txt_MaHoaDon;
        private System.Windows.Forms.MaskedTextBox msk_NgayXuat;
        private System.Windows.Forms.Label lb_NhanVien;
        private System.Windows.Forms.TextBox txt_NhanVien;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.GroupBox grb_ChiTietPhieu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lb_SoLuong;
        private System.Windows.Forms.Label lb_MaSach;
        private System.Windows.Forms.TextBox txt_MaSach;
        private System.Windows.Forms.Label lb_TenSach;
        private System.Windows.Forms.TextBox txt_TenSach;
        private System.Windows.Forms.Label lb_DonGia;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private DevExpress.XtraEditors.SimpleButton btn_AddBook;
        private System.Windows.Forms.Panel pn_Nav;
        private System.Windows.Forms.Label lb_KhachHang;
        private System.Windows.Forms.TextBox txt_KhachHang;
        private System.Windows.Forms.Panel pn_Money;
        private System.Windows.Forms.TextBox txt_DaThanhToan;
        private System.Windows.Forms.Label lb_DaThanhToan;
        private System.Windows.Forms.TextBox txt_ConLai;
        private System.Windows.Forms.Label lb_ConLai;

    }
}
