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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;

namespace QuanLyBanHang.MenuNhanVien
{
    public partial class uc_StaffList : UserControl
    {
        bool imagedefault = true;

        //Contructor
        public uc_StaffList()
        {
            InitializeComponent();
        }

        #region Load dữ liệu
        private void uc_StaffList_Load(object sender, EventArgs e)
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
        private void LoadData(string strsearch)
        {
            try
            {
                NhanVienClient client = new NhanVienClient();
                DataTable dtb = client.NhanVien_GetNhanVien(new NhanVien(), strsearch).Tables[0];
                dgv_DsNhanVien.DataSource = dtb;
                FormatGrid();
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
                if (dgv_DsNhanVien.DataSource != null && grid_DsNhanVien.RowCount >= 0)
                {
                    grid_DsNhanVien.Columns["HinhAnh"].Visible = false;
                    grid_DsNhanVien.Columns["TenDangNhap"].Visible = false;
                    grid_DsNhanVien.Columns["MatKhau"].Visible = false;
                    grid_DsNhanVien.Columns["Quyen"].Visible = false;

                    grid_DsNhanVien.Columns["MaNhanVien"].Visible = true;
                    grid_DsNhanVien.Columns["MaNhanVien"].Caption = "Mã Nhân viên";
                    grid_DsNhanVien.Columns["MaNhanVien"].Width = 60;

                    grid_DsNhanVien.Columns["TenNhanVien"].Visible = true;
                    grid_DsNhanVien.Columns["TenNhanVien"].Caption = "Tên Nhân viên";
                    grid_DsNhanVien.Columns["TenNhanVien"].Width = 100;

                    grid_DsNhanVien.Columns["NgaySinh"].Visible = true;
                    grid_DsNhanVien.Columns["NgaySinh"].Caption = "Ngày sinh";
                    grid_DsNhanVien.Columns["NgaySinh"].Width = 80;
                    grid_DsNhanVien.Columns["NgaySinh"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    grid_DsNhanVien.Columns["NgaySinh"].DisplayFormat.FormatString = "d";

                    grid_DsNhanVien.Columns["GioiTinh"].Visible = true;
                    grid_DsNhanVien.Columns["GioiTinh"].Caption = "Giới tính";
                    grid_DsNhanVien.Columns["GioiTinh"].Width = 40;

                    grid_DsNhanVien.Columns["CMND"].Visible = true;
                    grid_DsNhanVien.Columns["CMND"].Caption = "CMND";
                    grid_DsNhanVien.Columns["CMND"].Width = 60;

                    grid_DsNhanVien.Columns["DiaChi"].Visible = true;
                    grid_DsNhanVien.Columns["DiaChi"].Caption = "Địa chỉ";
                    grid_DsNhanVien.Columns["DiaChi"].Width = 180;

                    grid_DsNhanVien.Columns["SoDienThoai"].Visible = true;
                    grid_DsNhanVien.Columns["SoDienThoai"].Caption= "Số điện thoại";
                    grid_DsNhanVien.Columns["SoDienThoai"].Width = 80;

                    //grid_DsNhanVien.OptionsBehavior.Editable = false;
                    if (dgv_DsNhanVien.RepositoryItems.Count == 0)
                    {
                        //Thêm button sửa
                        AddCol("EditButton", "btn_Edit", "Sửa", 0, Properties.Resources.edit);
                        grid_DsNhanVien.Columns["EditButton"].Width = 80;
                        //Thêm button xoá
                        AddCol("DeleteButton", "btn_Delete", "Xoá", 0, Properties.Resources.del);
                        grid_DsNhanVien.Columns["DeleteButton"].Width = 80;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void AddCol(string fieldName, string buttonName, string Caption, int index, Image imagebutton)
        {
            GridColumn col = grid_DsNhanVien.Columns.AddVisible(fieldName, Caption);
            grid_DsNhanVien.Columns[fieldName].VisibleIndex = index;
            col.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            RepositoryItemButtonEdit repButton = new RepositoryItemButtonEdit();
            repButton.Name = buttonName;
            repButton.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            repButton.Buttons[0].Image = imagebutton;
            repButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            //Add event click
            if (buttonName == "btn_Edit")
                repButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_Sua_Click);
            else if (buttonName == "btn_Delete")
                repButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_Xoa_Click);
            dgv_DsNhanVien.RepositoryItems.Add(repButton);
            col.ColumnEdit = repButton;
            col.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
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
        #endregion

        #region Nút thêm - xoá - sửa
        private void pic_Them_Click(object sender, EventArgs e)
        {
            pic_Avatar.Image = Properties.Resources.userdefault;
            imagedefault = true;
            txt_MaNhanVien.Text = "";
            txt_MaNhanVien.ReadOnly = false;
            txt_TenNhanVien.Text = "";
            txt_TenNhanVien.ReadOnly = false;
            txt_NgaySinh.Text = "";
            txt_NgaySinh.ReadOnly = false;
            txt_GioiTinh.Text = "";
            txt_GioiTinh.ReadOnly = false;
            txt_CMND.Text = "";
            txt_CMND.ReadOnly = false;
            txt_DiaChi.Text = "";
            txt_DiaChi.ReadOnly = false;
            txt_SoDienThoai.Text = "";
            txt_SoDienThoai.ReadOnly = false;
            btn_Browse.Visible = true;
            btn_CapNhat.Visible = true;
            lb_Search.Visible = false;
            txt_Search.Visible = false;
            pic_Them.Visible = false;
        }
        private void btn_Sua_Click(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            txt_MaNhanVien.Text = grid_DsNhanVien.GetRowCellValue(grid_DsNhanVien.FocusedRowHandle, "MaNhanVien").ToString();
            txt_TenNhanVien.Text = grid_DsNhanVien.GetRowCellValue(grid_DsNhanVien.FocusedRowHandle, "TenNhanVien").ToString();
            txt_NgaySinh.Text = grid_DsNhanVien.GetRowCellValue(grid_DsNhanVien.FocusedRowHandle, "NgaySinh").ToString();
            txt_GioiTinh.Text = grid_DsNhanVien.GetRowCellValue(grid_DsNhanVien.FocusedRowHandle, "GioiTinh").ToString();
            txt_CMND.Text = grid_DsNhanVien.GetRowCellValue(grid_DsNhanVien.FocusedRowHandle, "CMND").ToString();
            txt_DiaChi.Text = grid_DsNhanVien.GetRowCellValue(grid_DsNhanVien.FocusedRowHandle, "DiaChi").ToString();
            txt_SoDienThoai.Text = grid_DsNhanVien.GetRowCellValue(grid_DsNhanVien.FocusedRowHandle, "SoDienThoai").ToString();
            if (!string.IsNullOrEmpty(grid_DsNhanVien.GetRowCellValue(grid_DsNhanVien.FocusedRowHandle, "HinhAnh").ToString()))
            {
                MemoryStream ms = new MemoryStream((byte[])grid_DsNhanVien.GetRowCellValue(grid_DsNhanVien.FocusedRowHandle, "HinhAnh"));
                pic_Avatar.Image = Image.FromStream(ms);
                imagedefault = false;
            }
            else
            {
                pic_Avatar.Image = Properties.Resources.userdefault;
                imagedefault = true;
            }

            if (txt_MaNhanVien.Text != "")
            {
                txt_TenNhanVien.ReadOnly = false;
                txt_NgaySinh.ReadOnly = false;
                txt_GioiTinh.ReadOnly = false;
                txt_CMND.ReadOnly = false;
                txt_DiaChi.ReadOnly = false;
                txt_SoDienThoai.ReadOnly = false;
                btn_Browse.Visible = true;
                btn_CapNhat.Visible = true;
                lb_Search.Visible = false;
                txt_Search.Visible = false;
                pic_Them.Visible = false;
            }
        }
        private void btn_Xoa_Click(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                NhanVienClient client = new NhanVienClient();
                if (MessageBox.Show("Bạn chắc chắn muốn xoá nhân viên '" + grid_DsNhanVien.GetRowCellValue(grid_DsNhanVien.FocusedRowHandle, "TenNhanVien").ToString() + "' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (client.NhanVien_Delete(grid_DsNhanVien.GetRowCellValue(grid_DsNhanVien.FocusedRowHandle, "MaNhanVien").ToString()))
                        MessageBox.Show("Xoá sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadData("");
                }
                pic_Avatar.Image = Properties.Resources.userdefault;
                imagedefault = true;
                txt_MaNhanVien.Text = "";
                txt_MaNhanVien.ReadOnly = true;
                txt_TenNhanVien.Text = "";
                txt_TenNhanVien.ReadOnly = true;
                txt_NgaySinh.Text = "";
                txt_NgaySinh.ReadOnly = true;
                txt_GioiTinh.Text = "";
                txt_GioiTinh.ReadOnly = true;
                txt_CMND.Text = "";
                txt_CMND.ReadOnly = true;
                txt_DiaChi.Text = "";
                txt_DiaChi.ReadOnly = true;
                txt_SoDienThoai.Text = "";
                txt_SoDienThoai.ReadOnly = true;
                btn_Browse.Visible = false;
                btn_CapNhat.Visible = false;
                lb_Search.Visible = true;
                txt_Search.Visible = true;
                pic_Them.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checknull())
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNhanVien = txt_MaNhanVien.Text;
                    nv.TenNhanVien = txt_TenNhanVien.Text;
                    nv.GioiTinh = txt_GioiTinh.Text;
                    nv.NgaySinh = Convert.ToDateTime(txt_NgaySinh.Text);
                    nv.DiaChi = txt_DiaChi.Text;
                    nv.SoDienThoai = txt_SoDienThoai.Text;
                    nv.CMND = txt_CMND.Text;
                    if (!imagedefault)
                    {
                        if (!string.IsNullOrEmpty(pic_Avatar.ImageLocation))
                        {
                            FileStream fs = new FileStream(pic_Avatar.ImageLocation, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fs);
                            nv.HinhAnh = br.ReadBytes((int)fs.Length);
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream();
                            pic_Avatar.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            nv.HinhAnh = ms.ToArray();
                        }
                    }
                    else
                        nv.HinhAnh = null;
                    NhanVienClient client = new NhanVienClient();
                    if (txt_MaNhanVien.ReadOnly)
                    {
                        if (client.NhanVien_Update(nv))
                        {
                            MessageBox.Show("Cập nhật nhân viên thành công", "Thông  báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData("");
                        }
                        else
                            MessageBox.Show("Cập nhật nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (client.NhanVien_Insert(nv))
                        {
                            MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData("");
                        }
                        else
                            MessageBox.Show("Thêm nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    pic_Avatar.Image = Properties.Resources.userdefault;
                    imagedefault = true;
                    txt_MaNhanVien.Text = "";
                    txt_MaNhanVien.ReadOnly = true;
                    txt_TenNhanVien.Text = "";
                    txt_TenNhanVien.ReadOnly = true;
                    txt_NgaySinh.Text = "";
                    txt_NgaySinh.ReadOnly = true;
                    txt_GioiTinh.Text = "";
                    txt_GioiTinh.ReadOnly = true;
                    txt_CMND.Text = "";
                    txt_CMND.ReadOnly = true;
                    txt_DiaChi.Text = "";
                    txt_DiaChi.ReadOnly = true;
                    txt_SoDienThoai.Text = "";
                    txt_SoDienThoai.ReadOnly = true;
                    btn_Browse.Visible = false;
                    btn_CapNhat.Visible = false;
                    lb_Search.Visible = true;
                    txt_Search.Visible = true;
                    pic_Them.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        //Kiểm tra dữ liệu trước khi insert/ipdate: trả về true nếu có dữ liệu sai
        private bool checknull()
        {
            if (string.IsNullOrEmpty(txt_MaNhanVien.Text))
            {
                MessageBox.Show("Thiếu mã nhân viên");
                txt_MaNhanVien.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(txt_TenNhanVien.Text))
            {
                MessageBox.Show("Thiếu tên nhân viên");
                txt_TenNhanVien.Focus();
                return true;
            }
            if (txt_NgaySinh.Text.Trim() == "/  /")
            {
                MessageBox.Show("Thiếu ngày sinh");
                txt_NgaySinh.Focus();
                return true;
            }
            return false;
        }

        //Nút tìm ảnh
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|(*.png)|*.png|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Avatar Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pic_Avatar.ImageLocation = dlg.FileName.ToString();
                    imagedefault = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Search thông tin sách
        private void txt_Search_TextChanged(object sender, EventArgs e)
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
    }
}
