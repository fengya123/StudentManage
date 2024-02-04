
using System;

namespace WinStudent
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUserPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUserPwd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.btnlogin);
            this.groupBox1.Location = new System.Drawing.Point(155, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 403);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Location = new System.Drawing.Point(178, 173);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.Size = new System.Drawing.Size(164, 28);
            this.txtUserPwd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(210, 271);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 45);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "账号:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(178, 120);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(164, 28);
            this.txtUserName.TabIndex = 1;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(54, 271);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(132, 45);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "登录";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录页面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUserPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnlogin;
    }
}

