﻿namespace WindowsFormsApplication1
{
    partial class Form26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form26));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.学号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.认定等级 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.家庭住址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.籍贯 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.政治面貌 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.家庭年收入 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.认定理由 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.评审结果 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.评审意见 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号,
            this.姓名,
            this.联系电话,
            this.认定等级,
            this.家庭住址,
            this.身份证号,
            this.籍贯,
            this.政治面貌,
            this.家庭年收入,
            this.认定理由,
            this.评审结果,
            this.评审意见});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1253, 550);
            this.dataGridView1.TabIndex = 4;
            // 
            // 学号
            // 
            this.学号.DataPropertyName = "学号";
            this.学号.HeaderText = "学号";
            this.学号.Name = "学号";
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "姓名";
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            // 
            // 联系电话
            // 
            this.联系电话.DataPropertyName = "联系电话";
            this.联系电话.HeaderText = "联系电话";
            this.联系电话.Name = "联系电话";
            // 
            // 认定等级
            // 
            this.认定等级.DataPropertyName = "认定等级";
            this.认定等级.HeaderText = "认定等级";
            this.认定等级.Name = "认定等级";
            // 
            // 家庭住址
            // 
            this.家庭住址.DataPropertyName = "家庭住址";
            this.家庭住址.HeaderText = "家庭住址";
            this.家庭住址.Name = "家庭住址";
            // 
            // 身份证号
            // 
            this.身份证号.DataPropertyName = "身份证号";
            this.身份证号.HeaderText = "身份证号";
            this.身份证号.Name = "身份证号";
            // 
            // 籍贯
            // 
            this.籍贯.DataPropertyName = "籍贯";
            this.籍贯.HeaderText = "籍贯";
            this.籍贯.Name = "籍贯";
            // 
            // 政治面貌
            // 
            this.政治面貌.DataPropertyName = "政治面貌";
            this.政治面貌.HeaderText = "政治面貌";
            this.政治面貌.Name = "政治面貌";
            // 
            // 家庭年收入
            // 
            this.家庭年收入.DataPropertyName = "家庭年收入";
            this.家庭年收入.HeaderText = "家庭年收入";
            this.家庭年收入.Name = "家庭年收入";
            // 
            // 认定理由
            // 
            this.认定理由.DataPropertyName = "认定理由";
            this.认定理由.HeaderText = "认定理由";
            this.认定理由.Name = "认定理由";
            // 
            // 评审结果
            // 
            this.评审结果.DataPropertyName = "评审结果";
            this.评审结果.HeaderText = "评审结果";
            this.评审结果.Name = "评审结果";
            // 
            // 评审意见
            // 
            this.评审意见.DataPropertyName = "评审意见";
            this.评审意见.HeaderText = "评审意见";
            this.评审意见.Name = "评审意见";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(529, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "奖学金评审表";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(1141, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "检索";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form26
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1250, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form26";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息管理系统  奖学金管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系电话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 认定等级;
        private System.Windows.Forms.DataGridViewTextBoxColumn 家庭住址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 籍贯;
        private System.Windows.Forms.DataGridViewTextBoxColumn 政治面貌;
        private System.Windows.Forms.DataGridViewTextBoxColumn 家庭年收入;
        private System.Windows.Forms.DataGridViewTextBoxColumn 认定理由;
        private System.Windows.Forms.DataGridViewTextBoxColumn 评审结果;
        private System.Windows.Forms.DataGridViewTextBoxColumn 评审意见;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}