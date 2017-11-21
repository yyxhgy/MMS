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
    public partial class pfgl : DevExpress.XtraEditors.XtraForm
    {
        public pfgl()
        {
            InitializeComponent();
        }

        private void pfgl_Load(object sender, EventArgs e)
        {
            string psql = "select * from gl_pf";
            psql = mysql.getSqlPager("*", "gl_pf", "", "id", "asc", pagerControl1.PageIndex, pagerControl1.PageSize);
            string ssql = "select * from gl_pf_detail";
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
            DataSet ds_pf = new DataSet();
            DataTable dt_pf_detail = new DataTable();
            try
            {
                ds_pf = mysql.ds(confighelper.connStr, psql);
                ds_pf.Tables[0].TableName = "ds_pf";
                dt_pf_detail = mysql.dt(confighelper.connStr, ssql);
                dt_pf_detail.TableName = "dt_pf_detail";
                ds_pf.Tables.Add(dt_pf_detail);

                DataRelation dr = new DataRelation("配方明细", ds_pf.Tables["ds_pf"].Columns["id"], ds_pf.Tables["dt_pf_detail"].Columns["pid"], false);
                ds_pf.Relations.Add(dr);
                string key = txt_key.Text.Trim();
                string kh = cb_kh.Text.Trim();
                string where = "where 1=1 ";
                if (key != "")
                {
                    where += "and (pf_bh like '%" + key + "%' or pf_ys like '%" + key + "%' or pf_jz like '%" + key + "%' ) ";
                }
                else if (kh != "")
                {
                    where += "and pf_kh ='" + kh + "'";
                }
                string sql1 = "select * from gl_pf " + where + " ";
                DataTable dy_total = mysql.dt(confighelper.connStr, sql1);
                pagerControl1.DrawControl(dy_total.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            control.DataSource = ds_pf.Tables["ds_pf"];
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
                aView.Columns["pid"].Visible = false;
                aView.Columns["pf_yf_bh"].Caption = "原粉编号";
                aView.Columns["pf_yf_sl"].Caption = "原粉数量(g)";
                aView.Columns["pf_yf_bh"].OptionsColumn.AllowEdit = false;
                aView.Columns["pf_yf_sl"].OptionsColumn.AllowEdit = false;
                aView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
                aView.BestFitColumns();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string key = txt_key.Text.Trim();
            string kh = cb_kh.Text.Trim();
            string where = "and 1=1 ";
            if (key != "")
            {
                where += "and (pf_bh like '%" + key + "%' or pf_ys like '%" + key + "%' or pf_jz like '%" + key + "%' ) ";
            }
            else if (kh != "")
            {
                where += "and pf_kh ='" + kh + "'";
            }
            string psql = "select * from gl_pf " + where + " ";
            psql = mysql.getSqlPager("*", "gl_pf ", where, "id", "asc", pagerControl1.PageIndex, pagerControl1.PageSize);
            string ssql = "select * from gl_pf_detail";
            databind(gridControl1, psql, ssql);
        }
        /*新增配方*/
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            pf_add a = new pf_add("add", "");
            a.btn_search_Click += new delegate_pf_add(btn_search_Click);
            a.ShowDialog();
        }
        /*修改配方*/
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                pf_add a = new pf_add("edit", gridView1.GetFocusedDataRow()["pf_bh"].ToString());
                a.btn_search_Click += new delegate_pf_add(btn_search_Click);
                a.ShowDialog();
            }
            catch (Exception ex)
            {
                status.Text = "请选择一行数据！";
            }
        }
        /*删除配方*/
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                status.Text = "";
                string id = gridView1.GetFocusedDataRow()["id"].ToString();
                string sql = "delete from gl_pf where id=" + id + "";
                mysql.ExecuteNonQuery(confighelper.connStr, sql);
                btn_search_Click(sender, e);

            }
            catch (Exception ex)
            {
                status.Text = "请选择一行数据！";
            }
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
    }
}