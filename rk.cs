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
    public partial class rk : DevExpress.XtraEditors.XtraForm
    {
        public rk()
        {
            InitializeComponent();
        }

        private void rk_Load(object sender, EventArgs e)
        {
            string psql = "select * from `gl_rk` order by id desc";
            //string ssql = "select * from `gl_rk_detail`";
            databind(gridControl1, psql);
        }
        /*数据绑定*/
        private void databind(DevExpress.XtraGrid.GridControl control, string psql)
        {
            DataTable dt_rk = mysql.dt(confighelper.connStr, psql);
            //DataTable dt_rk_detail = mysql.dt(confighelper.connStr, ssql);
            //DataRelation dr = new DataRelation("明细", new DataColumn[] { dt_rk.Columns["id"] }, new DataColumn[] { dt_rk_detail.Columns["pid"] });
            control.DataSource = dt_rk;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string where = "where 1=1 ";
            if (txt_timeST.Text != "")
            {
                where += "and rk_rq>='" + txt_timeST.Text + "'";
            }
            if (txt_timeED.Text != "")
            {
                where += "and rk_rq<='" + txt_timeED.Text + "'";
            }
            if (txt_rkbh.Text != "")
            {
                where += "and rk_bh like '%" + txt_rkbh.Text + "%'";
            }
            string psql = "select * from `gl_rk` " + where + " order by id desc";
            databind(gridControl1, psql);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            rk_add a = new rk_add();
            a.btn_search_Click += new DelegateReload(btn_search_Click);
            a.ShowDialog();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                status.Text = "";
                string id = gridView1.GetFocusedDataRow()["id"].ToString();
                string sql = "delete from gl_rk where id=" + id + "";
                mysql.ExecuteNonQuery(confighelper.connStr, sql);
                btn_search_Click(sender, e);

            }
            catch (Exception ex)
            {
                status.Text = "请选择一行数据！";
            }
        }
    }
}