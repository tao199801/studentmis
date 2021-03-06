﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form31 : Form
    {
        public Form31()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection a1 = new OleDbConnection();
            OleDbCommand a2 = new OleDbCommand();
            a1.ConnectionString = data.mystr;
            a1.Open();
            string sql1 = "select * from  课程信息表";
            OleDbDataAdapter ad1 = new OleDbDataAdapter(sql1, a1);
            DataSet ds1 = new DataSet();
            ad1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
            MessageBox.Show("信息查询成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection a1 = new OleDbConnection();
            OleDbCommand a2 = new OleDbCommand();
            a1.ConnectionString = data.mystr;
            a1.Open();
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要修改此课程吗！", "修改课程", messButton, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                string wa;
                wa = "update 课程信息表 set  课程代号='" + this.dataGridView1.CurrentRow.Cells["课程代号"].Value + "', 课程类别='" + this.dataGridView1.CurrentRow.Cells["课程类别"].Value + "', 任课教师='" + this.dataGridView1.CurrentRow.Cells["任课教师"].Value + "', 教师代号='" + this.dataGridView1.CurrentRow.Cells["教师代号"].Value + "',  学年='" + this.dataGridView1.CurrentRow.Cells["学年"].Value + "', 学期='" + this.dataGridView1.CurrentRow.Cells["学期"].Value + "',周时='" + this.dataGridView1.CurrentRow.Cells["周时"].Value + "' ,学号='" + this.dataGridView1.CurrentRow.Cells["学号"].Value + "' where 课程名='" + this.dataGridView1.CurrentRow.Cells["课程名"].Value + "'";
                a2.CommandText = wa;
                a2.Connection = a1;
                a2.ExecuteNonQuery();
                { MessageBox.Show("信息修改成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection a1 = new OleDbConnection();
            OleDbCommand a2 = new OleDbCommand();
            a1.ConnectionString = data.mystr;
            a1.Open();
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要删除此课程吗！", "删除课程", messButton, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                string wa;
                wa = "delete * from 课程信息表 where 课程名='" + this.dataGridView1.CurrentRow.Cells["课程名"].Value + "'and 课程代号='" + this.dataGridView1.CurrentRow.Cells["课程代号"].Value + "'and 课程类别='" + this.dataGridView1.CurrentRow.Cells["课程类别"].Value + "'and 任课教师='" + this.dataGridView1.CurrentRow.Cells["任课教师"].Value + "'and 教师代号='" + this.dataGridView1.CurrentRow.Cells["教师代号"].Value + "'and 学年='" + this.dataGridView1.CurrentRow.Cells["学年"].Value + "'and 学期='" + this.dataGridView1.CurrentRow.Cells["学期"].Value + "'and 周时='" + this.dataGridView1.CurrentRow.Cells["周时"].Value + "'and 学号='" + this.dataGridView1.CurrentRow.Cells["学号"].Value + "' ";
                a2.CommandText = wa;
                a2.Connection = a1;
                a2.ExecuteNonQuery();
                { MessageBox.Show("课程删除成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }
    }
}