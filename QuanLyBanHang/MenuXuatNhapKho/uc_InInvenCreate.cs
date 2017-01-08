using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using QuanLyBanHang.BanHangService;

namespace QuanLyBanHang.MenuXuatNhapKho
{
    public partial class uc_InInvenCreate : UserControl
    {
        PhieuNhap pn = new PhieuNhap();
        DataTable sanpham = new DataTable();//Ds sp được phép nhập
        bool IsInsertOrUpdate = false; //Flag false:Update

        #region Contructor
        public uc_InInvenCreate()
        {
            InitializeComponent();
            IsInsertOrUpdate = true;
        }
        public uc_InInvenCreate(PhieuNhap pn_detail, bool isInsert)
        {
            InitializeComponent();
            this.pn = pn_detail;
            IsInsertOrUpdate = isInsert;
        }
        #endregion

        #region Load dữ liệu
        private void uc_InInvenCreate_Load(object sender, EventArgs e)
        {
            try
            {
                PhieuNhapClient client = new PhieuNhapClient();
                DataTable dtb = new DataTable();
                dtb.Columns.Add("MaSanPham");
                dtb.Columns.Add("SoLuong");
                dtb.Columns.Add("DonGia");
                if (string.IsNullOrEmpty(pn.MaPhieuNhap))//Insert
                {
                    txt_MaPhieuNhap.Text =client.PhieuNhap_GetNewID(DateTime.Today.Year, DateTime.Today.Month);
                    txt_MaPhieuNhap.Enabled = false;
                    txt_TongTien.Text = "0";
                    txt_TongTien.Enabled = false;
                    LoadMaNhanVien();
                    LoadSanPham();
                    dgv_DanhSachChiTiet.DataSource = dtb;
                }
                else//Update or Detail
                {
                    txt_MaPhieuNhap.Text = pn.MaPhieuNhap;
                    txt_MaPhieuNhap.Enabled = false;
                    msk_NgayNhap.Text = pn.NgayNhap.ToString("dd/MM/yyyy");
                    txt_NhanVien.Text = pn.MaNhanVien.ToString();
                    txt_TongTien.Text = pn.TongTien.ToString("#,##");
                    txt_TongTien.Enabled = false;
                    foreach (PhieuNhapCT ct in pn.DSChiTiet)
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
                        msk_NgayNhap.Enabled = false;
                        txt_NhanVien.Enabled = false;
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
        private void txt_TenSach_TextChanged(object sender, EventArgs e)
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
        private void txt_MaSach_TextChanged(object sender, EventArgs e)
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
                if (!ChecknullBookInfo())
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

        private bool ChecknullBookInfo()
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
                PhieuNhapClient client = new PhieuNhapClient();
                PhieuNhap pn = new PhieuNhap();
                pn.MaPhieuNhap = txt_MaPhieuNhap.Text;
                pn.NgayNhap = Convert.ToDateTime(msk_NgayNhap.Text);
                pn.MaNhanVien = txt_NhanVien.Text;
                pn.TongTien = Convert.ToDecimal(txt_TongTien.Text);
                List<PhieuNhapCT> dsct = new List<PhieuNhapCT>();
                foreach (DataGridViewRow row in dgv_DanhSachChiTiet.Rows)
                {
                    PhieuNhapCT ct = new PhieuNhapCT();
                    ct.MaPhieuNhap = txt_MaPhieuNhap.Text;
                    ct.MaSanPham = row.Cells["MaSanPham"].Value.ToString();
                    ct.SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    ct.DonGia = Convert.ToDecimal(row.Cells["DonGia"].Value);
                    dsct.Add(ct);
                }
                pn.DSChiTiet = dsct.ToArray();
                if (IsInsertOrUpdate && !Checknull())
                {
                    if (client.PhieuNhap_Insert(pn))
                    {
                        MessageBox.Show("Thêm phiếu nhập thành công");
                        DataTable dtb = new DataTable();
                        dtb.Columns.Add("MaSanPham");
                        dtb.Columns.Add("SoLuong");
                        dtb.Columns.Add("DonGia");
                        txt_MaPhieuNhap.Text = client.PhieuNhap_GetNewID(DateTime.Today.Year, DateTime.Today.Month);
                        txt_MaPhieuNhap.Enabled = false;
                        txt_NhanVien.Text = "";
                        msk_NgayNhap.Text = "";
                        txt_TongTien.Text = "0";
                        txt_TongTien.Enabled = false;
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
                    if (client.PhieuNhap_Update(pn))
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
            if (msk_NgayNhap.Text.Trim() == "/  /")
            {
                MessageBox.Show("Thiếu ngày nhập");
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

        //Xoá sản phẩm khỏi phiếu
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
