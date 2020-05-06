namespace WindowsFormsApplication1
{
    partial class Form29
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form29));
            this.button1 = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(1078, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
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
            this.学号,
            this.姓名,
            this.课程名,
            this.成绩,
            this.有效成绩,
            this.班级,
            this.学分,
            this.学年,
            this.学期});
            this.dataGridView1.Location = new System.Drawing.Point(3, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 399);
            this.dataGridView1.TabIndex = 24;
            // 
            // 学号
            // 
            this.学号.DataPropertyName = "学号";
            this.学号.HeaderText = "学号";
            this.学号.Name = "学号";
            this.学号.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(525, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "学生成绩表";
            // 
            // Form29
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1191, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form29";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息管理系统 成绩管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn 有效成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班级;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学分;
        private System.Windows.Forms.DataGridViewComboBoxColumn 学年;
        private System.Windows.Forms.DataGridViewComboBoxColumn 学期;
        private System.Windows.Forms.Label label1;
    }
}