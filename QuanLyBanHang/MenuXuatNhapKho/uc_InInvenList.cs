using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBanHang.BanHangService;

namespace QuanLyBanHang.MenuXuatNhapKho
{
    public partial class uc_InInvenList : UserControl
    {
        PhieuNhapClient client = new PhieuNhapClient();
        //Contructor
        public uc_InInvenList()
        {
            InitializeComponent();
        }

        #region Load Data
        private void uc_InInvenList_Load(object sender, EventArgs e)
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
                PhieuNhap pn = new PhieuNhap();
                dgv_DanhSachPhieuNhap.DataSource = client.PhieuNhap_GetPhieuNhap(pn, "").Tables[0];
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
                if (dgv_DanhSachPhieuNhap.Rows.Count >= 0)
                {
                    dgv_DanhSachPhieuNhap.Columns["MaPhieuNhap"].Visible = true;
                    dgv_DanhSachPhieuNhap.Columns["MaPhieuNhap"].HeaderText = "Mã phiếu nhập";
                    dgv_DanhSachPhieuNhap.Columns["MaPhieuNhap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachPhieuNhap.Columns["NhanVien"].Visible = true;
                    dgv_DanhSachPhieuNhap.Columns["NhanVien"].HeaderText = "Mã nhân viên";
                    dgv_DanhSachPhieuNhap.Columns["NhanVien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgv_DanhSachPhieuNhap.Columns["TenNhanVien"].Visible = true;
                    dgv_DanhSachPhieuNhap.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
                    dgv_DanhSachPhieuNhap.Columns["TenNhanVien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachPhieuNhap.Columns["NgayNhap"].Visible = true;
                    dgv_DanhSachPhieuNhap.Columns["NgayNhap"].HeaderText = "Ngày nhập";
                    dgv_DanhSachPhieuNhap.Columns["NgayNhap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgv_DanhSachPhieuNhap.Columns["NgayNhap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgv_DanhSachPhieuNhap.Columns["TongTien"].Visible = true;
                    dgv_DanhSachPhieuNhap.Columns["TongTien"].HeaderText = "Tổng tiền nhập";
                    dgv_DanhSachPhieuNhap.Columns["TongTien"].DefaultCellStyle.Format = "#,##";
                    dgv_DanhSachPhieuNhap.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachPhieuNhap.Columns["STT"].Width = 50;
                    dgv_DanhSachPhieuNhap.Columns["Detail"].Width = 60;
                    dgv_DanhSachPhieuNhap.Columns["Delete"].Width = 60;
                    dgv_DanhSachPhieuNhap.Columns["Fix"].Width = 60;
                    dgv_DanhSachPhieuNhap.Columns["MaPhieuNhap"].Width = 150;
                    dgv_DanhSachPhieuNhap.Columns["NhanVien"].Width = 120;
                    dgv_DanhSachPhieuNhap.Columns["NgayNhap"].Width = 120;
                    dgv_DanhSachPhieuNhap.Columns["TongTien"].Width = 120;
                    dgv_DanhSachPhieuNhap.Columns["TenNhanVien"].Width = 400;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dgv_DanhSachPhieuNhap_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgv_DanhSachPhieuNhap.Rows.Count > 0)
            {
                if ((e.RowIndex % 2) == 0)
                {
                    dgv_DanhSachPhieuNhap.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                }
                this.dgv_DanhSachPhieuNhap.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
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
        private void dgv_DanhSachPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Nút xem chi tiết
                if (e.ColumnIndex == dgv_DanhSachPhieuNhap.Columns["Detail"].Index)
                {
                    PhieuNhap pn = new PhieuNhap();
                    pn.MaPhieuNhap = dgv_DanhSachPhieuNhap.CurrentRow.Cells["MaPhieuNhap"].Value.ToString();
                    pn.MaNhanVien = dgv_DanhSachPhieuNhap.CurrentRow.Cells["NhanVien"].Value.ToString();
                    pn.NgayNhap = Convert.ToDateTime(dgv_DanhSachPhieuNhap.CurrentRow.Cells["NgayNhap"].Value);
                    pn.TongTien = Convert.ToDecimal(dgv_DanhSachPhieuNhap.CurrentRow.Cells["TongTien"].Value);
                    pn.DSChiTiet = client.PhieuNhap_LoadChiTiet(pn.MaPhieuNhap);
                    uc_InInvenCreate uc = new uc_InInvenCreate(pn, true);
                    LoadTab("Chi tiết phiếu nhập", uc);
                }
                //Nút sửa
                if (e.ColumnIndex == dgv_DanhSachPhieuNhap.Columns["Fix"].Index)
                {
                    PhieuNhap pn = new PhieuNhap();
                    pn.MaPhieuNhap = dgv_DanhSachPhieuNhap.CurrentRow.Cells["MaPhieuNhap"].Value.ToString();
                    pn.MaNhanVien = dgv_DanhSachPhieuNhap.CurrentRow.Cells["NhanVien"].Value.ToString();
                    pn.NgayNhap = Convert.ToDateTime(dgv_DanhSachPhieuNhap.CurrentRow.Cells["NgayNhap"].Value);
                    pn.TongTien = Convert.ToDecimal(dgv_DanhSachPhieuNhap.CurrentRow.Cells["TongTien"].Value);
                    pn.DSChiTiet = client.PhieuNhap_LoadChiTiet(pn.MaPhieuNhap);
                    uc_InInvenCreate uc = new uc_InInvenCreate(pn, false);
                    LoadTab("Sửa phiếu nhập", uc);
                }
                //Nút xoá
                if (e.ColumnIndex == dgv_DanhSachPhieuNhap.Columns["Delete"].Index)
                {
                    PhieuNhap pn = new PhieuNhap();
                    pn.MaPhieuNhap = dgv_DanhSachPhieuNhap.CurrentRow.Cells["MaPhieuNhap"].Value.ToString();
                    pn.MaNhanVien = dgv_DanhSachPhieuNhap.CurrentRow.Cells["NhanVien"].Value.ToString();
                    pn.NgayNhap = Convert.ToDateTime(dgv_DanhSachPhieuNhap.CurrentRow.Cells["NgayNhap"].Value);
                    pn.TongTien = Convert.ToDecimal(dgv_DanhSachPhieuNhap.CurrentRow.Cells["TongTien"].Value);
                    pn.DSChiTiet = client.PhieuNhap_LoadChiTiet(pn.MaPhieuNhap);
                    if (MessageBox.Show("Bạn chắc chắn muốn xoá phiếu nhập này", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (client.PhieuNhap_Delete(pn.MaPhieuNhap))
                        {
                            MessageBox.Show("Xoá phiếu nhập thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xoá phiếu nhập thất bại");
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
                uc_InInvenCreate uc = new uc_InInvenCreate();
                LoadTab("Lập phiếu nhập", uc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Tìm kiếm phiếu nhập
        private void txt_ThongTinTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PhieuNhap pn = new PhieuNhap();
                dgv_DanhSachPhieuNhap.DataSource = client.PhieuNhap_GetPhieuNhap(pn, txt_ThongTinTimKiem.Text).Tables[0];
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
