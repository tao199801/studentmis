namespace WindowsFormsApplication1
{
    partial class Form17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form17));
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.学号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.有效成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.班级 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学分 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学年 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.学期 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(593, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号,
            this.姓名,
            this.课程名,
            this.成绩,
            this.有效成绩,
            this.班级,
            this.学分,
            this.学年,
            this.学期});
            this.dataGridView1.Location = new System.Drawing.Point(2, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1292, 38);
            this.dataGridView1.TabIndex = 22;
            // 
            // 学号
            // 
            this.学号.DataPropertyName = "学号";
            this.学号.HeaderText = "学号";
            this.学号.Name = "学号";
            this.学号.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.学号.Visible = false;
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "姓名";
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            this.姓名.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 课程名
            // 
            this.课程名.DataPropertyName = "课程名";
            this.课程名.HeaderText = "课程名";
            this.课程名.Name = "课程名";
            // 
            // 成绩
            // 
            this.成绩.DataPropertyName = "成绩";
            this.成绩.HeaderText = "成绩";
            this.成绩.Name = "成绩";
            // 
            // 有效成绩
            // 
            this.有效成绩.DataPropertyName = "有效成绩";
            this.有效成绩.HeaderText = "有效成绩";
            this.有效成绩.Name = "有效成绩";
            // 
            // 班级
            // 
            this.班级.DataPropertyName = "班级";
            this.班级.HeaderText = "班级";
            this.班级.Name = "班级";
            // 
            // 学分
            // 
            this.学分.DataPropertyName = "学分";
            this.学分.HeaderText = "学分";
            this.学分.Name = "学分";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "请输入所添加学生的学号：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 21);
            this.textBox1.TabIndex = 24;
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1299, 324);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form17";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息管理系统  添加成绩";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn 有效成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班级;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学分;
        private System.Windows.Forms.DataGridViewComboBoxColumn 学年;
        private System.Windows.Forms.DataGridViewComboBoxColumn 学期;

    }
}