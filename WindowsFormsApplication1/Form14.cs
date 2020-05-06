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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mysql;
            OleDbConnection a1 = new OleDbConnection();
            OleDbCommand a2 = new OleDbCommand();
            a1.ConnectionString = data.mystr;
            a1.Open();

            mysql = "select * from  助学金评审表 where 学号='" + textBox1.Text.Trim() + "'";
            a2.CommandText = mysql;
            a2.Connection = a1;
            OleDbDataReader a3 = a2.ExecuteReader();
            if (a3.Read())
            {
                MessageBox.Show("用户已经提交了申请！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox8.Text == "" || textBox9.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
                {
                    MessageBox.Show("请输入完整信息,否则不能提交！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                    DialogResult dr = MessageBox.Show("确定要提交信息吗！", "提交后将不能修改！", messButton, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        a3.Close();
                        string sql;
                        sql = "insert into 助学金评审表 values (" + "'" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + comboBox1.Text.Trim() + "','" + textBox4.Text.Trim() + "','" + textBox5.Text.Trim() + "', '" + textBox6.Text.Trim() + "','" + comboBox2.Text.Trim() + "','" + textBox8.Text.Trim() + "','" + textBox9.Text.Trim() + "','" + comboBox3.Text.Trim() + "','" + textBox7.Text.Trim() + "')";
                        a2.CommandText = sql;
                        a2.Connection = a1;
                        a2.ExecuteNonQuery();
                        MessageBox.Show("恭喜，信息提交成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }


        private void button1_Click_2(object sender, EventArgs e)
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
                wa = "select * from 助学金信息表 where 学号='" + textBox1.Text.Trim() + "'";
                a2.CommandText = wa;
                a2.Connection = a1;
                OleDbDataReader a3 = a2.ExecuteReader();
                if (a3.Read() == false)
                { MessageBox.Show("系统不存在此信息！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    textBox1.Text = a3[0].ToString();
                    textBox2.Text = a3[1].ToString();
                    textBox3.Text = a3[2].ToString();
                    comboBox1.Text = a3[3].ToString();
                    textBox4.Text = a3[4].ToString();
                    textBox5.Text = a3[5].ToString();
                    textBox6.Text = a3[6].ToString();
                    comboBox2.Text = a3[7].ToString();
                    textBox8.Text = a3[8].ToString();
                    textBox9.Text = a3[9].ToString();
                    pictureBox1.ImageLocation = a3[10].ToString();



                    { MessageBox.Show("信息查询成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
            }
        }
    }
}
     
