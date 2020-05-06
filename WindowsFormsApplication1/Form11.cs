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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }













        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string wa;
            OleDbConnection a1 = new OleDbConnection();
            OleDbCommand a2 = new OleDbCommand();
            a1.ConnectionString = data.mystr;
            a1.Open();
            if (textBox2.Text == "")
            { MessageBox.Show("请输入教师工号！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                wa = "select * from 教师信息表 where 工号='" + textBox2.Text.Trim() + "'";
                a2.CommandText = wa;
                a2.Connection = a1;
                OleDbDataReader a3 = a2.ExecuteReader();
                if (a3.Read() == false)
                { MessageBox.Show("系统不存在此信息！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    textBox2.Text = a3[0].ToString();
                    textBox1.Text = a3[1].ToString();
                    textBox3.Text = a3[2].ToString();
                    textBox4.Text = a3[3].ToString();
                    comboBox1.Text = a3[4].ToString();
                    textBox5.Text = a3[5].ToString();
                    comboBox2.Text = a3[6].ToString();
                    textBox6.Text = a3[7].ToString();
                    comboBox3.Text = a3[8].ToString();
                    comboBox4.Text = a3[9].ToString();
                    pictureBox1.ImageLocation = a3[10].ToString();



                    { MessageBox.Show("信息查询成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string mysql;
            OleDbConnection a1 = new OleDbConnection();
            OleDbCommand a2 = new OleDbCommand();
            a1.ConnectionString = data.mystr;
            a1.Open();
            mysql = "select * from  教师信息表 where 工号='" + textBox2.Text.Trim() + "'";
            a2.CommandText = mysql;
            a2.Connection = a1;
            OleDbDataReader a3 = a2.ExecuteReader();
            if (a3.Read())
            {
                MessageBox.Show("用户信息已经存在！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || pictureBox1.ImageLocation == "")
                {
                    MessageBox.Show("请输入完整信息！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    a3.Close();
                    string sql;
                    sql = "insert into 教师信息表 values (" + "'" + textBox2.Text.Trim() + "','" + textBox1.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox4.Text.Trim() + "','" + comboBox1.Text.Trim() + "','" + textBox5.Text.Trim() + "','" + comboBox2.Text.Trim() + "', '" + textBox6.Text.Trim() + "','" + comboBox3.Text.Trim() + "','" + comboBox4.Text.Trim() + "','" + Program.Imagefile + "')";
                    a2.CommandText = sql;
                    a2.Connection = a1;
                    a2.ExecuteNonQuery();
                    MessageBox.Show("信息添加成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            pictureBox1.ImageLocation = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string wa;
            OleDbConnection a1 = new OleDbConnection();
            OleDbCommand a2 = new OleDbCommand();
            a1.ConnectionString = data.mystr;
            a1.Open();
            if (textBox2.Text == "")
            { MessageBox.Show("请输入工号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                string sql = "select * from 教师信息表 where 工号='" + textBox2.Text.Trim() + "'";
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
                        wa = "update 教师信息表 set 姓名='" + textBox1.Text.Trim() + "',宿舍= '" + textBox3.Text.Trim() + "',家庭住址= '" + textBox4.Text.Trim() + "',年级= '" + comboBox1.Text.Trim() + "',邮政编码= '" + textBox5.Text.Trim() + "',专业='" + comboBox2.Text.Trim() + "',电话号码='" + textBox6.Text.Trim() + "',班级= '" + comboBox3.Text.Trim() + "',民族='" + comboBox4.Text.Trim() + "',照片='" + Program.Imagefile + "' where 工号='" + textBox2.Text.Trim() + "'";
                        a2.CommandText = wa;
                        a2.Connection = a1;
                        a2.ExecuteNonQuery();
                        MessageBox.Show("信息修改成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dr = new OpenFileDialog();
            dr.ShowDialog();
            dr.Filter = "image file (*.bmp;*.jpg)|*.bmp;*.jpg";
            string imagefile = dr.FileName;
            pictureBox1.ImageLocation = imagefile;
            Program.Imagefile = imagefile;
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}