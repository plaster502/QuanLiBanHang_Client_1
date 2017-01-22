namespace QuanLyBanHang.MenuBanHang
{
    partial class uc_OrderCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_OrderCreate));
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_MaDonHang = new System.Windows.Forms.Label();
            this.txt_MaDonHang = new System.Windows.Forms.TextBox();
            this.grb_ChiTietBaoGia = new System.Windows.Forms.GroupBox();
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
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.txt_NhanVien = new System.Windows.Forms.TextBox();
            this.msk_NgayDat = new System.Windows.Forms.MaskedTextBox();
            this.lb_NhanVien = new System.Windows.Forms.Label();
            this.lb_NgayDat = new System.Windows.Forms.Label();
            this.txt_KhachHang = new System.Windows.Forms.TextBox();
            this.lb_KhachHang = new System.Windows.Forms.Label();
            this.pn_Nav = new System.Windows.Forms.Panel();
            this.dgv_DanhSachChiTiet = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.grb_ChiTietBaoGia.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pn_Nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Xoá";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 435;
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_TongTien.Location = new System.Drawing.Point(456, 84);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(75, 20);
            this.lb_TongTien.TabIndex = 6;
            this.lb_TongTien.Text = "Tổng tiền";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.97958F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.02042F));
            this.tableLayoutPanel1.Controls.Add(this.lb_MaDonHang, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_MaDonHang, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.grb_ChiTietBaoGia, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_TongTien, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_TongTien, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_NhanVien, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.msk_NgayDat, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_NhanVien, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_NgayDat, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_KhachHang, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_KhachHang, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.35135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.64865F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(824, 344);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lb_MaDonHang
            // 
            this.lb_MaDonHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_MaDonHang.AutoSize = true;
            this.lb_MaDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_MaDonHang.Location = new System.Drawing.Point(99, 13);
            this.lb_MaDonHang.Name = "lb_MaDonHang";
            this.lb_MaDonHang.Size = new System.Drawing.Size(102, 20);
            this.lb_MaDonHang.TabIndex = 0;
            this.lb_MaDonHang.Text = "Mã đơn hàng";
            // 
            // txt_MaDonHang
            // 
            this.txt_MaDonHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaDonHang.Location = new System.Drawing.Point(223, 10);
            this.txt_MaDonHang.Name = "txt_MaDonHang";
            this.txt_MaDonHang.Size = new System.Drawing.Size(198, 26);
            this.txt_MaDonHang.TabIndex = 1;
            // 
            // grb_ChiTietBaoGia
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.grb_ChiTietBaoGia, 4);
            this.grb_ChiTietBaoGia.Controls.Add(this.tableLayoutPanel2);
            this.grb_ChiTietBaoGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_ChiTietBaoGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_ChiTietBaoGia.Location = new System.Drawing.Point(91, 116);
            this.grb_ChiTietBaoGia.Name = "grb_ChiTietBaoGia";
            this.grb_ChiTietBaoGia.Size = new System.Drawing.Size(638, 181);
            this.grb_ChiTietBaoGia.TabIndex = 8;
            this.grb_ChiTietBaoGia.TabStop = false;
            this.grb_ChiTietBaoGia.Text = "Chi tiết báo giá";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.5493F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.4507F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 269F));
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(632, 156);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lb_SoLuong
            // 
            this.lb_SoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_SoLuong.AutoSize = true;
            this.lb_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_SoLuong.Location = new System.Drawing.Point(20, 69);
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
            this.lb_MaSanPham.Location = new System.Drawing.Point(3, 16);
            this.lb_MaSanPham.Name = "lb_MaSanPham";
            this.lb_MaSanPham.Size = new System.Drawing.Size(105, 20);
            this.lb_MaSanPham.TabIndex = 1;
            this.lb_MaSanPham.Text = "Mã sản phẩm";
            // 
            // txt_MaSanPham
            // 
            this.txt_MaSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaSanPham.Location = new System.Drawing.Point(115, 13);
            this.txt_MaSanPham.Name = "txt_MaSanPham";
            this.txt_MaSanPham.Size = new System.Drawing.Size(151, 26);
            this.txt_MaSanPham.TabIndex = 2;
            this.txt_MaSanPham.TextChanged += new System.EventHandler(this.txt_MaSanPham_TextChanged);
            // 
            // lb_TenSanPham
            // 
            this.lb_TenSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_TenSanPham.AutoSize = true;
            this.lb_TenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_TenSanPham.Location = new System.Drawing.Point(280, 6);
            this.lb_TenSanPham.Name = "lb_TenSanPham";
            this.lb_TenSanPham.Size = new System.Drawing.Size(70, 40);
            this.lb_TenSanPham.TabIndex = 3;
            this.lb_TenSanPham.Text = "Tên sản phẩm";
            // 
            // txt_TenSanPham
            // 
            this.txt_TenSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenSanPham.Location = new System.Drawing.Point(385, 13);
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
            this.lb_DonGia.Location = new System.Drawing.Point(283, 69);
            this.lb_DonGia.Name = "lb_DonGia";
            this.lb_DonGia.Size = new System.Drawing.Size(64, 20);
            this.lb_DonGia.TabIndex = 7;
            this.lb_DonGia.Text = "Đơn giá";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_DonGia.Location = new System.Drawing.Point(385, 66);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(223, 26);
            this.txt_DonGia.TabIndex = 8;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SoLuong.Location = new System.Drawing.Point(115, 66);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(151, 26);
            this.txt_SoLuong.TabIndex = 6;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_AddProduct.Appearance.Options.UseFont = true;
            this.btn_AddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddProduct.Image")));
            this.btn_AddProduct.Location = new System.Drawing.Point(465, 109);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(164, 33);
            this.btn_AddProduct.TabIndex = 8;
            this.btn_AddProduct.Text = "Thêm sản phẩm";
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 4);
            this.panel1.Controls.Add(this.btn_Luu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(91, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 38);
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
            // txt_TongTien
            // 
            this.txt_TongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TongTien.Location = new System.Drawing.Point(559, 81);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(170, 26);
            this.txt_TongTien.TabIndex = 7;
            // 
            // txt_NhanVien
            // 
            this.txt_NhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NhanVien.Location = new System.Drawing.Point(224, 45);
            this.txt_NhanVien.Name = "txt_NhanVien";
            this.txt_NhanVien.Size = new System.Drawing.Size(195, 26);
            this.txt_NhanVien.TabIndex = 5;
            // 
            // msk_NgayDat
            // 
            this.msk_NgayDat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msk_NgayDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.msk_NgayDat.Location = new System.Drawing.Point(559, 10);
            this.msk_NgayDat.Mask = "00/00/0000";
            this.msk_NgayDat.Name = "msk_NgayDat";
            this.msk_NgayDat.Size = new System.Drawing.Size(170, 26);
            this.msk_NgayDat.TabIndex = 3;
            this.msk_NgayDat.ValidatingType = typeof(System.DateTime);
            // 
            // lb_NhanVien
            // 
            this.lb_NhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_NhanVien.AutoSize = true;
            this.lb_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_NhanVien.Location = new System.Drawing.Point(111, 48);
            this.lb_NhanVien.Name = "lb_NhanVien";
            this.lb_NhanVien.Size = new System.Drawing.Size(79, 20);
            this.lb_NhanVien.TabIndex = 4;
            this.lb_NhanVien.Text = "Nhân viên";
            // 
            // lb_NgayDat
            // 
            this.lb_NgayDat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_NgayDat.AutoSize = true;
            this.lb_NgayDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_NgayDat.Location = new System.Drawing.Point(457, 13);
            this.lb_NgayDat.Name = "lb_NgayDat";
            this.lb_NgayDat.Size = new System.Drawing.Size(72, 20);
            this.lb_NgayDat.TabIndex = 2;
            this.lb_NgayDat.Text = "Ngày đặt";
            // 
            // txt_KhachHang
            // 
            this.txt_KhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_KhachHang.Location = new System.Drawing.Point(559, 45);
            this.txt_KhachHang.Name = "txt_KhachHang";
            this.txt_KhachHang.Size = new System.Drawing.Size(170, 26);
            this.txt_KhachHang.TabIndex = 10;
            // 
            // lb_KhachHang
            // 
            this.lb_KhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_KhachHang.AutoSize = true;
            this.lb_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_KhachHang.Location = new System.Drawing.Point(446, 48);
            this.lb_KhachHang.Name = "lb_KhachHang";
            this.lb_KhachHang.Size = new System.Drawing.Size(94, 20);
            this.lb_KhachHang.TabIndex = 11;
            this.lb_KhachHang.Text = "Khách hàng";
            // 
            // pn_Nav
            // 
            this.pn_Nav.Controls.Add(this.tableLayoutPanel1);
            this.pn_Nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Nav.Location = new System.Drawing.Point(0, 0);
            this.pn_Nav.Name = "pn_Nav";
            this.pn_Nav.Size = new System.Drawing.Size(824, 344);
            this.pn_Nav.TabIndex = 6;
            // 
            // dgv_DanhSachChiTiet
            // 
            this.dgv_DanhSachChiTiet.AllowUserToAddRows = false;
            this.dgv_DanhSachChiTiet.AllowUserToDeleteRows = false;
            this.dgv_DanhSachChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Delete});
            this.dgv_DanhSachChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachChiTiet.Location = new System.Drawing.Point(0, 344);
            this.dgv_DanhSachChiTiet.Name = "dgv_DanhSachChiTiet";
            this.dgv_DanhSachChiTiet.Size = new System.Drawing.Size(824, 68);
            this.dgv_DanhSachChiTiet.TabIndex = 7;
            this.dgv_DanhSachChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachChiTiet_CellClick);
            this.dgv_DanhSachChiTiet.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_DanhSachChiTiet_RowPrePaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 391;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Xoá";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 390;
            // 
            // uc_OrderCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_DanhSachChiTiet);
            this.Controls.Add(this.pn_Nav);
            this.Name = "uc_OrderCreate";
            this.Size = new System.Drawing.Size(824, 412);
            this.Load += new System.EventHandler(this.uc_OrderCreate_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grb_ChiTietBaoGia.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pn_Nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_MaDonHang;
        private System.Windows.Forms.TextBox txt_MaDonHang;
        private System.Windows.Forms.GroupBox grb_ChiTietBaoGia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lb_SoLuong;
        private System.Windows.Forms.Label lb_MaSanPham;
        private System.Windows.Forms.TextBox txt_MaSanPham;
        private System.Windows.Forms.Label lb_TenSanPham;
        private System.Windows.Forms.TextBox txt_TenSanPham;
        private System.Windows.Forms.Label lb_DonGia;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private DevExpress.XtraEditors.SimpleButton btn_AddProduct;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.TextBox txt_NhanVien;
        private System.Windows.Forms.Label lb_NhanVien;
        private System.Windows.Forms.Label lb_NgayDat;
        private System.Windows.Forms.MaskedTextBox msk_NgayDat;
        private System.Windows.Forms.Panel pn_Nav;
        private System.Windows.Forms.DataGridView dgv_DanhSachChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.TextBox txt_KhachHang;
        private System.Windows.Forms.Label lb_KhachHang;
    }
}
