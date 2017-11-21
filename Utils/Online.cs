using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace DXApplication4.Utils
{
    public class Online
    {
        public static bool check()
        {
            string strip = "www.baidu.com";
            if (cmdIP(strip) == "网络连接成功！")
            {
                return true;
            }
            MessageBox.Show("网络无法连接，请查看网络是否已连接！");
            return false;
        }
        public static string getHtml(string url)
        {
            byte[] bytes = new WebClient().DownloadData(url);
            return Encoding.GetEncoding("utf-8").GetString(bytes);
        }
        public string check_user(string userid, string password)
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(confighelper.connStr))
            {
                connection.Open();
                MySqlCommand selectCommand = new MySqlCommand("SELECT * FROM `GL_member` WHERE username=@userid and password=@password", connection, connection.BeginTransaction());
                MySqlParameter parameter = new MySqlParameter("@userid", userid)
                {
                    DbType = DbType.String
                };
                if (userid == null)
                {
                    parameter.Value = DBNull.Value;
                }
                selectCommand.Parameters.Add(parameter);
                MySqlParameter parameter2 = new MySqlParameter("@password", password)
                {
                    DbType = DbType.String
                };
                if (password == null)
                {
                    parameter2.Value = DBNull.Value;
                }
                selectCommand.Parameters.Add(parameter2);
                new MySqlDataAdapter(selectCommand).Fill(dataTable);
            }
            int count = dataTable.Rows.Count;
            if (count > 0)
            {
                return "1";
            }
            return "0";
        }

        public static string cmdIP(string strip)
        {
            string str;
            Process process = new Process
            {
                StartInfo = { FileName = "cmd.exe", UseShellExecute = false, RedirectStandardInput = true, RedirectStandardOutput = true, RedirectStandardError = true, CreateNoWindow = true }
            };
            process.Start();
            process.StandardInput.WriteLine("ping -n 1 " + strip);
            process.StandardInput.WriteLine("exit");
            string str2 = process.StandardOutput.ReadToEnd();
            if (str2.IndexOf("(0%loss)") != -1)
            {
                str = "连接";
            }
            else if (str2.IndexOf("Destination host unreachable.") != -1)
            {
                str = "无法达到目的的主机";
            }
            else if (str2.IndexOf("Request timed out.") != -1)
            {
                str = "超时";
            }
            else if (str2.IndexOf("Unknown host") != -1)
            {
                str = "无法解析主机";
            }
            else
            {
                str = "网络连接成功！";
            }
            process.Close();
            return str;
        }
    }
}
