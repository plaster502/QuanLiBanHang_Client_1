﻿namespace QuanLyBanHang.MenuBanHang
{
    partial class uc_QuoteList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_QuoteList));
            this.pn_Nav = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pic_Them = new System.Windows.Forms.PictureBox();
            this.lb_ThongTinTimKiem = new System.Windows.Forms.Label();
            this.txt_ThongTinTimKiem = new System.Windows.Forms.TextBox();
            this.dgv_DanhSachBaoGia = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Fix = new System.Windows.Forms.DataGridViewImageColumn();
            this.pn_Nav.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachBaoGia)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Nav
            // 
            this.pn_Nav.Controls.Add(this.tableLayoutPanel1);
            this.pn_Nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Nav.Location = new System.Drawing.Point(0, 0);
            this.pn_Nav.Name = "pn_Nav";
            this.pn_Nav.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pn_Nav.Size = new System.Drawing.Size(656, 49);
            this.pn_Nav.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pic_Them, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_ThongTinTimKiem, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_ThongTinTimKiem, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(656, 44);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pic_Them
            // 
            this.pic_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_Them.BackColor = System.Drawing.Color.Transparent;
            this.pic_Them.Image = global::QuanLyBanHang.Properties.Resources.add;
            this.pic_Them.Location = new System.Drawing.Point(3, 3);
            this.pic_Them.Name = "pic_Them";
            this.pic_Them.Size = new System.Drawing.Size(83, 36);
            this.pic_Them.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Them.TabIndex = 5;
            this.pic_Them.TabStop = false;
            this.pic_Them.Click += new System.EventHandler(this.pic_Them_Click);
            this.pic_Them.MouseLeave += new System.EventHandler(this.pic_Them_MouseLeave);
            this.pic_Them.MouseHover += new System.EventHandler(this.pic_Them_MouseHover);
            // 
            // lb_ThongTinTimKiem
            // 
            this.lb_ThongTinTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_ThongTinTimKiem.AutoSize = true;
            this.lb_ThongTinTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_ThongTinTimKiem.Location = new System.Drawing.Point(107, 12);
            this.lb_ThongTinTimKiem.Name = "lb_ThongTinTimKiem";
            this.lb_ThongTinTimKiem.Size = new System.Drawing.Size(131, 20);
            this.lb_ThongTinTimKiem.TabIndex = 0;
            this.lb_ThongTinTimKiem.Text = "Thông tin báo giá";
            // 
            // txt_ThongTinTimKiem
            // 
            this.txt_ThongTinTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_ThongTinTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_ThongTinTimKiem.Location = new System.Drawing.Point(259, 9);
            this.txt_ThongTinTimKiem.Name = "txt_ThongTinTimKiem";
            this.txt_ThongTinTimKiem.Size = new System.Drawing.Size(304, 26);
            this.txt_ThongTinTimKiem.TabIndex = 1;
            this.txt_ThongTinTimKiem.TextChanged += new System.EventHandler(this.txt_ThongTinTimKiem_TextChanged);
            // 
            // dgv_DanhSachBaoGia
            // 
            this.dgv_DanhSachBaoGia.AllowUserToAddRows = false;
            this.dgv_DanhSachBaoGia.AllowUserToDeleteRows = false;
            this.dgv_DanhSachBaoGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachBaoGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Detail,
            this.Delete,
            this.Fix});
            this.dgv_DanhSachBaoGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachBaoGia.Location = new System.Drawing.Point(0, 49);
            this.dgv_DanhSachBaoGia.Name = "dgv_DanhSachBaoGia";
            this.dgv_DanhSachBaoGia.Size = new System.Drawing.Size(656, 275);
            this.dgv_DanhSachBaoGia.TabIndex = 3;
            this.dgv_DanhSachBaoGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachBaoGia_CellClick);
            this.dgv_DanhSachBaoGia.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_DanhSachBaoGia_RowPrePaint);
            // 
            // STT
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle11;
            this.STT.FillWeight = 38.5323F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 72;
            // 
            // Detail
            // 
            this.Detail.FillWeight = 113.6703F;
            this.Detail.HeaderText = "Chi tiết";
            this.Detail.Image = ((System.Drawing.Image)(resources.GetObject("Detail.Image")));
            this.Detail.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Detail.Name = "Detail";
            this.Detail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detail.Width = 211;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 113.6703F;
            this.Delete.HeaderText = "Xoá";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 212;
            // 
            // Fix
            // 
            this.Fix.FillWeight = 113.6703F;
            this.Fix.HeaderText = "Sửa";
            this.Fix.Image = ((System.Drawing.Image)(resources.GetObject("Fix.Image")));
            this.Fix.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Fix.Name = "Fix";
            this.Fix.Width = 211;
            // 
            // uc_QuoteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_DanhSachBaoGia);
            this.Controls.Add(this.pn_Nav);
            this.Name = "uc_QuoteList";
            this.Size = new System.Drawing.Size(656, 324);
            this.Load += new System.EventHandler(this.uc_QuoteList_Load);
            this.pn_Nav.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachBaoGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Nav;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pic_Them;
        private System.Windows.Forms.Label lb_ThongTinTimKiem;
        private System.Windows.Forms.TextBox txt_ThongTinTimKiem;
        private System.Windows.Forms.DataGridView dgv_DanhSachBaoGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewImageColumn Detail;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Fix;
    }
}
