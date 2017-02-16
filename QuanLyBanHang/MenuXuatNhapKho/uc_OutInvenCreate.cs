using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.BanHangService;

namespace QuanLyBanHang.MenuXuatNhapKho
{
    public partial class uc_OutInvenCreate : UserControl
    {
        PhieuXuat px = new PhieuXuat();
        DataTable sanpham = new DataTable();//Ds sp được phép bán
        bool IsInsertOrUpdate = false; //Flag false:Update

        #region Contructor
        public uc_OutInvenCreate()
        {
            InitializeComponent();
            IsInsertOrUpdate = true;
        }
        public uc_OutInvenCreate(PhieuXuat px_Detail, bool isInsert)
        {
            InitializeComponent();
            this.px = px_Detail;
            IsInsertOrUpdate = isInsert;
        }
        #endregion

        #region Load dữ liệu
        private void uc_OutInvenCreate_Load(object sender, EventArgs e)
        {
            try
            {
                PhieuXuatClient client = new PhieuXuatClient();
                DataTable dtb = new DataTable();
                dtb.Columns.Add("MaSanPham");
                dtb.Columns.Add("SoLuongYeuCau");
                dtb.Columns.Add("SoLuongThucXuat");
                dtb.Columns.Add("DonGia");
                if (string.IsNullOrEmpty(px.MaPhieuXuat))//Insert
                {
                    txt_MaPhieuXuat.Text = client.PhieuXuat_GetNewID(DateTime.Today.Year, DateTime.Today.Month);
                    txt_MaPhieuXuat.Enabled = false;
                    txt_TongTien.Text = "0";
                    txt_TongTien.Enabled = false;
                    LoadMaNhanVien();
                    LoadMaKhachHang();
                    LoadSanPham();
                    LoadHoaDon();
                    dgv_DanhSachChiTiet.DataSource = dtb;
                }
                else//Update or Detail
                {
                    txt_MaPhieuXuat.Text = px.MaPhieuXuat;
                    txt_MaPhieuXuat.Enabled = false;
                    msk_NgayXuat.Text = px.NgayXuat.ToString("dd/MM/yyyy");
                    txt_NhanVien.Text = px.MaNhanVien.ToString();
                    txt_KhachHang.Text = px.MaKhachHang.ToString();
                    txt_DiaChi.Text = px.DiaChiGiaoHang;
                    txt_HoaDon.Text = px.MaHoaDon;
                    txt_TongTien.Text = px.TongTien.ToString("#,##");
                    txt_TongTien.Enabled = false;
                    txt_DonGia.Enabled = false;
                    foreach (PhieuXuatCT ct in px.DSChiTiet)
                    {
                        DataRow row = dtb.NewRow();
                        row["MaSanPham"] = ct.MaSanPham;
                        row["SoLuongYeuCau"] = ct.SoLuongYeuCau;
                        row["SoLuongThucXuat"] = ct.SoLuongThuc;
                        row["DonGia"] = ct.DonGia.ToString("#,##");
                        dtb.Rows.Add(row);
                    }
                    dgv_DanhSachChiTiet.DataSource = dtb;
                    if (IsInsertOrUpdate)
                    {
                        msk_NgayXuat.Enabled = false;
                        txt_NhanVien.Enabled = false;
                        btn_Add.Visible = false;
                        btn_Luu.Visible = false;

                        txt_MaSanPham.Enabled = false;
                        txt_TenSanPham.Enabled = false;
                        txt_SoLuongYC.Enabled = false;
                        txt_SoLuongTX.Enabled = false;
                        txt_KhachHang.Enabled = false;
                        txt_DiaChi.Enabled = false;
                        dgv_DanhSachChiTiet.Columns["Delete"].Visible = false;
                    }
                    LoadMaNhanVien();
                    LoadMaKhachHang();
                    LoadSanPham();
                    LoadHoaDon();
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
        private void LoadHoaDon()
        {
            try
            {
                HoaDonClient hdclient = new HoaDonClient();
                HoaDon hd = new HoaDon();
                DataTable dtb = hdclient.HoaDon_GetHoaDon(hd, "").Tables[0];
                AutoCompleteStringCollection DsHoaDon = new AutoCompleteStringCollection();
                foreach (DataRow row in dtb.Rows)
                {
                    DsHoaDon.Add(row["MaHoaDon"].ToString());
                }
                txt_HoaDon.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_HoaDon.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_HoaDon.AutoCompleteCustomSource = DsHoaDon;
            }
            catch(Exception ex)
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
                    dgv_DanhSachChiTiet.Columns["SoLuongYeuCau"].HeaderText = "Số lượng yêu cầu";
                    dgv_DanhSachChiTiet.Columns["SoLuongThucXuat"].HeaderText = "Số lượng xuất";
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

        //Tính tiền
        private decimal Sum()
        {
            try
            {
                decimal Tong = 0;
                if (dgv_DanhSachChiTiet.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgv_DanhSachChiTiet.Rows)
                    {
                        Tong += (Convert.ToDecimal(row.Cells["SoLuongThucXuat"].Value) * Convert.ToDecimal(row.Cells["DonGia"].Value));
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
                    row["SoLuongYeuCau"] = txt_SoLuongYC.Text;
                    row["SoLuongThucXuat"] = txt_SoLuongTX.Text;
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
            if (txt_SoLuongYC.Text.Trim() == "")
            {
                MessageBox.Show("Thiếu số lượng yêu cầu");
                return true;
            }
            if (txt_SoLuongTX.Text.Trim() == "")
            {
                MessageBox.Show("Thiếu số lượng thực xuất");
                return true;
            }
            return false;
        }

        //Nút lưu
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuXuatClient client = new PhieuXuatClient();
                PhieuXuat px = new PhieuXuat();
                px.MaPhieuXuat = txt_MaPhieuXuat.Text;
                px.NgayXuat = Convert.ToDateTime(msk_NgayXuat.Text);
                px.MaNhanVien = txt_NhanVien.Text;
                px.MaKhachHang = txt_KhachHang.Text;
                px.TongTien = Convert.ToDecimal(txt_TongTien.Text);
                px.DiaChiGiaoHang = txt_DiaChi.Text;
                px.MaHoaDon = txt_HoaDon.Text;
                List<PhieuXuatCT> dsct = new List<PhieuXuatCT>();
                foreach (DataGridViewRow row in dgv_DanhSachChiTiet.Rows)
                {
                    PhieuXuatCT ct = new PhieuXuatCT();
                    ct.MaPhieuXuat = txt_MaPhieuXuat.Text;
                    ct.MaSanPham = row.Cells["MaSanPham"].Value.ToString();
                    ct.SoLuongYeuCau = Convert.ToInt32(row.Cells["SoLuongYeuCau"].Value);
                    ct.SoLuongThuc = Convert.ToInt32(row.Cells["SoLuongThucXuat"].Value);
                    ct.DonGia = Convert.ToDecimal(row.Cells["DonGia"].Value);
                    dsct.Add(ct);
                }
                px.DSChiTiet = dsct.ToArray();
                if (IsInsertOrUpdate && !Checknull())
                {
                    if (client.PhieuXuat_Insert(px))
                    {
                        MessageBox.Show("Thêm phiếu xuất thành công");
                        DataTable dtb = new DataTable();
                        dtb.Columns.Add("MaSanPham");
                        dtb.Columns.Add("SoLuongYeuCau");
                        dtb.Columns.Add("SoLuongThucXuat");
                        dtb.Columns.Add("DonGia");
                        txt_MaPhieuXuat.Text = client.PhieuXuat_GetNewID(DateTime.Today.Year, DateTime.Today.Month);
                        txt_MaPhieuXuat.Enabled = false;
                        txt_NhanVien.Text = "";
                        txt_KhachHang.Text = "";
                        msk_NgayXuat.Text = "";
                        txt_TongTien.Text = "0";
                        txt_TongTien.Enabled = false;
                        txt_DiaChi.Text = "";
                        txt_HoaDon.Text = "";
                        txt_MaSanPham.Text = "";
                        txt_TenSanPham.Text = "";
                        txt_SoLuongYC.Text = "";
                        txt_SoLuongTX.Text = "";
                        txt_DonGia.Text = "";
                        LoadMaNhanVien();
                        LoadMaKhachHang();
                        LoadSanPham();
                        LoadHoaDon();
                        dgv_DanhSachChiTiet.DataSource = dtb;
                    }
                    else
                    {
                        MessageBox.Show("Thêm phiếu xuất thất bại");
                    }
                }
                else if (!IsInsertOrUpdate && !Checknull())
                {
                    if (client.PhieuXuat_Update(px))
                    {
                        MessageBox.Show("Cập nhật phiếu xuất thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phiếu xuất thất bại");
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
                MessageBox.Show("Thiếu nhân viên xuất");
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

        //Xoá sách khỏi phiếu
        private void dgv_DanhSachChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_DanhSachChiTiet.Columns["Delete"].Index)
            {
                dgv_DanhSachChiTiet.Rows.RemoveAt(dgv_DanhSachChiTiet.CurrentRow.Index);
                txt_TongTien.Text = Sum().ToString("#,##");
            }
        }

    }
}
