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
    public partial class uc_QuoteList : UserControl
    {
        BaoGiaClient client = new BaoGiaClient();
        //Contructor
        public uc_QuoteList()
        {
            InitializeComponent();
        }

        #region Load Data
        private void uc_QuoteList_Load(object sender, EventArgs e)
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
                BaoGiaClient baogia_client = new BaoGiaClient();
                BaoGia bg = new BaoGia();
                dgv_DanhSachBaoGia.DataSource = baogia_client.BaoGia_GetBaoGia(bg, "").Tables[0];
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
                if (dgv_DanhSachBaoGia.Rows.Count >= 0)
                {
                    dgv_DanhSachBaoGia.Columns["MaBaoGia"].Visible = true;
                    dgv_DanhSachBaoGia.Columns["MaBaoGia"].HeaderText = "Mã báo giá";
                    dgv_DanhSachBaoGia.Columns["MaBaoGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachBaoGia.Columns["NhanVien"].Visible = true;
                    dgv_DanhSachBaoGia.Columns["NhanVien"].HeaderText = "Mã nhân viên";
                    dgv_DanhSachBaoGia.Columns["NhanVien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgv_DanhSachBaoGia.Columns["TenNhanVien"].Visible = true;
                    dgv_DanhSachBaoGia.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
                    dgv_DanhSachBaoGia.Columns["TenNhanVien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachBaoGia.Columns["NgayLap"].Visible = true;
                    dgv_DanhSachBaoGia.Columns["NgayLap"].HeaderText = "Ngày lập";
                    dgv_DanhSachBaoGia.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgv_DanhSachBaoGia.Columns["NgayLap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgv_DanhSachBaoGia.Columns["NgayHetHan"].Visible = true;
                    dgv_DanhSachBaoGia.Columns["NgayHetHan"].HeaderText = "Ngày hết hạn";
                    dgv_DanhSachBaoGia.Columns["NgayHetHan"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgv_DanhSachBaoGia.Columns["NgayHetHan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgv_DanhSachBaoGia.Columns["TongTien"].Visible = true;
                    dgv_DanhSachBaoGia.Columns["TongTien"].HeaderText = "Tổng tiền";
                    dgv_DanhSachBaoGia.Columns["TongTien"].DefaultCellStyle.Format = "#,##";
                    dgv_DanhSachBaoGia.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachBaoGia.Columns["ChietKhau"].Visible = true;
                    dgv_DanhSachBaoGia.Columns["ChietKhau"].HeaderText = "Chiết khấu";
                    dgv_DanhSachBaoGia.Columns["ChietKhau"].DefaultCellStyle.Format = "#,##";
                    dgv_DanhSachBaoGia.Columns["ChietKhau"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dgv_DanhSachBaoGia.Columns["STT"].Width = 50;
                    dgv_DanhSachBaoGia.Columns["Detail"].Width = 60;
                    dgv_DanhSachBaoGia.Columns["Delete"].Width = 60;
                    dgv_DanhSachBaoGia.Columns["Fix"].Width = 60;
                    dgv_DanhSachBaoGia.Columns["MaBaoGia"].Width = 150;
                    dgv_DanhSachBaoGia.Columns["NhanVien"].Width = 120;
                    dgv_DanhSachBaoGia.Columns["NgayLap"].Width = 120;
                    dgv_DanhSachBaoGia.Columns["NgayHetHan"].Width = 120;
                    dgv_DanhSachBaoGia.Columns["TongTien"].Width = 120;
                    dgv_DanhSachBaoGia.Columns["ChietKhau"].Width = 120;
                    dgv_DanhSachBaoGia.Columns["TenNhanVien"].Width = 400;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dgv_DanhSachBaoGia_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgv_DanhSachBaoGia.Rows.Count > 0)
            {
                if ((e.RowIndex % 2) == 0)
                {
                    dgv_DanhSachBaoGia.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                }
                this.dgv_DanhSachBaoGia.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
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
        private void dgv_DanhSachBaoGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Nút xem chi tiết
                if (e.ColumnIndex == dgv_DanhSachBaoGia.Columns["Detail"].Index)
                {
                    BaoGia bg = new BaoGia();
                    bg.MaBaoGia = dgv_DanhSachBaoGia.CurrentRow.Cells["MaBaoGia"].Value.ToString();
                    bg.MaNhanVien = dgv_DanhSachBaoGia.CurrentRow.Cells["NhanVien"].Value.ToString();
                    bg.NgayTao = Convert.ToDateTime(dgv_DanhSachBaoGia.CurrentRow.Cells["NgayLap"].Value);
                    bg.NgayHetHan = Convert.ToDateTime(dgv_DanhSachBaoGia.CurrentRow.Cells["NgayHetHan"].Value);
                    bg.TongTien = Convert.ToDecimal(dgv_DanhSachBaoGia.CurrentRow.Cells["TongTien"].Value);
                    bg.ChietKhau = Convert.ToDecimal(dgv_DanhSachBaoGia.CurrentRow.Cells["ChietKhau"].Value);
                    bg.DSChiTiet = client.BaoGia_LoadChiTiet(bg.MaBaoGia);
                    uc_QuoteCreate uc = new uc_QuoteCreate(bg,true);
                    LoadTab("Chi tiết báo giá", uc);
                }
                //Nút sửa
                if (e.ColumnIndex == dgv_DanhSachBaoGia.Columns["Fix"].Index)
                {
                    BaoGia bg = new BaoGia();
                    bg.MaBaoGia = dgv_DanhSachBaoGia.CurrentRow.Cells["MaBaoGia"].Value.ToString();
                    bg.MaNhanVien = dgv_DanhSachBaoGia.CurrentRow.Cells["NhanVien"].Value.ToString();
                    bg.NgayTao = Convert.ToDateTime(dgv_DanhSachBaoGia.CurrentRow.Cells["NgayLap"].Value);
                    bg.NgayHetHan = Convert.ToDateTime(dgv_DanhSachBaoGia.CurrentRow.Cells["NgayHetHan"].Value);
                    bg.TongTien = Convert.ToDecimal(dgv_DanhSachBaoGia.CurrentRow.Cells["TongTien"].Value);
                    bg.ChietKhau = Convert.ToDecimal(dgv_DanhSachBaoGia.CurrentRow.Cells["ChietKhau"].Value);
                    bg.DSChiTiet = client.BaoGia_LoadChiTiet(bg.MaBaoGia);
                    uc_QuoteCreate uc = new uc_QuoteCreate(bg, false);
                    LoadTab("Sửa báo giá", uc);
                }
                //Nút xoá
                if (e.ColumnIndex == dgv_DanhSachBaoGia.Columns["Delete"].Index)
                {
                    BaoGia bg = new BaoGia();
                    bg.MaBaoGia = dgv_DanhSachBaoGia.CurrentRow.Cells["MaBaoGia"].Value.ToString();
                    bg.MaNhanVien = dgv_DanhSachBaoGia.CurrentRow.Cells["NhanVien"].Value.ToString();
                    bg.NgayTao = Convert.ToDateTime(dgv_DanhSachBaoGia.CurrentRow.Cells["NgayLap"].Value);
                    bg.NgayHetHan = Convert.ToDateTime(dgv_DanhSachBaoGia.CurrentRow.Cells["NgayHetHan"].Value);
                    bg.TongTien = Convert.ToDecimal(dgv_DanhSachBaoGia.CurrentRow.Cells["TongTien"].Value);
                    bg.ChietKhau = Convert.ToDecimal(dgv_DanhSachBaoGia.CurrentRow.Cells["ChietKhau"].Value);
                    bg.DSChiTiet = client.BaoGia_LoadChiTiet(bg.MaBaoGia);
                    if (MessageBox.Show("Bạn chắc chắn muốn xoá báo giá này", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (client.BaoGia_Delete(bg.MaBaoGia))
                        {
                            MessageBox.Show("Xoá báo giá thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xoá báo giá thất bại");
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
                uc_QuoteCreate uc = new uc_QuoteCreate();
                LoadTab("Lập báo giá", uc);
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
                dgv_DanhSachBaoGia.DataSource = client.BaoGia_GetBaoGia(new BaoGia(), txt_ThongTinTimKiem.Text).Tables[0];
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
