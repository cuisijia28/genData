using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace genData
{

    public partial class Form2 : Form
    {
        MySqlConnection conn;
        string connstr;
        List<string> colName;
        List<string> colType;
        int nowDisplay = -1;


        // for insert 
        const int insertNum = 100;
        string firstName = @"赵钱孙李周吴郑王冯陈褚卫蒋沈韩杨朱秦尤许何吕施张孔曹严华金魏陶姜戚谢邹喻水云苏潘葛奚范彭郎鲁韦昌马苗凤花方俞任袁柳鲍史唐费岑薛雷贺倪汤滕殷罗毕郝邬安常乐于时傅卞齐康伍余元卜顾孟平黄和穆萧尹姚邵湛汪祁毛禹狄米贝明臧计成戴宋茅庞熊纪舒屈项祝董粱杜阮席季麻强贾路娄危江童颜郭梅盛林刁钟徐邱骆高夏蔡田胡凌霍万柯卢莫房缪干解应宗丁宣邓郁单杭洪包诸左石崔吉龚程邢滑裴陆荣翁荀羊甄家封芮储靳邴松井富乌焦巴弓牧隗山谷车侯伊宁仇祖武符刘景詹束龙叶幸司韶黎乔苍双闻莘劳逄姬冉宰桂牛寿通边燕冀尚农温庄晏瞿茹习鱼容向古戈终居衡步都耿满弘国文东殴沃曾关红游盖益桓公晋楚闫";
        string boy = @"伟刚勇毅俊峰强军平保东文辉力明永健世广志义兴良海山仁波宁贵福生龙元全国胜学祥才发武新利清飞彬富顺信子杰涛昌成康星光天达安岩中茂进林有坚和彪博诚先敬震振壮会思群豪心邦承乐绍功松善厚庆磊民友裕河哲江超浩亮政谦亨奇固之轮翰朗伯宏言若鸣朋斌梁栋维启克伦翔旭鹏泽晨辰士以建家致树炎德行时泰盛雄琛钧冠策腾楠榕风航弘";
        string girl = @"秀娟英华慧巧美娜静淑惠珠翠雅芝玉萍红娥玲芬芳燕彩春菊兰凤洁梅琳素云莲真环雪荣爱妹霞香月莺媛艳瑞凡佳嘉琼勤珍贞莉桂娣叶璧璐娅琦晶妍茜秋珊莎锦黛青倩婷姣婉娴瑾颖露瑶怡婵雁蓓纨仪荷丹蓉眉君琴蕊薇菁梦岚苑婕馨瑗琰韵融园艺咏卿聪澜纯毓悦昭冰爽琬茗羽希宁欣飘育滢馥筠柔竹霭凝晓欢霄枫芸菲寒伊亚宜可姬舒影荔枝思丽";
        Hashtable ht = new Hashtable();
        Random rm = new Random();
        string[] depts = { "CS", "MA", "IS", "TE" };

        public Form2(string connstr)
        {
            InitializeComponent();
            this.connstr = connstr;
            init();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.refreshTable();
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            refreshTable();
        }
        

        private void refreshTable()
        {
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            // 把所有的表加到combox
            openconn();
            List<string> tables = new List<string>();
            try
            {
                MySqlCommand cmd = new MySqlCommand("show tables;", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string t = reader.GetString(0);
                        tables.Add(t);
                    }
                }
                comboBox1.DataSource = tables;
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("读取table出错！");
                this.Close();
            }
            closeconn();

            // 显示第一个
            display(0);
        }

        private void display(int index)
        {
            if (index == nowDisplay)
                return;

            mysqlData.Columns.Clear();
            openconn();
            if (index >= 0 && comboBox1.Items.Count > index)
            {
                string sql = "show columns from ";
                sql += comboBox1.GetItemText(comboBox1.Items[index]) + ";";

                colName = new List<string>();
                colType = new List<string>();
                try
                {
                    // 读列
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string t = reader.GetString(0);
                            string tt = reader.GetString(1);

                            colName.Add(t);
                            colType.Add(tt);
                        }
                    }
                    reader.Close();

                    // 设置列
                    for (int i = 0; i < colName.Count; i++)
                    {
                        DataGridViewColumn addCol = new DataGridViewColumn();
                        addCol.ValueType = typeof(string);

                        addCol.Name = "column" + i.ToString();
                        addCol.HeaderText = colName[i]; 
                        DataGridViewCell dgvcell = new DataGridViewTextBoxCell();
                        addCol.CellTemplate = dgvcell;
                        mysqlData.Columns.Add(addCol);
                    }

                    // 读数据
                    sql = "select * from " + comboBox1.GetItemText(comboBox1.Items[index]) + ";";
                    cmd = new MySqlCommand(sql, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int i = mysqlData.Rows.Add();
                        for (int j = 0; j < mysqlData.Columns.Count; j++)
                        {
                            if (!reader.IsDBNull(j))
                            {
                                mysqlData.Rows[i].Cells[j].Value = reader.GetString(j);
                            }
                        }
                    }

                    nowDisplay = index;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            closeconn();
        }
        
        private void openconn()
        {
            if (conn == null)
            {
                conn = new MySqlConnection(connstr);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        private void closeconn()
        {
            if (conn != null || conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
       
        private void init()
        {
            mysqlData.ReadOnly = true;
            richTextBox1.Text = "select * from student where Ssex='男';";
            pid.Text = "1005";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0)
            {
                int c = 0;
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    if (comboBox1.Items[i] == comboBox1.SelectedItem)
                    {
                        c = i; break;
                    }
                }

                display(c);
            }
        }

        private void execute_Click(object sender, EventArgs e)
        {
            selectData.Columns.Clear();

            openconn();
            string sql = richTextBox1.Text;
            if (sql == "")
                return;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                
                // 设置列
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    DataGridViewColumn addCol = new DataGridViewColumn();
                    addCol.ValueType = typeof(string);

                    addCol.Name = "column" + i.ToString();
                    addCol.HeaderText = "column" + i.ToString();
                    DataGridViewCell dgvcell = new DataGridViewTextBoxCell();
                    addCol.CellTemplate = dgvcell;
                    selectData.Columns.Add(addCol);
                }
                // 添加数据
                while (reader.Read())
                {
                    int i = selectData.Rows.Add();
                    for (int j = 0; j < selectData.Columns.Count; j++)
                    {
                        if (!reader.IsDBNull(j))
                        {
                            selectData.Rows[i].Cells[j].Value = reader.GetString(j);
                        }
                    }
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("执行成功！");
            }

            closeconn();
            nowDisplay = -1;
        }

        private void removeTableBt_Click(object sender, EventArgs e)
        {
            openconn();
            if (comboBox1.SelectedItem != null)
            {
                string sql = "DROP TABLE " + comboBox1.SelectedItem.ToString() + ";";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine("删除成功！");
                    nowDisplay = -1;
                    refreshTable();

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("删除失败！");
                }
            }
            closeconn();
        }

        private void addTableBt_Click(object sender, EventArgs e)
        {
            createTableForm ctForm = new createTableForm(connstr);
            ctForm.ShowDialog();

        }

        private void output_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请保存文件的路径";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                else
                {
                    // 创建文件夹
                    string tmp_path = "./tmp";  // last_modified
                    string path_db = tmp_path + "\\db"; // 1.mysql
                    string path_op_query = tmp_path + "\\std"; // op.mysql query.mysql

                    Directory.CreateDirectory(tmp_path);
                    Directory.CreateDirectory(path_db);
                    Directory.CreateDirectory(path_op_query);

                    // 写query答案
                    using (StreamWriter sw = new StreamWriter(path_op_query + "\\query.mysql"))
                    {
                        sw.WriteLine(richTextBox1.Text);
                    }

                    File.GetAttributes("test.ps1");
                    string strCmdText = Path.Combine(Directory.GetCurrentDirectory(), "test.bat");
                    var process = new Process();
                    process.StartInfo.FileName = strCmdText;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // 不显示
                    process.Start();
                    process.WaitForExit();

                    string path = @"test.zip";
                    string path2 = dialog.SelectedPath + "\\" + pid.Text + ".zip";
                    try
                    {
                        if (File.Exists(path2))
                            File.Delete(path2);

                        File.Move(path, path2);
                    }
                    catch (Exception ee)
                    {
                        Console.WriteLine(ee.Message);
                        Console.WriteLine("移动失败！");
                    }
                }
            }

            MessageBox.Show("生成成功！","生成结果",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void genRandata_Click(object sender, EventArgs e)
        {
            ht = new Hashtable();
            int count = insertNum;
            while (count != 0)
            {
                int value = rm.Next(10000, 1000000);
                if (!ht.ContainsKey(value))
                {
                    ht.Add(value.ToString(), value.ToString());
                    //Console.Write(value + "\n");
                    count--;
                }
            }
            openconn();
            ICollection key = ht.Keys;
            MySqlCommand cmd;

            // 待修改——只能插student
            string constStr = @"INSERT INTO "+"student"+" VALUES ";
            foreach (string k in key)
            {
                string tmp = "(2012" + k + "," + getNameSex() + "," + rm.Next(18, 25).ToString() + "," + getDept() + ");";
                try
                {
                    cmd = new MySqlCommand(constStr + tmp, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            closeconn();
            nowDisplay = -1;
            refreshTable();
        }
        private string getNameSex()
        {
            string result = "'";
            result += firstName[rm.Next(0, firstName.Length)];
            int sex = rm.Next(1, 3);
            int num = rm.Next(1, 3);
            while (num != 0)
            {
                if (sex == 1)
                    result += boy[rm.Next(0, boy.Length)];
                else
                    result += girl[rm.Next(0, girl.Length)];
                num--;
            }
            result += "','";
            if (sex == 1)
                result += "男'";
            else
                result += "女'";
            Console.WriteLine(result);
            return result;
        }
        private string getDept()
        {
            return "'" + depts[rm.Next(0, depts.Length)] + "'";
        }

    }
}
