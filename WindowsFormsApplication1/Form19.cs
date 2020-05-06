using System;
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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string wa;
            OleDbConnection a1 = new OleDbConnection();
            OleDbCommand a2 = new OleDbCommand();
            a1.ConnectionString = data.mystr;
            a1.Open();
            if (textBox1.Text == "")
            { MessageBox.Show("请输入学号！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {

                wa = "select * from 课程信息表 where  学生学号='" + textBox1.Text.Trim() + "'";
                a2.CommandText = wa;
                a2.Connection = a1;
                OleDbDataReader a3 = a2.ExecuteReader();
                if (a3.Read() == false)
                { MessageBox.Show("系统不存在此信息！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {

                    string sql1 = "select * from  课程信息表 where  学生学号='" + textBox1.Text.Trim() + "'";
                    OleDbDataAdapter ad1 = new OleDbDataAdapter(sql1, a1);
                    DataSet ds1 = new DataSet();
                    ad1.Fill(ds1);
                    dataGridView1.DataSource = ds1.Tables[0];
                    MessageBox.Show("选课结果查询成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void 选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection a1 = new OleDbConnection();
            OleDbCommand a2 = new OleDbCommand();
            a1.ConnectionString = data.mystr;
            a1.Open();
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要退选吗！", "退选", messButton, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                string wa;
                wa = "delete * from 课程信息表 where 课程名='" + this.dataGridView1.CurrentRow.Cells["课程名"].Value + "'and 课程代号='" + this.dataGridView1.CurrentRow.Cells["课程代号"].Value + "'and 课程类别='" + this.dataGridView1.CurrentRow.Cells["课程类别"].Value + "'and 任课教师='" + this.dataGridView1.CurrentRow.Cells["任课教师"].Value + "'and 教师代号='" + this.dataGridView1.CurrentRow.Cells["教师代号"].Value + "'and 学年='" + this.dataGridView1.CurrentRow.Cells["学年"].Value + "'and 学期='" + this.dataGridView1.CurrentRow.Cells["学期"].Value + "'and 周时='" + this.dataGridView1.CurrentRow.Cells["周时"].Value + "'and 学生学号='" + this.dataGridView1.CurrentRow.Cells["学生学号"].Value + "'";
                a2.CommandText = wa;
                a2.Connection = a1;
                a2.ExecuteNonQuery();

                MessageBox.Show("课程退选成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
