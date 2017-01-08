using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.MenuHeThong
{
    public partial class uc_Support : UserControl
    {
        public uc_Support()
        {
            InitializeComponent();
        }

        private void trv_HuongDan_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "nod_ThongTinDonVi":
                    pdfv_TaiLieu.LoadDocument(Application.StartupPath + "\\PDFDoc\\doc_ThayDoiThongTinDonVi.pdf");
                    break;
            }
        }
    }
}
