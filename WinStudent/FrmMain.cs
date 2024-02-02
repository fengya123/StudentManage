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
        public FrmMain()
        {
            InitializeComponent();
        }
            ///<summary>
            ///新增学生
            ///</summary>
            ///<param name="sender"></param>
            ///<param name="e"></param>

        private void subAddStudent_Click(object sender, EventArgs e)
        {
            FrmAddStudent fAddstudent= new FrmAddStudent();
            fAddstudent.Show();
        }

        private void miExit_Click(object sender, EventArgs e)
        {

        }
    }
}
