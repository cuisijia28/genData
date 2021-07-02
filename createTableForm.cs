using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genData
{
    public partial class createTableForm : Form
    {
        const int tbNum = 64;
        string connstr;
        public createTableForm(string connstr)
        {
            this.connstr = connstr;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 2;
            // do something
            string sql = @"CREATE TABLE ";
            sql += tableName.Text + " (";
            sql += textBox1.Text + " " + comboBox1.SelectedItem.ToString() + "(" + textBox2.Text + ")";
            for (int i = 1; i < count; i++)
            {
                sql += ","+textBox3.Text + " " + comboBox2.SelectedItem.ToString() + "(" + textBox4.Text + ")";
            }
            sql += ");";

            try
            {
                MySqlConnection tmpConn = new MySqlConnection(connstr);
                MySqlCommand cmd = new MySqlCommand(sql, tmpConn);
                tmpConn.Open();

                cmd.ExecuteNonQuery();
                Console.WriteLine("添加成功");

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("添加失败");
            }

            this.Close();
        }

        private void createTableForm_Load(object sender, EventArgs e)
        {

            // 待修改
            comboBox1.Items.Add("INT");
            comboBox1.Items.Add("VARCHAR");
            comboBox1.Items.Add("CHAR");
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Add("INT");
            comboBox2.Items.Add("VARCHAR");
            comboBox2.Items.Add("CHAR");
            comboBox2.SelectedIndex = 0;




            // 待修改
            //TextBox[] tbs = new TextBox[tbNum];

            //for (int i = 0; i < tbNum; i++)
            //{
            //    tbs[i] = new TextBox();
            //    tbs[i].Visible = false;
            //    this.Controls.Add(tbs[i]);
            //}
            //tbs[0].Visible = true;
            //tbs[0].Text = "fsfsfsd";

        }
    }
}
