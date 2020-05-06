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
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection a1 = new OleDbConnection();
            OleDbCommand a2 = new OleDbCommand();
            a1.ConnectionString = data.mystr;
            a1.Open();

            string sql1 = "select * from  学生信息表 ";
            OleDbDataAdapter ad1 = new OleDbDataAdapter(sql1, a1);
            DataSet ds1 = new DataSet();
            ad1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
            MessageBox.Show("检索成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OleDbConnection a1 = new OleDbConnection();
            OleDbCommand a2 = new OleDbCommand();
            a1.ConnectionString = data.mystr;
            a1.Open();
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要删除此信息吗！", "删除信息", messButton, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                string wa;
                wa = "delete * from 学生信息表 where 姓名='" + this.dataGridView1.CurrentRow.Cells["姓名"].Value + "'and 学号='" + this.dataGridView1.CurrentRow.Cells["学号"].Value + "'and 宿舍='" + this.dataGridView1.CurrentRow.Cells["宿舍"].Value + "'and 家庭住址='" + this.dataGridView1.CurrentRow.Cells["家庭住址"].Value + "'and 年级='" + this.dataGridView1.CurrentRow.Cells["年级"].Value + "'and 邮政编码='" + this.dataGridView1.CurrentRow.Cells["邮政编码"].Value + "'and 专业='" + this.dataGridView1.CurrentRow.Cells["专业"].Value + "'and 电话号码='" + this.dataGridView1.CurrentRow.Cells["电话号码"].Value + "'and 班级='" + this.dataGridView1.CurrentRow.Cells["班级"].Value + "'and 民族='" + this.dataGridView1.CurrentRow.Cells["民族"].Value + "'and 照片='" + this.dataGridView1.CurrentRow.Cells["照片"].Value + "'";
                a2.CommandText = wa;
                a2.Connection = a1;
                a2.ExecuteNonQuery();

                { MessageBox.Show("信息删除成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
