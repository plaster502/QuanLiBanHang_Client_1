using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBanHang.BanHangService;

namespace QuanLyBanHang.MenuHeThong
{
    public partial class uc_UnitInfo : UserControl
    {
        DonViClient donvi_client = new DonViClient();

        //Contructor
        public uc_UnitInfo()
        {
            InitializeComponent();
        }

        #region Load thông tin
        private void uc_UnitInfo_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void Line_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen p = new Pen(Color.DimGray, 3);
            l.DrawLine(p, 0, pn_line1.Size.Height / 2, pn_line1.Location.X + pn_line1.Width, pn_line1.Size.Height / 2);
            l.Clip = new System.Drawing.Region(new Rectangle(0, pn_line1.Size.Height / 2, pn_line1.Location.X + pn_line1.Width, pn_line1.Size.Height / 2));
            l.Dispose();
        }
        //Lấy thông tin đơn vị
        private void LoadData()
        {
            DonVi donvi = donvi_client.DonVi_GetData();
            lb_TenDonVi_value.Text = donvi.TenDonVi;
            lb_TenDonVi_value.Visible = true;
            lb_Website_value.Text = donvi.Website;
            lb_Website_value.Visible = true;
            lb_Facebook_value.Text = donvi.Facebook;
            lb_Facebook_value.Visible = true;
            lb_DiaChi_value.Text = donvi.DiaChi;
            lb_DiaChi_value.Visible = true;
            lb_SoDienThoai_value.Text = donvi.SoDienThoai;
            lb_SoDienThoai_value.Visible = true;
            lb_Email_value.Text = donvi.Email;
            lb_Email_value.Visible = true;
            lb_Fax_value.Text = donvi.Fax;
            lb_Fax_value.Visible = true;
            lb_MaSoThue_value.Text = donvi.MaSoThue;
            lb_MaSoThue_value.Visible = true;
            lb_NganHang_value.Text = donvi.NganHang;
            lb_NganHang_value.Visible = true;
            lb_SoTaiKhoan_value.Text = donvi.SoTaiKhoan;
            lb_SoTaiKhoan_value.Visible = true;
        }
        #endregion

        #region Nút Chỉnh sửa/Lưu
        private void lb_ChinhSua_MouseHover(object sender, EventArgs e)
        {
            lb_ChinhSua.LinkColor = Color.Red;
        }
        private void lb_ChinhSua_MouseLeave(object sender, EventArgs e)
        {
            lb_ChinhSua.LinkColor = Color.DimGray;
        }

        private void lb_ChinhSua_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lb_ChinhSua.Text == "Chỉnh sửa")
            {
                ConvertInfo(true);
                lb_ChinhSua.Text = "Lưu";
            }
            else
            {
                ConvertInfo(false);
                DonVi donvi = new DonVi();
                donvi.TenDonVi = txt_TenDonVi_value.Text;
                donvi.Website = txt_Website_value.Text;
                donvi.Facebook = txt_Facebook_value.Text;
                donvi.DiaChi = txt_DiaChi_value.Text;
                donvi.SoDienThoai = txt_SoDienThoai_value.Text;
                donvi.Email = txt_Email_value.Text;
                donvi.Fax = txt_Fax_value.Text;
                donvi.MaSoThue = txt_MaSoThue_value.Text;
                donvi.SoTaiKhoan = txt_SoTaiKhoan_value.Text;
                donvi.NganHang = txt_NganHang_value.Text;
                try
                {
                    if (donvi_client.DonVi_UpdateInfo(donvi))
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                lb_ChinhSua.Text = "Chỉnh sửa";
                LoadData();
            }
        }
        //Load thông tin lên textbox khi bấm "Chỉnh sửa"
        private void ConvertInfo(bool Totxt)
        {
            if (Totxt)
            {
                txt_TenDonVi_value.BringToFront();
                txt_TenDonVi_value.Visible = true;
                lb_TenDonVi_value.Visible = false;
                txt_TenDonVi_value.Text = lb_TenDonVi_value.Text;
                Size s = new System.Drawing.Size(panel2.Width - 285, txt_TenDonVi_value.Size.Height);
                txt_TenDonVi_value.Size = s;

                txt_Website_value.BringToFront();
                txt_Website_value.Visible = true;
                lb_Website_value.Visible = false;
                txt_Website_value.Text = lb_Website_value.Text;
                s = new System.Drawing.Size(panel2.Width - 285, txt_Website_value.Size.Height);
                txt_Website_value.Size = s;

                txt_Facebook_value.BringToFront();
                txt_Facebook_value.Visible = true;
                lb_Facebook_value.Visible = false;
                txt_Facebook_value.Text = lb_Facebook_value.Text;
                s = new System.Drawing.Size(panel2.Width - 285, txt_Facebook_value.Size.Height);
                txt_Facebook_value.Size = s;

                txt_DiaChi_value.BringToFront();
                txt_DiaChi_value.Visible = true;
                lb_DiaChi_value.Visible = false;
                txt_DiaChi_value.Text = lb_DiaChi_value.Text;
                s = new System.Drawing.Size(panel2.Width - 285, txt_DiaChi_value.Size.Height);
                txt_DiaChi_value.Size = s;

                txt_SoDienThoai_value.BringToFront();
                txt_SoDienThoai_value.Visible = true;
                lb_SoDienThoai_value.Visible = false;
                txt_SoDienThoai_value.Text = lb_SoDienThoai_value.Text;
                s = new System.Drawing.Size(panel2.Width - 285, txt_SoDienThoai_value.Size.Height);
                txt_SoDienThoai_value.Size = s;

                txt_Email_value.BringToFront();
                txt_Email_value.Visible = true;
                lb_Email_value.Visible = false;
                txt_Email_value.Text = lb_Email_value.Text;
                s = new System.Drawing.Size(panel2.Width - 285, txt_Email_value.Size.Height);
                txt_Email_value.Size = s;

                txt_Fax_value.BringToFront();
                txt_Fax_value.Visible = true;
                lb_Fax_value.Visible = false;
                txt_Fax_value.Text = lb_Fax_value.Text;
                s = new System.Drawing.Size(panel2.Width - 285, txt_Fax_value.Size.Height);
                txt_Fax_value.Size = s;

                txt_MaSoThue_value.BringToFront();
                txt_MaSoThue_value.Visible = true;
                lb_MaSoThue_value.Visible = false;
                txt_MaSoThue_value.Text = lb_MaSoThue_value.Text;
                s = new System.Drawing.Size(panel2.Width - 285, txt_MaSoThue_value.Size.Height);
                txt_MaSoThue_value.Size = s;

                txt_NganHang_value.BringToFront();
                txt_NganHang_value.Visible = true;
                lb_NganHang_value.Visible = false;
                txt_NganHang_value.Text = lb_NganHang_value.Text;
                s = new System.Drawing.Size(panel2.Width - 285, txt_NganHang_value.Size.Height);
                txt_NganHang_value.Size = s;

                txt_SoTaiKhoan_value.BringToFront();
                txt_SoTaiKhoan_value.Visible = true;
                lb_SoTaiKhoan_value.Visible = false;
                txt_SoTaiKhoan_value.Text = lb_SoTaiKhoan_value.Text;
                s = new System.Drawing.Size(panel2.Width - 285, txt_SoTaiKhoan_value.Size.Height);
                txt_SoTaiKhoan_value.Size = s;
            }
            else
            {
                txt_TenDonVi_value.SendToBack();
                txt_TenDonVi_value.Visible = false;
                lb_TenDonVi_value.Visible = true;

                txt_Website_value.SendToBack();
                txt_Website_value.Visible = false;
                lb_Website_value.Visible = true;

                txt_Facebook_value.SendToBack();
                txt_Facebook_value.Visible = false;
                lb_Facebook_value.Visible = true;

                txt_DiaChi_value.SendToBack();
                txt_DiaChi_value.Visible = false;
                lb_DiaChi_value.Visible = true;

                txt_SoDienThoai_value.SendToBack();
                txt_SoDienThoai_value.Visible = false;
                lb_SoDienThoai_value.Visible = true;

                txt_Email_value.SendToBack();
                txt_Email_value.Visible = false;
                lb_Email_value.Visible = true;

                txt_Fax_value.SendToBack();
                txt_Fax_value.Visible = false;
                lb_Fax_value.Visible = true;

                txt_MaSoThue_value.SendToBack();
                txt_MaSoThue_value.Visible = false;
                lb_MaSoThue_value.Visible = true;

                txt_NganHang_value.SendToBack();
                txt_NganHang_value.Visible = false;
                lb_NganHang_value.Visible = true;

                txt_SoTaiKhoan_value.SendToBack();
                txt_SoTaiKhoan_value.Visible = false;
                lb_SoTaiKhoan_value.Visible = true;
            }
        }
        #endregion
    }
}
