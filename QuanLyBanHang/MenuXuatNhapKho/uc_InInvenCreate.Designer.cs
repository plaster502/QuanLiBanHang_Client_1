namespace QuanLyBanHang.MenuXuatNhapKho
{
    partial class uc_InInvenCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_InInvenCreate));
            this.lb_MaPhieuNhap = new System.Windows.Forms.Label();
            this.txt_MaPhieuNhap = new System.Windows.Forms.TextBox();
            this.pn_Nav = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_NgayNhap = new System.Windows.Forms.Label();
            this.msk_NgayNhap = new System.Windows.Forms.MaskedTextBox();
            this.lb_NhanVien = new System.Windows.Forms.Label();
            this.txt_NhanVien = new System.Windows.Forms.TextBox();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.grb_ChiTietPhieu = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_SoLuong = new System.Windows.Forms.Label();
            this.lb_MaSanPham = new System.Windows.Forms.Label();
            this.txt_MaSanPham = new System.Windows.Forms.TextBox();
            this.lb_TenSanPham = new System.Windows.Forms.Label();
            this.txt_TenSanPham = new System.Windows.Forms.TextBox();
            this.lb_DonGia = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.btn_AddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.dgv_DanhSachChiTiet = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pn_Nav.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grb_ChiTietPhieu.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_MaPhieuNhap
            // 
            this.lb_MaPhieuNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_MaPhieuNhap.AutoSize = true;
            this.lb_MaPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_MaPhieuNhap.Location = new System.Drawing.Point(59, 11);
            this.lb_MaPhieuNhap.Name = "lb_MaPhieuNhap";
            this.lb_MaPhieuNhap.Size = new System.Drawing.Size(114, 20);
            this.lb_MaPhieuNhap.TabIndex = 0;
            this.lb_MaPhieuNhap.Text = "Mã phiếu nhập";
            // 
            // txt_MaPhieuNhap
            // 
            this.txt_MaPhieuNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaPhieuNhap.Location = new System.Drawing.Point(201, 8);
            this.txt_MaPhieuNhap.Name = "txt_MaPhieuNhap";
            this.txt_MaPhieuNhap.Size = new System.Drawing.Size(198, 26);
            this.txt_MaPhieuNhap.TabIndex = 1;
            // 
            // pn_Nav
            // 
            this.pn_Nav.Controls.Add(this.tableLayoutPanel1);
            this.pn_Nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Nav.Location = new System.Drawing.Point(0, 0);
            this.pn_Nav.Name = "pn_Nav";
            this.pn_Nav.Size = new System.Drawing.Size(756, 295);
            this.pn_Nav.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.97958F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.02042F));
            this.tableLayoutPanel1.Controls.Add(this.lb_MaPhieuNhap, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_NgayNhap, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_MaPhieuNhap, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.msk_NgayNhap, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_NhanVien, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_NhanVien, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_TongTien, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_TongTien, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.grb_ChiTietPhieu, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.34146F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.65854F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 295);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lb_NgayNhap
            // 
            this.lb_NgayNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_NgayNhap.AutoSize = true;
            this.lb_NgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_NgayNhap.Location = new System.Drawing.Point(429, 11);
            this.lb_NgayNhap.Name = "lb_NgayNhap";
            this.lb_NgayNhap.Size = new System.Drawing.Size(85, 20);
            this.lb_NgayNhap.TabIndex = 2;
            this.lb_NgayNhap.Text = "Ngày nhập";
            // 
            // msk_NgayNhap
            // 
            this.msk_NgayNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msk_NgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.msk_NgayNhap.Location = new System.Drawing.Point(537, 8);
            this.msk_NgayNhap.Mask = "00/00/0000";
            this.msk_NgayNhap.Name = "msk_NgayNhap";
            this.msk_NgayNhap.Size = new System.Drawing.Size(145, 26);
            this.msk_NgayNhap.TabIndex = 3;
            this.msk_NgayNhap.ValidatingType = typeof(System.DateTime);
            // 
            // lb_NhanVien
            // 
            this.lb_NhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_NhanVien.AutoSize = true;
            this.lb_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_NhanVien.Location = new System.Drawing.Point(77, 45);
            this.lb_NhanVien.Name = "lb_NhanVien";
            this.lb_NhanVien.Size = new System.Drawing.Size(79, 20);
            this.lb_NhanVien.TabIndex = 4;
            this.lb_NhanVien.Text = "Nhân viên";
            // 
            // txt_NhanVien
            // 
            this.txt_NhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NhanVien.Location = new System.Drawing.Point(201, 42);
            this.txt_NhanVien.Name = "txt_NhanVien";
            this.txt_NhanVien.Size = new System.Drawing.Size(198, 26);
            this.txt_NhanVien.TabIndex = 5;
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_TongTien.Location = new System.Drawing.Point(434, 45);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(75, 20);
            this.lb_TongTien.TabIndex = 6;
            this.lb_TongTien.Text = "Tổng tiền";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TongTien.Location = new System.Drawing.Point(537, 42);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(145, 26);
            this.txt_TongTien.TabIndex = 7;
            // 
            // grb_ChiTietPhieu
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.grb_ChiTietPhieu, 4);
            this.grb_ChiTietPhieu.Controls.Add(this.tableLayoutPanel2);
            this.grb_ChiTietPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_ChiTietPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_ChiTietPhieu.Location = new System.Drawing.Point(57, 77);
            this.grb_ChiTietPhieu.Name = "grb_ChiTietPhieu";
            this.grb_ChiTietPhieu.Size = new System.Drawing.Size(638, 170);
            this.grb_ChiTietPhieu.TabIndex = 8;
            this.grb_ChiTietPhieu.TabStop = false;
            this.grb_ChiTietPhieu.Text = "Chi tiết phiếu nhập";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.5493F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.4507F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.tableLayoutPanel2.Controls.Add(this.lb_SoLuong, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_MaSanPham, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_MaSanPham, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_TenSanPham, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_TenSanPham, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_DonGia, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_DonGia, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_SoLuong, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_AddProduct, 3, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(632, 145);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lb_SoLuong
            // 
            this.lb_SoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_SoLuong.AutoSize = true;
            this.lb_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_SoLuong.Location = new System.Drawing.Point(21, 62);
            this.lb_SoLuong.Name = "lb_SoLuong";
            this.lb_SoLuong.Size = new System.Drawing.Size(72, 20);
            this.lb_SoLuong.TabIndex = 5;
            this.lb_SoLuong.Text = "Số lượng";
            // 
            // lb_MaSanPham
            // 
            this.lb_MaSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_MaSanPham.AutoSize = true;
            this.lb_MaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_MaSanPham.Location = new System.Drawing.Point(5, 14);
            this.lb_MaSanPham.Name = "lb_MaSanPham";
            this.lb_MaSanPham.Size = new System.Drawing.Size(105, 20);
            this.lb_MaSanPham.TabIndex = 1;
            this.lb_MaSanPham.Text = "Mã sản phẩm";
            // 
            // txt_MaSanPham
            // 
            this.txt_MaSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaSanPham.Location = new System.Drawing.Point(118, 11);
            this.txt_MaSanPham.Name = "txt_MaSanPham";
            this.txt_MaSanPham.Size = new System.Drawing.Size(156, 26);
            this.txt_MaSanPham.TabIndex = 2;
            this.txt_MaSanPham.TextChanged += new System.EventHandler(this.txt_MaSach_TextChanged);
            // 
            // lb_TenSanPham
            // 
            this.lb_TenSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_TenSanPham.AutoSize = true;
            this.lb_TenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_TenSanPham.Location = new System.Drawing.Point(288, 4);
            this.lb_TenSanPham.Name = "lb_TenSanPham";
            this.lb_TenSanPham.Size = new System.Drawing.Size(70, 40);
            this.lb_TenSanPham.TabIndex = 3;
            this.lb_TenSanPham.Text = "Tên sản phẩm";
            // 
            // txt_TenSanPham
            // 
            this.txt_TenSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenSanPham.Location = new System.Drawing.Point(389, 11);
            this.txt_TenSanPham.Name = "txt_TenSanPham";
            this.txt_TenSanPham.Size = new System.Drawing.Size(223, 26);
            this.txt_TenSanPham.TabIndex = 4;
            this.txt_TenSanPham.TextChanged += new System.EventHandler(this.txt_TenSach_TextChanged);
            // 
            // lb_DonGia
            // 
            this.lb_DonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_DonGia.AutoSize = true;
            this.lb_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_DonGia.Location = new System.Drawing.Point(291, 62);
            this.lb_DonGia.Name = "lb_DonGia";
            this.lb_DonGia.Size = new System.Drawing.Size(64, 20);
            this.lb_DonGia.TabIndex = 7;
            this.lb_DonGia.Text = "Đơn giá";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_DonGia.Location = new System.Drawing.Point(389, 59);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(223, 26);
            this.txt_DonGia.TabIndex = 8;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SoLuong.Location = new System.Drawing.Point(118, 59);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(156, 26);
            this.txt_SoLuong.TabIndex = 6;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_AddProduct.Appearance.Options.UseFont = true;
            this.btn_AddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddProduct.Image")));
            this.btn_AddProduct.Location = new System.Drawing.Point(432, 99);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(197, 33);
            this.btn_AddProduct.TabIndex = 8;
            this.btn_AddProduct.Text = "Thêm sách vào phiếu";
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 4);
            this.panel1.Controls.Add(this.btn_Luu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(57, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 39);
            this.panel1.TabIndex = 9;
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
            this.btn_Luu.Size = new System.Drawing.Size(94, 33);
            this.btn_Luu.TabIndex = 0;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
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
            this.dgv_DanhSachChiTiet.Location = new System.Drawing.Point(0, 295);
            this.dgv_DanhSachChiTiet.Name = "dgv_DanhSachChiTiet";
            this.dgv_DanhSachChiTiet.Size = new System.Drawing.Size(756, 40);
            this.dgv_DanhSachChiTiet.TabIndex = 3;
            this.dgv_DanhSachChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachChiTiet_CellClick);
            this.dgv_DanhSachChiTiet.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_DanhSachChiTiet_RowPrePaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
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
            // uc_InInvenCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dgv_DanhSachChiTiet);
            this.Controls.Add(this.pn_Nav);
            this.Name = "uc_InInvenCreate";
            this.Size = new System.Drawing.Size(756, 335);
            this.Load += new System.EventHandler(this.uc_InInvenCreate_Load);
            this.pn_Nav.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grb_ChiTietPhieu.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_MaPhieuNhap;
        private System.Windows.Forms.TextBox txt_MaPhieuNhap;
        private System.Windows.Forms.Panel pn_Nav;
        private System.Windows.Forms.DataGridView dgv_DanhSachChiTiet;
        private System.Windows.Forms.Label lb_NgayNhap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MaskedTextBox msk_NgayNhap;
        private System.Windows.Forms.Label lb_NhanVien;
        private System.Windows.Forms.TextBox txt_NhanVien;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.GroupBox grb_ChiTietPhieu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lb_MaSanPham;
        private System.Windows.Forms.TextBox txt_MaSanPham;
        private System.Windows.Forms.Label lb_TenSanPham;
        private System.Windows.Forms.TextBox txt_TenSanPham;
        private System.Windows.Forms.Label lb_SoLuong;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label lb_DonGia;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_AddProduct;
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
