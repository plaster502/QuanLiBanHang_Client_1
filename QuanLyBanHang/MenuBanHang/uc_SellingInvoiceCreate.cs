﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyBanHang.BanHangService;

namespace QuanLyBanHang.MenuBanHang
{
    public partial class uc_SellingInvoiceCreate : UserControl
    {
        HoaDon hd = new HoaDon();
        DataTable sanpham = new DataTable();
        bool IsInsertOrUpdate = false; //Flag false:Update

        #region Contructor
        public uc_SellingInvoiceCreate()
        {
            InitializeComponent();
            IsInsertOrUpdate = true;
        }
        public uc_SellingInvoiceCreate(HoaDon _detail, bool isInsert)
        {
            InitializeComponent();
            this.hd = _detail;
            IsInsertOrUpdate = isInsert;
        }
        #endregion

        #region Load dữ liệu
        private void uc_SellingInvoiceCreate_Load(object sender, EventArgs e)
        {
            try
            {
                HoaDonClient client = new HoaDonClient();
                DataTable dtb = new DataTable();
                dtb.Columns.Add("MaSanPham");
                dtb.Columns.Add("SoLuong");
                dtb.Columns.Add("DonGia");
                if (string.IsNullOrEmpty(hd.MaHoaDon))//Insert
                {
                    txt_MaHoaDon.Text = client.HoaDon_GetNewID(DateTime.Today.Year, DateTime.Today.Month);
                    txt_MaHoaDon.Enabled = false;
                    txt_TongTien.Text = "0";
                    txt_TongTien.Enabled = false;
                    LoadMaNhanVien();
                    LoadMaKhachHang();
                    LoadSanPham();
                    LoadDonHang();
                    dgv_DanhSachChiTiet.DataSource = dtb;
                }
                else//Update or Detail
                {
                    txt_MaHoaDon.Text = hd.MaHoaDon;
                    txt_MaHoaDon.Enabled = false;
                    msk_NgayXuat.Text = hd.NgayXuat.ToString("dd/MM/yyyy");
                    txt_NhanVien.Text = hd.NhanVien.ToString();
                    txt_KhachHang.Text = hd.KhachHang.ToString();
                    txt_DonHang.Text = hd.DonDatHang.ToString();
                    txt_TongTien.Text = hd.TongTien.ToString("#,##");
                    txt_TongTien.Enabled = false;
                    txt_DaThanhToan.Text = hd.DaThanhToan.ToString("#,##");
                    txt_ConLai.Text = hd.ConLai.ToString("#,##");
                    txt_ConLai.Enabled = false;
                    foreach (HoaDonCT ct in hd.DSChiTiet)
                    {
                        DataRow row = dtb.NewRow();
                        row["MaSanPham"] = ct.MaSanPham;
                        row["SoLuong"] = ct.SoLuong;
                        row["DonGia"] = ct.DonGia.ToString("#,##");
                        dtb.Rows.Add(row);
                    }
                    dgv_DanhSachChiTiet.DataSource = dtb;
                    if (IsInsertOrUpdate)
                    {
                        msk_NgayXuat.Enabled = false;
                        txt_NhanVien.Enabled = false;
                        txt_KhachHang.Enabled = false;
                        txt_DonHang.Enabled = false;
                        btn_AddProduct.Visible = false;
                        btn_Luu.Visible = false;

                        txt_MaSanPham.Enabled = false;
                        txt_TenSanPham.Enabled = false;
                        txt_DonGia.Enabled = false;
                        txt_SoLuong.Enabled = false;
                        dgv_DanhSachChiTiet.Columns["Delete"].Visible = false;
                    }
                    LoadMaNhanVien();
                    LoadMaKhachHang();
                    LoadSanPham();
                    LoadDonHang();
                    FormatGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadMaNhanVien()
        {
            try
            {
                NhanVienClient nvclient = new NhanVienClient();
                NhanVien nv = new NhanVien();
                DataTable dtb = nvclient.NhanVien_GetNhanVien(nv, "").Tables[0];
                AutoCompleteStringCollection DsNhanVien = new AutoCompleteStringCollection();
                foreach (DataRow row in dtb.Rows)
                {
                    DsNhanVien.Add(row["MaNhanVien"].ToString());
                }
                txt_NhanVien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_NhanVien.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_NhanVien.AutoCompleteCustomSource = DsNhanVien;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LoadMaKhachHang()
        {
            try
            {
                KhachHangClient khclient = new KhachHangClient();
                KhachHang kh = new KhachHang();
                DataTable dtb = khclient.KhachHang_GetKhachHang(kh, "").Tables[0];
                AutoCompleteStringCollection DsKhachHang = new AutoCompleteStringCollection();
                foreach (DataRow row in dtb.Rows)
                {
                    DsKhachHang.Add(row["MaKhachHang"].ToString());
                }
                txt_KhachHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_KhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_KhachHang.AutoCompleteCustomSource = DsKhachHang;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LoadSanPham()
        {
            try
            {
                SanPhamClient client = new SanPhamClient();
                this.sanpham = client.SanPham_Search("").Tables[0];
                AutoCompleteStringCollection DsMaSanPham = new AutoCompleteStringCollection();
                AutoCompleteStringCollection DsTenSanPham = new AutoCompleteStringCollection();
                foreach (DataRow row in this.sanpham.Rows)
                {
                    DsMaSanPham.Add(row["MaSanPham"].ToString());
                    DsTenSanPham.Add(row["TenSanPham"].ToString());
                }
                txt_MaSanPham.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_MaSanPham.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_MaSanPham.AutoCompleteCustomSource = DsMaSanPham;

                txt_TenSanPham.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_TenSanPham.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_TenSanPham.AutoCompleteCustomSource = DsTenSanPham;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LoadDonHang()
        {
            try
            {
                DonDatHangClient ddhclient = new DonDatHangClient();
                DonDatHang ddh = new DonDatHang();
                DataTable dtb = ddhclient.DonDatHang_GetDonHang(ddh,"").Tables[0];
                AutoCompleteStringCollection DsDonHang = new AutoCompleteStringCollection();
                foreach (DataRow row in dtb.Rows)
                {
                    DsDonHang.Add(row["MaDonHang"].ToString());
                }
                txt_DonHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_DonHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_DonHang.AutoCompleteCustomSource = DsDonHang;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void FormatGrid()
        {
            try
            {
                if (dgv_DanhSachChiTiet.Rows.Count > 0)
                {
                    dgv_DanhSachChiTiet.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";
                    dgv_DanhSachChiTiet.Columns["SoLuong"].HeaderText = "Số lượng";
                    dgv_DanhSachChiTiet.Columns["DonGia"].HeaderText = "Đơn giá";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dgv_DanhSachChiTiet_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {
                if (dgv_DanhSachChiTiet.Rows.Count > 0)
                {
                    if ((e.RowIndex % 2) == 0)
                    {
                        dgv_DanhSachChiTiet.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                    }
                    this.dgv_DanhSachChiTiet.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Event Gợi ý textbox
        private void txt_TenSanPham_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataRow[] row = sanpham.Select("TenSanPham = '" + txt_TenSanPham.Text + "'");
                if (row.Length > 0)
                    txt_MaSanPham.Text = row[0]["MaSanPham"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txt_MaSanPham_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataRow[] row = sanpham.Select("MaSanPham = '" + txt_MaSanPham.Text + "'");
                if (row.Length > 0)
                    txt_TenSanPham.Text = row[0]["TenSanPham"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        //Tính tổng tiền
        private decimal Sum()
        {
            try
            {
                decimal Tong = 0;
                if (dgv_DanhSachChiTiet.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgv_DanhSachChiTiet.Rows)
                    {
                        Tong += (Convert.ToDecimal(row.Cells["SoLuong"].Value) * Convert.ToDecimal(row.Cells["DonGia"].Value));
                    }
                }
                return Tong;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Thêm sản phẩm vào phiếu + tính toán lại tổng tiển
        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ChecknullInfo())
                {
                    DataTable dtb = (DataTable)dgv_DanhSachChiTiet.DataSource;
                    DataRow row = dtb.NewRow();
                    row["MaSanPham"] = txt_MaSanPham.Text;
                    row["SoLuong"] = txt_SoLuong.Text;
                    row["DonGia"] = txt_DonGia.Text;
                    dtb.Rows.Add(row);
                    dgv_DanhSachChiTiet.DataSource = dtb;
                    FormatGrid();
                    txt_TongTien.Text = Sum().ToString("#,##");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ChecknullInfo()
        {
            if (txt_MaSanPham.Text.Trim() == "")
            {
                MessageBox.Show("Thiếu mã sản phẩm");
                return true;
            }
            if (txt_TenSanPham.Text.Trim() == "")
            {
                MessageBox.Show("Thiếu tên sản phẩm");
                return true;
            }
            if (txt_DonGia.Text.Trim() == "")
            {
                MessageBox.Show("Thiếu đơn giá");
                return true;
            }
            if (txt_SoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Thiếu số lượng");
                return true;
            }
            return false;
        }

        //Nút lưu
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDonClient client = new HoaDonClient();
                HoaDon hd = new HoaDon();
                hd.MaHoaDon = txt_MaHoaDon.Text;
                hd.NgayXuat = Convert.ToDateTime(msk_NgayXuat.Text);
                hd.NhanVien = txt_NhanVien.Text;
                hd.KhachHang = txt_KhachHang.Text;
                hd.DonDatHang = txt_DonHang.Text;
                hd.TongTien = Convert.ToDecimal(txt_TongTien.Text);
                hd.DaThanhToan = Convert.ToDecimal(txt_DaThanhToan.Text);
                hd.ConLai = Convert.ToDecimal(txt_ConLai.Text);
                List<HoaDonCT> dsct = new List<HoaDonCT>();
                foreach (DataGridViewRow row in dgv_DanhSachChiTiet.Rows)
                {
                    HoaDonCT ct = new HoaDonCT();
                    ct.MaHoaDon = txt_MaHoaDon.Text;
                    ct.MaSanPham = row.Cells["MaSanPham"].Value.ToString();
                    ct.SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    ct.DonGia = Convert.ToDecimal(row.Cells["DonGia"].Value);
                    dsct.Add(ct);
                }
                hd.DSChiTiet = dsct.ToArray();
                if (IsInsertOrUpdate && !Checknull())
                {
                    if (client.HoaDon_Insert(hd))
                    {
                        MessageBox.Show("Thêm hoá đơn thành công");
                        DataTable dtb = new DataTable();
                        dtb.Columns.Add("MaSanPham");
                        dtb.Columns.Add("SoLuong");
                        dtb.Columns.Add("DonGia");
                        txt_MaHoaDon.Text = client.HoaDon_GetNewID(DateTime.Today.Year, DateTime.Today.Month);
                        txt_MaHoaDon.Enabled = false;
                        txt_NhanVien.Text = "";
                        txt_KhachHang.Text = "";
                        txt_DonHang.Text = "";
                        msk_NgayXuat.Text = "";
                        txt_TongTien.Text = "0";
                        txt_TongTien.Enabled = false;
                        txt_DaThanhToan.Text = "0";
                        txt_ConLai.Text = "0";
                        txt_MaSanPham.Text = "";
                        txt_TenSanPham.Text = "";
                        txt_SoLuong.Text = "";
                        txt_DonGia.Text = "";
                        LoadMaNhanVien();
                        LoadMaKhachHang();
                        LoadSanPham();
                        LoadDonHang();
                        dgv_DanhSachChiTiet.DataSource = dtb;
                    }
                    else
                    {
                        MessageBox.Show("Thêm hoá đơn thất bại");
                    }
                }
                else if (!IsInsertOrUpdate && !Checknull())
                {
                    if (client.HoaDon_Update(hd))
                    {
                        MessageBox.Show("Cập nhật hoá đơn thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật hoá đơn thất bại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool Checknull()
        {
            if (msk_NgayXuat.Text.Trim() == "/  /")
            {
                MessageBox.Show("Thiếu ngày xuất");
                return true;
            }
            if (string.IsNullOrEmpty(txt_NhanVien.Text))
            {
                MessageBox.Show("Thiếu nhân viên tạo");
                return true;
            }
            if (string.IsNullOrEmpty(txt_KhachHang.Text))
            {
                MessageBox.Show("Thiếu khách hàng");
                return true;
            }
            if (dgv_DanhSachChiTiet.Rows.Count <= 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào được chọn nhập");
                return true;
            }
            return false;
        }

        //Xoá sản phẩm khỏi phiếus
        private void dgv_DanhSachChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_DanhSachChiTiet.Columns["Delete"].Index)
            {
                dgv_DanhSachChiTiet.Rows.RemoveAt(dgv_DanhSachChiTiet.CurrentRow.Index);
                txt_TongTien.Text = Sum().ToString("#,##");
                if (!string.IsNullOrEmpty(txt_DaThanhToan.Text))
                {
                    decimal conlai = Convert.ToDecimal(txt_TongTien.Text) - Convert.ToDecimal(txt_DaThanhToan.Text);
                    txt_ConLai.Text = conlai.ToString("#,###");
                }
            }
        }

        private decimal Remain()
        {
            decimal ThanhToan = 0;
            try
            {
                ThanhToan = Convert.ToDecimal(txt_DaThanhToan.Text);
            }
            catch (Exception ex)
            {
                ThanhToan = 0;
            }
            return Convert.ToDecimal(txt_TongTien.Text) - ThanhToan;
        }

        private void txt_DaThanhToan_TextChanged(object sender, EventArgs e)
        {
            txt_ConLai.Text = Remain().ToString("#,##");
        }
    }
}
