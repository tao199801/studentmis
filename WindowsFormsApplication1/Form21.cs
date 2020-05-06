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
    public partial class Form21 : Form
    {
        public Form21()
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
                    if (textBox3.Text == "")
                    { MessageBox.Show("请再次输入密码！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
                                    MessageBox.Show("添加失败,该用户名已经存在！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                                else
                                {
                                    wa = "INSERT into 用户表 values(" + "'" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + comboBox1.Text.Trim() + "')";

                                    a2.CommandText = wa;
                                    a2.Connection = a1;
                                    a2.ExecuteNonQuery();
                                    MessageBox.Show("用户已注册成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }

                            else
                            {
                                MessageBox.Show("两次密码不一样！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { MessageBox.Show("请输入用户名！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
                if (textBox2.Text == "")
                { MessageBox.Show("请输入用户密码！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                    if (textBox3.Text == "")
                    { MessageBox.Show("请再次输入密码！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else
                        if (comboBox1.Text == "")
                        { MessageBox.Show("请选择用户角色！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                        else
                        {
                            if (textBox2.Text == textBox3.Text)
                            {
                                string wa;
                                OleDbConnection a1 = new OleDbConnection();
                                OleDbCommand a2 = new OleDbCommand();
                                a1.ConnectionString = "Provider=Microsoft.ace.OLEDB.12.0;Data Source= 学生信息管理数据库.accdb";
                                a1.Open();


                                string sql = "select * from 用户表 where 用户名='" + textBox1.Text.Trim() + "'";
                                a2.CommandText = sql;
                                a2.Connection = a1;
                                OleDbDataReader a3 = a2.ExecuteReader();
                                if (a3.Read() == false)
                                { MessageBox.Show("系统不存在此信息！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                                else
                                {
                                    MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                                    DialogResult dr = MessageBox.Show("确定要修改此信息吗！", "修改信息", messButton, MessageBoxIcon.Information);
                                    if (dr == DialogResult.OK)
                                    {
                                        a3.Close();
                                        wa = "update 用户表 set 用户名='" + textBox1.Text.Trim() + "' , 密码='" + textBox2.Text.Trim() + "',角色='" + comboBox1.Text.Trim() + "' where 用户名='" + textBox1.Text.Trim() + "'";
                                        a2.CommandText = wa;
                                        a2.Connection = a1;
                                        a2.ExecuteNonQuery();
                                        MessageBox.Show("信息修改成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }

                                }
                            }

                            else
                            {
                                MessageBox.Show("两次密码不一样！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }


        }
    }
}