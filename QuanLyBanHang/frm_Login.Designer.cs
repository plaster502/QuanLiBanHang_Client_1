﻿namespace QuanLyBanHang
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
            this.pic_Exit = new System.Windows.Forms.PictureBox();
            this.pic_LogIn = new System.Windows.Forms.PictureBox();
            this.pic_Pass = new System.Windows.Forms.PictureBox();
            this.pic_Account = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogIn)).BeginInit();
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
            // pic_Exit
            // 
            resources.ApplyResources(this.pic_Exit, "pic_Exit");
            this.pic_Exit.Name = "pic_Exit";
            this.pic_Exit.TabStop = false;
            this.pic_Exit.Click += new System.EventHandler(this.pic_Exit_Click);
            this.pic_Exit.MouseLeave += new System.EventHandler(this.pic_Exit_MouseLeave);
            this.pic_Exit.MouseHover += new System.EventHandler(this.pic_Exit_MouseHover);
            // 
            // pic_LogIn
            // 
            resources.ApplyResources(this.pic_LogIn, "pic_LogIn");
            this.pic_LogIn.Name = "pic_LogIn";
            this.pic_LogIn.TabStop = false;
            this.pic_LogIn.Click += new System.EventHandler(this.pic_LogIn_Click);
            this.pic_LogIn.MouseLeave += new System.EventHandler(this.pic_LogIn_MouseLeave);
            this.pic_LogIn.MouseHover += new System.EventHandler(this.pic_LogIn_MouseHover);
            // 
            // pic_Pass
            // 
            resources.ApplyResources(this.pic_Pass, "pic_Pass");
            this.pic_Pass.Image = global::QuanLyBanHang.Properties.Resources.pass;
            this.pic_Pass.Name = "pic_Pass";
            this.pic_Pass.TabStop = false;
            // 
            // pic_Account
            // 
            resources.ApplyResources(this.pic_Account, "pic_Account");
            this.pic_Account.Image = global::QuanLyBanHang.Properties.Resources.user;
            this.pic_Account.Name = "pic_Account";
            this.pic_Account.TabStop = false;
            // 
            // frm_Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ControlBox = false;
            this.Controls.Add(this.pic_Exit);
            this.Controls.Add(this.pic_LogIn);
            this.Controls.Add(this.pic_Pass);
            this.Controls.Add(this.pic_Account);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Account);
            this.Name = "frm_Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_Login_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogIn)).EndInit();
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
        private System.Windows.Forms.PictureBox pic_LogIn;
        private System.Windows.Forms.PictureBox pic_Exit;
    }
}