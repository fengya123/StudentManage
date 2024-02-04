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
    public partial class FrmMain : Form
    {
        private object fStudentList;

        public FrmMain()
        {
            InitializeComponent();
        }
        ///<summary>
        ///新增学生  
        ///</summary>
        ///<param name="sender"></param>
        ///<param name="e"></param>
        ///
        private void subAddStudent_Click(object sender, EventArgs e)
        {
            FrmAddStudent fAddStudent = new FrmAddStudent();
            fAddStudent.MdiParent = this;
            fAddStudent.Show();//顶级窗体  不能显示在MDI容器重
        }



        private void subStudentList_Click(object sender, EventArgs e)

        {

            bool bl = CheckForm(typeof(FrmStudentList).Name);
            if (!bl)
            {
                FrmStudentList fStudentList = FrmStudentList.CreateInstance();
                fStudentList.MdiParent = this;
                fStudentList.Show();

            }

        }
        /// <summary>
        /// 检查窗体是否已经打开
        /// </summary>
        /// <param name="formName"></param>
        /// <returns></returns>
        private bool CheckForm(string formName)
        {
            bool bl = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == formName)
                {
                    bl = true;
                    f.Activate();
                    break;
                }
            }
            return bl;
        }
        /// <summary>
        /// 新增班级 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void subAddClass_Click(object sender, EventArgs e)

        {
            FrmAddClass fAddClass = new FrmAddClass();
            fAddClass.MdiParent = this;
            fAddClass.Show();
        }
        /// <summary>
        /// 班级列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subClassList_Click(object sender, EventArgs e)
        {

            bool bl = CheckForm(typeof(FrmClassList).Name);
            if (!bl)
            {
                FrmClassList fClasslist = new FrmClassList();
                fClasslist.MdiParent = this;
                fClasslist.Show();

            }
        }
        /// <summary>
        /// 年级列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subGradeList_Click(object sender, EventArgs e)
        {
            bool bl = CheckForm(typeof(FrmGradeList).Name);
            if (!bl)
            {
                FrmGradeList fGradeList = new FrmGradeList();
                fGradeList.MdiParent = this;
                fGradeList.Show();

            }
        }
        /// <summary>
        /// 窗体关闭，退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result= MessageBox.Show("您确定要退出系统吗？","退出提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();//退出当前线程上的消息循环
            }
            else
            {
                e.Cancel = true;//手动取消
            }
        }
        //退出系统
        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }


    }
}