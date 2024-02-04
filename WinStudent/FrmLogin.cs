using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinStudent
{
    public partial class FrmLogin : Form
    {
        private SqlParameter[] paras;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //获取用户输入信息  
            string uName = txtUserName.Text.Trim();
            string uPwd = txtUserPwd.Text.Trim();
            //判断是否为空    
            if (string.IsNullOrEmpty(uName))
            {
                MessageBox.Show("请输入账号!", "登陆提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(uPwd))
            {
                MessageBox.Show("请输入密码!", "登陆提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtUserPwd.Focus();
                return;
            }
            {
                //写查询语句
                string sql = "select count(1) from UserInfo where UserName=@UserName and UserPwd=@UserPwd";
                SqlParameter[] paras = {
                    new SqlParameter("@UserName", uName),
                    new SqlParameter("@UserPwd",uPwd)
                };
                ////建立与数据库的链接
                ////连接字符串 -- 钥匙
                ////string connSting = "server=.;database=test;Integrated  Security=true"; 
                ////字符串 Window 身份验证
                //string connString = "server=LAPTOP-D9MFPFTD;database=StudentNewDB;Persist Security Info=True;User ID=sa;Password=123456;";//Sql 身份验证
                //SqlConnection conn = new SqlConnection(connString);
                ////打开连接
                //conn.Open(); ;  //最晚打开 最早关闭
                //添加参数
                //SqlParameter paraUName = new SqlParameter("@UserName", uName);
                //SqlParameter paraUPwd = new SqlParameter("@UserName", uPwd);
                ////创建Command对象
                //SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.Parameters.Clear();
                ////cmd.Parameters.Add(paraUName);
                ////cmd.Parameters.Add(paraUPwd);
                //cmd.Parameters.AddRange(paras);
                ////执行命令
                //object o = cmd.ExecuteScalar();//执行查询，返回结果集第一行第一列的值，忽略其他行或列
                ////关闭连接
                //conn.Close();

                //调用
                object o = SqlHelper.ExecuteScalar(sql, paras);
                //处理结果
                if (o == null || o == DBNull.Value || ((int)o) == 0)
                {
                    MessageBox.Show("登录账号或密码有错，请检查！", "登陆提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                else;

                /*1122132111*/
            }
            {
                MessageBox.Show("登录成功! ", "登陆提示", MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                //转到主页面
                FrmMain fMain = new FrmMain();
                fMain.Show();
                this.Hide();
            }

            //返回的结果进行不同的提示

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit()


        }

        private void test()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }


    }
}
