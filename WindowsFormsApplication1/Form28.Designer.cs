namespace WindowsFormsApplication1
{
    partial class Form28
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form28));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.工号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.宿舍 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.家庭住址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年级 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.邮政编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.专业 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电话号码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.班级 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.民族 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.照片 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.工号,
            this.姓名,
            this.宿舍,
            this.家庭住址,
            this.年级,
            this.邮政编码,
            this.专业,
            this.电话号码,
            this.班级,
            this.民族,
            this.照片});
            this.dataGridView1.Location = new System.Drawing.Point(-3, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1290, 470);
            this.dataGridView1.TabIndex = 4;
            // 
            // 工号
            // 
            this.工号.DataPropertyName = "工号";
            this.工号.HeaderText = "工号";
            this.工号.Name = "工号";
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "姓名";
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            // 
            // 宿舍
            // 
            this.宿舍.DataPropertyName = "宿舍";
            this.宿舍.HeaderText = "宿舍";
            this.宿舍.Name = "宿舍";
            // 
            // 家庭住址
            // 
            this.家庭住址.DataPropertyName = "家庭住址";
            this.家庭住址.HeaderText = "家庭住址";
            this.家庭住址.Name = "家庭住址";
            // 
            // 年级
            // 
            this.年级.DataPropertyName = "年级";
            this.年级.HeaderText = "年级";
            this.年级.Name = "年级";
            // 
            // 邮政编码
            // 
            this.邮政编码.DataPropertyName = "邮政编码";
            this.邮政编码.HeaderText = "邮政编码";
            this.邮政编码.Name = "邮政编码";
            // 
            // 专业
            // 
            this.专业.DataPropertyName = "专业";
            this.专业.HeaderText = "专业";
            this.专业.Name = "专业";
            // 
            // 电话号码
            // 
            this.电话号码.DataPropertyName = "电话号码";
            this.电话号码.HeaderText = "电话号码";
            this.电话号码.Name = "电话号码";
            // 
            // 班级
            // 
            this.班级.DataPropertyName = "班级";
            this.班级.HeaderText = "班级";
            this.班级.Name = "班级";
            // 
            // 民族
            // 
            this.民族.DataPropertyName = "民族";
            this.民族.HeaderText = "民族";
            this.民族.Name = "民族";
            // 
            // 照片
            // 
            this.照片.DataPropertyName = "照片";
            this.照片.HeaderText = "照片";
            this.照片.Name = "照片";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(549, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "教师信息表";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(1166, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "检索";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(616, 580);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "删除信息";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form28
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1285, 621);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form28";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息管理系统 教师信息管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 宿舍;
        private System.Windows.Forms.DataGridViewTextBoxColumn 家庭住址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年级;
        private System.Windows.Forms.DataGridViewTextBoxColumn 邮政编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 专业;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电话号码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班级;
        private System.Windows.Forms.DataGridViewTextBoxColumn 民族;
        private System.Windows.Forms.DataGridViewTextBoxColumn 照片;
        private System.Windows.Forms.Button button2;
    }
}