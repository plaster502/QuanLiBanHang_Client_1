namespace QuanLyBanHang.MenuXuatNhapKho
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
            this.txt_SoLuongTX = new System.Windows.Forms.TextBox();
            this.lb_SoLuongTX = new System.Windows.Forms.Label();
            this.lb_SoLuongYC = new System.Windows.Forms.Label();
            this.lb_MaSanPham = new System.Windows.Forms.Label();
            this.txt_MaSanPham = new System.Windows.Forms.TextBox();
            this.lb_TenSanPham = new System.Windows.Forms.Label();
            this.txt_TenSanPham = new System.Windows.Forms.TextBox();
            this.lb_DonGia = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_SoLuongYC = new System.Windows.Forms.TextBox();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.grb_ChiTietPhieu = new System.Windows.Forms.GroupBox();
            this.lb_MaPhieuXuat = new System.Windows.Forms.Label();
            this.txt_MaPhieuXuat = new System.Windows.Forms.TextBox();
            this.pn_Nav = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_NgayXuat = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.msk_NgayXuat = new System.Windows.Forms.MaskedTextBox();
            this.lb_NhanVien = new System.Windows.Forms.Label();
            this.txt_NhanVien = new System.Windows.Forms.TextBox();
            this.lb_KhachHang = new System.Windows.Forms.Label();
            this.txt_KhachHang = new System.Windows.Forms.TextBox();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.txt_HoaDon = new System.Windows.Forms.TextBox();
            this.lb_HoaDon = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachChiTiet)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grb_ChiTietPhieu.SuspendLayout();
            this.pn_Nav.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel2.Controls.Add(this.txt_SoLuongTX, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_SoLuongTX, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_SoLuongYC, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_MaSanPham, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_MaSanPham, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_TenSanPham, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_TenSanPham, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_DonGia, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_DonGia, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_SoLuongYC, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_Add, 3, 2);
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
            // txt_SoLuongTX
            // 
            this.txt_SoLuongTX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SoLuongTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SoLuongTX.Location = new System.Drawing.Point(137, 94);
            this.txt_SoLuongTX.Name = "txt_SoLuongTX";
            this.txt_SoLuongTX.Size = new System.Drawing.Size(158, 26);
            this.txt_SoLuongTX.TabIndex = 10;
            // 
            // lb_SoLuongTX
            // 
            this.lb_SoLuongTX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_SoLuongTX.AutoSize = true;
            this.lb_SoLuongTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_SoLuongTX.Location = new System.Drawing.Point(10, 97);
            this.lb_SoLuongTX.Name = "lb_SoLuongTX";
            this.lb_SoLuongTX.Size = new System.Drawing.Size(106, 20);
            this.lb_SoLuongTX.TabIndex = 9;
            this.lb_SoLuongTX.Text = "Số lượng xuất";
            // 
            // lb_SoLuongYC
            // 
            this.lb_SoLuongYC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_SoLuongYC.AutoSize = true;
            this.lb_SoLuongYC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_SoLuongYC.Location = new System.Drawing.Point(27, 51);
            this.lb_SoLuongYC.Name = "lb_SoLuongYC";
            this.lb_SoLuongYC.Size = new System.Drawing.Size(72, 20);
            this.lb_SoLuongYC.TabIndex = 5;
            this.lb_SoLuongYC.Text = "Số lượng";
            // 
            // lb_MaSanPham
            // 
            this.lb_MaSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_MaSanPham.AutoSize = true;
            this.lb_MaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_MaSanPham.Location = new System.Drawing.Point(11, 10);
            this.lb_MaSanPham.Name = "lb_MaSanPham";
            this.lb_MaSanPham.Size = new System.Drawing.Size(105, 20);
            this.lb_MaSanPham.TabIndex = 1;
            this.lb_MaSanPham.Text = "Mã sản phẩm";
            // 
            // txt_MaSanPham
            // 
            this.txt_MaSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaSanPham.Location = new System.Drawing.Point(137, 7);
            this.txt_MaSanPham.Name = "txt_MaSanPham";
            this.txt_MaSanPham.Size = new System.Drawing.Size(158, 26);
            this.txt_MaSanPham.TabIndex = 2;
            this.txt_MaSanPham.TextChanged += new System.EventHandler(this.txt_MaSanPham_TextChanged);
            // 
            // lb_TenSanPham
            // 
            this.lb_TenSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_TenSanPham.AutoSize = true;
            this.lb_TenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_TenSanPham.Location = new System.Drawing.Point(309, 10);
            this.lb_TenSanPham.Name = "lb_TenSanPham";
            this.lb_TenSanPham.Size = new System.Drawing.Size(110, 20);
            this.lb_TenSanPham.TabIndex = 3;
            this.lb_TenSanPham.Text = "Tên sản phẩm";
            // 
            // txt_TenSanPham
            // 
            this.txt_TenSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenSanPham.Location = new System.Drawing.Point(432, 7);
            this.txt_TenSanPham.Name = "txt_TenSanPham";
            this.txt_TenSanPham.Size = new System.Drawing.Size(223, 26);
            this.txt_TenSanPham.TabIndex = 4;
            this.txt_TenSanPham.TextChanged += new System.EventHandler(this.txt_TenSanPham_TextChanged);
            // 
            // lb_DonGia
            // 
            this.lb_DonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_DonGia.AutoSize = true;
            this.lb_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_DonGia.Location = new System.Drawing.Point(332, 51);
            this.lb_DonGia.Name = "lb_DonGia";
            this.lb_DonGia.Size = new System.Drawing.Size(64, 20);
            this.lb_DonGia.TabIndex = 7;
            this.lb_DonGia.Text = "Đơn giá";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_DonGia.Location = new System.Drawing.Point(432, 48);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(223, 26);
            this.txt_DonGia.TabIndex = 8;
            // 
            // txt_SoLuongYC
            // 
            this.txt_SoLuongYC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SoLuongYC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SoLuongYC.Location = new System.Drawing.Point(137, 48);
            this.txt_SoLuongYC.Name = "txt_SoLuongYC";
            this.txt_SoLuongYC.Size = new System.Drawing.Size(158, 26);
            this.txt_SoLuongYC.TabIndex = 6;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Add.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.Location = new System.Drawing.Point(441, 90);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(220, 33);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Thêm sản phẩm";
            this.btn_Add.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TongTien.Location = new System.Drawing.Point(516, 129);
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
            this.grb_ChiTietPhieu.Text = "Chi tiết phiếu xuất";
            // 
            // lb_MaPhieuXuat
            // 
            this.lb_MaPhieuXuat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_MaPhieuXuat.AutoSize = true;
            this.lb_MaPhieuXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_MaPhieuXuat.Location = new System.Drawing.Point(50, 12);
            this.lb_MaPhieuXuat.Name = "lb_MaPhieuXuat";
            this.lb_MaPhieuXuat.Size = new System.Drawing.Size(108, 20);
            this.lb_MaPhieuXuat.TabIndex = 0;
            this.lb_MaPhieuXuat.Text = "Mã phiếu xuất";
            // 
            // txt_MaPhieuXuat
            // 
            this.txt_MaPhieuXuat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaPhieuXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaPhieuXuat.Location = new System.Drawing.Point(174, 9);
            this.txt_MaPhieuXuat.Name = "txt_MaPhieuXuat";
            this.txt_MaPhieuXuat.Size = new System.Drawing.Size(198, 26);
            this.txt_MaPhieuXuat.TabIndex = 1;
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
            this.tableLayoutPanel1.Controls.Add(this.lb_MaPhieuXuat, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_NgayXuat, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_MaPhieuXuat, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_DiaChi, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.msk_NgayXuat, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_NhanVien, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_NhanVien, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.grb_ChiTietPhieu, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_KhachHang, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_KhachHang, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_TongTien, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_TongTien, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_HoaDon, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_HoaDon, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_DiaChi, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
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
            this.lb_NgayXuat.Location = new System.Drawing.Point(403, 12);
            this.lb_NgayXuat.Name = "lb_NgayXuat";
            this.lb_NgayXuat.Size = new System.Drawing.Size(79, 20);
            this.lb_NgayXuat.TabIndex = 2;
            this.lb_NgayXuat.Text = "Ngày xuất";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_DiaChi.Location = new System.Drawing.Point(59, 90);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(91, 20);
            this.lb_DiaChi.TabIndex = 14;
            this.lb_DiaChi.Text = "Địa chỉ giao";
            // 
            // msk_NgayXuat
            // 
            this.msk_NgayXuat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msk_NgayXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.msk_NgayXuat.Location = new System.Drawing.Point(539, 9);
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
            this.lb_NhanVien.Location = new System.Drawing.Point(65, 48);
            this.lb_NhanVien.Name = "lb_NhanVien";
            this.lb_NhanVien.Size = new System.Drawing.Size(79, 20);
            this.lb_NhanVien.TabIndex = 4;
            this.lb_NhanVien.Text = "Nhân viên";
            // 
            // txt_NhanVien
            // 
            this.txt_NhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NhanVien.Location = new System.Drawing.Point(174, 45);
            this.txt_NhanVien.Name = "txt_NhanVien";
            this.txt_NhanVien.Size = new System.Drawing.Size(198, 26);
            this.txt_NhanVien.TabIndex = 5;
            // 
            // lb_KhachHang
            // 
            this.lb_KhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_KhachHang.AutoSize = true;
            this.lb_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_KhachHang.Location = new System.Drawing.Point(395, 48);
            this.lb_KhachHang.Name = "lb_KhachHang";
            this.lb_KhachHang.Size = new System.Drawing.Size(94, 20);
            this.lb_KhachHang.TabIndex = 10;
            this.lb_KhachHang.Text = "Khách hàng";
            // 
            // txt_KhachHang
            // 
            this.txt_KhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_KhachHang.Location = new System.Drawing.Point(512, 45);
            this.txt_KhachHang.Name = "txt_KhachHang";
            this.txt_KhachHang.Size = new System.Drawing.Size(198, 26);
            this.txt_KhachHang.TabIndex = 12;
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_TongTien.Location = new System.Drawing.Point(405, 132);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(75, 20);
            this.lb_TongTien.TabIndex = 6;
            this.lb_TongTien.Text = "Tổng tiền";
            // 
            // txt_HoaDon
            // 
            this.txt_HoaDon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_HoaDon.Location = new System.Drawing.Point(175, 129);
            this.txt_HoaDon.Name = "txt_HoaDon";
            this.txt_HoaDon.Size = new System.Drawing.Size(197, 26);
            this.txt_HoaDon.TabIndex = 15;
            // 
            // lb_HoaDon
            // 
            this.lb_HoaDon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_HoaDon.AutoSize = true;
            this.lb_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_HoaDon.Location = new System.Drawing.Point(69, 132);
            this.lb_HoaDon.Name = "lb_HoaDon";
            this.lb_HoaDon.Size = new System.Drawing.Size(70, 20);
            this.lb_HoaDon.TabIndex = 16;
            this.lb_HoaDon.Text = "Hóa đơn";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_DiaChi, 3);
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_DiaChi.Location = new System.Drawing.Point(175, 87);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(535, 26);
            this.txt_DiaChi.TabIndex = 14;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridView dgv_DanhSachChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_MaPhieuXuat;
        private System.Windows.Forms.Label lb_NgayXuat;
        private System.Windows.Forms.TextBox txt_MaPhieuXuat;
        private System.Windows.Forms.MaskedTextBox msk_NgayXuat;
        private System.Windows.Forms.Label lb_NhanVien;
        private System.Windows.Forms.TextBox txt_NhanVien;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.GroupBox grb_ChiTietPhieu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lb_SoLuongYC;
        private System.Windows.Forms.Label lb_MaSanPham;
        private System.Windows.Forms.TextBox txt_MaSanPham;
        private System.Windows.Forms.Label lb_TenSanPham;
        private System.Windows.Forms.TextBox txt_TenSanPham;
        private System.Windows.Forms.Label lb_DonGia;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_SoLuongYC;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private System.Windows.Forms.Panel pn_Nav;
        private System.Windows.Forms.Label lb_KhachHang;
        private System.Windows.Forms.TextBox txt_KhachHang;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.TextBox txt_HoaDon;
        private System.Windows.Forms.Label lb_HoaDon;
        private System.Windows.Forms.TextBox txt_SoLuongTX;
        private System.Windows.Forms.Label lb_SoLuongTX;
    }
}
