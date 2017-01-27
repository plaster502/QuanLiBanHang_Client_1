using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBanHang.BanHangService;
using System.Collections.Generic;
using System.Xml;
namespace QuanLyBanHang
{
    public partial class frm_Login : Form
    {
        private bool mouseIsDown = false;
        private Point firstPoint;
        private NhanVienClient client = new NhanVienClient();
        private List<NhanNgonNgu> listlabel = new List<NhanNgonNgu>();
        //Contructor
        public frm_Login()
        {
            InitializeComponent();
        }

        // Nút đăng nhập
        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                string userid = client.NhanVien_CheckLogIn(txt_Account.Text, txt_Password.Text);
                if (userid != "")
                {
                    frm_Main main = new frm_Main(userid, listlabel);
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

        // Nút thoát
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void frm_Login_Load(object sender, EventArgs e)
        {
            GetLanguage();
            this.Text = listlabel[0].Chu;
            btn_LogIn.Text = listlabel[0].Chu;
            btn_Exit.Text = listlabel[1].Chu;
        }
        
        //lấy mã ngôn ngữ
        private void GetLanguage()
        {
            int languagecode = 0;
            XmlTextReader reader = new XmlTextReader(Application.StartupPath + @"\\AppSetting.xml");
            reader.WhitespaceHandling = WhitespaceHandling.None;
            reader.Read();
            while (!reader.EOF)
            {
                if (reader.Name == "appsetting" && !reader.IsStartElement())
                    break;
                reader.Read();
                reader.Read();
                languagecode = Convert.ToInt32(reader.ReadElementString("language"));
            }
            reader.Close();

            NhanNgonNguClient client = new NhanNgonNguClient();
            listlabel = new List<NhanNgonNgu>(client.NhanNgonNgu_GetLabelByLang(languagecode));
        }
    }
}
