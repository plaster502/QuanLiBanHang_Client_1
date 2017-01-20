using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyBanHang.BanHangService;

namespace QuanLyBanHang.MenuBanHang
{
    public partial class uc_OrderCreate : UserControl
    {
        DonDatHang bg = new DonDatHang();
        DataTable sanpham = new DataTable();
        bool IsInsertOrUpdate = false; //Flag false:Update

        #region Contructor
        public uc_OrderCreate()
        {
            InitializeComponent();
            IsInsertOrUpdate = true;
        }
        public uc_OrderCreate(DonDatHang _detail, bool isInsert)
        {
            InitializeComponent();
            this.bg = _detail;
            IsInsertOrUpdate = isInsert;
        }
        #endregion
    }
}
