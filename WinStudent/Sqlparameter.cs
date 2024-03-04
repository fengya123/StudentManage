using System;

namespace WinStudent
{
    [Obsolete]
    ///遗弃用
    internal class Sqlparameter111
    {
        private string v;
        private int gradeId;
        private string v1;
        private string v2;
        
        public Sqlparameter111(string v, int gradeId)
        {
            this.v = v;
            this.gradeId = gradeId;
        }

        public Sqlparameter111(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}