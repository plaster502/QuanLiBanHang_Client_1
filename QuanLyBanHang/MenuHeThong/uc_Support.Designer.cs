namespace QuanLyBanHang.MenuHeThong
{
    partial class uc_Support
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Sửa thông tin đơn vị");
            this.trv_HuongDan = new System.Windows.Forms.TreeView();
            this.pdfv_TaiLieu = new DevExpress.XtraPdfViewer.PdfViewer();
            this.SuspendLayout();
            // 
            // trv_HuongDan
            // 
            this.trv_HuongDan.Dock = System.Windows.Forms.DockStyle.Left;
            this.trv_HuongDan.Location = new System.Drawing.Point(0, 0);
            this.trv_HuongDan.Name = "trv_HuongDan";
            treeNode1.Name = "nod_ThongTinDonVi";
            treeNode1.Text = "Sửa thông tin đơn vị";
            this.trv_HuongDan.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.trv_HuongDan.Size = new System.Drawing.Size(214, 417);
            this.trv_HuongDan.TabIndex = 0;
            this.trv_HuongDan.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trv_HuongDan_NodeMouseClick);
            // 
            // pdfv_TaiLieu
            // 
            this.pdfv_TaiLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfv_TaiLieu.Location = new System.Drawing.Point(214, 0);
            this.pdfv_TaiLieu.Name = "pdfv_TaiLieu";
            this.pdfv_TaiLieu.Size = new System.Drawing.Size(699, 417);
            this.pdfv_TaiLieu.TabIndex = 1;
            // 
            // uc_Support
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pdfv_TaiLieu);
            this.Controls.Add(this.trv_HuongDan);
            this.Name = "uc_Support";
            this.Size = new System.Drawing.Size(913, 417);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trv_HuongDan;
        private DevExpress.XtraPdfViewer.PdfViewer pdfv_TaiLieu;
    }
}
