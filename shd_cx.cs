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
    public partial class shd_cx : DevExpress.XtraEditors.XtraForm
    {
        public shd_cx()
        {
            InitializeComponent();
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            string where = "and a.shd_bh=b.shd_bh ";
            if (txt_key.Text != "")
            {
                where += "and (a.shd_bh like '%" + txt_key.Text.Trim() + "%' or b.shd_pf_bh like '%" + txt_key.Text.Trim() + "%' or b.shd_pf_jz like '%" + txt_key.Text.Trim() + "%' or b.shd_pf_ys like '%" + txt_key.Text.Trim() + "%') ";
            }
            if (cb_kh.Text != "")
            {
                where += "and a.shd_kh ='" + cb_kh.Text + "' ";
            }
            if (txt_timest.Text != "")
            {
                where += " and a.shd_rq >= '" + txt_timest.Text + "'";
            }
            if (txt_timeed.Text != "")
            {
                where += " and a.shd_rq <='" + txt_timeed.Text + "'";
            }
            string psql = "SELECT a.* from gl_shd a,gl_shd_detail b " + where + " GROUP BY shd_bh";
            psql = mysql.getSqlPager1("a.*", "gl_shd a,gl_shd_detail b",where,"a.id","a.shd_bh",pagerControl1.PageIndex,pagerControl1.PageSize,"id");
            string ssql = "select * from gl_shd_detail";
            databind(gridControl1, psql, ssql);
        }

        private void shd_cx_Load(object sender, EventArgs e)
        {
            string psql = "select * from gl_shd";
            psql = mysql.getSqlPager("*", "gl_shd", "", "id", "asc", pagerControl1.PageIndex, pagerControl1.PageSize);
            string ssql = "select * from gl_shd_detail";
            pagerControl1.OnPageChanged += new EventHandler(pagerControl1_OnPageChanged);
            databind(gridControl1, psql, ssql);
            bindcmb();
        }
        void pagerControl1_OnPageChanged(object sender, EventArgs e)
        {
            btn_search_Click(sender,e);
        }
        private void databind(DevExpress.XtraGrid.GridControl control, string psql, string ssql)
        {
            DataSet ds_shd = new DataSet();
            DataTable dt_shd_detail = new DataTable();
            try
            {
                ds_shd = mysql.ds(confighelper.connStr, psql);
                ds_shd.Tables[0].TableName = "ds_shd";
                dt_shd_detail = mysql.dt(confighelper.connStr, ssql);
                dt_shd_detail.TableName = "dt_shd_detail";
                ds_shd.Tables.Add(dt_shd_detail);

                DataRelation dr = new DataRelation("送货单明细", ds_shd.Tables["ds_shd"].Columns["shd_bh"], ds_shd.Tables["dt_shd_detail"].Columns["shd_bh"], false);
                ds_shd.Relations.Add(dr);
                string where = "where a.shd_bh=b.shd_bh ";
                if (txt_key.Text != "")
                {
                    where += "and (a.shd_bh like '%" + txt_key.Text.Trim() + "%' or b.shd_pf_bh like '%" + txt_key.Text.Trim() + "%' or b.shd_pf_jz like '%" + txt_key.Text.Trim() + "%' or b.shd_pf_ys like '%" + txt_key.Text.Trim() + "%') ";
                }
                if (cb_kh.Text != "")
                {
                    where += "and a.shd_kh ='" + cb_kh.Text + "' ";
                }
                if (txt_timest.Text != "")
                {
                    where += " and a.shd_rq >= '" + txt_timest.Text + "'";
                }
                if (txt_timeed.Text != "")
                {
                    where += " and a.shd_rq <='" + txt_timeed.Text + "'";
                }
                string sql1 = "SELECT a.* from gl_shd a,gl_shd_detail b " + where + " GROUP BY shd_bh";
                DataTable dy_total = mysql.dt(confighelper.connStr, sql1);
                pagerControl1.DrawControl(dy_total.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            control.DataSource = ds_shd.Tables["ds_shd"];
            status.Text = "记录数:" + ds_shd.Tables["ds_shd"].Rows.Count;
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

        private void gridView1_MasterRowExpanded(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView aView = gridView1.GetDetailView(e.RowHandle, e.RelationIndex) as DevExpress.XtraGrid.Views.Grid.GridView;
            if (aView != null)
            {
                aView.Columns["id"].Visible = false;　　　　//aView就是子View，设置VID 列为隐藏
                aView.Columns["shd_bh"].Visible = false;
                aView.Columns["shd_pf_bh"].Caption = "配方编号";
                aView.Columns["shd_pf_sl"].Caption = "配方数量";
                aView.Columns["shd_pf_jg"].Caption = "配方价格";
                aView.Columns["shd_pf_ys"].Caption = "配方颜色";
                aView.Columns["shd_pf_jz"].Caption = "配方胶质";
                aView.Columns["shd_pf_dw"].Caption = "配方单位";
                aView.Columns["shd_pf_bh"].OptionsColumn.AllowEdit = false;
                aView.Columns["shd_pf_sl"].OptionsColumn.AllowEdit = false;
                aView.Columns["shd_pf_jg"].OptionsColumn.AllowEdit = false;
                aView.Columns["shd_pf_ys"].OptionsColumn.AllowEdit = false;
                aView.Columns["shd_pf_jz"].OptionsColumn.AllowEdit = false;
                aView.Columns["shd_pf_dw"].OptionsColumn.AllowEdit = false;
                aView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
                //aView.OptionsView.ShowFooter = true ;
                //aView.Columns["shd_pf_jg"].Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                //new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "shd_pf_jg", "总计：{0:0.##}")});
                aView.BestFitColumns();
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            string sql = "select *,shd_pf_jg*shd_pf_sl shd_pf_je from gl_shd_detail where shd_bh='" + this.gridView1.GetFocusedDataRow()["shd_bh"].ToString() + "'";
            DataTable table = mysql.dt(confighelper.connStr, sql);
            table.TableName = "shd_detail";
            sql = "select  * , DATE_FORMAT(shd_rq,'%Y-%m-%d') shd_sj from gl_shd where shd_bh='" + this.gridView1.GetFocusedDataRow()["shd_bh"].ToString() + "'";
            DataTable table2 = mysql.dt(confighelper.connStr, sql);
            table2.TableName = "shd";
            DataSet data = new DataSet();
            DataRow row = null;
            int count = table.Rows.Count;
            int num2 = 6 - (count % 6);
            for (int i = 0; i < num2; i++)
            {
                row = table.NewRow();
                table.Rows.Add(row);
            }
            data.Tables.Add(table);
            data.Tables.Add(table2);
            Report report = new Report();
            report.Load("shd.frx");
            report.RegisterData(data);
            report.Show();
            report.Dispose();
        }
    }
}