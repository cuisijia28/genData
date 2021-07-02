using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genData
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
            connectionString.Server = textBox1.Text;
			if (uint.TryParse(textBox2.Text, out uint port_number))
			{
				connectionString.Port = port_number;
			}
			connectionString.UserID = textBox3.Text;
            connectionString.Password = textBox4.Text;
            connectionString.Database = textBox5.Text;
            connectionString.CharacterSet = "utf8";
            using (MySqlConnection conn = new MySqlConnection(connectionString.ConnectionString))
			{
				try
				{
                    conn.Open();
                    conn.Close();

                    Hide();

                    Form2 form2 = new Form2(connectionString.ConnectionString);
                    form2.ShowDialog();

                    Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "MySQL连接失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }
            }
            
        }
    }

}
