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
    public partial class uc_CustomerInfo : UserControl
    {
        KhachHang kh = new KhachHang();

        #region Contructor
        public uc_CustomerInfo()
        {
            InitializeComponent();
        }
        public uc_CustomerInfo(KhachHang a)
        {
            InitializeComponent();
            kh = a;
            lb_TenKhachHang.Text = a.TenKhachHang;
            lb_DiaChi.Text = "Địa chỉ: "+ a.DiaChi;
            lb_Mail.Text = "Email: "+ a.Email;
            lb_SoDienThoai.Text = "SĐT: "+ a.SoDienThoai;
            lb_No.Text = "Nợ: "+ a.SoNo.ToString("#,##");
        }
        #endregion

        #region Event Control
        private void uc_CustomerInfo_MouseEnter(object sender, EventArgs e)
        {
            pn_Nav.Visible = true;
        }
        private void uc_CustomerInfo_MouseLeave(object sender, EventArgs e)
        {
            if (this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
                return;
            pn_Nav.Visible = false;
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

        //Nút sửa 
        private void pic_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                frm_AddCustomer suakhachhang = new frm_AddCustomer(this.kh);
                pn_Nav.Visible = false;
                suakhachhang.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Nút xóa
        private void pic_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                pn_Nav.Visible = false;
                KhachHang khach = new KhachHang();
                khach.MaKhachHang = kh.MaKhachHang;
                if (MessageBox.Show("Bạn chắc chắn muốn xoá khách hàng '" + kh.TenKhachHang + "' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (khach.Delete())
                    {
                        MessageBox.Show("Xoá khách hàng thành công");
                    }
                    else
                        MessageBox.Show("Xoá khách hàng thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
