using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 信息查询与修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 f4 = new Form3();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 f4 = new Form3();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 f4 = new Form3();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 查看成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 f4 = new Form5();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 网上选课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 f4 = new Form6();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 助学金申请ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 f4 = new Form7();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 奖学金认定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form8 f4 = new Form8();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 助学金认定结果ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form9 f4 = new Form9();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 奖学金认定结果ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form10 f4 = new Form10();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 正选结果ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form19 f4 = new Form19();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 退选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form19 f4 = new Form19();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form22 f4 = new Form22();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 选课管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 助学金管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
