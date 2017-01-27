namespace QuanLyBanHang
{
    partial class frm_Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_LogIn = new DevExpress.XtraEditors.SimpleButton();
            this.pic_Pass = new System.Windows.Forms.PictureBox();
            this.pic_Account = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Account)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Account
            // 
            resources.ApplyResources(this.txt_Account, "txt_Account");
            this.txt_Account.Name = "txt_Account";
            // 
            // txt_Password
            // 
            resources.ApplyResources(this.txt_Password, "txt_Password");
            this.txt_Password.Name = "txt_Password";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton1.Appearance.Font")));
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.Image = global::QuanLyBanHang.Properties.Resources.cancel;
            resources.ApplyResources(this.btn_Exit, "btn_Exit");
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_LogIn.Appearance.Font")));
            this.btn_LogIn.Appearance.Options.UseFont = true;
            this.btn_LogIn.Image = global::QuanLyBanHang.Properties.Resources.door_in;
            resources.ApplyResources(this.btn_LogIn, "btn_LogIn");
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // pic_Pass
            // 
            this.pic_Pass.Image = global::QuanLyBanHang.Properties.Resources.pass;
            resources.ApplyResources(this.pic_Pass, "pic_Pass");
            this.pic_Pass.Name = "pic_Pass";
            this.pic_Pass.TabStop = false;
            // 
            // pic_Account
            // 
            this.pic_Account.Image = global::QuanLyBanHang.Properties.Resources.user;
            resources.ApplyResources(this.pic_Account, "pic_Account");
            this.pic_Account.Name = "pic_Account";
            this.pic_Account.TabStop = false;
            // 
            // frm_Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ControlBox = false;
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.pic_Pass);
            this.Controls.Add(this.pic_Account);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Account);
            this.Name = "frm_Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_Login_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Account)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Account;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.PictureBox pic_Account;
        private System.Windows.Forms.PictureBox pic_Pass;
        private DevExpress.XtraEditors.SimpleButton btn_LogIn;
        private DevExpress.XtraEditors.SimpleButton btn_Exit;
    }
}