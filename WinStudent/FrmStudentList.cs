using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
