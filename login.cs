using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System.Threading;
using DXApplication4.Utils;

namespace DXApplication4
{
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        public login()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            #region 联网验证
            if (confighelper.lwyz == "1")
            {
                if (!Online.check())
                {
                    return;
                }
                if (Online.getHtml("http://www.cnblogs.com/yyxhgy/p/5069227.html").Split(new string[] { "ALEX" }, StringSplitOptions.RemoveEmptyEntries)[1] != "开启")
                {
                    MessageBox.Show("服务未开启！请联系开发人员");
                    return;
                }
            }
            #endregion
            tips.Text = "";
            tips.Refresh();
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();
            if (username == "" || password == "")
            {
                tips.Text = "账号/密码为空！";
                tips.Refresh();
                return;
            }
            string a = check_user(username, password);
            txt_username.Enabled = false;
            txt_password.Enabled = false;
            simpleButton1.Enabled = false;
            simpleButton1.Text = "登录中";
            this.simpleButton1.Refresh();
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(500);
                simpleButton1.Text += ".";
                this.simpleButton1.Refresh();
            }
            if (a == "1")
            {
                Main f1 = new Main();
                this.Hide();
                f1.ShowDialog();
                Application.ExitThread();
            }
            else
            {
                tips.Text = "账号/密码错误！";
                tips.Refresh();
                txt_username.Text = "";
                txt_password.Text = "";
                txt_username.Enabled = true;
                txt_password.Enabled = true;
                simpleButton1.Enabled = true;
                simpleButton1.Text = "登录";
                this.simpleButton1.Refresh();
            }
        }
        public string check_user(string userid, string password)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(confighelper.connStr))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `GL_member` WHERE username=@userid and password=@password", conn, conn.BeginTransaction());

                MySqlParameter m_user_id = new MySqlParameter("@userid", userid);
                m_user_id.DbType = DbType.String;
                if (userid == null)
                {
                    m_user_id.Value = DBNull.Value;
                }
                cmd.Parameters.Add(m_user_id);

                MySqlParameter m_password = new MySqlParameter("@password", password);
                m_password.DbType = DbType.String;
                if (password == null)
                {
                    m_password.Value = DBNull.Value;
                }
                cmd.Parameters.Add(m_password);

                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(dt);
            }
            int i = dt.Rows.Count;
            string a = "";
            if (i > 0)
            {
                a = "1";
            }
            else
            {
                a = "0";
            }
            return a;
        }

        private void login_Load(object sender, EventArgs e)
        {
            tips.ForeColor = Color.Red;
            pictureBox1.Image = Image.FromFile("" + Application.StartupPath + "\\images\\6084c7c5f8d0418a77b6beda1bbeaf1a.jpg");

        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.R)
            {
                jm a = new jm();
                a.ShowDialog();
            }
        }
    }
}