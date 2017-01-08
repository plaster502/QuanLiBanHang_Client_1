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
using DevExpress.LookAndFeel;
using DevExpress.XtraReports.UI;

namespace QuanLyBanSach.MenuThongKe
{
    public partial class uc_InventoryReport : UserControl
    {
        DateTime curr;
        //Contructor
        public uc_InventoryReport()
        {
            InitializeComponent();
        }

        #region Load Data
        private void uc_InventoryReport_Load(object sender, EventArgs e)
        {
            cbo_Year.DataSource = BaoCaoTon.LoadYear();
            cbo_Year.DisplayMember = "Nam";
            cbo_Year.ValueMember = "Nam";
            cbo_Year.Text = DateTime.Today.ToString("yyyy");

            pn_T10.Appearance.BackColor = Color.Salmon;
            pn_T10.Appearance.Options.UseBackColor = true;
            pn_T10.LookAndFeel.UseDefaultLookAndFeel = false;
            pn_T10.LookAndFeel.Style = LookAndFeelStyle.Flat;

            curr = new DateTime(2016, 10, 01);

            LoadData();
        }
        private void LoadData()
        {
            BaoCaoTon bct = new BaoCaoTon();
            bct.ThangBaoCao = curr;
            dgv_DSachSach.DataSource = BaoCaoTon_CT.LoadData(bct);
            FormatGrid();
        }
        private void FormatGrid()
        {
            if (dgv_DSachSach.Rows.Count > 0)
            {
                dgv_DSachSach.Columns["MaSach"].HeaderText = "Mã sách";
                dgv_DSachSach.Columns["TonDau"].HeaderText = "Tồn đầu";
                dgv_DSachSach.Columns["PhatSinh"].HeaderText = "Phát sinh";
                dgv_DSachSach.Columns["BanRa"].HeaderText = "Bán ra";
                dgv_DSachSach.Columns["TonCuoi"].HeaderText = "Tồn cuối";
            }
        }
        private void dgv_DSachSach_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgv_DSachSach.Rows.Count > 0)
            {
                if ((e.RowIndex % 2) == 0)
                {
                    dgv_DSachSach.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }
        #endregion

        #region Hiệu ứng nút
        private void pn_T1_MouseHover(object sender, EventArgs e)
        {
            if (curr.Month != 1)
            {
                pn_T1.Appearance.BackColor = Color.DarkGray;
            }
        }
        private void pn_T1_MouseLeave(object sender, EventArgs e)
        {
            if (curr.Month != 1)
            {
                pn_T1.Appearance.BackColor = Color.Transparent;
            }
        }
        private void pn_T1_Click(object sender, EventArgs e)
        {
            pn_T1.Appearance.BackColor = Color.Salmon;
            pn_T2.Appearance.BackColor = Color.Transparent;
            pn_T3.Appearance.BackColor = Color.Transparent;
            pn_T4.Appearance.BackColor = Color.Transparent;
            pn_T5.Appearance.BackColor = Color.Transparent;
            pn_T6.Appearance.BackColor = Color.Transparent;
            pn_T7.Appearance.BackColor = Color.Transparent;
            pn_T8.Appearance.BackColor = Color.Transparent;
            pn_T9.Appearance.BackColor = Color.Transparent;
            pn_T10.Appearance.BackColor = Color.Transparent;
            pn_T11.Appearance.BackColor = Color.Transparent;
            pn_T12.Appearance.BackColor = Color.Transparent;

            curr = new DateTime(Convert.ToInt32(cbo_Year.SelectedValue), 01, 01);
            LoadData();
        }

        private void pn_T2_MouseHover(object sender, EventArgs e)
        {
            if (curr.Month != 2)
            {
                pn_T2.Appearance.BackColor = Color.DarkGray;
            }
        }
        private void pn_T2_MouseLeave(object sender, EventArgs e)
        {
            if (curr.Month != 2)
            {
                pn_T2.Appearance.BackColor = Color.Transparent;
            }
        }
        private void pn_T2_Click(object sender, EventArgs e)
        {
            pn_T1.Appearance.BackColor = Color.Transparent;
            pn_T2.Appearance.BackColor = Color.Salmon;
            pn_T3.Appearance.BackColor = Color.Transparent;
            pn_T4.Appearance.BackColor = Color.Transparent;
            pn_T5.Appearance.BackColor = Color.Transparent;
            pn_T6.Appearance.BackColor = Color.Transparent;
            pn_T7.Appearance.BackColor = Color.Transparent;
            pn_T8.Appearance.BackColor = Color.Transparent;
            pn_T9.Appearance.BackColor = Color.Transparent;
            pn_T10.Appearance.BackColor = Color.Transparent;
            pn_T11.Appearance.BackColor = Color.Transparent;
            pn_T12.Appearance.BackColor = Color.Transparent;

            curr = new DateTime(Convert.ToInt32(cbo_Year.SelectedValue), 02, 01);
            LoadData();
        }

        private void pn_T3_MouseHover(object sender, EventArgs e)
        {
            if (curr.Month != 3)
            {
                pn_T3.Appearance.BackColor = Color.DarkGray;
            }
        }
        private void pn_T3_MouseLeave(object sender, EventArgs e)
        {
            if (curr.Month != 3)
            {
                pn_T3.Appearance.BackColor = Color.Transparent;
            }
        }
        private void pn_T3_Click(object sender, EventArgs e)
        {
            pn_T1.Appearance.BackColor = Color.Transparent;
            pn_T2.Appearance.BackColor = Color.Transparent;
            pn_T3.Appearance.BackColor = Color.Salmon;
            pn_T4.Appearance.BackColor = Color.Transparent;
            pn_T5.Appearance.BackColor = Color.Transparent;
            pn_T6.Appearance.BackColor = Color.Transparent;
            pn_T7.Appearance.BackColor = Color.Transparent;
            pn_T8.Appearance.BackColor = Color.Transparent;
            pn_T9.Appearance.BackColor = Color.Transparent;
            pn_T10.Appearance.BackColor = Color.Transparent;
            pn_T11.Appearance.BackColor = Color.Transparent;
            pn_T12.Appearance.BackColor = Color.Transparent;

            curr = new DateTime(Convert.ToInt32(cbo_Year.SelectedValue), 03, 01);
            LoadData();
        }

        private void pn_T4_MouseHover(object sender, EventArgs e)
        {
            if (curr.Month != 4)
            {
                pn_T4.Appearance.BackColor = Color.DarkGray;
            }
        }
        private void pn_T4_MouseLeave(object sender, EventArgs e)
        {
            if (curr.Month != 4)
            {
                pn_T4.Appearance.BackColor = Color.Transparent;
            }
        }
        private void pn_T4_Click(object sender, EventArgs e)
        {
            pn_T1.Appearance.BackColor = Color.Transparent;
            pn_T2.Appearance.BackColor = Color.Transparent;
            pn_T3.Appearance.BackColor = Color.Transparent;
            pn_T4.Appearance.BackColor = Color.Salmon;
            pn_T5.Appearance.BackColor = Color.Transparent;
            pn_T6.Appearance.BackColor = Color.Transparent;
            pn_T7.Appearance.BackColor = Color.Transparent;
            pn_T8.Appearance.BackColor = Color.Transparent;
            pn_T9.Appearance.BackColor = Color.Transparent;
            pn_T10.Appearance.BackColor = Color.Transparent;
            pn_T11.Appearance.BackColor = Color.Transparent;
            pn_T12.Appearance.BackColor = Color.Transparent;

            curr = new DateTime(Convert.ToInt32(cbo_Year.SelectedValue), 04, 01);
            LoadData();
        }

        private void pn_T5_MouseHover(object sender, EventArgs e)
        {
            if (curr.Month != 5)
            {
                pn_T5.Appearance.BackColor = Color.DarkGray;
            }
        }
        private void pn_T5_MouseLeave(object sender, EventArgs e)
        {
            if (curr.Month != 5)
            {
                pn_T5.Appearance.BackColor = Color.Transparent;
            }
        }
        private void pn_T5_Click(object sender, EventArgs e)
        {
            pn_T1.Appearance.BackColor = Color.Transparent;
            pn_T2.Appearance.BackColor = Color.Transparent;
            pn_T3.Appearance.BackColor = Color.Transparent;
            pn_T4.Appearance.BackColor = Color.Transparent;
            pn_T5.Appearance.BackColor = Color.Salmon;
            pn_T6.Appearance.BackColor = Color.Transparent;
            pn_T7.Appearance.BackColor = Color.Transparent;
            pn_T8.Appearance.BackColor = Color.Transparent;
            pn_T9.Appearance.BackColor = Color.Transparent;
            pn_T10.Appearance.BackColor = Color.Transparent;
            pn_T11.Appearance.BackColor = Color.Transparent;
            pn_T12.Appearance.BackColor = Color.Transparent;

            curr = new DateTime(Convert.ToInt32(cbo_Year.SelectedValue), 05, 01);
            LoadData();
        }

        private void pn_T6_MouseHover(object sender, EventArgs e)
        {
            if (curr.Month != 6)
            {
                pn_T6.Appearance.BackColor = Color.DarkGray;
            }
        }
        private void pn_T6_MouseLeave(object sender, EventArgs e)
        {
            if (curr.Month != 6)
            {
                pn_T6.Appearance.BackColor = Color.Transparent;
            }
        }
        private void pn_T6_Click(object sender, EventArgs e)
        {
            pn_T1.Appearance.BackColor = Color.Transparent;
            pn_T2.Appearance.BackColor = Color.Transparent;
            pn_T3.Appearance.BackColor = Color.Transparent;
            pn_T4.Appearance.BackColor = Color.Transparent;
            pn_T5.Appearance.BackColor = Color.Transparent;
            pn_T6.Appearance.BackColor = Color.Salmon;
            pn_T7.Appearance.BackColor = Color.Transparent;
            pn_T8.Appearance.BackColor = Color.Transparent;
            pn_T9.Appearance.BackColor = Color.Transparent;
            pn_T10.Appearance.BackColor = Color.Transparent;
            pn_T11.Appearance.BackColor = Color.Transparent;
            pn_T12.Appearance.BackColor = Color.Transparent;

            curr = new DateTime(Convert.ToInt32(cbo_Year.SelectedValue), 06, 01);
            LoadData();
        }

        private void pn_T7_MouseHover(object sender, EventArgs e)
        {
            if (curr.Month != 7)
            {
                pn_T7.Appearance.BackColor = Color.DarkGray;
            }
        }
        private void pn_T7_MouseLeave(object sender, EventArgs e)
        {
            if (curr.Month != 7)
            {
                pn_T7.Appearance.BackColor = Color.Transparent;
            }
        }
        private void pn_T7_Click(object sender, EventArgs e)
        {
            pn_T1.Appearance.BackColor = Color.Transparent;
            pn_T2.Appearance.BackColor = Color.Transparent;
            pn_T3.Appearance.BackColor = Color.Transparent;
            pn_T4.Appearance.BackColor = Color.Transparent;
            pn_T5.Appearance.BackColor = Color.Transparent;
            pn_T6.Appearance.BackColor = Color.Transparent;
            pn_T7.Appearance.BackColor = Color.Salmon;
            pn_T8.Appearance.BackColor = Color.Transparent;
            pn_T9.Appearance.BackColor = Color.Transparent;
            pn_T10.Appearance.BackColor = Color.Transparent;
            pn_T11.Appearance.BackColor = Color.Transparent;
            pn_T12.Appearance.BackColor = Color.Transparent;

            curr = new DateTime(Convert.ToInt32(cbo_Year.SelectedValue), 07, 01);
            LoadData();
        }

        private void pn_T8_MouseHover(object sender, EventArgs e)
        {
            if (curr.Month != 8)
            {
                pn_T8.Appearance.BackColor = Color.DarkGray;
            }
        }
        private void pn_T8_MouseLeave(object sender, EventArgs e)
        {
            if (curr.Month != 8)
            {
                pn_T8.Appearance.BackColor = Color.Transparent;
            }
        }
        private void pn_T8_Click(object sender, EventArgs e)
        {
            pn_T1.Appearance.BackColor = Color.Transparent;
            pn_T2.Appearance.BackColor = Color.Transparent;
            pn_T3.Appearance.BackColor = Color.Transparent;
            pn_T4.Appearance.BackColor = Color.Transparent;
            pn_T5.Appearance.BackColor = Color.Transparent;
            pn_T6.Appearance.BackColor = Color.Transparent;
            pn_T7.Appearance.BackColor = Color.Transparent;
            pn_T8.Appearance.BackColor = Color.Salmon;
            pn_T9.Appearance.BackColor = Color.Transparent;
            pn_T10.Appearance.BackColor = Color.Transparent;
            pn_T11.Appearance.BackColor = Color.Transparent;
            pn_T12.Appearance.BackColor = Color.Transparent;

            curr = new DateTime(Convert.ToInt32(cbo_Year.SelectedValue), 08, 01);
            LoadData();
        }

        private void pn_T9_MouseHover(object sender, EventArgs e)
        {
            if (curr.Month != 9)
            {
                pn_T9.Appearance.BackColor = Color.DarkGray;
            }
        }
        private void pn_T9_MouseLeave(object sender, EventArgs e)
        {
            if (curr.Month != 9)
            {
                pn_T9.Appearance.BackColor = Color.Transparent;
            }
        }
        private void pn_T9_Click(object sender, EventArgs e)
        {
            pn_T1.Appearance.BackColor = Color.Transparent;
            pn_T2.Appearance.BackColor = Color.Transparent;
            pn_T3.Appearance.BackColor = Color.Transparent;
            pn_T4.Appearance.BackColor = Color.Transparent;
            pn_T5.Appearance.BackColor = Color.Transparent;
            pn_T6.Appearance.BackColor = Color.Transparent;
            pn_T7.Appearance.BackColor = Color.Transparent;
            pn_T8.Appearance.BackColor = Color.Transparent;
            pn_T9.Appearance.BackColor = Color.Salmon;
            pn_T10.Appearance.BackColor = Color.Transparent;
            pn_T11.Appearance.BackColor = Color.Transparent;
            pn_T12.Appearance.BackColor = Color.Transparent;

            curr = new DateTime(Convert.ToInt32(cbo_Year.SelectedValue), 09, 01);
            LoadData();
        }

        private void pn_T10_MouseHover(object sender, EventArgs e)
        {
            if (curr.Month != 10)
            {
                pn_T10.Appearance.BackColor = Color.DarkGray;
            }
        }
        private void pn_T10_MouseLeave(object sender, EventArgs e)
        {
            if (curr.Month != 10)
            {
                pn_T10.Appearance.BackColor = Color.Transparent;
            }
        }
        private void pn_T10_Click(object sender, EventArgs e)
        {
            pn_T1.Appearance.BackColor = Color.Transparent;
            pn_T2.Appearance.BackColor = Color.Transparent;
            pn_T3.Appearance.BackColor = Color.Transparent;
            pn_T4.Appearance.BackColor = Color.Transparent;
            pn_T5.Appearance.BackColor = Color.Transparent;
            pn_T6.Appearance.BackColor = Color.Transparent;
            pn_T7.Appearance.BackColor = Color.Transparent;
            pn_T8.Appearance.BackColor = Color.Transparent;
            pn_T9.Appearance.BackColor = Color.Transparent;
            pn_T10.Appearance.BackColor = Color.Salmon;
            pn_T11.Appearance.BackColor = Color.Transparent;
            pn_T12.Appearance.BackColor = Color.Transparent;

            curr = new DateTime(Convert.ToInt32(cbo_Year.SelectedValue), 10, 01);
            LoadData();
        }

        private void pn_T11_MouseHover(object sender, EventArgs e)
        {
            if (curr.Month != 11)
            {
                pn_T11.Appearance.BackColor = Color.DarkGray;
            }
        }
        private void pn_T11_MouseLeave(object sender, EventArgs e)
        {
            if (curr.Month != 11)
            {
                pn_T11.Appearance.BackColor = Color.Transparent;
            }
        }
        private void pn_T11_Click(object sender, EventArgs e)
        {
            pn_T1.Appearance.BackColor = Color.Transparent;
            pn_T2.Appearance.BackColor = Color.Transparent;
            pn_T3.Appearance.BackColor = Color.Transparent;
            pn_T4.Appearance.BackColor = Color.Transparent;
            pn_T5.Appearance.BackColor = Color.Transparent;
            pn_T6.Appearance.BackColor = Color.Transparent;
            pn_T7.Appearance.BackColor = Color.Transparent;
            pn_T8.Appearance.BackColor = Color.Transparent;
            pn_T9.Appearance.BackColor = Color.Transparent;
            pn_T10.Appearance.BackColor = Color.Transparent;
            pn_T11.Appearance.BackColor = Color.Salmon;
            pn_T12.Appearance.BackColor = Color.Transparent;

            curr = new DateTime(Convert.ToInt32(cbo_Year.SelectedValue), 11, 01);
            LoadData();
        }

        private void pn_T12_MouseHover(object sender, EventArgs e)
        {
            if (curr.Month != 12)
            {
                pn_T12.Appearance.BackColor = Color.DarkGray;
            }
        }
        private void pn_T12_MouseLeave(object sender, EventArgs e)
        {
            if (curr.Month != 12)
            {
                pn_T12.Appearance.BackColor = Color.Transparent;
            }
        }
        private void pn_T12_Click(object sender, EventArgs e)
        {
            pn_T1.Appearance.BackColor = Color.Transparent;
            pn_T2.Appearance.BackColor = Color.Transparent;
            pn_T3.Appearance.BackColor = Color.Transparent;
            pn_T4.Appearance.BackColor = Color.Transparent;
            pn_T5.Appearance.BackColor = Color.Transparent;
            pn_T6.Appearance.BackColor = Color.Transparent;
            pn_T7.Appearance.BackColor = Color.Transparent;
            pn_T8.Appearance.BackColor = Color.Transparent;
            pn_T9.Appearance.BackColor = Color.Transparent;
            pn_T10.Appearance.BackColor = Color.Transparent;
            pn_T11.Appearance.BackColor = Color.Transparent;
            pn_T12.Appearance.BackColor = Color.Salmon;

            curr = new DateTime(Convert.ToInt32(cbo_Year.SelectedValue), 12, 01);
            LoadData();
        }

        private void cbo_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_Year.SelectedIndex > 0)
                curr = new DateTime(Convert.ToInt32(cbo_Year.SelectedValue), curr.Month, 01);
        }
        #endregion


        //Review báo cáo
        private void btn_Export_Click(object sender, EventArgs e)
        {
            exrp_ExportInventoryRp export = new exrp_ExportInventoryRp();
            export.Parameters["ThangBaoCao"].Value = curr.ToString("yyyyMM");
            export.Parameters["ThangBaoCao"].Visible = false;
            export.Parameters["ThangBaoCao_Cu"].Value = curr.AddMonths(-1).ToString("yyyyMM");
            export.Parameters["ThangBaoCao_Cu"].Visible = false;
            export.Parameters["ThangBaoCao_txt"].Value = curr.ToString("MM/yyyy");
            export.Parameters["ThangBaoCao_txt"].Visible = false;
            export.ShowPreview();
        }


    }
}
