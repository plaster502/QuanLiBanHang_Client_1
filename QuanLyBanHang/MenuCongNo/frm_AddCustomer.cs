using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace QuanLyBanSach.MenuCongNo
{
    public partial class frm_AddCustomer : Form
    {
        KhachHang kh = new KhachHang();
        #region Contructor
        public frm_AddCustomer()
        {
            InitializeComponent();
        }
        public frm_AddCustomer(KhachHang khach)
        {
            InitializeComponent();
            kh = khach;
        }
        #endregion

        //Huỷ bỏ
        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Cập nhật
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checknull())
                {
                    KhachHang obj = new KhachHang();
                    obj.MaKhachHang = txt_MaKhachHang.Text;
                    obj.TenKhachHang = txt_TenKhachHang.Text;
                    obj.DiaChi = txt_DiaChi.Text;
                    obj.SoDienThoai = txt_SoDienThoai.Text;
                    obj.Email = txt_Email.Text;
                    if (string.IsNullOrEmpty(txt_No.Text))
                        obj.SoNo = 0;
                    else
                        obj.SoNo = Convert.ToDecimal(txt_No.Text);
                    if (txt_MaKhachHang.ReadOnly)
                    {
                        if (obj.Update())
                        {
                            MessageBox.Show("Cập nhật nhân viên thành công");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Cập nhật nhân viên thất bại");
                    }
                    else
                    {
                        if (obj.Insert())
                        {
                            MessageBox.Show("Thêm nhân viên thành công");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhân viên thất bại");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Kiểm tra rỗng : trả về true nếu có rỗng
        private bool checknull()
        {
            if(string.IsNullOrEmpty(txt_MaKhachHang.Text))
            {
                MessageBox.Show("Thiếu mã khách hàng");
                txt_MaKhachHang.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(txt_TenKhachHang.Text))
            {
                MessageBox.Show("Thiếu tên khách hàng");
                txt_TenKhachHang.Focus();
                return true;
            }
            return false;
        }

        //Load Form
        private void frm_AddCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(kh.MaKhachHang))
                {
                    txt_MaKhachHang.ReadOnly = true;
                    this.Text = "Sửa thông tin khách hàng";
                    txt_MaKhachHang.Text = kh.MaKhachHang;
                    txt_TenKhachHang.Text = kh.TenKhachHang;
                    txt_DiaChi.Text = kh.DiaChi;
                    txt_SoDienThoai.Text = kh.SoDienThoai;
                    txt_Email.Text = kh.Email;
                    txt_No.Text = kh.SoNo.ToString("#,##");
                }
                else
                {
                    txt_No.Text = "0";
                    this.Text = "Thêm khách hàng";
                }
                txt_No.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
