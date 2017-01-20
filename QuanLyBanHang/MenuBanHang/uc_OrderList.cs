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
    public partial class uc_OrderList : UserControl
    {
        DonDatHangClient client = new DonDatHangClient();
        //Contructor
        public uc_OrderList()
        {
            InitializeComponent();
        }

        #region Load Data
        private void uc_OrderList_Load(object sender, EventArgs e)
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
                DonDatHangClient donhang_client = new DonDatHangClient();
                DonDatHang dh = new DonDatHang();
                dgv_DanhSachDonHang.DataSource = donhang_client.DonDatHang_GetDonHang(dh, "").Tables[0];
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
                if (dgv_DanhSachDonHang.Rows.Count >= 0)
                {
                    dgv_DanhSachDonHang.Columns["MaDonHang"].Visible = true;
                    dgv_DanhSachDonHang.Columns["MaDonHang"].HeaderText = "Mã đơn hàng";
                    dgv_DanhSachDonHang.Columns["MaDonHang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachDonHang.Columns["NhanVien"].Visible = true;
                    dgv_DanhSachDonHang.Columns["NhanVien"].HeaderText = "Mã nhân viên";
                    dgv_DanhSachDonHang.Columns["NhanVien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgv_DanhSachDonHang.Columns["TenNhanVien"].Visible = true;
                    dgv_DanhSachDonHang.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
                    dgv_DanhSachDonHang.Columns["TenNhanVien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachDonHang.Columns["KhachHang"].Visible = true;
                    dgv_DanhSachDonHang.Columns["KhachHang"].HeaderText = "Mã khách hàng";
                    dgv_DanhSachDonHang.Columns["KhachHang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgv_DanhSachDonHang.Columns["TenKhachHang"].Visible = true;
                    dgv_DanhSachDonHang.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
                    dgv_DanhSachDonHang.Columns["TenKhachHang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachDonHang.Columns["NgayLap"].Visible = true;
                    dgv_DanhSachDonHang.Columns["NgayLap"].HeaderText = "Ngày lập";
                    dgv_DanhSachDonHang.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgv_DanhSachDonHang.Columns["NgayLap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgv_DanhSachDonHang.Columns["TongTien"].Visible = true;
                    dgv_DanhSachDonHang.Columns["TongTien"].HeaderText = "Tổng tiền";
                    dgv_DanhSachDonHang.Columns["TongTien"].DefaultCellStyle.Format = "#,##";
                    dgv_DanhSachDonHang.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachDonHang.Columns["STT"].Width = 50;
                    dgv_DanhSachDonHang.Columns["Detail"].Width = 60;
                    dgv_DanhSachDonHang.Columns["Delete"].Width = 60;
                    dgv_DanhSachDonHang.Columns["Fix"].Width = 60;
                    dgv_DanhSachDonHang.Columns["MaDonHang"].Width = 150;
                    dgv_DanhSachDonHang.Columns["NhanVien"].Width = 120;
                    dgv_DanhSachDonHang.Columns["KhachHang"].Width = 120;
                    dgv_DanhSachDonHang.Columns["NgayLap"].Width = 120;
                    dgv_DanhSachDonHang.Columns["TongTien"].Width = 120;
                    dgv_DanhSachDonHang.Columns["TenNhanVien"].Width = 400;
                    dgv_DanhSachDonHang.Columns["TenKhachHang"].Width = 400;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dgv_DanhSachDonHang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgv_DanhSachDonHang.Rows.Count > 0)
            {
                if ((e.RowIndex % 2) == 0)
                {
                    dgv_DanhSachDonHang.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                }
                this.dgv_DanhSachDonHang.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
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
        private void dgv_DanhSachDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Nút xem chi tiết
                if (e.ColumnIndex == dgv_DanhSachDonHang.Columns["Detail"].Index)
                {
                    DonDatHang dh = new DonDatHang();
                    dh.MaDonHang = dgv_DanhSachDonHang.CurrentRow.Cells["MaDonHang"].Value.ToString();
                    dh.MaNhanVien = dgv_DanhSachDonHang.CurrentRow.Cells["NhanVien"].Value.ToString();
                    dh.MaKhachHang = dgv_DanhSachDonHang.CurrentRow.Cells["KhachHang"].Value.ToString();
                    dh.NgayTao = Convert.ToDateTime(dgv_DanhSachDonHang.CurrentRow.Cells["NgayLap"].Value);
                    dh.TongTien = Convert.ToDecimal(dgv_DanhSachDonHang.CurrentRow.Cells["TongTien"].Value);
                    dh.DSChiTiet = client.DonDatHang_LoadChiTiet(dh.MaDonHang);
                    uc_OrderCreate uc = new uc_OrderCreate(dh, true);
                    LoadTab("Chi tiết đơn hàng", uc);
                }
                //Nút sửa
                if (e.ColumnIndex == dgv_DanhSachDonHang.Columns["Fix"].Index)
                {
                    DonDatHang dh = new DonDatHang();
                    dh.MaDonHang = dgv_DanhSachDonHang.CurrentRow.Cells["MaDonHang"].Value.ToString();
                    dh.MaNhanVien = dgv_DanhSachDonHang.CurrentRow.Cells["NhanVien"].Value.ToString();
                    dh.MaKhachHang = dgv_DanhSachDonHang.CurrentRow.Cells["KhachHang"].Value.ToString();
                    dh.NgayTao = Convert.ToDateTime(dgv_DanhSachDonHang.CurrentRow.Cells["NgayLap"].Value);
                    dh.TongTien = Convert.ToDecimal(dgv_DanhSachDonHang.CurrentRow.Cells["TongTien"].Value);
                    dh.DSChiTiet = client.DonDatHang_LoadChiTiet(dh.MaDonHang);
                    uc_OrderCreate uc = new uc_OrderCreate(dh, false);
                    LoadTab("Sửa đơn hàng", uc);
                }
                //Nút xoá
                if (e.ColumnIndex == dgv_DanhSachDonHang.Columns["Delete"].Index)
                {
                    DonDatHang dh = new DonDatHang();
                    dh.MaDonHang = dgv_DanhSachDonHang.CurrentRow.Cells["MaDonHang"].Value.ToString();
                    dh.MaNhanVien = dgv_DanhSachDonHang.CurrentRow.Cells["NhanVien"].Value.ToString();
                    dh.MaKhachHang = dgv_DanhSachDonHang.CurrentRow.Cells["KhachHang"].Value.ToString();
                    dh.NgayTao = Convert.ToDateTime(dgv_DanhSachDonHang.CurrentRow.Cells["NgayLap"].Value);
                    dh.TongTien = Convert.ToDecimal(dgv_DanhSachDonHang.CurrentRow.Cells["TongTien"].Value);
                    dh.DSChiTiet = client.DonDatHang_LoadChiTiet(dh.MaDonHang);
                    if (MessageBox.Show("Bạn chắc chắn muốn xoá đơn hàng này", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (client.DonDatHang_Delete(dh.MaDonHang))
                        {
                            MessageBox.Show("Xoá đơn hàng thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xoá đơn hàng thất bại");
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
                uc_OrderCreate uc = new uc_OrderCreate();
                LoadTab("Lập đơn hàng", uc);
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
                dgv_DanhSachDonHang.DataSource = client.DonDatHang_GetDonHang(new DonDatHang(), txt_ThongTinTimKiem.Text).Tables[0];
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
