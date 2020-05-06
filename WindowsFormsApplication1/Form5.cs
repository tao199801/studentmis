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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string wa;
            OleDbConnection a1 = new OleDbConnection();
            OleDbCommand a2 = new OleDbCommand();
            a1.ConnectionString = data.mystr;
            a1.Open();
            if (textBox1.Text == "")
            { MessageBox.Show("请输入学生学号！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                
                wa = "select * from 成绩表 where 学号='" + textBox1.Text.Trim() + "'and 学年='" + comboBox1.Text.Trim() + "'and 学期='" + comboBox2.Text.Trim() + "'";
                a2.CommandText = wa;
                a2.Connection = a1;
                OleDbDataReader a3 = a2.ExecuteReader();
                if (a3.Read() == false)
                { MessageBox.Show("系统不存在此信息！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {   

                    string sql1 ="select * from  成绩表 where 学号='" + textBox1.Text.Trim() + "'and 学年='" + comboBox1.Text.Trim() + "'and 学期='" + comboBox2.Text.Trim() + "'";
                    OleDbDataAdapter ad1 = new OleDbDataAdapter(sql1, a1);
                    DataSet ds1 = new DataSet();
                    ad1.Fill(ds1);
                    dataGridView1.DataSource = ds1.Tables[0];
                    MessageBox.Show("信息查询成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}