using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBanHang.BanHangService;

namespace QuanLyBanHang.MenuXuatNhapKho
{
    public partial class uc_OutInvenList : UserControl
    {
        PhieuXuatClient client = new PhieuXuatClient();
        //Contructor
        public uc_OutInvenList()
        {
            InitializeComponent();
        }

        #region Load data
        private void uc_OutInvenList_Load(object sender, EventArgs e)
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
                PhieuXuat px = new PhieuXuat();
                dgv_DanhSachPhieuXuat.DataSource = client.PhieuXuat_GetPhieuXuat(px, "").Tables[0];
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
                if (dgv_DanhSachPhieuXuat.Rows.Count >= 0)
                {
                    dgv_DanhSachPhieuXuat.Columns["MaPhieuXuat"].Visible = true;
                    dgv_DanhSachPhieuXuat.Columns["MaPhieuXuat"].HeaderText = "Mã phiếu xuất";
                    dgv_DanhSachPhieuXuat.Columns["MaPhieuXuat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachPhieuXuat.Columns["KhachHang"].Visible = true;
                    dgv_DanhSachPhieuXuat.Columns["KhachHang"].HeaderText = "Mã khách hàng";
                    dgv_DanhSachPhieuXuat.Columns["KhachHang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgv_DanhSachPhieuXuat.Columns["TenKhachHang"].Visible = true;
                    dgv_DanhSachPhieuXuat.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
                    dgv_DanhSachPhieuXuat.Columns["TenKhachHang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachPhieuXuat.Columns["NhanVien"].Visible = true;
                    dgv_DanhSachPhieuXuat.Columns["NhanVien"].HeaderText = "Mã nhân viên";
                    dgv_DanhSachPhieuXuat.Columns["NhanVien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgv_DanhSachPhieuXuat.Columns["TenNhanVien"].Visible = true;
                    dgv_DanhSachPhieuXuat.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
                    dgv_DanhSachPhieuXuat.Columns["TenNhanVien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachPhieuXuat.Columns["NgayXuat"].Visible = true;
                    dgv_DanhSachPhieuXuat.Columns["NgayXuat"].HeaderText = "Ngày xuất";
                    dgv_DanhSachPhieuXuat.Columns["NgayXuat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv_DanhSachPhieuXuat.Columns["NgayXuat"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    dgv_DanhSachPhieuXuat.Columns["HoaDon"].Visible = true;
                    dgv_DanhSachPhieuXuat.Columns["HoaDon"].HeaderText = "Hoá đơn";
                    dgv_DanhSachPhieuXuat.Columns["HoaDon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachPhieuXuat.Columns["DiaChiNhan"].Visible = true;
                    dgv_DanhSachPhieuXuat.Columns["DiaChiNhan"].HeaderText = "Địa chỉ nhận";
                    dgv_DanhSachPhieuXuat.Columns["DiaChiNhan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachPhieuXuat.Columns["TongTien"].Visible = true;
                    dgv_DanhSachPhieuXuat.Columns["TongTien"].HeaderText = "Tổng tiền";
                    dgv_DanhSachPhieuXuat.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgv_DanhSachPhieuXuat.Columns["TongTien"].DefaultCellStyle.Format = "#,##";
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dgv_DanhSachPhieuXuat_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgv_DanhSachPhieuXuat.Rows.Count > 0)
            {
                if ((e.RowIndex % 2) == 0)
                {
                    dgv_DanhSachPhieuXuat.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                }
                this.dgv_DanhSachPhieuXuat.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
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
        private void dgv_DanhSachPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Nút xem chi tiết
                if (e.ColumnIndex == dgv_DanhSachPhieuXuat.Columns["Detail"].Index)
                {
                    PhieuXuat px = new PhieuXuat();
                    px.MaPhieuXuat = dgv_DanhSachPhieuXuat.CurrentRow.Cells["MaPhieuXuat"].Value.ToString();
                    px.MaKhachHang = dgv_DanhSachPhieuXuat.CurrentRow.Cells["KhachHang"].Value.ToString();
                    px.MaNhanVien = dgv_DanhSachPhieuXuat.CurrentRow.Cells["NhanVien"].Value.ToString();
                    px.NgayXuat = Convert.ToDateTime(dgv_DanhSachPhieuXuat.CurrentRow.Cells["NgayXuat"].Value);
                    px.MaHoaDon = dgv_DanhSachPhieuXuat.CurrentRow.Cells["HoaDon"].Value.ToString();
                    px.DiaChiGiaoHang = dgv_DanhSachPhieuXuat.CurrentRow.Cells["DiaChiNhan"].Value.ToString();
                    px.TongTien = Convert.ToDecimal(dgv_DanhSachPhieuXuat.CurrentRow.Cells["TongTien"].Value);
                    px.DSChiTiet = client.PhieuXuat_LoadChiTiet(px.MaPhieuXuat);
                    uc_OutInvenCreate uc = new uc_OutInvenCreate(px, true);
                    LoadTab("Chi tiết phiếu xuất", uc);
                }
                //Nút sửa
                if (e.ColumnIndex == dgv_DanhSachPhieuXuat.Columns["Fix"].Index)
                {
                    PhieuXuat px = new PhieuXuat();
                    px.MaPhieuXuat = dgv_DanhSachPhieuXuat.CurrentRow.Cells["MaPhieuXuat"].Value.ToString();
                    px.MaKhachHang = dgv_DanhSachPhieuXuat.CurrentRow.Cells["KhachHang"].Value.ToString();
                    px.MaNhanVien = dgv_DanhSachPhieuXuat.CurrentRow.Cells["NhanVien"].Value.ToString();
                    px.NgayXuat = Convert.ToDateTime(dgv_DanhSachPhieuXuat.CurrentRow.Cells["NgayXuat"].Value);
                    px.MaHoaDon = dgv_DanhSachPhieuXuat.CurrentRow.Cells["HoaDon"].Value.ToString();
                    px.DiaChiGiaoHang = dgv_DanhSachPhieuXuat.CurrentRow.Cells["DiaChiNhan"].Value.ToString();
                    px.TongTien = Convert.ToDecimal(dgv_DanhSachPhieuXuat.CurrentRow.Cells["TongTien"].Value);
                    px.DSChiTiet = client.PhieuXuat_LoadChiTiet(px.MaPhieuXuat);
                    uc_OutInvenCreate uc = new uc_OutInvenCreate(px, false);
                    LoadTab("Sửa phiếu xuất", uc);
                }
                //Nút xoá
                if (e.ColumnIndex == dgv_DanhSachPhieuXuat.Columns["Delete"].Index)
                {
                    PhieuXuat px = new PhieuXuat();
                    px.MaPhieuXuat = dgv_DanhSachPhieuXuat.CurrentRow.Cells["MaPhieuXuat"].Value.ToString();
                    px.MaKhachHang = dgv_DanhSachPhieuXuat.CurrentRow.Cells["KhachHang"].Value.ToString();
                    px.MaNhanVien = dgv_DanhSachPhieuXuat.CurrentRow.Cells["NhanVien"].Value.ToString();
                    px.NgayXuat = Convert.ToDateTime(dgv_DanhSachPhieuXuat.CurrentRow.Cells["NgayXuat"].Value);
                    px.MaHoaDon = dgv_DanhSachPhieuXuat.CurrentRow.Cells["HoaDon"].Value.ToString();
                    px.DiaChiGiaoHang = dgv_DanhSachPhieuXuat.CurrentRow.Cells["DiaChiNhan"].Value.ToString();
                    px.TongTien = Convert.ToDecimal(dgv_DanhSachPhieuXuat.CurrentRow.Cells["TongTien"].Value);
                    px.DSChiTiet = client.PhieuXuat_LoadChiTiet(px.MaPhieuXuat);
                    if (MessageBox.Show("Bạn chắc chắn muốn xoá phiếu xuất này", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (client.PhieuXuat_Delete(px.MaPhieuXuat))
                        {
                            MessageBox.Show("Xoá phiếu xuất thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xoá phiếu xuất thất bại");
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
                uc_OutInvenCreate uc = new uc_OutInvenCreate();
                LoadTab("Thêm phiếu xuất", uc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Tìm kiếm phiếu xuất
        private void txt_ThongTinTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PhieuXuat px = new PhieuXuat();
                dgv_DanhSachPhieuXuat.DataSource = client.PhieuXuat_GetPhieuXuat(px, txt_ThongTinTimKiem.Text);
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
