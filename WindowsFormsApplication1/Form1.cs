using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         *登录按钮触发事件
         */
        private void button1_Click(object sender, EventArgs e)
        {
            string wa;
            OleDbConnection a1 = new OleDbConnection();
            OleDbCommand a2 = new OleDbCommand();
            //数据库连接
            a1.ConnectionString = "Provider=Microsoft.ace.OLEDB.12.0;Data Source= 学生信息管理数据库.accdb";
            a1.Open();
            //在数据库中查找对应 的用户名和密码
            wa = "Select * from 用户表 where 用户名='" + textBox1.Text.Trim() + "'and 密码='" + textBox2.Text.Trim() + "'and 角色='" + comboBox1.Text.Trim() + "'";
            a2.CommandText = wa;
            a2.Connection = a1;
            a2.ExecuteScalar();
            //获取到数据证明输入账号正确
            if (null != a2.ExecuteScalar())
            {
                //判断账户类型是否为学生
                if (comboBox1.Text == "学生")
                {
                    MessageBox.Show("欢迎进入信息管理系统学生端！", "登录成功！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Visible = false;
                    Form2 f2 = new Form2();   //Form2为学生端主界面
                    f2.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    //判断账户类型是否为老师
                    if (comboBox1.Text == "老师")
                    {
                        MessageBox.Show("欢迎进入信息管理系统教师端！", "登录成功！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Visible = false;
                        Form4 f3 = new Form4();  //Form4为教师端主界面
                        f3.ShowDialog();
                        this.Visible = true;
                    }
                    else
                    {
                        //判断账户类型是否为管理员
                        MessageBox.Show("欢迎进入后台管理模式！", "登录成功！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Visible = false;
                        Form16 f4 = new Form16();  //Form2为后台管理主界面
                        f4.ShowDialog();
                        this.Visible = true;

                    }
                }
            }
            else  //账户或者密码错误
            {
                MessageBox.Show("登录失败！请输入正确的用户名、密码和角色！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }

        /*
       *注册按钮触发事件
       */
        private void button2_Click(object sender, EventArgs e)
        {
            Form32 f2 = new Form32();  //Form32为注册界面
            f2.ShowDialog();
        }

        /*
       *取消按钮触发事件
       */
        private void button3_Click(object sender, EventArgs e)
        {
            //清空数据
            textBox1.Text = "";  
            textBox2.Text = "";
            comboBox1.Text = "";

        }

        /*
       *底部版权超链接
       */
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           linkLabel1.LinkVisited = true;
            //使用IE浏览器打开
           System.Diagnostics.Process.Start("IExplore", "https://www.cztcms.cn");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
