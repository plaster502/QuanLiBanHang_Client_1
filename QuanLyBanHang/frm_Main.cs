using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
//Service references
using QuanLyBanHang.BanHangService;
//Menu references
using QuanLyBanHang.MenuHeThong;
using QuanLyBanHang.MenuDanhMuc;
using QuanLyBanHang.MenuNhanVien;
using System.Collections.Generic;

namespace QuanLyBanHang
{
    public partial class frm_Main : Form
    {
        string userid = "";
        List<NhanNgonNgu> language = new List<NhanNgonNgu>();

        #region Contructor
        public frm_Main()
        {
            InitializeComponent();
        }
        public frm_Main(string _User,List<NhanNgonNgu> labellist)
        {
            userid = _User;
            language = labellist;
            InitializeComponent();
        }
        #endregion

        // Form Event
        private void frm_Main_Load(object sender, EventArgs e)
        {
            LoadTotalReport();
            LoadLanguage();
        }

        #region 1.Hệ Thống
        // 1.1. Thông tin đơn vị
        private void ni_ThongTinDonVi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uc_UnitInfo uc = new uc_UnitInfo();
            LoadTab("Thông tin đơn vị", uc);
        }
        // 1.2. Thông tin người dùng
        private void ni_ThongTinTaiKhoan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uc_UserInfo uc = new uc_UserInfo(userid);
            LoadTab("Thông tin tài khoản", uc);
        }
        // 1.3. Trợ giúp
        private void ni_TroGiup_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uc_Support uc = new uc_Support();
            LoadTab("Trợ giúp", uc);
        }
        // 1.4. Đăng xuất
        private void ni_DangXuat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_Login lgi = new frm_Login();
            lgi.Show();
            this.Close();
        }
        // 1.5. Thoát
        private void ni_Thoat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region 2.Danh mục
        // 2.1. Sản phẩm
        private void ni_SanPham_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uc_Product uc = new uc_Product();
            LoadTab("Sản phẩm", uc);
        }
        // 2.2. Nhóm sản phẩm
        private void ni_NhomSanPham_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uc_ProductGroup uc = new uc_ProductGroup();
            LoadTab("Nhóm sản phẩm", uc);
        }
        // 2.3. Đơn vị tính
        private void ni_DonViTinh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uc_ProductUnit uc = new uc_ProductUnit();
            LoadTab("Đơn vị tính", uc);
        }
        #endregion

        #region 3.Nhân viên
        //3.1. Danh sách nhân viên
        private void ni_DanhSachNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uc_StaffList uc = new uc_StaffList();
            LoadTab("Danh sách nhân viên", uc);
        }
        #endregion

        #region 4.Bán hàng
        //4.1. Báo giá
        private void ni_BaoGia_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            QuanLyBanHang.MenuBanHang.uc_QuoteList uc = new QuanLyBanHang.MenuBanHang.uc_QuoteList();
            LoadTab("Danh sách báo giá", uc);
        }
        //4.2. Đơn hàng
        private void ni_PhieuDatHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            QuanLyBanHang.MenuBanHang.uc_OrderList uc = new MenuBanHang.uc_OrderList();
            LoadTab("Danh sách đơn hàng", uc);
        }
        //4.3. Hoá đơn
        private void ni_HoaDon_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            QuanLyBanHang.MenuBanHang.uc_SellingInvoiceList uc = new MenuBanHang.uc_SellingInvoiceList();
            LoadTab("Danh sách hoá đơn", uc);
        }
        #endregion

        #region 5.Xuất-Nhập kho
        // 5.1. Phiếu nhập
        private void ni_PhieuNhap_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            QuanLyBanHang.MenuXuatNhapKho.uc_InInvenList uc = new MenuXuatNhapKho.uc_InInvenList();
            LoadTab("Danh sách phiếu nhập", uc);
        }
        // 5.2. Phiếu xuất
        private void ni_PhieuXuat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //QuanLyBanSach.MenuXuatNhapKho.uc_OutInvenList uc = new MenuXuatNhapKho.uc_OutInvenList();
            //LoadTab("Danh sách hoá đơn", uc);
        }
        #endregion

        #region 6.Công nợ
        // 6.1. Khách hàng
        private void ni_KhachHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //QuanLyBanSach.MenuCongNo.uc_Customer uc = new MenuCongNo.uc_Customer();
            //LoadTab("Khách hàng", uc);
        }
        // 6.2. Thông tin công nợ
        private void ni_ThongTinCongNo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //QuanLyBanSach.MenuCongNo.uc_Owe uc = new MenuCongNo.uc_Owe();
            //LoadTab("Thông tin công nợ", uc);
        }
        // 6.3. Phiếu thu
        private void ni_DanhSachPhieuThu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //QuanLyBanSach.MenuCongNo.uc_ReceiptList uc = new MenuCongNo.uc_ReceiptList();
            //LoadTab("Danh sách phiếu thu", uc);
        }
        #endregion

        #region 7.Thống kê
        // 7.1. Báo cáo tồn kho
        private void ni_BaoCaoTonKho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //QuanLyBanSach.MenuThongKe.uc_InventoryReport uc = new MenuThongKe.uc_InventoryReport();
            //LoadTab("Báo cáo tồn kho", uc);
        }
        // 7.2. Báo cáo công nợ
        private void ni_BaoCaoCongNo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //QuanLyBanSach.MenuThongKe.uc_OweReport uc = new MenuThongKe.uc_OweReport();
            //LoadTab("Báo cáo công nợ", uc);
        }
        // 7.3. Khoá sổ
        private void ni_KhoaSo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //QuanLyBanSach.MenuThongKe.uc_OweReport uc = new MenuThongKe.uc_OweReport();
            //LoadTab("Báo cáo công nợ", uc);
        }
        #endregion


        #region Tab menu
        //Load tab menu
        public void LoadTab(string nametab, UserControl control)
        {
            try
            {
                nametab += "        ";
                foreach (TabPage page in tabCtrl_Main.TabPages)
                {
                    if (page.Text == nametab)
                    {
                        tabCtrl_Main.TabPages.Remove(page);
                    }
                }
                TabPage pagenew = new TabPage();
                pagenew.Text = nametab;
                pagenew.Controls.Add(control);
                control.Dock = DockStyle.Fill;
                tabCtrl_Main.TabPages.Add(pagenew);
                tabCtrl_Main.SelectedTab = pagenew;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load tab '" + nametab + "' bị lỗi: " + ex);
            }
        }
        // Nút tắt tab
        private void tabCtrl_Main_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != 0)
            {
                e.Graphics.DrawImage(Properties.Resources.close_but, new Rectangle(e.Bounds.Right - 17, e.Bounds.Top + 4, 13, 13));
            }
            e.Graphics.DrawString(this.tabCtrl_Main.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }
        private void tabCtrl_Main_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 1; i < this.tabCtrl_Main.TabPages.Count; i++)
            {
                Rectangle r = tabCtrl_Main.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 17, r.Top + 4, 13,13);
                if (closeButton.Contains(e.Location))
                {
                    this.tabCtrl_Main.TabPages.RemoveAt(i);
                    break;
                }
            }
        }
        #endregion

        //Load thông tin thống kê
        private void LoadTotalReport()
        {
            try
            {
                #region Thống kê phiếu nhập
                PhieuNhapClient phieunhap_client = new PhieuNhapClient();
                PhieuNhap pn = new PhieuNhap();
                pn.NgayNhap = DateTime.Today;
                DataTable dt = phieunhap_client.PhieuNhap_GetPhieuNhap(pn, "").Tables[0];
                lb_PhieuNhap1_SoPhieu_value.Text = dt.Rows.Count.ToString();
                decimal Tongtiennhap = 0;
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Tongtiennhap += Convert.ToDecimal(row["TongTien"]);
                    }
                }
                if (Tongtiennhap != 0)
                    lb_PhieuNhap1_Tien_value.Text = Tongtiennhap.ToString("#,##");
                else
                    lb_PhieuNhap1_Tien_value.Text = "0";
                pn = new PhieuNhap();
                dt = phieunhap_client.PhieuNhap_GetPhieuNhap(pn, " and Year(pns.NgayNhap) = " + DateTime.Today.Year + " and Month(pns.NgayNhap) = " + DateTime.Today.Month).Tables[0];
                lb_PhieuNhap2_SoPhieu_value.Text = dt.Rows.Count.ToString();
                Tongtiennhap = 0;
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Tongtiennhap += Convert.ToDecimal(row["TongTien"]);
                    }
                }
                if (Tongtiennhap != 0)
                    lb_PhieuNhap2_Tien_value.Text = Tongtiennhap.ToString("#,##");
                else
                    lb_PhieuNhap2_Tien_value.Text = "0";
                #endregion
                #region Thống kê phiếu xuất
                PhieuXuatClient phieuxuat_client = new PhieuXuatClient();
                PhieuXuat px = new PhieuXuat();
                px.NgayXuat = DateTime.Today;
                dt = phieuxuat_client.PhieuXuat_GetPhieuXuat(px, "").Tables[0];
                lb_PhieuXuat1_SoPhieu_value.Text = dt.Rows.Count.ToString();
                decimal Tongtienxuat = 0;
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Tongtienxuat += Convert.ToDecimal(row["TongTien"]);
                    }
                }
                if (Tongtienxuat != 0)
                    lb_PhieuXuat1_Tien_value.Text = Tongtienxuat.ToString("#,##");
                else
                    lb_PhieuXuat1_Tien_value.Text = "0";
                px = new PhieuXuat();
                dt = phieuxuat_client.PhieuXuat_GetPhieuXuat(px, " and Year(pxs.NgayXuat) = " + DateTime.Today.Year + " and Month(pxs.NgayXuat) = " + DateTime.Today.Month).Tables[0];
                lb_PhieuXuat2_SoPhieu_value.Text = dt.Rows.Count.ToString();
                Tongtienxuat = 0;
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Tongtienxuat += Convert.ToDecimal(row["TongTien"]);
                    }
                }
                if (Tongtienxuat != 0)
                    lb_PhieuXuat2_Tien_value.Text = Tongtienxuat.ToString("#,##");
                else
                    lb_PhieuXuat2_Tien_value.Text = "0";
                #endregion
                #region Thống kê hoá đơn - ghi nợ
                HoaDonClient hoadon_client = new HoaDonClient();
                HoaDon hd = new HoaDon();
                hd.NgayXuat = DateTime.Today;
                dt = hoadon_client.HoaDon_GetHoaDon(hd, "").Tables[0];
                lb_HoaDon1_SoHD_value.Text = dt.Rows.Count.ToString();
                Tongtienxuat = 0;
                decimal Tongtienno = 0;
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Tongtienxuat += Convert.ToDecimal(row["TongTien"]);
                        Tongtienno += Convert.ToDecimal(row["ConLai"]);
                    }
                }
                if (Tongtienxuat != 0)
                    lb_HoaDon1_DoanhThu_value.Text = Tongtienxuat.ToString("#,##");
                else
                    lb_HoaDon1_DoanhThu_value.Text = "0";
                if (Tongtienno != 0)
                    lb_SoNo_value.Text = Tongtienno.ToString("#,##");
                else
                    lb_SoNo_value.Text = "0";
                hd = new HoaDon();
                dt = hoadon_client.HoaDon_GetHoaDon(hd, " and Year(NgayXuat) = " + DateTime.Today.Year + " and Month(NgayXuat) = " + DateTime.Today.Month).Tables[0];
                lb_HoaDon2_SoHD_value.Text = dt.Rows.Count.ToString();
                Tongtienxuat = 0;
                Tongtienno = 0;
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Tongtienxuat += Convert.ToDecimal(row["TongTien"]);
                        Tongtienno += Convert.ToDecimal(row["ConLai"]);
                    }
                }
                if (Tongtienxuat != 0)
                    lb_HoaDon2_DoanhThu_value.Text = Tongtienxuat.ToString("#,##");
                else
                    lb_HoaDon2_DoanhThu_value.Text = "0";
                if (Tongtienno != 0)
                    lb_SoNo_Thang_value.Text = Tongtienno.ToString("#,##");
                else
                    lb_SoNo_Thang_value.Text = "0";
                #endregion
                #region Thống kê khách hàng
                KhachHangClient khachhang_client = new KhachHangClient();
                KhachHang kh = new KhachHang();
                //Đếm tổng số khách hàng
                dt = khachhang_client.KhachHang_GetKhachHang(kh,"").Tables[0];
                lb_KhachHang_Tong_value.Text = dt.Rows.Count.ToString();
                //Đếm số khách hàng còn nợ
                dt = khachhang_client.KhachHang_GetKhachHang(kh, " and SoNo > 0").Tables[0];
                lb_KhachHang_ConNo_value.Text = dt.Rows.Count.ToString();
                #endregion
                #region Thống kê nhân viên
                NhanVienClient nhanvien_client = new NhanVienClient();
                //Đếm số nv nam
                NhanVien nv = new NhanVien();
                nv.GioiTinh = "Nam";
                dt = nhanvien_client.NhanVien_GetNhanVien(nv,"").Tables[0];
                lb_NhanVien_Nam_value.Text = dt.Rows.Count.ToString();
                //Đếm số nv nữ
                nv = new NhanVien();
                nv.GioiTinh = "Nu";
                dt = nhanvien_client.NhanVien_GetNhanVien(nv,"").Tables[0];
                lb_NhanVien_Nu_value.Text = dt.Rows.Count.ToString();
                #endregion
                #region Thống kê phiếu thu - thanh toán nợ
                PhieuThuClient phieuthu_client = new PhieuThuClient();
                PhieuThu pt = new PhieuThu();
                pt.NgayThu = DateTime.Today;
                dt = phieuthu_client.PhieuThu_GetPhieuThu(pt,"").Tables[0];
                decimal TongTienThu = 0;
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        TongTienThu += Convert.ToDecimal(row["SoTienThu"]);
                    }
                }
                if (TongTienThu != 0)
                    lb_TienThu_value.Text = TongTienThu.ToString("#,##");
                else
                    lb_TienThu_value.Text = "0";
                pt = new PhieuThu();
                dt = phieuthu_client.PhieuThu_GetPhieuThu(pt," and Year(NgayThu) = " + DateTime.Today.Year + " and Month(NgayThu) = " + DateTime.Today.Month).Tables[0];
                TongTienThu = 0;
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        TongTienThu += Convert.ToDecimal(row["SoTienThu"]);
                    }
                }
                if (TongTienThu != 0)
                    lb_TienThu_Thang_value.Text = TongTienThu.ToString("#,##");
                else
                    lb_TienThu_Thang_value.Text = "0";
                #endregion
                #region Thống kê sản phẩm
                SanPhamClient sanpham_client = new SanPhamClient();
                SanPham sp = new SanPham();
                SanPham[] dssp = sanpham_client.SanPham_GetSanPham(sp, "");
                lb_MaSanPham_value.Text = dssp.Length.ToString();
                decimal tongsotonkho = 0;
                if (dssp.Length > 0)
                {
                    foreach (SanPham sanpham in dssp)
                    {
                        tongsotonkho += Convert.ToDecimal(sanpham.LuongTon);
                    }
                }
                lb_TongTon_value.Text = tongsotonkho.ToString();
                dssp = sanpham_client.SanPham_GetSanPham(sp," and SoLuongTon > 0");
                lb_ConHang_value.Text = dssp.Length.ToString();
                dssp = sanpham_client.SanPham_GetSanPham(sp," and SoLuongTon = 0");
                lb_HetHang_value.Text = dssp.Length.ToString();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Load form theo ngôn ngữ
        private void LoadLanguage()
        {
            NhanNgonNguClient clientnn = new NhanNgonNguClient();

            this.Text = language[2].Chu;

            #region report area
            grb_PhieuNhap.Text = language[3].Chu;
            lb_PhieuNhap1.Text = language[4].Chu;
            lb_PhieuNhap1_SoPhieu.Text = "- "+ language[5].Chu + ":";
            lb_PhieuNhap1_Tien.Text = "- " + language[6].Chu + ":";
            lb_PhieuNhap2.Text = language[7].Chu + ":"; 
            lb_PhieuNhap2_SoPhieu.Text = "- " + language[5].Chu + ":";
            lb_PhieuNhap2_Tien.Text = "- " + language[6].Chu + ":";

            grb_PhieuXuat.Text = language[8].Chu;
            lb_PhieuXuat1.Text = language[4].Chu + ":";
            lb_PhieuXuat1_SoPhieu.Text = "- " + language[5].Chu + ":";
            lb_PhieuXuat1_Tien.Text = "- " + language[6].Chu + ":";
            lb_PhieuXuat2.Text = language[7].Chu + ":";
            lb_PhieuXuat2_SoPhieu.Text = "- " + language[5].Chu + ":";
            lb_PhieuXuat2_Tien.Text = "- " + language[6].Chu + ":";

            grb_HoaDon.Text = language[9].Chu;
            lb_HoaDon1.Text = language[4].Chu + ":";
            lb_HoaDon1_SoHD.Text = "- " + language[10].Chu + ":";
            lb_HoaDon1_DoanhThu.Text = "- " + language[11].Chu + ":";
            lb_HoaDon2.Text = language[7].Chu + ":";
            lb_HoaDon2_SoHD.Text = "- " + language[10].Chu + ":";
            lb_HoaDon2_DoanhThu.Text = "- " + language[11].Chu + ":";

            grb_StaffCustomer.Text = language[13].Chu + " - " + language[12].Chu;
            lb_KhachHang.Text = language[13].Chu;
            lb_KhachHang_ConNo.Text = "- " + language[14].Chu + ":";
            lb_KhachHang_Tong.Text = "- " + language[15].Chu + ":";
            lb_NhanVien.Text = language[12].Chu;
            lb_NhanVien_Nam.Text = "- " + language[16].Chu + ":";
            lb_NhanVien_Nu.Text = "- " + language[17].Chu + ":";

            grb_CongNo.Text = language[18].Chu;
            lb_CongNo1.Text = language[4].Chu + ":";
            lb_CongNo2.Text = language[7].Chu + ":";
            lb_SoNo.Text = "- " + language[19].Chu + ":";
            lb_SoNo_Thang.Text = "- " + language[19].Chu + ":";
            lb_TienThu.Text = "- " + language[20].Chu + ":";
            lb_TienThu_Thang.Text = "- " + language[20].Chu + ":";

            grb_SanPham.Text = language[21].Chu;
            lb_MaSanPham.Text = language[22].Chu;
            lb_TongTon.Text = language[23].Chu;
            lb_ConHang.Text = "- " + language[24].Chu + ":";
            lb_HetHang.Text = "- " + language[25].Chu + ":";
            #endregion

            tab_MenuMain.Text = language[26].Chu + "     ";

            #region menu area
            ng_HeThong.Caption = "1. " + language[27].Chu;
            ni_ThongTinDonVi.Caption = "1.1. " + language[28].Chu;
            ni_ThongTinTaiKhoan.Caption = "1.2. " + language[29].Chu;
            ni_TroGiup.Caption = "1.3. " + language[30].Chu;
            ni_DangXuat.Caption = "1.4. " + language[31].Chu;
            ni_Thoat.Caption = "1.5 ." + language[1].Chu;

            ng_DanhMuc.Caption = "2. " + language[32].Chu;
            ni_SanPham.Caption = "2.1. " + language[21].Chu;
            ni_NhomSanPham.Caption = "2.2. " + language[33].Chu;
            ni_DonViTinh.Caption = "2.3. " + language[34].Chu;

            ng_NhanVien.Caption = "3. " + language[12].Chu;
            ni_DanhSachNhanVien.Caption = "3.1. " + language[35].Chu;

            ng_BanHang.Caption = "4. " + language[36].Chu;
            ni_BaoGia.Caption = "4.1. " + language[37].Chu;
            ni_PhieuDatHang.Caption = "4.2. " + language[38].Chu;
            ni_HoaDon.Caption = "4.3. " + language[9].Chu;

            ng_XuatNhapKho.Caption = "5. " + language[39].Chu;
            ni_PhieuNhap.Caption = "5.1. " + language[3].Chu;
            ni_PhieuXuat.Caption = "5.2. " + language[8].Chu;

            ng_CongNo.Caption = "6. " + language[18].Chu;
            ni_KhachHang.Caption = "6.1. " + language[13].Chu;
            ni_ThongTinCongNo.Caption = "6.2. " + language[40].Chu;
            ni_DanhSachPhieuThu.Caption = "6.3. " + language[41].Chu;

            ng_ThongKe.Caption = "7. " + language[42].Chu;
            ni_BaoCaoCongNo.Caption = "7.1. " + language[43].Chu;
            ni_BaoCaoTonKho.Caption = "7.2. " + language[44].Chu;
            ni_KhoaSoThang.Caption = "7.3. " + language[45].Chu;
            #endregion
        }

    }
}
;