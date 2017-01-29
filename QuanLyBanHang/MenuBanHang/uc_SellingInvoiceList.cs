using System;
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
    public partial class uc_SellingInvoiceList : UserControl
    {
        HoaDonClient client = new HoaDonClient();
        //Contructor
        public uc_SellingInvoiceList()
        {
            InitializeComponent();
        }

        #region Load Data
        private void uc_SellingInvoiceList_Load(object sender, EventArgs e)
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
                HoaDon hd = new HoaDon();
                dgv_DanhSachHoaDon.DataSource = client.HoaDon_GetHoaDon(hd, "").Tables[0];
                FormatGrid();
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
                if (dgv_DanhSachHoaDon.Rows.Count >= 0)
                {
                    dgv_DanhSachHoaDon.Columns["MaHoaDon"].Visible = true;
                    dgv_DanhSachHoaDon.Columns["MaHoaDon"].HeaderText = "Mã hoá đơn";
                    dgv_DanhSachHoaDon.Columns["MaHoaDon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachHoaDon.Columns["NhanVien"].Visible = true;
                    dgv_DanhSachHoaDon.Columns["NhanVien"].HeaderText = "Mã nhân viên";
                    dgv_DanhSachHoaDon.Columns["NhanVien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgv_DanhSachHoaDon.Columns["TenNhanVien"].Visible = true;
                    dgv_DanhSachHoaDon.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
                    dgv_DanhSachHoaDon.Columns["TenNhanVien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachHoaDon.Columns["KhachHang"].Visible = true;
                    dgv_DanhSachHoaDon.Columns["KhachHang"].HeaderText = "Mã khách hàng";
                    dgv_DanhSachHoaDon.Columns["KhachHang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgv_DanhSachHoaDon.Columns["TenKhachHang"].Visible = true;
                    dgv_DanhSachHoaDon.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
                    dgv_DanhSachHoaDon.Columns["TenKhachHang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachHoaDon.Columns["NgayXuat"].Visible = true;
                    dgv_DanhSachHoaDon.Columns["NgayXuat"].HeaderText = "Ngày xuất";
                    dgv_DanhSachHoaDon.Columns["NgayXuat"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgv_DanhSachHoaDon.Columns["NgayXuat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgv_DanhSachHoaDon.Columns["TongTien"].Visible = true;
                    dgv_DanhSachHoaDon.Columns["TongTien"].HeaderText = "Tổng tiền";
                    dgv_DanhSachHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "#,##";
                    dgv_DanhSachHoaDon.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachHoaDon.Columns["DonHang"].Visible = true;
                    dgv_DanhSachHoaDon.Columns["DonHang"].HeaderText = "Đơn hàng";
                    dgv_DanhSachHoaDon.Columns["DonHang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachHoaDon.Columns["DaThanhToan"].Visible = true;
                    dgv_DanhSachHoaDon.Columns["DaThanhToan"].HeaderText = "Đã thanh toán";
                    dgv_DanhSachHoaDon.Columns["DaThanhToan"].DefaultCellStyle.Format = "#,##";
                    dgv_DanhSachHoaDon.Columns["DaThanhToan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachHoaDon.Columns["ConLai"].Visible = true;
                    dgv_DanhSachHoaDon.Columns["ConLai"].HeaderText = "Còn lại";
                    dgv_DanhSachHoaDon.Columns["ConLai"].DefaultCellStyle.Format = "#,##";
                    dgv_DanhSachHoaDon.Columns["ConLai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachHoaDon.Columns["STT"].Width = 50;
                    dgv_DanhSachHoaDon.Columns["Detail"].Width = 60;
                    dgv_DanhSachHoaDon.Columns["Delete"].Width = 60;
                    dgv_DanhSachHoaDon.Columns["Fix"].Width = 60;
                    dgv_DanhSachHoaDon.Columns["MaHoaDon"].Width = 150;
                    dgv_DanhSachHoaDon.Columns["NhanVien"].Width = 120;
                    dgv_DanhSachHoaDon.Columns["NgayXuat"].Width = 120;
                    dgv_DanhSachHoaDon.Columns["TongTien"].Width = 120;
                    dgv_DanhSachHoaDon.Columns["DonHang"].Width = 120;
                    dgv_DanhSachHoaDon.Columns["TenNhanVien"].Width = 400;
                    dgv_DanhSachHoaDon.Columns["TenKhachHang"].Width = 400;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dgv_DanhSachHoaDon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgv_DanhSachHoaDon.Rows.Count > 0)
            {
                if ((e.RowIndex % 2) == 0)
                {
                    dgv_DanhSachHoaDon.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                }
                this.dgv_DanhSachHoaDon.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
            }
        }
        #endregion

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
        
        //Click vào lưới
        private void dgv_DanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Nút xem chi tiết
                if (e.ColumnIndex == dgv_DanhSachHoaDon.Columns["Detail"].Index)
                {
                    HoaDon hd = new HoaDon();
                    hd.MaHoaDon = dgv_DanhSachHoaDon.CurrentRow.Cells["MaHoaDon"].Value.ToString();
                    hd.NhanVien = dgv_DanhSachHoaDon.CurrentRow.Cells["NhanVien"].Value.ToString();
                    hd.KhachHang = dgv_DanhSachHoaDon.CurrentRow.Cells["KhachHang"].Value.ToString();
                    hd.NgayXuat = Convert.ToDateTime(dgv_DanhSachHoaDon.CurrentRow.Cells["NgayXuat"].Value);
                    hd.DonDatHang = dgv_DanhSachHoaDon.CurrentRow.Cells["DonHang"].Value.ToString();
                    hd.TongTien = Convert.ToDecimal(dgv_DanhSachHoaDon.CurrentRow.Cells["TongTien"].Value);
                    hd.DaThanhToan = Convert.ToDecimal(dgv_DanhSachHoaDon.CurrentRow.Cells["DaThanhToan"].Value);
                    hd.ConLai = Convert.ToDecimal(dgv_DanhSachHoaDon.CurrentRow.Cells["ConLai"].Value);
                    hd.DSChiTiet = client.HoaDon_LoadChiTiet(hd.MaHoaDon);
                    uc_SellingInvoiceCreate uc = new uc_SellingInvoiceCreate(hd, true);
                    LoadTab("Chi tiết hoá đơn", uc);
                }
                //Nút sửa
                if (e.ColumnIndex == dgv_DanhSachHoaDon.Columns["Fix"].Index)
                {
                    HoaDon hd = new HoaDon();
                    hd.MaHoaDon = dgv_DanhSachHoaDon.CurrentRow.Cells["MaHoaDon"].Value.ToString();
                    hd.NhanVien = dgv_DanhSachHoaDon.CurrentRow.Cells["NhanVien"].Value.ToString();
                    hd.KhachHang = dgv_DanhSachHoaDon.CurrentRow.Cells["KhachHang"].Value.ToString();
                    hd.NgayXuat = Convert.ToDateTime(dgv_DanhSachHoaDon.CurrentRow.Cells["NgayXuat"].Value);
                    hd.DonDatHang = dgv_DanhSachHoaDon.CurrentRow.Cells["DonHang"].Value.ToString();
                    hd.TongTien = Convert.ToDecimal(dgv_DanhSachHoaDon.CurrentRow.Cells["TongTien"].Value);
                    hd.DaThanhToan = Convert.ToDecimal(dgv_DanhSachHoaDon.CurrentRow.Cells["DaThanhToan"].Value);
                    hd.ConLai = Convert.ToDecimal(dgv_DanhSachHoaDon.CurrentRow.Cells["ConLai"].Value);
                    hd.DSChiTiet = client.HoaDon_LoadChiTiet(hd.MaHoaDon);
                    uc_SellingInvoiceCreate uc = new uc_SellingInvoiceCreate(hd, false);
                    LoadTab("Sửa hoá đơn", uc);
                }
                //Nút xoá
                if (e.ColumnIndex == dgv_DanhSachHoaDon.Columns["Delete"].Index)
                {
                    HoaDon hd = new HoaDon();
                    hd.MaHoaDon = dgv_DanhSachHoaDon.CurrentRow.Cells["MaHoaDon"].Value.ToString();
                    hd.NhanVien = dgv_DanhSachHoaDon.CurrentRow.Cells["NhanVien"].Value.ToString();
                    hd.KhachHang = dgv_DanhSachHoaDon.CurrentRow.Cells["KhachHang"].Value.ToString();
                    hd.NgayXuat = Convert.ToDateTime(dgv_DanhSachHoaDon.CurrentRow.Cells["NgayXuat"].Value);
                    hd.DonDatHang = dgv_DanhSachHoaDon.CurrentRow.Cells["DonHang"].Value.ToString();
                    hd.TongTien = Convert.ToDecimal(dgv_DanhSachHoaDon.CurrentRow.Cells["TongTien"].Value);
                    hd.DaThanhToan = Convert.ToDecimal(dgv_DanhSachHoaDon.CurrentRow.Cells["DaThanhToan"].Value);
                    hd.ConLai = Convert.ToDecimal(dgv_DanhSachHoaDon.CurrentRow.Cells["ConLai"].Value);
                    hd.DSChiTiet = client.HoaDon_LoadChiTiet(hd.MaHoaDon);
                    if (MessageBox.Show("Bạn chắc chắn muốn xoá hoá đơn này", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (client.HoaDon_Delete(hd.MaHoaDon))
                        {
                            MessageBox.Show("Xoá hoá đơn thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xoá hoá đơn thất bại");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Thêm tab trên form main
        public void LoadTab(string nametab, UserControl control)
        {
            try
            {
                TabControl tabCtrl_Main = (this.Parent.Parent.Parent as frm_Main).Controls["tabCtrl_Main"] as TabControl;
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
                throw ex;
            }
        }

        //Nút thêm
        private void pic_Them_Click(object sender, EventArgs e)
        {
            try
            {
                uc_SellingInvoiceCreate uc = new uc_SellingInvoiceCreate();
                LoadTab("Lập hoá đơn", uc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Tìm kiếm đơn hàng
        private void txt_ThongTinTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_DanhSachHoaDon.DataSource = client.HoaDon_GetHoaDon(new HoaDon(), txt_ThongTinTimKiem.Text).Tables[0];
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
