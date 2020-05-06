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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void 成绩录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form11 f4 = new Form11();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form11 f4 = new Form11();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 成绩查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form15 f4 = new Form15();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form11 f4 = new Form11();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 本班学生管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form12 f4 = new Form12();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 助学金评审ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form14 f4 = new Form14();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 奖学金评审ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form13 f4 = new Form13();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 成绩录入ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form17 f4 = new Form17();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 成绩修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form15 f4 = new Form15();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 成绩修改ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form15 f4 = new Form15();
            f4.ShowDialog();
            this.Visible = true;
        }

        private void 学生管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form22 f4 = new Form22();
            f4.ShowDialog();
            this.Visible = true;
        }

    
    }
}
