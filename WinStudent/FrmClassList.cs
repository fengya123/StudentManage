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
    public partial class FrmClassList : Form
    {
        public FrmClassList()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 初始化年纪列表，所有班级列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FrmClassList_Load(object sender, EventArgs e)
        {
            InitGrades();//加载年级列表

        }

        private void InitGrades()
        {
            string sql = "select GradeId ,GradeName  from GradeInfo";
            DataTable dtGradeList = SqlHelper.GetDataTable(sql);
            cboGrades.DataSource = dtGradeList;
        }
    }
}
