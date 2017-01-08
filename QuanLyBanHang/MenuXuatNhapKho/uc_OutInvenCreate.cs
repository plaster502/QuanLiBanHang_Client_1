using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace QuanLyBanSach.MenuXuatNhapKho
{
    public partial class uc_OutInvenCreate : UserControl
    {
        HoaDon hd = new HoaDon();
        DataTable book = new DataTable();//Ds sách được phép bán
        bool IsInsertOrUpdate = false; //Flag false:Update

        #region Contructor
        public uc_OutInvenCreate()
        {
            InitializeComponent();
            IsInsertOrUpdate = true;
        }
        public uc_OutInvenCreate(HoaDon hd_Detail, bool isInsert)
        {
            InitializeComponent();
            this.hd = hd_Detail;
            IsInsertOrUpdate = isInsert;
        }
        #endregion

        #region Load Data
        private void uc_OutInvenCreate_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtb = new DataTable();
                dtb.Columns.Add("MaSach");
                dtb.Columns.Add("SoLuong");
                dtb.Columns.Add("DonGia");
                if (string.IsNullOrEmpty(hd.MaHoaDon))//Insert
                {
                    txt_MaHoaDon.Text = HoaDon.GetNewID(DateTime.Today.Year, DateTime.Today.Month);
                    txt_MaHoaDon.Enabled = false;
                    txt_TongTien.Text = "0";
                    txt_TongTien.Enabled = false;
                    txt_DaThanhToan.Text = "0";
                    txt_ConLai.Text = "0";
                    txt_ConLai.Enabled = false;
                    txt_DonGia.Enabled = false;
                    LoadMaNhanVien();
                    LoadMaKhachHang();
                    LoadSach();
                    dgv_DanhSachChiTiet.DataSource = dtb;
                }
                else//Update or Detail
                {
                    txt_MaHoaDon.Text = hd.MaHoaDon;
                    txt_MaHoaDon.Enabled = false;
                    msk_NgayXuat.Text = hd.NgayXuat.ToString("dd/MM/yyyy");
                    txt_NhanVien.Text = hd.NhanVien.ToString();
                    txt_KhachHang.Text = hd.KhachHang.ToString();
                    txt_TongTien.Text = hd.TongTien.ToString("#,##");
                    txt_TongTien.Enabled = false;
                    txt_DaThanhToan.Text = hd.DaThanhToan.ToString("#,##");
                    txt_ConLai.Text = hd.ConLai.ToString("#,##");
                    txt_ConLai.Enabled = false;
                    txt_DonGia.Enabled = false;
                    foreach (HoaDon_CT ct in hd.DSChiTiet)
                    {
                        DataRow row = dtb.NewRow();
                        row["MaSach"] = ct.MaSach;
                        row["SoLuong"] = ct.SoLuong;
                        row["DonGia"] = ct.DonGia.ToString("#,##");
                        dtb.Rows.Add(row);
                    }
                    dgv_DanhSachChiTiet.DataSource = dtb;
                    if (IsInsertOrUpdate)
                    {
                        msk_NgayXuat.Enabled = false;
                        txt_NhanVien.Enabled = false;
                        btn_AddBook.Visible = false;
                        btn_Luu.Visible = false;

                        txt_MaSach.Enabled = false;
                        txt_TenSach.Enabled = false;
                        txt_SoLuong.Enabled = false;
                        txt_KhachHang.Enabled = false;
                        txt_DaThanhToan.Enabled = false;
                        dgv_DanhSachChiTiet.Columns["Delete"].Visible = false;
                    }
                    LoadMaNhanVien();
                    LoadMaKhachHang();
                    LoadSach();
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
                NhanVien nv = new NhanVien();
                DataTable dtb = nv.GetNhanVien("");
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
        private void LoadSach()
        {
            try
            {
                this.book = new Sach().GetSach("");
                AutoCompleteStringCollection DsMaSach = new AutoCompleteStringCollection();
                AutoCompleteStringCollection DsTenSach = new AutoCompleteStringCollection();
                foreach (DataRow row in this.book.Rows)
                {
                    DsMaSach.Add(row["MaSach"].ToString());
                    DsTenSach.Add(row["TenSach"].ToString());
                }
                txt_MaSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_MaSach.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_MaSach.AutoCompleteCustomSource = DsMaSach;

                txt_TenSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_TenSach.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_TenSach.AutoCompleteCustomSource = DsTenSach;
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
                KhachHang kh = new KhachHang();
                DataTable dtb = kh.GetKhachHang("");
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

        private void FormatGrid()
        {
            try
            {
                if (dgv_DanhSachChiTiet.Rows.Count > 0)
                {
                    dgv_DanhSachChiTiet.Columns["MaSach"].HeaderText = "Mã sách";
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
                DataRow[] row = book.Select("TenSach = '" + txt_TenSach.Text + "'");
                if (row.Length > 0)
                {
                    txt_MaSach.Text = row[0]["MaSach"].ToString();
                    txt_DonGia.Text = Convert.ToDecimal(row[0]["DonGia"]).ToString("#,##");
                }
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
                DataRow[] row = book.Select("MaSach = '" + txt_MaSach.Text + "'");
                if (row.Length > 0)
                {
                    txt_TenSach.Text = row[0]["TenSach"].ToString();
                    txt_DonGia.Text = Convert.ToDecimal(row[0]["DonGia"]).ToString("#,##");
                }
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

        //Thêm sách vào phiếu + tính toán lại tiển
        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ChecknullBookInfo())
                {
                    DataTable dtb = (DataTable)dgv_DanhSachChiTiet.DataSource;
                    DataRow row = dtb.NewRow();
                    row["MaSach"] = txt_MaSach.Text;
                    row["SoLuong"] = txt_SoLuong.Text;
                    row["DonGia"] = txt_DonGia.Text;
                    dtb.Rows.Add(row);
                    dgv_DanhSachChiTiet.DataSource = dtb;
                    FormatGrid();
                    txt_TongTien.Text = Sum().ToString("#,##");
                    txt_ConLai.Text = Remain().ToString("0,##");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool ChecknullBookInfo()
        {
            if (txt_MaSach.Text.Trim() == "")
            {
                MessageBox.Show("Thiếu mã sách");
                return true;
            }
            if (txt_TenSach.Text.Trim() == "")
            {
                MessageBox.Show("Thiếu tên sách");
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
        private void txt_DaThanhToan_TextChanged(object sender, EventArgs e)
        {
            txt_ConLai.Text = Remain().ToString("#,##");
        }

        //Nút lưu
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon hd = new HoaDon();
                hd.MaHoaDon = txt_MaHoaDon.Text;
                hd.NgayXuat = Convert.ToDateTime(msk_NgayXuat.Text);
                hd.NhanVien = txt_NhanVien.Text;
                hd.KhachHang = txt_KhachHang.Text;
                hd.TongTien = Convert.ToDecimal(txt_TongTien.Text);
                hd.DaThanhToan = Convert.ToDecimal(txt_DaThanhToan.Text);
                if (string.IsNullOrEmpty(txt_ConLai.Text))
                    hd.ConLai = 0;
                else
                    hd.ConLai = Convert.ToDecimal(txt_ConLai.Text);
                hd.DSChiTiet = new List<HoaDon_CT>();
                foreach (DataGridViewRow row in dgv_DanhSachChiTiet.Rows)
                {
                    HoaDon_CT ct = new HoaDon_CT();
                    ct.MaHoaDon = txt_MaHoaDon.Text;
                    ct.MaSach = row.Cells["MaSach"].Value.ToString();
                    ct.SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    ct.DonGia = Convert.ToDecimal(row.Cells["DonGia"].Value);
                    hd.DSChiTiet.Add(ct);
                }
                if (IsInsertOrUpdate && !Checknull())
                {
                    if (hd.Insert())
                    {
                        MessageBox.Show("Thêm hoá đơn thành công");
                        DataTable dtb = new DataTable();
                        dtb.Columns.Add("MaSach");
                        dtb.Columns.Add("SoLuong");
                        dtb.Columns.Add("DonGia");
                        txt_MaHoaDon.Text = HoaDon.GetNewID(DateTime.Today.Year, DateTime.Today.Month);
                        txt_MaHoaDon.Enabled = false;
                        txt_NhanVien.Text = "";
                        txt_KhachHang.Text = "";
                        msk_NgayXuat.Text = "";
                        txt_TongTien.Text = "0";
                        txt_TongTien.Enabled = false;
                        txt_DaThanhToan.Text = "0";
                        txt_ConLai.Text = "0";
                        txt_ConLai.Enabled = false;
                        txt_MaSach.Text = "";
                        txt_TenSach.Text = "";
                        txt_SoLuong.Text = "";
                        txt_DonGia.Text = "";
                        LoadMaNhanVien();
                        LoadMaKhachHang();
                        LoadSach();
                        dgv_DanhSachChiTiet.DataSource = dtb;
                    }
                    else
                    {
                        MessageBox.Show("Thêm hoá đơn thất bại");
                    }
                }
                else if (!IsInsertOrUpdate && !Checknull())
                {
                    if (hd.Update())
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
                MessageBox.Show("Thiếu ngày nhập");
                return true;
            }
            if (string.IsNullOrEmpty(txt_NhanVien.Text))
            {
                MessageBox.Show("Thiếu nhân viên nhập");
                return true;
            }
            if (string.IsNullOrEmpty(txt_KhachHang.Text))
            {
                MessageBox.Show("Thiếu khách hàng");
                return true;
            }
            if (dgv_DanhSachChiTiet.Rows.Count <= 0)
            {
                MessageBox.Show("Chưa có sách nào được chọn nhập");
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
                txt_ConLai.Text = Remain().ToString("#,##");
            }
        }

    }
}
