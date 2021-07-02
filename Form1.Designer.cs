
namespace genData
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.db = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.user = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.pwd = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.port = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.server = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox5.Location = new System.Drawing.Point(119, 199);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(115, 30);
			this.textBox5.TabIndex = 34;
			// 
			// db
			// 
			this.db.AutoSize = true;
			this.db.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.db.Location = new System.Drawing.Point(13, 202);
			this.db.Name = "db";
			this.db.Size = new System.Drawing.Size(100, 22);
			this.db.TabIndex = 33;
			this.db.Text = "database:";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(119, 107);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(115, 30);
			this.textBox3.TabIndex = 30;
			this.textBox3.Text = "root";
			// 
			// user
			// 
			this.user.AutoSize = true;
			this.user.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.user.Location = new System.Drawing.Point(53, 110);
			this.user.Name = "user";
			this.user.Size = new System.Drawing.Size(60, 22);
			this.user.TabIndex = 29;
			this.user.Text = "user:";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(119, 153);
			this.textBox4.Name = "textBox4";
			this.textBox4.PasswordChar = '*';
			this.textBox4.Size = new System.Drawing.Size(115, 30);
			this.textBox4.TabIndex = 32;
			// 
			// pwd
			// 
			this.pwd.AutoSize = true;
			this.pwd.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pwd.Location = new System.Drawing.Point(13, 156);
			this.pwd.Name = "pwd";
			this.pwd.Size = new System.Drawing.Size(100, 22);
			this.pwd.TabIndex = 31;
			this.pwd.Text = "password:";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(119, 61);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(115, 30);
			this.textBox2.TabIndex = 28;
			this.textBox2.Text = "3306";
			// 
			// port
			// 
			this.port.AutoSize = true;
			this.port.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.port.Location = new System.Drawing.Point(53, 64);
			this.port.Name = "port";
			this.port.Size = new System.Drawing.Size(60, 22);
			this.port.TabIndex = 27;
			this.port.Text = "port:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(119, 15);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(115, 30);
			this.textBox1.TabIndex = 26;
			this.textBox1.Text = "127.0.0.1";
			// 
			// server
			// 
			this.server.AutoSize = true;
			this.server.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.server.Location = new System.Drawing.Point(33, 18);
			this.server.Name = "server";
			this.server.Size = new System.Drawing.Size(80, 22);
			this.server.TabIndex = 25;
			this.server.Text = "server:";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(76, 247);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 33);
			this.button1.TabIndex = 35;
			this.button1.Text = "Connect";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(255, 297);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.db);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.user);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.pwd);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.port);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.server);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "数据库登录";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label db;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label port;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label server;
        private System.Windows.Forms.Button button1;
    }
}

