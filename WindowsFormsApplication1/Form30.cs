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
    public partial class Form30 : Form
    {
        public Form30()
        {
            InitializeComponent();
        }

        private void Form30_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { MessageBox.Show("请输入用户名！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
                if (textBox2.Text == "")
                { MessageBox.Show("请先查询用户信息！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else

                    if (comboBox1.Text == "")
                    { MessageBox.Show("请先查询用户信息！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                    else
                    {
                        OleDbConnection a1 = new OleDbConnection();
                        OleDbCommand a2 = new OleDbCommand();
                        a1.ConnectionString = data.mystr;
                        a1.Open();
                        MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                        DialogResult dr = MessageBox.Show("确定要删除此用户吗！", "删除用户", messButton, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            string wa;
                            wa = "delete * from 用户表 where 用户名='" + textBox1.Text.Trim() + "' and 密码='" + textBox2.Text.Trim() + "'and 角色='" + comboBox1.Text.Trim() + "' ";
                            a2.CommandText = wa;
                            a2.Connection = a1;
                            a2.ExecuteNonQuery();

                            { MessageBox.Show("用户删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        }
                    }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string wa;
            OleDbConnection a1 = new OleDbConnection();
            OleDbCommand a2 = new OleDbCommand();
            a1.ConnectionString = data.mystr;
            a1.Open();
            if (textBox1.Text == "")
            { MessageBox.Show("请输入用户名！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                wa = "select * from 用户表 where 用户名='" + textBox1.Text.Trim() + "'";
                a2.CommandText = wa;
                a2.Connection = a1;
                OleDbDataReader a3 = a2.ExecuteReader();
                if (a3.Read() == false)
                { MessageBox.Show("系统不存在此信息！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    textBox1.Text = a3[0].ToString();
                    textBox2.Text = a3[1].ToString();
                    comboBox1.Text = a3[2].ToString();

                    { MessageBox.Show("用户信息查询成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
            }
        }
    }
}
