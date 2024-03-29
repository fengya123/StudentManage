﻿
namespace WinStudent
{
    partial class FrmGradeList
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
            this.dgvGradeList = new System.Windows.Forms.DataGridView();
            this.GradeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGradeList
            // 
            this.dgvGradeList.AllowUserToAddRows = false;
            this.dgvGradeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGradeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GradeId,
            this.GradeName});
            this.dgvGradeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGradeList.Location = new System.Drawing.Point(0, 0);
            this.dgvGradeList.Name = "dgvGradeList";
            this.dgvGradeList.RowHeadersWidth = 62;
            this.dgvGradeList.RowTemplate.Height = 30;
            this.dgvGradeList.Size = new System.Drawing.Size(1058, 760);
            this.dgvGradeList.TabIndex = 0;
            this.dgvGradeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GradeId
            // 
            this.GradeId.DataPropertyName = "GradeId";
            this.GradeId.HeaderText = "年级编号";
            this.GradeId.MinimumWidth = 8;
            this.GradeId.Name = "GradeId";
            // 
            // GradeName
            // 
            this.GradeName.DataPropertyName = "GradeName";
            this.GradeName.HeaderText = "年级名称";
            this.GradeName.MinimumWidth = 8;
            this.GradeName.Name = "GradeName";
            // 
            // FrmGradeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 760);
            this.Controls.Add(this.dgvGradeList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGradeList";
            this.Text = "年级列表页面";
            this.Load += new System.EventHandler(this.FrmGradeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGradeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeName;
    }
}