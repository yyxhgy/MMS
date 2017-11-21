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
    public delegate void DelegateReload(object sender, EventArgs e);
    public partial class rk_add : DevExpress.XtraEditors.XtraForm
    {
        public event DelegateReload btn_search_Click;
        public DateTime rkrq = System.DateTime.Now;
        public rk_add()
        {
            InitializeComponent();
        }
        /*页面载入*/
        private void rk_add_Load(object sender, EventArgs e)
        {
            txt_rkbh.Text = "RK" + rkrq.ToString("yyyyMMddHHmmss") + "";
            this.Text = "原粉入库";
        }
        /*保存*/
        private void btn_save_Click(object sender, EventArgs e)
        {
            this.status.Text = "";
            if (this.txt_yfbh.Text == "")
            {
                this.status.Text = "请输入原粉编号！";
                this.status.ForeColor = Color.Red;
                this.txt_yfbh.Focus();
            }
            else if (this.txt_yfsl.Text == "")
            {
                this.status.Text = "请输入原粉数量！";
                this.status.ForeColor = Color.Red;
                this.txt_yfsl.Focus();
            }
            else if (this.txt_yfjg.Text == "")
            {
                this.status.Text = "请输入原粉价格！";
                this.status.ForeColor = Color.Red;
                this.txt_yfsl.Focus();
            }
            else
            {
                string sql = "INSERT INTO gl_rk(rk_bh,rk_yf_bh,rk_yf_sl,rk_rq,rk_yf_jg)VALUES('" + this.txt_rkbh.Text + "','" + this.txt_yfbh.Text.Trim() + "','" + this.txt_yfsl.Text.Trim() + "','" + this.rkrq.ToString() + "','" + this.txt_yfjg.Text.Trim() + "')";
                mysql.ExecuteNonQuery(confighelper.connStr, sql);
                kczj.kc_add(this.txt_yfbh.Text, (Convert.ToInt32(this.txt_yfsl.Text) * 0x3e8).ToString());
                sql = "update gl_kc set yf_jg='" + this.txt_yfjg.Text.Trim() + "' where kc_yf_bh='" + this.txt_yfbh.Text.Trim() + "'";
                mysql.ExecuteNonQuery(confighelper.connStr, sql);
                sql = "select * from gl_rk where rk_bh ='" + this.txt_rkbh.Text + "'";
                this.databind(this.gridControl1, sql);
            }
        }
        /*添加新项*/
        private void btn_add_Click(object sender, EventArgs e)
        {
            this.txt_yfbh.Text = "";
            this.txt_yfsl.Text = "";
            this.txt_yfjg.Text = "";
            this.txt_yfbh.Focus();
        }
        /*删除*/
        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                status.Text = "";
                string id = gridView1.GetFocusedDataRow()["id"].ToString();
                string sql = "delete from gl_rk where id=" + id + "";
                mysql.ExecuteNonQuery(confighelper.connStr, sql);
                kczj.kc_reduce(txt_yfbh.Text, txt_yfsl.Text);
                sql = "select * from gl_rk where rk_bh ='" + txt_rkbh.Text + "'";
                databind(gridControl1, sql);
            }
            catch (Exception ex)
            {
                status.Text = "请选择一行数据！";
            }
        }
        /*撤销该单*/
        private void btn_rev_Click(object sender, EventArgs e)
        {
            string sql = "select * from gl_rk where rk_bh='" + txt_rkbh.Text + "'";
            DataTable dt = mysql.dt(confighelper.connStr, sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                kczj.kc_reduce(dt.Rows[i]["rk_yf_bh"].ToString(), dt.Rows[i]["rk_yf_sl"].ToString());
            }
            sql = "delete from gl_rk where rk_bh='"+txt_rkbh.Text+"'";
            mysql.ExecuteNonQuery(confighelper.connStr, sql);
            this.Close();
        }
        private void databind(DevExpress.XtraGrid.GridControl control, string sql)
        {
            DataTable dt_rk = mysql.dt(confighelper.connStr, sql);
            control.DataSource = dt_rk;
        }

        private void rk_add_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn_search_Click(sender, e);
        }
    }
}