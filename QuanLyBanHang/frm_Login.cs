using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.BanHangService;
namespace QuanLyBanHang
{
    public partial class frm_Login : Form
    {
        private bool mouseIsDown = false;
        private Point firstPoint;
        private NhanVienClient client = new NhanVienClient();
        //Contructor
        public frm_Login()
        {
            InitializeComponent();
        }

        #region Nút đăng nhập
        private void pic_LogIn_MouseHover(object sender, EventArgs e)
        {
            pic_LogIn.Image = Properties.Resources.dangnhap2;
        }
        private void pic_LogIn_MouseLeave(object sender, EventArgs e)
        {
            pic_LogIn.Image = Properties.Resources.dangnhap1;
        }
        private void pic_LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                string userid = client.NhanVien_CheckLogIn(txt_Account.Text, txt_Password.Text);
                if (userid != "")
                {
                    frm_Main main = new frm_Main(userid);
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản và mật khẩu sai ! Yêu cầu kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Nút thoát
        private void pic_Exit_MouseHover(object sender, EventArgs e)
        {
            pic_Exit.Image = Properties.Resources.thoat2;
        }
        private void pic_Exit_MouseLeave(object sender, EventArgs e)
        {
            pic_Exit.Image = Properties.Resources.thoat1;
        }
        private void pic_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Di chuyển form
        private void frm_Login_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
        }
        private void frm_Login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }
        private void frm_Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                // Get the difference between the two points
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }
        #endregion

    }
}
