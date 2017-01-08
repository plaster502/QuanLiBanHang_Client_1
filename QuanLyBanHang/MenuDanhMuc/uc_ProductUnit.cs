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

namespace QuanLyBanHang.MenuDanhMuc
{
    public partial class uc_ProductUnit : UserControl
    {
        string ProductUnitID = "";

        //Contructor
        public uc_ProductUnit()
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

        private void pic_Sua_MouseHover(object sender, EventArgs e)
        {
            pic_Sua.BackColor = Color.Gainsboro;
        }
        private void pic_Sua_MouseLeave(object sender, EventArgs e)
        {
            pic_Sua.BackColor = Color.Transparent;
        }

        private void pic_Xoa_MouseHover(object sender, EventArgs e)
        {
            pic_Xoa.BackColor = Color.Gainsboro;
        }
        private void pic_Xoa_MouseLeave(object sender, EventArgs e)
        {
            pic_Xoa.BackColor = Color.Transparent;
        }
        #endregion

        #region Load dữ liệu
        private void uc_ProductUnit_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadData(string swhere)
        {
            try
            {
                DonViTinhClient client = new DonViTinhClient();
                BindingSource bds = new BindingSource();
                bds.DataSource = client.DonViTinh_Search(swhere);
                dgv_DanhMucDVTinh.DataSource = bds.DataSource;
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
                if (dgv_DanhMucDVTinh.DataSource != null && dgv_DanhMucDVTinh.Rows.Count >= 0)
                {
                    dgv_DanhMucDVTinh.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_DanhMucDVTinh.Font, FontStyle.Bold);

                    dgv_DanhMucDVTinh.Columns["MaDonViTinh"].Visible = true;
                    dgv_DanhMucDVTinh.Columns["MaDonViTinh"].HeaderText = "Mã đơn vị tính";
                    dgv_DanhMucDVTinh.Columns["MaDonViTinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgv_DanhMucDVTinh.Columns["MaDonViTinh"].ReadOnly = true;

                    dgv_DanhMucDVTinh.Columns["TenDonViTinh"].Visible = true;
                    dgv_DanhMucDVTinh.Columns["TenDonViTinh"].HeaderText = "Tên đơn vị tính";
                    dgv_DanhMucDVTinh.Columns["TenDonViTinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgv_DanhMucDVTinh.Columns["TenDonViTinh"].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dgv_DanhMucDVTinh_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgv_DanhMucDVTinh.Rows.Count > 0)
            {
                if ((e.RowIndex % 2) == 0)
                {
                    dgv_DanhMucDVTinh.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                }
                this.dgv_DanhMucDVTinh.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
            }
        }
        #endregion

        //Khung tìm kiếm
        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                LoadData(txt_Search.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Load thông tin từ lưới lên form
        private void dgv_DanhMucDVTinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_DanhMucDVTinh.DataSource != null && dgv_DanhMucDVTinh.Rows.Count > 0)
                {
                    txt_MaDonViTinh.Text = dgv_DanhMucDVTinh.CurrentRow.Cells["MaDonViTinh"].Value.ToString();
                    txt_TenDonViTinh.Text = dgv_DanhMucDVTinh.CurrentRow.Cells["TenDonViTinh"].Value.ToString();

                    txt_MaDonViTinh.ReadOnly = true;
                    txt_TenDonViTinh.ReadOnly = true;

                    btn_CapNhat.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Thêm - Xoá - Sửa
        private void pic_Them_Click(object sender, EventArgs e)
        {
            ProductUnitID = "";
            txt_MaDonViTinh.ReadOnly = false;
            txt_MaDonViTinh.Text = "";
            txt_TenDonViTinh.ReadOnly = false;
            txt_TenDonViTinh.Text = "";
            btn_CapNhat.Visible = true;
        }
        private void pic_Sua_Click(object sender, EventArgs e)
        {
            txt_MaDonViTinh.ReadOnly = true;
            txt_TenDonViTinh.ReadOnly = false;
            ProductUnitID = txt_MaDonViTinh.Text;
            btn_CapNhat.Visible = true;
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Checknull())
                {
                    DonViTinhClient client = new DonViTinhClient();
                    DonViTinh dvt = new DonViTinh();
                    dvt.MaDonViTinh = Convert.ToInt32(txt_MaDonViTinh.Text);
                    dvt.TenDonViTinh = txt_TenDonViTinh.Text;
                    //Cập nhật thông tin
                    if (!string.IsNullOrEmpty(ProductUnitID))
                    {
                        if (client.DonViTinh_Update(dvt))
                        {
                            MessageBox.Show("Cập nhật đơn vị tính thành công");
                            LoadData("");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật đơn vị tính thất bại");
                        }
                    }
                    else
                    {
                        if (client.DonViTinh_Insert(dvt))
                        {
                            MessageBox.Show("Thêm đơn vị tính thành công");
                            LoadData("");
                        }
                        else
                            MessageBox.Show("Thêm đơn vị tính thất bại");
                    }
                    txt_MaDonViTinh.ReadOnly = true;
                    txt_TenDonViTinh.ReadOnly = true;
                    btn_CapNhat.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Kiểm tra thiếu dữ liệu : true- thiếu
        private bool Checknull()
        {
            try
            {
                if (string.IsNullOrEmpty(txt_MaDonViTinh.Text))
                {
                    txt_MaDonViTinh.Focus();
                    MessageBox.Show("Thiếu 'mã đơn vị tính' ", "Thông báo");
                    return true;
                }
                if (string.IsNullOrEmpty(txt_TenDonViTinh.Text))
                {
                    txt_TenDonViTinh.Focus();
                    MessageBox.Show("Thiếu 'tên đơn vị tính'", "Thống báo");
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Nút xoá
        private void pic_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DonViTinhClient client = new DonViTinhClient();
                if (!string.IsNullOrEmpty(txt_MaDonViTinh.Text))
                {
                    if (client.DonViTinh_Delete(Convert.ToInt32(txt_MaDonViTinh.Text)))
                    {
                        MessageBox.Show("Xoá đơn vị tính thành công");
                        LoadData("");
                    }
                    else
                    {
                        MessageBox.Show("Xoá đơn vị tính thất bại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
