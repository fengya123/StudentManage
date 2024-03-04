using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WinStudent
{
    class SqlHelper
    {   //连接字符串
        private static readonly string connString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        private static SqlCommand cmd;
        private static object conn;

        public static object ExecuteScalar(string sql, params SqlParameter[] paras)
        {
            object o = null;
            //字符串 Window 身份验证
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //打开连接
                conn.Open();  //最晚打开 最早关闭
                              //创建Command对象
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(paras);
                //执行命令
                o = cmd.ExecuteScalar();//执行查询，返回结果集第一行第一列的值，忽略其他行或列
                                        //关闭连接
                                        //conn.Close();
            }
            return o;
        }



        /// <summary>
        /// 返回DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql, params SqlParameter[] paras)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {

                SqlCommand cmd = new SqlCommand(sql, conn);
                if(paras!=null)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddRange(paras);

                }
                //断开式连接 是不是不用连接数据库呢？不是
                //执行命令 一定是Command来完成
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                //打开连接
                conn.Open();  //最晚打开 最早关闭
                              //创建Command对象
                              //数据填充
                da.Fill(dt);
            }
            return dt;
        }
    }
}
