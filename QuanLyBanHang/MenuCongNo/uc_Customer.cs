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
    public partial class uc_Customer : UserControl
    {
        //Contructor
        public uc_Customer()
        {
            InitializeComponent();
        }

        #region Load Data
        private void uc_Customer_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadData(string swhere)
        {
            try
            {
                KhachHang kh = new KhachHang();
                DataTable listkh = kh.GetKhachHang(swhere);
                FormatControl(listkh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void FormatControl(DataTable danhsachkhachhang)
        {
            try
            {
                if (danhsachkhachhang.Rows.Count > 0)
                {
                    int width = this.Parent.Parent.Width;
                    int Cusinline = width / 240;//số khách trên 1 dòng
                    for (int i = 0; i < danhsachkhachhang.Rows.Count; i++)
                    {
                        KhachHang kh = new KhachHang();
                        kh.MaKhachHang = danhsachkhachhang.Rows[i]["MaKhachHang"].ToString();
                        kh.TenKhachHang = danhsachkhachhang.Rows[i]["TenKhachHang"].ToString();
                        kh.DiaChi = danhsachkhachhang.Rows[i]["DiaChi"].ToString();
                        kh.SoDienThoai = danhsachkhachhang.Rows[i]["SoDienThoai"].ToString();
                        kh.Email = danhsachkhachhang.Rows[i]["Email"].ToString();
                        kh.SoNo = Convert.ToDecimal(danhsachkhachhang.Rows[i]["SoNo"].ToString());

                        uc_CustomerInfo a = new uc_CustomerInfo(kh);
                        a.Location = new Point(10 + (240 * (i % Cusinline)), 10 + (142 * (i / Cusinline)));
                        pn_Customer.Controls.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
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

        private void pic_Refresh_MouseHover(object sender, EventArgs e)
        {
            pic_Refresh.BackColor = Color.Gainsboro;
        }
        private void pic_Refresh_MouseLeave(object sender, EventArgs e)
        {
            pic_Refresh.BackColor = Color.Transparent;
        }
        #endregion

        //Nút thêm
        private void pic_Them_Click(object sender, EventArgs e)
        {
            try
            {
                frm_AddCustomer addfrm = new frm_AddCustomer();
                addfrm.ShowDialog();
                LoadData("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Nút refresh
        private void pic_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                pn_Customer.Controls.Clear();
                LoadData("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Tìm kiếm
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pn_Customer.Controls.Clear();
                string dk = "and ((MaKhachHang like '%" + txt_Search.Text + "%') or (TenKhachHang like N'%" + txt_Search.Text + "%') or (DiaChi like N'%" + txt_Search + "%') or (SoDienThoai like N'%" + txt_Search + "%') or (Email like N'%" + txt_Search.Text + "%'))";
                LoadData(dk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
