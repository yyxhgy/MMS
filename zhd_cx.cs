using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FastReport;

namespace DXApplication4
{
    public partial class zhd_cx : DevExpress.XtraEditors.XtraForm
    {
        public zhd_cx()
        {
            InitializeComponent();
        }

        private void zhd_cx_Load(object sender, EventArgs e)
        {
            string psql = "select * from gl_zhd";
            psql = mysql.getSqlPager("*", "gl_zhd", "", "id", "asc", pagerControl1.PageIndex, pagerControl1.PageSize);
            string ssql = "select * from gl_zhd_detail";
            pagerControl1.OnPageChanged += new EventHandler(pagerControl1_OnPageChanged);
            databind(gridControl1, psql, ssql);
            bindcmb();
        }
        void pagerControl1_OnPageChanged(object sender, EventArgs e)
        {
            btn_search_Click(sender, e);
        }
        private void databind(DevExpress.XtraGrid.GridControl control, string psql, string ssql)
        {
            DataSet ds_zhd = new DataSet();
            DataTable dt_zhd_detail = new DataTable();
            try
            {
                ds_zhd = mysql.ds(confighelper.connStr, psql);
                ds_zhd.Tables[0].TableName = "ds_zhd";
                dt_zhd_detail = mysql.dt(confighelper.connStr, ssql);
                dt_zhd_detail.TableName = "dt_zhd_detail";
                ds_zhd.Tables.Add(dt_zhd_detail);
                string where = "where 1=1 ";
                if (txt_key.Text != "")
                {
                    where += "and (zhd_bh like '%" + txt_key.Text.Trim() + "%' or zhd_pf_bh like '%" + txt_key.Text.Trim() + "%' or zhd_pf_jz like '%" + txt_key.Text.Trim() + "%' or zhd_pf_ys like '%" + txt_key.Text.Trim() + "%') ";
                }
                if (cb_kh.Text != "")
                {
                    where += "and zhd_kh ='" + cb_kh.Text + "' ";
                }
                if (txt_timest.Text != "")
                {
                    where += " and zhd_rq >= '" + txt_timest.Text + "'";
                }
                if (txt_timeed.Text != "")
                {
                    where += " and zhd_rq <='" + txt_timeed.Text + "'";
                }
                string sql1 = "select * from gl_zhd " + where + "";
                DataTable dy_total = mysql.dt(confighelper.connStr, sql1);
                pagerControl1.DrawControl(dy_total.Rows.Count);
                DataRelation dr = new DataRelation("做货单明细", ds_zhd.Tables["ds_zhd"].Columns["zhd_bh"], ds_zhd.Tables["dt_zhd_detail"].Columns["zhd_bh"], false);
                ds_zhd.Relations.Add(dr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            control.DataSource = ds_zhd.Tables["ds_zhd"];
            status.Text = "记录数:" + ds_zhd.Tables["ds_zhd"].Rows.Count;
        }

        private void gridView1_MasterRowExpanded(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView aView = gridView1.GetDetailView(e.RowHandle, e.RelationIndex) as DevExpress.XtraGrid.Views.Grid.GridView;
            if (aView != null)
            {
                aView.Columns["id"].Visible = false;　　　　//aView就是子View，设置VID 列为隐藏
                aView.Columns["zhd_bh"].Visible = false;
                aView.Columns["zhd_yf_bh"].Caption = "原粉编号";
                aView.Columns["zhd_yf_sl"].Caption = "原粉数量(g)";
                aView.Columns["zhd_yf_bh"].OptionsColumn.AllowEdit = false;
                aView.Columns["zhd_yf_sl"].OptionsColumn.AllowEdit = false;
                aView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
                aView.OptionsView.ShowFooter = false;
                aView.BestFitColumns();
            }
        }
        //初始化绑定默认关键词（此数据源可以从数据库取）
        List<string> listOnit = new List<string>();
        //输入key之后，返回的关键词
        List<string> listNew = new List<string>();

        private void bindcmb()
        {
            string sql = "select '' kh_name union select kh_name from gl_kh";
            DataTable dt = mysql.dt(confighelper.connStr, sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listOnit.Add(dt.Rows[i]["kh_name"].ToString());
            }
            cb_kh.Items.AddRange(listOnit.ToArray());
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            string where = "and 1=1 ";
            if (txt_key.Text != "")
            {
                where += "and (zhd_bh like '%" + txt_key.Text.Trim() + "%' or zhd_pf_bh like '%" + txt_key.Text.Trim() + "%' or zhd_pf_jz like '%" + txt_key.Text.Trim() + "%' or zhd_pf_ys like '%" + txt_key.Text.Trim() + "%') ";
            }
            if (cb_kh.Text != "")
            {
                where += "and zhd_kh ='" + cb_kh.Text + "' ";
            }
            if (txt_timest.Text != "")
            {
                where += " and zhd_rq >= '" + txt_timest.Text + "'";
            }
            if (txt_timeed.Text != "")
            {
                where += " and zhd_rq <='" + txt_timeed.Text + "'";
            }
            string psql = "select * from gl_zhd " + where + "";
            psql = mysql.getSqlPager("*", "gl_zhd ", where, "id", "asc", pagerControl1.PageIndex, pagerControl1.PageSize);
            string ssql = "select * from gl_zhd_detail";
            databind(gridControl1, psql, ssql);
        }

        private void cb_kh_TextUpdate(object sender, EventArgs e)
        {
            cb_kh.Items.Clear();
            listNew.Clear();
            foreach (var item in listOnit)
            {
                if (item.Contains(this.cb_kh.Text))
                {
                    //符合，插入ListNew
                    listNew.Add(item);
                }
            }
            //combobox添加已经查到的关键词
            this.cb_kh.Items.AddRange(listNew.ToArray());
            //设置光标位置，否则光标位置始终保持在第一列，造成输入关键词的倒序排列
            this.cb_kh.SelectionStart = this.cb_kh.Text.Length;
            //保持鼠标指针原来状态，有时候鼠标指针会被下拉框覆盖，所以要进行一次设置。
            Cursor = Cursors.Default;
            //自动弹出下拉框
            this.cb_kh.DroppedDown = true;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            string sql = "select * from gl_zhd_detail where zhd_bh='" + this.gridView1.GetFocusedDataRow()["zhd_bh"].ToString() + "'";
            DataTable table = mysql.dt(confighelper.connStr, sql);
            table.TableName = "zhd";
            sql = "select  * , DATE_FORMAT(zhd_rq,'%Y-%m-%d') zhd_sj from gl_zhd where zhd_bh='" + this.gridView1.GetFocusedDataRow()["zhd_bh"].ToString() + "'";
            DataTable table2 = mysql.dt(confighelper.connStr, sql);
            table2.TableName = "zhd_main";
            DataSet data = new DataSet();
            DataRow row = null;
            int count = table.Rows.Count;
            int num2 = 9 - (count % 9);
            for (int i = 0; i < num2; i++)
            {
                row = table.NewRow();
                table.Rows.Add(row);
            }
            data.Tables.Add(table);
            data.Tables.Add(table2);
            Report report = new Report();
            report.Load("zhd.frx");
            report.RegisterData(data);
            try
            {
                report.Show();
            }
            catch
            {
                MessageBox.Show("无法打印！请与开发人员联系！");
            }
            report.Dispose();
        }
    }
}