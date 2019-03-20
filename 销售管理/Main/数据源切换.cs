using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
namespace 销售管理.Main
{
    public partial class 数据源切换 : Form
    {
        public 数据源切换()
        {
            InitializeComponent();
        }

        private void 数据源切换_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            String strConn = "";
            String keyValue = "";
            if (comboBox1.SelectedIndex == 0)
            {
                keyValue = "1";
                strConn = "Data Source=192.168.10.126,1488;Initial Catalog=MYDB;Persist Security Info=True;User ID=sa;Password=sasa";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                keyValue = "2";
                strConn = "Data Source=192.168.10.126,1488;Initial Catalog=MYDB_RT_MAT;Persist Security Info=True;User ID=sa;Password=sasa";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                keyValue = "3";
                strConn = "Data Source=1111.198.24.26,1488;Initial Catalog=MYDB;Persist Security Info=True;User ID=sa;Password=sasa";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                keyValue = "4";
                strConn = "Data Source=111.198.24.26,1488;Initial Catalog=MYDB_RT_MAT;Persist Security Info=True;User ID=sa;Password=sasa";
            }
            UpdateConnectionStringsConfig("销售管理.Properties.Settings.mydbConnectionString", strConn, "System.Data.SqlClient");
            ConfigurationManager.AppSettings.Set("key1", keyValue);
            MessageBox.Show("数据源切换成功！请重新登陆系统。");
                Close();
        }
        public void UpdateConnectionStringsConfig(string newName, string newConString, string newProviderName)
        {
            bool isModified = false;    //记录该连接串是否已经存在 
            if (ConfigurationManager.ConnectionStrings[newName] != null)
            {
                isModified = true;
            }
            //新建一个连接字符串实例 
            ConnectionStringSettings mySettings = new ConnectionStringSettings(newName, newConString, newProviderName);

            // 打开可执行的配置文件*.exe.config 
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // 如果连接串已存在，首先删除它 
            if (isModified)
            {
                config.ConnectionStrings.ConnectionStrings.Remove(newName);
                // 将新的连接串添加到配置文件中. 
                config.ConnectionStrings.ConnectionStrings.Add(mySettings);
                // 保存对配置文件所作的更改 
                config.Save(ConfigurationSaveMode.Modified);
                // 强制重新载入配置文件的ConnectionStrings配置节  
                ConfigurationManager.RefreshSection("ConnectionStrings");
            }
        }
    }
}
