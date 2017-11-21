using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXApplication4
{
    public delegate void DelegateReflash(object sender, EventArgs e);
    public partial class kh_detail : DevExpress.XtraEditors.XtraForm
    {
        public event DelegateReflash btn_search_Click;
        string Action = "";
        string Kh_id = "";
        public kh_detail(string action, string kh_id)
        {
            InitializeComponent();
            Action = action;
            Kh_id = kh_id;
        }

        private void kh_detail_Load(object sender, EventArgs e)
        {
            if (Action == "add")
            {
                this.Text = "客户新增";

            }
            else
            {
                this.Text = "客户修改";
                txt_khname.Enabled = false;
                string sql = "select * from gl_kh where id=" + Kh_id + "";
                DataTable dt = mysql.dt(confighelper.connStr, sql);
                txt_khname.Text = dt.Rows[0]["kh_name"].ToString();
                txt_khlxr.Text = dt.Rows[0]["kh_lxr"].ToString();
                txt_khlxrsj.Text = dt.Rows[0]["kh_lxr_sj"].ToString();
                txt_khlxrmail.Text = dt.Rows[0]["kh_lxr_mail"].ToString();
                txt_address.Text = dt.Rows[0]["kh_address"].ToString();
                txt_bz.Text = dt.Rows[0]["kh_bz"].ToString();
            }
        }
        /*修改、新增确认*/
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Action == "add")
            {
                if (txt_khname.Text != "")
                {
                    if (check(txt_khname.Text.Trim()).Rows.Count != 0)
                    {
                        status.Text = "客户单位已存在！";
                        status.ForeColor = Color.Red;
                        return;
                    }
                    string kh_name = txt_khname.Text;
                    string kh_lxr = txt_khlxr.Text;
                    string kh_lxrsj = txt_khlxrsj.Text;
                    string kh_lxrmail = txt_khlxrmail.Text;
                    string kh_address = txt_address.Text;
                    string kh_bz = txt_bz.Text;
                    string sql = "INSERT INTO gl_kh(kh_name,kh_lxr,kh_lxr_sj,kh_lxr_mail,kh_address,kh_bz)VALUES('" + kh_name + "','" + kh_lxr + "','" + kh_lxrsj + "','" + kh_lxrmail + "','" + kh_address + "','" + kh_bz + "')";
                    mysql.ExecuteNonQuery(confighelper.connStr, sql);
                }
                else
                {
                    status.Text = "客户单位不能为空！";
                    status.ForeColor = Color.Red;
                    return;
                }
            }
            else
            {
                string kh_lxr = txt_khlxr.Text;
                string kh_lxrsj = txt_khlxrsj.Text;
                string kh_lxrmail = txt_khlxrmail.Text;
                string kh_address = txt_address.Text;
                string kh_bz = txt_bz.Text;
                string sql = "UPDATE gl_kh set kh_lxr='" + kh_lxr + "',kh_lxr_sj='" + kh_lxrsj + "',kh_lxr_mail='" + kh_lxrmail + "',kh_address='" + kh_address + "',kh_bz='" + kh_bz + "' WHERE id=" + Kh_id + "";
                mysql.ExecuteNonQuery(confighelper.connStr, sql);
            }
            btn_search_Click(sender, e);
            this.Close();
        }
        /*检查客户单位是否存在*/
        private DataTable check(string khname)
        {
            string sql = "select * from gl_kh where kh_name='" + khname + "'";
            DataTable dt = mysql.dt(confighelper.connStr, sql);
            return dt;
        }

    }
}