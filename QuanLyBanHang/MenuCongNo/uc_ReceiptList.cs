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

namespace QuanLyBanSach.MenuCongNo
{
    public partial class uc_ReceiptList : UserControl
    {
        bool Insert = true;
        //Contructor
        public uc_ReceiptList()
        {
            InitializeComponent();
        }

        #region Hiệu ứng nút
        private void pic_Them_MouseHover(object sender, EventArgs e)
        {
            pic_Them.BackColor = Color.Gainsboro;
        }
        private void pic_Them_MouseLeave(object sender, EventArgs e)
        {
            pic_Them.BackColor = Color.Transparent;
        }
        #endregion

        #region Load data
        private void uc_ReceiptList_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadData()
        {
            try
            {
                PhieuThu pt = new PhieuThu();
                dgv_DanhSachPhieuThu.DataSource = pt.GetPhieuThu("");
                FormatGrid();
                LoadMaKhachHang();
                LoadMaNhanVien();
            }
            catch (Exception ex)
            {
                throw ex;
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
                if (dgv_DanhSachPhieuThu.Rows.Count >= 0)
                {
                    dgv_DanhSachPhieuThu.Columns["MaPhieuThu"].Visible = true;
                    dgv_DanhSachPhieuThu.Columns["MaPhieuThu"].HeaderText = "Mã phiếu thu";
                    dgv_DanhSachPhieuThu.Columns["MaPhieuThu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgv_DanhSachPhieuThu.Columns["MaPhieuThu"].Width = 130;

                    dgv_DanhSachPhieuThu.Columns["KhachHang"].Visible = true;
                    dgv_DanhSachPhieuThu.Columns["KhachHang"].HeaderText = "Mã khách hàng";
                    dgv_DanhSachPhieuThu.Columns["KhachHang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv_DanhSachPhieuThu.Columns["KhachHang"].Width = 130;

                    dgv_DanhSachPhieuThu.Columns["TenKhachHang"].Visible = true;
                    dgv_DanhSachPhieuThu.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
                    dgv_DanhSachPhieuThu.Columns["TenKhachHang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgv_DanhSachPhieuThu.Columns["TenKhachHang"].Width = 150;

                    dgv_DanhSachPhieuThu.Columns["NhanVien"].Visible = true;
                    dgv_DanhSachPhieuThu.Columns["NhanVien"].HeaderText = "Mã nhân viên";
                    dgv_DanhSachPhieuThu.Columns["NhanVien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv_DanhSachPhieuThu.Columns["NhanVien"].Width = 130;

                    dgv_DanhSachPhieuThu.Columns["TenNhanVien"].Visible = true;
                    dgv_DanhSachPhieuThu.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
                    dgv_DanhSachPhieuThu.Columns["TenNhanVien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgv_DanhSachPhieuThu.Columns["TenNhanVien"].Width = 150;

                    dgv_DanhSachPhieuThu.Columns["NgayThu"].Visible = true;
                    dgv_DanhSachPhieuThu.Columns["NgayThu"].HeaderText = "Ngày thu";
                    dgv_DanhSachPhieuThu.Columns["NgayThu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv_DanhSachPhieuThu.Columns["NgayThu"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgv_DanhSachPhieuThu.Columns["NgayThu"].Width = 130;

                    dgv_DanhSachPhieuThu.Columns["SoTienThu"].Visible = true;
                    dgv_DanhSachPhieuThu.Columns["SoTienThu"].HeaderText = "Tổng tiền";
                    dgv_DanhSachPhieuThu.Columns["SoTienThu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgv_DanhSachPhieuThu.Columns["SoTienThu"].DefaultCellStyle.Format = "#,##";
                    dgv_DanhSachPhieuThu.Columns["SoTienThu"].Width = 130;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dgv_DanhSachPhieuThu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgv_DanhSachPhieuThu.Rows.Count > 0)
            {
                if ((e.RowIndex % 2) == 0)
                {
                    dgv_DanhSachPhieuThu.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                }
                this.dgv_DanhSachPhieuThu.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
            }
        }
        #endregion

        //Nút Thêm
        private void pic_Them_Click(object sender, EventArgs e)
        {
            try
            {
                txt_MaPhieuThu.Text = PhieuThu.GetNewID(DateTime.Today.Year, DateTime.Today.Month);
                msk_NgayThu.Text = "";
                txt_NhanVien.Text = "";
                txt_KhachHang.Text = "";
                txt_SoTien.Text = "";
                Insert = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Tìm kiếm hoá đơn
        private void txt_ThongTinTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PhieuThu pt = new PhieuThu();
                dgv_DanhSachPhieuThu.DataSource = pt.GetPhieuThu(" and (pt.MaPhieuThu like '%" + txt_ThongTinTimKiem.Text + "%' or pt.KhachHang like '%" + txt_ThongTinTimKiem.Text + "%' or pt.NhanVien like '%" + txt_ThongTinTimKiem.Text + "%' or CONVERT(VARCHAR(10),pt.NgayThu,103) like '%"+txt_ThongTinTimKiem.Text+"%' or kh.TenKhachHang like N'%"+txt_ThongTinTimKiem.Text+"%' or nv.TenNhanVien like N'%"+txt_ThongTinTimKiem.Text+"%')");
                FormatGrid();
                LoadMaKhachHang();
                LoadMaNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Click vào lưới
        private void dgv_DanhSachPhieuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nút sửa
            if (e.ColumnIndex == dgv_DanhSachPhieuThu.Columns["Fix"].Index)
            {
                txt_MaPhieuThu.Text = dgv_DanhSachPhieuThu.CurrentRow.Cells["MaPhieuThu"].Value.ToString();
                msk_NgayThu.Text = Convert.ToDateTime(dgv_DanhSachPhieuThu.CurrentRow.Cells["NgayThu"].Value).ToShortDateString();
                txt_NhanVien.Text = dgv_DanhSachPhieuThu.CurrentRow.Cells["NhanVien"].Value.ToString();
                txt_KhachHang.Text = dgv_DanhSachPhieuThu.CurrentRow.Cells["KhachHang"].Value.ToString();
                txt_KhachHang.Enabled = false;
                txt_SoTien.Text = Convert.ToDecimal(dgv_DanhSachPhieuThu.CurrentRow.Cells["SoTienThu"].Value).ToString("#,##");
                Insert = false;
            }
            //Nút xoá
            if (e.ColumnIndex == dgv_DanhSachPhieuThu.Columns["Delete"].Index)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xoá phiếu thu này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    PhieuThu pt = new PhieuThu();
                    pt.MaPhieuThu = dgv_DanhSachPhieuThu.CurrentRow.Cells["MaPhieuThu"].Value.ToString();
                    pt.KhachHang = dgv_DanhSachPhieuThu.CurrentRow.Cells["KhachHang"].Value.ToString();
                    if (pt.Delete())
                        MessageBox.Show("Xoá thành công");
                    else
                        MessageBox.Show("Xoá thất bại");
                }
            }
        }

        //Nút cập nhật
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Checknull())
                {
                    PhieuThu pt = new PhieuThu();
                    pt.MaPhieuThu = txt_MaPhieuThu.Text;
                    pt.NgayThu = Convert.ToDateTime(msk_NgayThu.Text);
                    pt.KhachHang = txt_KhachHang.Text;
                    pt.NhanVien = txt_NhanVien.Text;
                    pt.SoTienThu = Convert.ToDecimal(txt_SoTien.Text);
                    if (Insert)
                    {
                        if (pt.Insert())
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        if (pt.Update())
                        {
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                            txt_KhachHang.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Kiểm tra lỗi
        public bool Checknull()
        {
            if (string.IsNullOrEmpty(txt_MaPhieuThu.Text))
            {
                MessageBox.Show("Thiếu mã phiếu");
                return true;
            }
            if (string.IsNullOrEmpty(txt_NhanVien.Text))
            {
                MessageBox.Show("Thiếu mã nhân viên");
                return true;
            }
            if (string.IsNullOrEmpty(txt_KhachHang.Text))
            {
                MessageBox.Show("Thiếu mã khách hàng");
                return true;
            }
            if (string.IsNullOrEmpty(txt_SoTien.Text))
            {
                MessageBox.Show("Mời điền số tiền thu ");
                return true;
            }
            if (msk_NgayThu.Text.Trim() == "/  /")
            {
                MessageBox.Show("Mời điền ngày thu");
                return true;
            }
            return false;
        }
    }
}
