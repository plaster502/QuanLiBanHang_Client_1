using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBanHang.BanHangService;

namespace QuanLyBanHang.MenuDanhMuc
{
    public partial class uc_Product : UserControl
    {
        string ProductID = "";

        //Contructor
        public uc_Product()
        {
            InitializeComponent();
        }

        #region Load dữ liệu
        private void uc_Book_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData("");
                LoadDonViTinh();
                LoadNhomSanPham();
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
                SanPhamClient client = new SanPhamClient();
                dgv_DanhMucSanPham.DataSource = client.SanPham_Search("").Tables[0];
                FormatGrid();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LoadDonViTinh()
        {
            try
            {
                DonViTinhClient client = new DonViTinhClient();
                BindingSource bds = new BindingSource();
                bds.DataSource = client.DonViTinh_GetData();
                cbo_DonViTinh.DataSource = bds.DataSource;
                cbo_DonViTinh.ValueMember = "MaDonViTinh";
                cbo_DonViTinh.DisplayMember = "TenDonViTinh";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LoadNhomSanPham()
        {
            try
            {
                NhomSanPhamClient client = new NhomSanPhamClient();
                BindingSource bds = new BindingSource();
                bds.DataSource = client.NhomSanPham_GetData();
                cbo_NhomSanPham.DataSource = bds.DataSource;
                cbo_NhomSanPham.ValueMember = "MaNhomSanPham";
                cbo_NhomSanPham.DisplayMember = "TenNhomSanPham";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Format lưới
        private void FormatGrid()
        {
            try
            {
                if (dgv_DanhMucSanPham.DataSource != null && dgv_DanhMucSanPham.Rows.Count >= 0)
                {
                    dgv_DanhMucSanPham.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_DanhMucSanPham.Font, FontStyle.Bold);

                    dgv_DanhMucSanPham.Columns["DonVi"].Visible = false;
                    dgv_DanhMucSanPham.Columns["NhomSanPham"].Visible = false;

                    dgv_DanhMucSanPham.Columns["MaSanPham"].Visible = true;
                    dgv_DanhMucSanPham.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";
                    dgv_DanhMucSanPham.Columns["MaSanPham"].Width = 80;
                    dgv_DanhMucSanPham.Columns["MaSanPham"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgv_DanhMucSanPham.Columns["MaSanPham"].ReadOnly = true;

                    dgv_DanhMucSanPham.Columns["TenSanPham"].Visible = true;
                    dgv_DanhMucSanPham.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
                    dgv_DanhMucSanPham.Columns["TenSanPham"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgv_DanhMucSanPham.Columns["TenSanPham"].ReadOnly = true;

                    dgv_DanhMucSanPham.Columns["MoTa"].Visible = true;
                    dgv_DanhMucSanPham.Columns["MoTa"].HeaderText = "Mô tả";
                    dgv_DanhMucSanPham.Columns["MoTa"].Width = 100;
                    dgv_DanhMucSanPham.Columns["MoTa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgv_DanhMucSanPham.Columns["MoTa"].ReadOnly = true;

                    dgv_DanhMucSanPham.Columns["Thue"].Visible = true;
                    dgv_DanhMucSanPham.Columns["Thue"].HeaderText = "Thuế";
                    dgv_DanhMucSanPham.Columns["Thue"].Width = 120;
                    dgv_DanhMucSanPham.Columns["Thue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgv_DanhMucSanPham.Columns["Thue"].ReadOnly = true;

                    dgv_DanhMucSanPham.Columns["TenDonViTinh"].Visible = true;
                    dgv_DanhMucSanPham.Columns["TenDonViTinh"].HeaderText = "Đơn vị tính";
                    dgv_DanhMucSanPham.Columns["TenDonViTinh"].Width = 120;
                    dgv_DanhMucSanPham.Columns["TenDonViTinh"].ReadOnly = true;

                    dgv_DanhMucSanPham.Columns["TenNhomSP"].Visible = true;
                    dgv_DanhMucSanPham.Columns["TenNhomSP"].HeaderText = "Nhóm sản phẩm";
                    dgv_DanhMucSanPham.Columns["TenNhomSP"].Width = 120;
                    dgv_DanhMucSanPham.Columns["TenNhomSP"].ReadOnly = true;

                    dgv_DanhMucSanPham.Columns["SoLuongTon"].Visible = true;
                    dgv_DanhMucSanPham.Columns["SoLuongTon"].HeaderText = "Số lượng tồn";
                    dgv_DanhMucSanPham.Columns["SoLuongTon"].Width = 80;
                    dgv_DanhMucSanPham.Columns["SoLuongTon"].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dgv_DanhMucSanPham_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgv_DanhMucSanPham.Rows.Count > 0)
            {
                if ((e.RowIndex % 2) == 0)
                {
                    dgv_DanhMucSanPham.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                }
                this.dgv_DanhMucSanPham.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
            }
        }
        #endregion

        //Search thông tin sách
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SanPhamClient client = new SanPhamClient();
                dgv_DanhMucSanPham.DataSource = client.SanPham_Search(txt_Search.Text).Tables[0];
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        //Load dữ liệu từ lưới
        private void dgv_DanhMucSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_DanhMucSanPham.DataSource != null && dgv_DanhMucSanPham.Rows.Count > 0)
                {
                    txt_MaSanPham.Text = dgv_DanhMucSanPham.CurrentRow.Cells["MaSanPham"].Value.ToString();
                    txt_TenSanPham.Text = dgv_DanhMucSanPham.CurrentRow.Cells["TenSanPham"].Value.ToString();
                    txt_MoTa.Text = dgv_DanhMucSanPham.CurrentRow.Cells["MoTa"].Value.ToString();
                    txt_Thue.Text = dgv_DanhMucSanPham.CurrentRow.Cells["Thue"].Value.ToString();
                    cbo_DonViTinh.SelectedValue = dgv_DanhMucSanPham.CurrentRow.Cells["DonVi"].Value.ToString();
                    cbo_NhomSanPham.SelectedValue = dgv_DanhMucSanPham.CurrentRow.Cells["NhomSanPham"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Nút thêm - xoá - sửa
        private void pic_Them_Click(object sender, EventArgs e)
        {
            ProductID = "";
            txt_MaSanPham.ReadOnly = false;
            txt_MaSanPham.Text = "";
            txt_TenSanPham.ReadOnly = false;
            txt_TenSanPham.Text = "";
            txt_MoTa.ReadOnly = false;
            txt_MoTa.Text = "";
            txt_Thue.ReadOnly = false;
            txt_Thue.Text = "";
            cbo_DonViTinh.SelectedValue = 0;
            cbo_NhomSanPham.SelectedValue = 0;
            btn_CapNhat.Visible = true;
        }
        private void pic_Sua_Click(object sender, EventArgs e)
        {
            txt_TenSanPham.ReadOnly = false;
            txt_MoTa.ReadOnly = false;
            txt_Thue.ReadOnly = false;
            ProductID = txt_MaSanPham.Text;
            btn_CapNhat.Visible = true;
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checknull())
                {
                    SanPhamClient client = new SanPhamClient();
                    SanPham sanpham = new SanPham();
                    sanpham.MaSanPham = txt_MaSanPham.Text;
                    sanpham.TenSanPham = txt_TenSanPham.Text;
                    sanpham.MoTa = txt_MoTa.Text;
                    sanpham.Thue = float.Parse(txt_Thue.Text);
                    sanpham.DonViTinh = Convert.ToInt32(cbo_DonViTinh.SelectedValue);
                    sanpham.Nhom = Convert.ToInt32(cbo_NhomSanPham.SelectedValue);
                    if (string.IsNullOrEmpty(ProductID))
                    {//Thêm
                        if (client.SanPham_Insert(sanpham))
                            MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {//Sửa
                        if (client.SanPham_Update(sanpham))
                            MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    btn_CapNhat.Visible = false;
                    LoadData("");

                    txt_MaSanPham.ReadOnly = true;
                    txt_MaSanPham.Text = "";
                    txt_TenSanPham.ReadOnly = true;
                    txt_TenSanPham.Text = "";
                    txt_MoTa.ReadOnly = true;
                    txt_MoTa.Text = "";
                    txt_Thue.ReadOnly = true;
                    txt_Thue.Text = "";
                    cbo_DonViTinh.SelectedValue = 0;
                    cbo_NhomSanPham.SelectedValue = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pic_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                SanPhamClient client = new SanPhamClient();
                if (!string.IsNullOrEmpty(txt_MaSanPham.Text))
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xoá sản phẩm '" + txt_TenSanPham.Text + "' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (client.SanPham_Delete(txt_MaSanPham.Text))
                            MessageBox.Show("Xoá sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadData("");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        //Kiểm tra dữ liệu trước khi insert/ipdate: trả về true nếu có dữ liệu sai
        private bool checknull()
        {
            try
            {
                bool kq = false;
                if (string.IsNullOrEmpty(txt_MaSanPham.Text))
                {
                    kq = true;
                    MessageBox.Show("Thiếu mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_MaSanPham.Focus();
                }
                if (string.IsNullOrEmpty(txt_TenSanPham.Text))
                {
                    kq = true;
                    MessageBox.Show("Thiếu tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_TenSanPham.Focus();
                }
                if (string.IsNullOrEmpty(txt_MoTa.Text))
                {
                    kq = true;
                    MessageBox.Show("Thiếu mô tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_MoTa.Focus();
                }
                if (Convert.ToInt32(cbo_DonViTinh.SelectedValue) == 0)
                {
                    kq = true;
                    MessageBox.Show("Mời chọn đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbo_DonViTinh.Focus();
                }
                if (Convert.ToInt32(cbo_NhomSanPham.SelectedValue) == 0)
                {
                    kq = true;
                    MessageBox.Show("Mời chọn nhóm sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbo_NhomSanPham.Focus();
                }
                if (string.IsNullOrEmpty(txt_Thue.Text))
                {
                    kq = true;
                    MessageBox.Show("Mời chọn thuế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Thue.Focus();
                }
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
