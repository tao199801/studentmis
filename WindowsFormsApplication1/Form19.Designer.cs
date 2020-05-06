namespace WindowsFormsApplication1
{
    partial class Form19
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form19));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.课程名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程代号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程类别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.任课教师 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.教师代号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学年 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.学期 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.周时 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1089, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "检索";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.课程名,
            this.学号,
            this.课程代号,
            this.课程类别,
            this.任课教师,
            this.教师代号,
            this.学年,
            this.学期,
            this.周时});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1210, 466);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 课程名
            // 
            this.课程名.DataPropertyName = "课程名";
            this.课程名.HeaderText = "课程名";
            this.课程名.Name = "课程名";
            // 
            // 学号
            // 
            this.学号.DataPropertyName = "学号";
            this.学号.HeaderText = "学号";
            this.学号.Name = "学号";
            this.学号.Visible = false;
            // 
            // 课程代号
            // 
            this.课程代号.DataPropertyName = "课程代号";
            this.课程代号.HeaderText = "课程代号";
            this.课程代号.Name = "课程代号";
            // 
            // 课程类别
            // 
            this.课程类别.DataPropertyName = "课程类别";
            this.课程类别.HeaderText = "课程类别";
            this.课程类别.Name = "课程类别";
            // 
            // 任课教师
            // 
            this.任课教师.DataPropertyName = "任课教师";
            this.任课教师.HeaderText = "任课教师";
            this.任课教师.Name = "任课教师";
            // 
            // 教师代号
            // 
            this.教师代号.DataPropertyName = "教师代号";
            this.教师代号.HeaderText = "教师代号";
            this.教师代号.Name = "教师代号";
            // 
            // 学年
            // 
            this.学年.DataPropertyName = "学年";
            this.学年.HeaderText = "学年";
            this.学年.Items.AddRange(new object[] {
            "2016-2017",
            "2017-2018",
            "2018-2019"});
            this.学年.Name = "学年";
            this.学年.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.学年.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 学期
            // 
            this.学期.DataPropertyName = "学期";
            this.学期.HeaderText = "学期";
            this.学期.Items.AddRange(new object[] {
            "第一学期",
            "第二学期"});
            this.学期.Name = "学期";
            this.学期.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.学期.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 周时
            // 
            this.周时.DataPropertyName = "周时";
            this.周时.HeaderText = "周时";
            this.周时.Items.AddRange(new object[] {
            "2-17周",
            "2-19周"});
            this.周时.Name = "周时";
            this.周时.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.周时.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退选ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // 退选ToolStripMenuItem
            // 
            this.退选ToolStripMenuItem.Name = "退选ToolStripMenuItem";
            this.退选ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.退选ToolStripMenuItem.Text = "退选";
            this.退选ToolStripMenuItem.Click += new System.EventHandler(this.退选ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "学号：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 21);
            this.textBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(445, 574);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "注意：在所选课程上单击鼠标右键可进行“退选”";
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1203, 595);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form19";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息管理系统  选课管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程代号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程类别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 任课教师;
        private System.Windows.Forms.DataGridViewTextBoxColumn 教师代号;
        private System.Windows.Forms.DataGridViewComboBoxColumn 学年;
        private System.Windows.Forms.DataGridViewComboBoxColumn 学期;
        private System.Windows.Forms.DataGridViewComboBoxColumn 周时;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退选ToolStripMenuItem;
    }
}