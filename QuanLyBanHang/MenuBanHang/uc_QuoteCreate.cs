using System.Data;
using System.Windows.Forms;
using QuanLyBanHang.BanHangService;
using System;
using System.Drawing;
using System.Collections.Generic;

namespace QuanLyBanHang.MenuBanHang
{
    public partial class uc_QuoteCreate : UserControl
    {
        BaoGia bg = new BaoGia();
        DataTable sanpham = new DataTable();//Ds sp được phép nhập
        bool IsInsertOrUpdate = false; //Flag false:Update

        #region Contructor
        public uc_QuoteCreate()
        {
            InitializeComponent();
            IsInsertOrUpdate = true;
        }
        public uc_QuoteCreate(BaoGia _detail, bool isInsert)
        {
            InitializeComponent();
            this.bg = _detail;
            IsInsertOrUpdate = isInsert;
        }
        #endregion

        #region Load dữ liệu
        private void uc_QuoteCreate_Load(object sender, System.EventArgs e)
        {
            try
            {
                BaoGiaClient client = new BaoGiaClient();
                DataTable dtb = new DataTable();
                dtb.Columns.Add("MaSanPham");
                dtb.Columns.Add("SoLuong");
                dtb.Columns.Add("DonGia");
                if (string.IsNullOrEmpty(bg.MaBaoGia))//Insert
                {
                    txt_MaBaoGia.Text = client.BaoGia_GetNewID(DateTime.Today.Year, DateTime.Today.Month);
                    txt_MaBaoGia.Enabled = false;
                    txt_TongTien.Text = "0";
                    txt_TongTien.Enabled = false;
                    LoadMaNhanVien();
                    LoadSanPham();
                    dgv_DanhSachChiTiet.DataSource = dtb;
                }
                else//Update or Detail
                {
                    txt_MaBaoGia.Text = bg.MaBaoGia;
                    txt_MaBaoGia.Enabled = false;
                    msk_NgayLap.Text = bg.NgayTao.ToString("dd/MM/yyyy");
                    msk_NgayHetHan.Text = bg.NgayHetHan.ToString("dd/MM/yyyy");
                    txt_NhanVien.Text = bg.MaNhanVien.ToString();
                    txt_ChietKhau.Text = bg.ChietKhau.ToString("#,##");
                    txt_TongTien.Text = bg.TongTien.ToString("#,##");
                    txt_TongTien.Enabled = false;
                    foreach (BaoGiaCT ct in bg.DSChiTiet)
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
                        msk_NgayLap.Enabled = false;
                        msk_NgayHetHan.Enabled = false;
                        txt_NhanVien.Enabled = false;
                        txt_ChietKhau.Enabled = false;
                        btn_AddProduct.Visible = false;
                        btn_Luu.Visible = false;

                        txt_MaSanPham.Enabled = false;
                        txt_TenSanPham.Enabled = false;
                        txt_DonGia.Enabled = false;
                        txt_SoLuong.Enabled = false;
                        dgv_DanhSachChiTiet.Columns["Delete"].Visible = false;
                    }
                    LoadMaNhanVien();
                    LoadSanPham();
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
                BaoGiaClient client = new BaoGiaClient();
                BaoGia bg = new BaoGia();
                bg.MaBaoGia = txt_MaBaoGia.Text;
                bg.NgayTao = Convert.ToDateTime(msk_NgayLap.Text);
                bg.NgayHetHan = Convert.ToDateTime(msk_NgayHetHan.Text);
                bg.MaNhanVien = txt_NhanVien.Text;
                bg.TongTien = Convert.ToDecimal(txt_TongTien.Text);
                if (!string.IsNullOrEmpty(txt_ChietKhau.Text))
                    bg.ChietKhau = Convert.ToDecimal(txt_ChietKhau.Text);
                else
                    bg.ChietKhau = 0;
                List<BaoGiaCT> dsct = new List<BaoGiaCT>();
                foreach (DataGridViewRow row in dgv_DanhSachChiTiet.Rows)
                {
                    BaoGiaCT ct = new BaoGiaCT();
                    ct.MaBaoGia = txt_MaBaoGia.Text;
                    ct.MaSanPham = row.Cells["MaSanPham"].Value.ToString();
                    ct.SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    ct.DonGia = Convert.ToDecimal(row.Cells["DonGia"].Value);
                    dsct.Add(ct);
                }
                bg.DSChiTiet = dsct.ToArray();
                if (IsInsertOrUpdate && !Checknull())
                {
                    if (client.BaoGia_Insert(bg))
                    {
                        MessageBox.Show("Thêm báo giá thành công");
                        DataTable dtb = new DataTable();
                        dtb.Columns.Add("MaSanPham");
                        dtb.Columns.Add("SoLuong");
                        dtb.Columns.Add("DonGia");
                        txt_MaBaoGia.Text = client.BaoGia_GetNewID(DateTime.Today.Year, DateTime.Today.Month);
                        txt_MaBaoGia.Enabled = false;
                        txt_NhanVien.Text = "";
                        msk_NgayLap.Text = "";
                        msk_NgayHetHan.Text = "";
                        txt_TongTien.Text = "0";
                        txt_TongTien.Enabled = false;
                        txt_ChietKhau.Text = "0";
                        txt_MaSanPham.Text = "";
                        txt_TenSanPham.Text = "";
                        txt_SoLuong.Text = "";
                        txt_DonGia.Text = "";
                        LoadMaNhanVien();
                        LoadSanPham();
                        dgv_DanhSachChiTiet.DataSource = dtb;
                    }
                    else
                    {
                        MessageBox.Show("Thêm phiếu nhập thất bại");
                    }
                }
                else if (!IsInsertOrUpdate && !Checknull())
                {
                    if (client.BaoGia_Update(bg))
                    {
                        MessageBox.Show("Cập nhật phiếu nhập thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phiếu nhập thất bại");
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
            if (msk_NgayLap.Text.Trim() == "/  /")
            {
                MessageBox.Show("Thiếu ngày lập");
                return true;
            }
            if (msk_NgayHetHan.Text.Trim() == "/  ")
            {
                MessageBox.Show("Thiếu ngày hết hạn");
                return true;
            }
            if (string.IsNullOrEmpty(txt_NhanVien.Text))
            {
                MessageBox.Show("Thiếu nhân viên nhập");
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
            }
        }
    }
}
