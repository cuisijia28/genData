
namespace genData
{
    partial class Form2
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
            this.mysqlData = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.removeTableBt = new System.Windows.Forms.Button();
            this.refreshTableBt = new System.Windows.Forms.Button();
            this.execute = new System.Windows.Forms.Button();
            this.addTableBt = new System.Windows.Forms.Button();
            this.selectData = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Button();
            this.pid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.genRandData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mysqlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectData)).BeginInit();
            this.SuspendLayout();
            // 
            // mysqlData
            // 
            this.mysqlData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mysqlData.Location = new System.Drawing.Point(17, 72);
            this.mysqlData.Name = "mysqlData";
            this.mysqlData.RowTemplate.Height = 23;
            this.mysqlData.Size = new System.Drawing.Size(512, 432);
            this.mysqlData.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 29);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "表名";
            // 
            // removeTableBt
            // 
            this.removeTableBt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.removeTableBt.Location = new System.Drawing.Point(291, 17);
            this.removeTableBt.Name = "removeTableBt";
            this.removeTableBt.Size = new System.Drawing.Size(79, 40);
            this.removeTableBt.TabIndex = 8;
            this.removeTableBt.Text = "删除表";
            this.removeTableBt.UseVisualStyleBackColor = true;
            this.removeTableBt.Click += new System.EventHandler(this.removeTableBt_Click);
            // 
            // refreshTableBt
            // 
            this.refreshTableBt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.refreshTableBt.Location = new System.Drawing.Point(206, 17);
            this.refreshTableBt.Name = "refreshTableBt";
            this.refreshTableBt.Size = new System.Drawing.Size(79, 40);
            this.refreshTableBt.TabIndex = 9;
            this.refreshTableBt.Text = "刷新表";
            this.refreshTableBt.UseVisualStyleBackColor = true;
            this.refreshTableBt.Click += new System.EventHandler(this.refresh_Click);
            // 
            // execute
            // 
            this.execute.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.execute.Location = new System.Drawing.Point(554, 464);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(79, 40);
            this.execute.TabIndex = 10;
            this.execute.Text = "测试";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // addTableBt
            // 
            this.addTableBt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addTableBt.Location = new System.Drawing.Point(450, 463);
            this.addTableBt.Name = "addTableBt";
            this.addTableBt.Size = new System.Drawing.Size(79, 40);
            this.addTableBt.TabIndex = 11;
            this.addTableBt.Text = "新增表";
            this.addTableBt.UseVisualStyleBackColor = true;
            this.addTableBt.Visible = false;
            this.addTableBt.Click += new System.EventHandler(this.addTableBt_Click);
            // 
            // selectData
            // 
            this.selectData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectData.Location = new System.Drawing.Point(552, 53);
            this.selectData.Name = "selectData";
            this.selectData.RowTemplate.Height = 23;
            this.selectData.Size = new System.Drawing.Size(443, 223);
            this.selectData.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(552, 330);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(443, 122);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(550, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "答案";
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.output.Location = new System.Drawing.Point(916, 464);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(79, 40);
            this.output.TabIndex = 15;
            this.output.Text = "导出";
            this.output.UseVisualStyleBackColor = true;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // pid
            // 
            this.pid.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pid.Location = new System.Drawing.Point(823, 470);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(75, 29);
            this.pid.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(775, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "题号";
            // 
            // genRandData
            // 
            this.genRandData.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.genRandData.Location = new System.Drawing.Point(376, 17);
            this.genRandData.Name = "genRandData";
            this.genRandData.Size = new System.Drawing.Size(124, 40);
            this.genRandData.TabIndex = 18;
            this.genRandData.Text = "插入随机数据";
            this.genRandData.UseVisualStyleBackColor = true;
            this.genRandData.Click += new System.EventHandler(this.genRandata_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(548, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "测试结果";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 520);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.genRandData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.selectData);
            this.Controls.Add(this.addTableBt);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.refreshTableBt);
            this.Controls.Add(this.removeTableBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.mysqlData);
            this.Name = "Form2";
            this.Text = "题目数据生成";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mysqlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView mysqlData;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeTableBt;
        private System.Windows.Forms.Button refreshTableBt;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.Button addTableBt;
        private System.Windows.Forms.DataGridView selectData;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button output;
        private System.Windows.Forms.TextBox pid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button genRandData;
        private System.Windows.Forms.Label label4;
    }
}