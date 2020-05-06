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
    public partial class Form15 : Form
    {
        public Form15()
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
                {
                    if (comboBox1.Text == "" || comboBox2.Text == "")
                  { MessageBox.Show("请输入检索信息！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else
                    {
                    wa = "select * from 成绩表 where  学年='" + comboBox1.Text.Trim() + "'and 学期='" + comboBox2.Text.Trim() + "'";
                    a2.CommandText = wa;
                    a2.Connection = a1;
                    OleDbDataReader a3 = a2.ExecuteReader();
                    if (a3.Read() == false)
                    { MessageBox.Show("系统不存在此信息！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else
                    {

                        string sql1 = "select * from  成绩表 where  学年='" + comboBox1.Text.Trim() + "'and 学期='" + comboBox2.Text.Trim() + "'";
                        OleDbDataAdapter ad1 = new OleDbDataAdapter(sql1, a1);
                        DataSet ds1 = new DataSet();
                        ad1.Fill(ds1);
                        dataGridView1.DataSource = ds1.Tables[0];
                        MessageBox.Show("信息查询成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                
                
                }
                }
                else
                {
                    wa = "select * from 成绩表 where  学号='" + textBox1.Text.Trim() + "'";
                    a2.CommandText = wa;
                    a2.Connection = a1;
                    OleDbDataReader a3 = a2.ExecuteReader();
                    if (a3.Read() == false)
                    { MessageBox.Show("系统不存在此信息！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else
                    {

                        string sql1 = "select * from  成绩表 where  学号='" + textBox1.Text.Trim() + "'";
                        OleDbDataAdapter ad1 = new OleDbDataAdapter(sql1, a1);
                        DataSet ds1 = new DataSet();
                        ad1.Fill(ds1);
                        dataGridView1.DataSource = ds1.Tables[0];
                        MessageBox.Show("信息查询成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
            }
           
        private void button5_Click(object sender, EventArgs e)
        {
        
           
            OleDbConnection a1 = new OleDbConnection();
            OleDbCommand a2 = new OleDbCommand();
            a1.ConnectionString = data.mystr;
            a1.Open();
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要删除此成绩吗！", "删除成绩", messButton, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                string wa;
                wa = "delete * from 成绩表 where 学号='" + this.dataGridView1.CurrentRow.Cells["学号"].Value + "'and 姓名='" + this.dataGridView1.CurrentRow.Cells["姓名"].Value + "'and 课程名='" + this.dataGridView1.CurrentRow.Cells["课程名"].Value + "'and 成绩='" + this.dataGridView1.CurrentRow.Cells["成绩"].Value + "'and 有效成绩='" + this.dataGridView1.CurrentRow.Cells["有效成绩"].Value + "'and 学分='" + this.dataGridView1.CurrentRow.Cells["学分"].Value + "'and 班级='" + this.dataGridView1.CurrentRow.Cells["班级"].Value + "'and 学年='" + this.dataGridView1.CurrentRow.Cells["学年"].Value + "'and 学期='" + this.dataGridView1.CurrentRow.Cells["学期"].Value + "'";
                a2.CommandText =wa ;
                a2.Connection = a1;
                a2.ExecuteNonQuery();
             
                { MessageBox.Show("成绩删除成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }

           




        }

        private void button3_Click(object sender, EventArgs e)
        {
           OleDbConnection a1 = new OleDbConnection();
            OleDbCommand a2 = new OleDbCommand();
            a1.ConnectionString = data.mystr;
            a1.Open();
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要修改此成绩吗！", "修改成绩", messButton, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)

            {
                string wa;
                wa = "update 成绩表 set  姓名='" + this.dataGridView1.CurrentRow.Cells["姓名"].Value + "', 课程名='" + this.dataGridView1.CurrentRow.Cells["课程名"].Value + "', 成绩='" + this.dataGridView1.CurrentRow.Cells["成绩"].Value + "', 有效成绩='" + this.dataGridView1.CurrentRow.Cells["有效成绩"].Value + "', 班级='" + this.dataGridView1.CurrentRow.Cells["班级"].Value + "' , 学分='" + this.dataGridView1.CurrentRow.Cells["学分"].Value + "', 学年='" + this.dataGridView1.CurrentRow.Cells["学年"].Value + "', 学期='" + this.dataGridView1.CurrentRow.Cells["学期"].Value + "' where 学号='" + this.dataGridView1.CurrentRow.Cells["学号"].Value + "'";
                a2.CommandText = wa;
                a2.Connection = a1;
                a2.ExecuteNonQuery();

                { MessageBox.Show("成绩修改成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }

        }
    }
}