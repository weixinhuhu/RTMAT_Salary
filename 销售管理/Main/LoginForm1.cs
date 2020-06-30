using Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using 销售管理.DAL;
using 销售管理.DAL.DataSetLoginLogTableAdapters;
using 销售管理.Main;
namespace 销售管理
{
    public partial class LoginForm1 : Form
    {
        public LoginForm1()
        {
            InitializeComponent();
        }
        public bool isLogined = false;

        private void OK_Click(object sender, EventArgs e)
        {
            //获取连接字符串
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            String xmlPath = "DBInfo.xml";
            if (xmlPath == null) {
                MessageBox.Show("请先选择数据源！");
            }
            Common.SqlConnectionSet.SetConnStr(xmlPath.Trim());

            try
            {
                MYDBEntities2 myEntity = new MYDBEntities2();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                string LoginName, Password;

                LoginName = txtLoginName.Text.Trim();
                Password = txtPassword.Text.Trim();
                List<T_Users> Users = myEntity.T_Users.Where(d => d.LoginName == LoginName).ToList();

                if (Users.Count < 1)
                {
                    MessageBox.Show("登录名输入错误");
                    return;
                }
                else
                {
                    var User = Users.FirstOrDefault();
                    Password = Classes.MD5.Md5Encrypt(Password);
                    if (string.Compare(Password, User.PassWord) != 0)
                    {
                        MessageBox.Show("密码输入错误");
                        txtPassword.Text = "";
                        return;
                    }
                    if (User.UserStatus != "正常")
                    {
                        MessageBox.Show("该账户已停用");
                        return;
                    }
                    if (LoginName.ToLower() == "admin")
                    {
                        CommonClass.SttUser.blSuperUser = true;
                    }
                    else
                    {
                        CommonClass.SttUser.blSuperUser = false;
                    }
                    Classes.PubClass.LoginName = LoginName;
                    Classes.PubClass.UserId = User.id;
                    Classes.PubClass.UserName = User.UserName;
                    Classes.PubClass.UserRight = User.OperRight;
                    Classes.PubClass.UserStatus = User.UserStatus;
                    Classes.PubClass.UserRoleId = User.IntRoleID ?? -1;
                    //添加权限
                    CommonClass.UserRightList.Clear();
                    销售管理.BLL.Da.GetUserRight(Classes.PubClass.UserRoleId);
                    CommonClass.SttDb.iDBType = 1;
                    isLogined = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            System.Net.IPAddress[] IPs = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName());
            for (int c = 0; c < IPs.Length; c++)
            {
                if (IPs[c].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    new T_LoginLogTableAdapter().Insert(Classes.PubClass.UserId, IPs[c].ToString());
                }
            }

            MainForm mForm = new MainForm(this);
            //mForm.tssb用户名.Text = "登录用户名:"+  Classes.PubClass.UserName +"  | 权限:" + Classes.PubClass.UserRight;
            mForm.LoadModuleListFromDb(Classes.PubClass.UserRoleId);
            mForm.Show();
            //this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void LoginForm1_Load(object sender, EventArgs e)
        {
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            String StrDB = ConfigurationManager.AppSettings["key1"];
            
            isLogined = false;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm1_Activated(object sender, EventArgs e)
        {
            txtLoginName.Focus();
            txtLoginName.SelectionStart = 0;
            txtLoginName.SelectionLength = txtLoginName.Text.Length;
        }
        public static void SaveXML(String ip, string port,string database)
        {
            string DbStr = "";
            string SqlStr = "";
            string EfStr = "";
            DbStr = string.Format("Provider=SQLOLEDB.1;Password={4};Persist Security Info=True;User ID={3};Initial Catalog={2};Data Source={0},{1}", ip, port, database, "sa", "sasa");
            SqlStr = string.Format("Data Source={0},{1};Initial Catalog={2};User ID={3};Password={4}", ip, port, database, "sa", "sasa");
            EfStr = string.Format("metadata=res://*/DAL.ModelDa.csdl|res://*/DAL.ModelDa.ssdl|res://*/DAL.ModelDa.msl;provider=System.Data.SqlClient;provider connection string=\"data source={0},{1};initial catalog={2};user id={3};password={4};MultipleActiveResultSets=True;App=EntityFramework\"", ip, port, database, "sa", "sasa");
            DbStr = Soft.Common.Utils.EncryptRc2(DbStr);
            SqlStr = Soft.Common.Utils.EncryptRc2(SqlStr);
            EfStr = Soft.Common.Utils.EncryptRc2(EfStr);
            try
            {
                string xmlPath = Application.StartupPath + "\\DBInfo.xml";
                XmlDocument xmlDoc = new XmlDocument();
                if (File.Exists(xmlPath) == false)
                {
                    //文件不存在则新建文件
                    xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", null, null));
                    //根节点
                    xmlDoc.AppendChild(xmlDoc.CreateElement("DBInfo"));
                    xmlDoc.Save(xmlPath);
                    //应用程序所在目录下级目录用“/”，上级目录用“../”
                    Common.XmlHelper.Insert(xmlPath, "/DBInfo", "DBType", "", "0");
                    Common.XmlHelper.Insert(xmlPath, "/DBInfo", "DBConnStr", "", DbStr);
                    Common.XmlHelper.Insert(xmlPath, "/DBInfo", "EFConnStr", "", EfStr);
                    Common.XmlHelper.Insert(xmlPath, "/DBInfo", "SqlConnStr", "", SqlStr);
                }
                else
                {
                    Common.XmlHelper.Delete(xmlPath, "/DBInfo/DBConnStr", "");
                    Common.XmlHelper.Delete(xmlPath, "/DBInfo/EFConnStr", "");
                    Common.XmlHelper.Delete(xmlPath, "/DBInfo/SqlConnStr", "");
                    Common.XmlHelper.Insert(xmlPath, "/DBInfo", "DBConnStr", "", DbStr);
                    Common.XmlHelper.Insert(xmlPath, "/DBInfo", "EFConnStr", "", EfStr);
                    Common.XmlHelper.Insert(xmlPath, "/DBInfo", "SqlConnStr", "", SqlStr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("异常：\n{0}", ex.Message));
                Application.Exit();
            }

        }
        public static void UpdateAppConfig(string newKey, string newValue)
        {
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            bool exist = false;
            foreach (string key in config.AppSettings.Settings.AllKeys)
            {
                if (key == newKey)
                {
                    exist = true;
                }
            }
            if (exist)
            {
                config.AppSettings.Settings.Remove(newKey);
            }
            config.AppSettings.Settings.Add(newKey, newValue);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public void UpdateConnectionStringsConfig(string newName, string newConString, string newProviderName, string fileName)
        {
            // 打开可执行的配置文件*.exe.config 
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.StartupPath + "\\" + fileName);
            // 删除原有字符串实例
            config.ConnectionStrings.ConnectionStrings.Remove(newName);
            // 新建一个连接字符串实例 
            ConnectionStringSettings mySettings = new ConnectionStringSettings(newName, newConString, newProviderName);
            // 将新的连接串添加到配置文件中. 
            config.ConnectionStrings.ConnectionStrings.Add(mySettings);
            // 保存对配置文件所作的更改 
            config.Save(ConfigurationSaveMode.Modified);
            //强制重新载入配置文件的ConnectionStrings配置节
            ConfigurationManager.RefreshSection("ConnectionStrings");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            数据源切换 mForm = new 数据源切换();
            mForm.ShowDialog();
        }
    }
}
