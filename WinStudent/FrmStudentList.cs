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
    public partial class FrmStudentList : Form
    {
        public FrmStudentList()
        {
            InitializeComponent();
        }

        //单例 只有一个实例 
        private static FrmStudentList frmStudentList = null;
        public static FrmStudentList CreateInstance()
        {
            if(frmStudentList==null ||frmStudentList.IsDisposed);
                frmStudentList = new FrmStudentList();
             return frmStudentList;

        }
        //加载班级列表、加载所有的学生信息
        private void FrmStudentList_Load(object sender, EventArgs e)
        {
            LoadClasses();//加载班级列表
            LoadAllStudentList();//加载学生列表
        }

        private void LoadAllStudentList()
        {
            string sql = "select StuId,StuName,ClassName,GradeName,Sex,Phone from StudentInfo s "+
                "inner join ClassInfo c on c.ClassId=s.ClassId "+
                "inner join GradeInfo g on g.GradeId=c.GradeId";
            //加载数据
            DataTable dtStudents = SqlHelper.GetDataTable(sql);
            //组装
            if (dtStudents.Rows.Count > 0)
            {
                foreach (DataRow dr in dtStudents.Rows)
                {
                    string className = dr["ClassName"].ToString();
                    string gradeName = dr["GradeName"].ToString();
                    dr["ClassName"] = className + "--" + gradeName;
                }
            }
            //我只想固定的列
            //dgvStudents.AutoGenerateColumns = false;
            dtStudents.Columns.Remove(dtStudents.Columns[3]);
            //绑定数据
            dgvStudents.DataSource = dtStudents;

        }

        private void LoadClasses()
        {
            //获取数据 --- 查询 --写sql
            string sql = "select ClassId,ClassName,GradeName from Classinfo c,GradeInfo g where c.GradeId=g.GradeId";

            DataTable dtClasses = SqlHelper.GetDataTable(sql);
            //组合班级列表显示项的过程
            if(dtClasses.Rows.Count>0)
            {
                foreach (DataRow dr in dtClasses.Rows)
                {
                    string className = dr["ClassName"].ToString();
                    string GradeName = dr["GradeName"].ToString();
                    dr["ClassName"] = className + "--" + GradeName;
                }
            }
            //添加默认选择项
            DataRow drNew = dtClasses.NewRow();
            drNew["ClassId"] = 0;
            drNew["ClassName"] = "请选择";

            dtClasses.Rows.InsertAt(drNew, 0);

            //指定数据源
            cboClasses.DataSource = dtClasses;
            cboClasses.DisplayMember = "ClassName";
            cboClasses.ValueMember = "ClassId";
        }
        /// <summary>
        /// 查询学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnFind_Click(object sender, EventArgs e)
        {
            //接收条件设置信息
            int classId = (int)cboClasses.SelectedValue;
            string stuName = txtStuName.Text.Trim();

            //查询sql
            string sql = "select StuId,StuName,ClassName,GradeName,Sex,Phone from StudentInfo s " +
                "inner join ClassInfo c on c.ClassId=s.ClassId " +
                "inner join GradeInfo g on g.GradeId=c.GradeId";
            sql += " where 1=1";
            if(classId>0)
            {
                sql += "and s.ClassId=@ClassId";
            }
            if(!string.IsNullOrEmpty(stuName))
            {
                sql += " and StuName like @StuName";
            }
            sql += " order by StuId";

            SqlParameter[] paras =
            {
                new SqlParameter("@ClassId",classId),
                new SqlParameter("@stuName","%"+stuName+"%")
            };

            //加载数据
            DataTable dtStudents = SqlHelper.GetDataTable(sql,paras);
            //组装
            if (dtStudents.Rows.Count > 0)
            {
                foreach (DataRow dr in dtStudents.Rows)
                {
                    string className = dr["ClassName"].ToString();
                    string gradeName = dr["GradeName"].ToString();
                    dr["ClassName"] = className + "--" + gradeName;
                }
            }
            //我只想固定的列
            //dgvStudents.AutoGenerateColumns = false;
            dtStudents.Columns.Remove(dtStudents.Columns[3]);
            //绑定数据
            dgvStudents.DataSource = dtStudents;

        }
    }
}
