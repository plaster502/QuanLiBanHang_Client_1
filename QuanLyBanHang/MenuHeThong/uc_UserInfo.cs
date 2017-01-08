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
using System.IO;

namespace QuanLyBanHang.MenuHeThong
{
    public partial class uc_UserInfo : UserControl
    {
        string _manhanvien = "";
        NhanVienClient client = new NhanVienClient();
        NhanVien user = new NhanVien();
        bool imagenotdefault = false;

        #region Contructor
        public uc_UserInfo()
        {
            InitializeComponent();
        }
        public uc_UserInfo(string MaNV)
        {
            InitializeComponent();
            _manhanvien = MaNV;
        }
        #endregion

        #region Load thông tin
        private void Line_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen p = new Pen(Color.DimGray, 3);
            l.DrawLine(p, 0, pn_line1.Size.Height / 2, pn_line1.Location.X + pn_line1.Width, pn_line1.Size.Height / 2);
            l.Clip = new System.Drawing.Region(new Rectangle(0, pn_line1.Size.Height / 2, pn_line1.Location.X + pn_line1.Width, pn_line1.Size.Height / 2));
            l.Dispose();
        }
        private void uc_UserInfo_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_manhanvien))
            {
                LoadData();
            }
        }
        //Lấy thông tin người dùng
        private void LoadData()
        {
            try
            {
                NhanVien nv = client.NhanVien_GetNhanVienByID(_manhanvien);
                user = nv;
                lb_MaNhanVien_value.Text = nv.MaNhanVien;
                lb_TenNhanVien_value.Text = nv.TenNhanVien;
                lb_NgaySinh_value.Text = nv.NgaySinh.ToString("dd/MM/yyyy");
                if (nv.GioiTinh == "Nam")
                    lb_GioiTinh_value.Text = nv.GioiTinh;
                else
                    lb_GioiTinh_value.Text = "Nữ";
                lb_CMND_value.Text = nv.CMND;
                lb_DiaChi_value.Text = nv.DiaChi;
                lb_SoDienThoai_value.Text = nv.SoDienThoai;
                lb_TenDangNhap_value.Text = nv.TenDangNhap;
                lb_MatKhau_value.Text = "";
                for (int i = 0; i < nv.MatKhau.Length; i++)
                    lb_MatKhau_value.Text += "*";
                if (nv.HinhAnh != null)
                {
                    MemoryStream ms = new MemoryStream(nv.HinhAnh);
                    pic_Ava.Image = Image.FromStream(ms);
                    imagenotdefault = true;
                }
                else
                    imagenotdefault = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Nút Chỉnh sửa / Lưu

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
                try
                {
                    NhanVien nv = new NhanVien();
                    nv.TenDangNhap = txt_TenDangNhap_value.Text;
                    nv.MatKhau = txt_MatKhau_value.Text;
                    if (imagenotdefault)
                    {
                        if (!string.IsNullOrEmpty(pic_Ava.ImageLocation))
                        {
                            FileStream fs = new FileStream(pic_Ava.ImageLocation, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fs);
                            nv.HinhAnh = br.ReadBytes((int)fs.Length);
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream();
                            pic_Ava.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            nv.HinhAnh = ms.ToArray();
                        }
                    }
                    else
                    {
                        nv.HinhAnh = null;
                    }
                    nv.MaNhanVien = _manhanvien;
                    if (client.NhanVien_UpdatePersonalInfo(nv))
                    {
                        MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void ConvertInfo(bool Totxt)
        {
            if (Totxt)
            {
                txt_TenDangNhap_value.BringToFront();
                txt_TenDangNhap_value.Visible = true;
                lb_TenDangNhap_value.Visible = false;
                txt_TenDangNhap_value.Text = lb_TenDangNhap_value.Text;
                Size s = new System.Drawing.Size(panel2.Width - 285, txt_TenDangNhap_value.Size.Height);
                txt_TenDangNhap_value.Size = s;

                txt_MatKhau_value.BringToFront();
                txt_MatKhau_value.Visible = true;
                lb_MatKhau_value.Visible = false;
                txt_MatKhau_value.Text = user.MatKhau;
                s = new System.Drawing.Size(panel2.Width - 285, txt_MatKhau_value.Size.Height);
                txt_MatKhau_value.Size = s;

                btn_Brower.Visible = true;
            }
            else
            {
                txt_TenDangNhap_value.SendToBack();
                txt_TenDangNhap_value.Visible = false;
                lb_TenDangNhap_value.Visible = true;

                txt_MatKhau_value.SendToBack();
                txt_MatKhau_value.Visible = false;
                lb_MatKhau_value.Visible = true;

                btn_Brower.Visible = false;
            }
        }
        #endregion

        //Load hình ảnh
        private void btn_Brower_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|(*.png)|*.png|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Avatar Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pic_Ava.ImageLocation = dlg.FileName.ToString();
                    if (!string.IsNullOrEmpty(pic_Ava.ImageLocation))
                        imagenotdefault = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
