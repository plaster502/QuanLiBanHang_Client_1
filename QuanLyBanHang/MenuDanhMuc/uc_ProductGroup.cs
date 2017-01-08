using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBanHang.BanHangService;

namespace QuanLyBanHang.MenuDanhMuc
{
    public partial class uc_ProductGroup : UserControl
    {
        string ProductGroupID = "";

        //Contructor
        public uc_ProductGroup()
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
        private void uc_ProductGroup_Load(object sender, EventArgs e)
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
                NhomSanPhamClient client = new NhomSanPhamClient();
                BindingSource bds = new BindingSource();
                bds.DataSource = client.NhomSanPham_Search(swhere);
                dgv_DanhMucNhomSP.DataSource = bds.DataSource;
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
                if (dgv_DanhMucNhomSP.DataSource != null && dgv_DanhMucNhomSP.Rows.Count >= 0)
                {
                    dgv_DanhMucNhomSP.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_DanhMucNhomSP.Font, FontStyle.Bold);

                    dgv_DanhMucNhomSP.Columns["MaNhomSanPham"].Visible = true;
                    dgv_DanhMucNhomSP.Columns["MaNhomSanPham"].HeaderText = "Mã nhóm sp";
                    dgv_DanhMucNhomSP.Columns["MaNhomSanPham"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgv_DanhMucNhomSP.Columns["MaNhomSanPham"].ReadOnly = true;

                    dgv_DanhMucNhomSP.Columns["TenNhomSanPham"].Visible = true;
                    dgv_DanhMucNhomSP.Columns["TenNhomSanPham"].HeaderText = "Tên nhóm sp";
                    dgv_DanhMucNhomSP.Columns["TenNhomSanPham"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgv_DanhMucNhomSP.Columns["TenNhomSanPham"].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dgv_DanhMucQuiDinh_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgv_DanhMucNhomSP.Rows.Count > 0)
            {
                if ((e.RowIndex % 2) == 0)
                {
                    dgv_DanhMucNhomSP.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                }
                this.dgv_DanhMucNhomSP.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
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
        private void dgv_DanhMucQuiDinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_DanhMucNhomSP.DataSource != null && dgv_DanhMucNhomSP.Rows.Count > 0)
                {
                    txt_MaNhomSP.Text = dgv_DanhMucNhomSP.CurrentRow.Cells["MaNhomSanPham"].Value.ToString();
                    txt_TenNhomSP.Text = dgv_DanhMucNhomSP.CurrentRow.Cells["TenNhomSanPham"].Value.ToString();
                    
                    txt_MaNhomSP.ReadOnly = true;
                    txt_TenNhomSP.ReadOnly = true;
                    
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
            ProductGroupID = "";
            txt_MaNhomSP.ReadOnly = false;
            txt_MaNhomSP.Text = "";
            txt_TenNhomSP.ReadOnly = false;
            txt_TenNhomSP.Text = "";
            btn_CapNhat.Visible = true;
        }
        private void pic_Sua_Click(object sender, EventArgs e)
        {
            txt_MaNhomSP.ReadOnly = true;
            txt_TenNhomSP.ReadOnly = false;
            ProductGroupID = txt_MaNhomSP.Text;
            btn_CapNhat.Visible = true;
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Checknull())
                {
                    NhomSanPhamClient client = new NhomSanPhamClient();
                    NhomSanPham nsp = new NhomSanPham();
                    nsp.MaNhomSanPham = Convert.ToInt32(txt_MaNhomSP.Text);
                    nsp.TenNhomSanPham = txt_TenNhomSP.Text;
                    //Cập nhật thông tin
                    if (!string.IsNullOrEmpty(ProductGroupID))
                    {
                        if (client.NhomSanPham_Update(nsp))
                        {
                            MessageBox.Show("Cập nhật nhóm sản phẩm thành công");
                            LoadData("");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật nhóm sản phẩm thất bại");
                        }
                    }
                    else
                    {
                        if (client.NhomSanPham_Insert(nsp))
                        {
                            MessageBox.Show("Thêm nhóm sản phẩm thành công");
                            LoadData("");
                        }
                        else
                            MessageBox.Show("Thêm nhóm sản phẩm thất bại");
                    }
                    txt_MaNhomSP.ReadOnly = true;
                    txt_TenNhomSP.ReadOnly = true;
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
                if (string.IsNullOrEmpty(txt_MaNhomSP.Text))
                {
                    txt_MaNhomSP.Focus();
                    MessageBox.Show("Thiếu 'mã nhóm sản phẩm' ", "Thông báo");
                    return true;
                }
                if (string.IsNullOrEmpty(txt_TenNhomSP.Text))
                {
                    txt_TenNhomSP.Focus();
                    MessageBox.Show("Thiếu 'tên nhóm sản phẩm'", "Thống báo");
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
                NhomSanPhamClient client = new NhomSanPhamClient();
                if (!string.IsNullOrEmpty(txt_MaNhomSP.Text))
                {
                    if (client.NhomSanPham_Delete(Convert.ToInt32(txt_MaNhomSP.Text)))
                    {
                        MessageBox.Show("Xoá nhóm sản phẩm thành công");
                        LoadData("");
                    }
                    else
                    {
                        MessageBox.Show("Xoá nhóm sản phẩm thất bại");
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
