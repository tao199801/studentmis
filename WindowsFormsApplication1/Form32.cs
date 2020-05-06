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
    public partial class Form32 : Form
    {
        public Form32()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { MessageBox.Show("请输入用户名！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
                if (textBox2.Text == "")
                { MessageBox.Show("请输入用户密码！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                    if (comboBox1.Text == "")
                    { MessageBox.Show("请选择用户角色！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                    else
                        if (textBox2.Text == textBox3.Text)
                        {


                            string wa;
                            OleDbConnection a1 = new OleDbConnection();
                            OleDbCommand a2 = new OleDbCommand();
                            a1.ConnectionString = "Provider=Microsoft.ace.OLEDB.12.0;Data Source= 学生信息管理数据库.accdb";
                            a1.Open();
                            wa = "Select * from 用户表 where 用户名='" + textBox1.Text.Trim() + "'";
                            a2.CommandText = wa;
                            a2.Connection = a1;
                            a2.ExecuteScalar();
                            if (null != a2.ExecuteScalar())
                            {
                                MessageBox.Show("注册失败,该用户名已经存在！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            else
                            {
                                wa = "INSERT into 用户表 values(" + "'" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + comboBox1.Text.Trim() + "')";

                                a2.CommandText = wa;
                                a2.Connection = a1;
                                a2.ExecuteNonQuery();
                                MessageBox.Show("用户注册成功,请进行登录！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               Application.OpenForms["form32"].Close();
                              

                            }
                        }
                        else
                        {
                            MessageBox.Show("两次输入的密码不一样！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form32_Load(object sender, EventArgs e)
        {

        }
    }
}
