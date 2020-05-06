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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { MessageBox.Show("请输入学生学号！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                string mysql;
                OleDbConnection a1 = new OleDbConnection();
                OleDbCommand a2 = new OleDbCommand();
                a1.ConnectionString = data.mystr;
                a1.Open();
               
                    string sql;
                    sql = "insert into 成绩表 values(" + "'" + textBox1.Text.Trim() + "','" + this.dataGridView1.CurrentRow.Cells["姓名"].Value + "','" + this.dataGridView1.CurrentRow.Cells["课程名"].Value + "','" + this.dataGridView1.CurrentRow.Cells["成绩"].Value + "','" + this.dataGridView1.CurrentRow.Cells["有效成绩"].Value + "','" + this.dataGridView1.CurrentRow.Cells["学分"].Value + "','" + this.dataGridView1.CurrentRow.Cells["班级"].Value + "','" + this.dataGridView1.CurrentRow.Cells["学年"].Value + "','" + this.dataGridView1.CurrentRow.Cells["学期"].Value + "')";
                a2.CommandText = sql;
                a2.Connection = a1;
                a2.ExecuteNonQuery();
                    MessageBox.Show("成绩录入成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        

      
    }
}