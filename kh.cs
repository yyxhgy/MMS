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
    public partial class kh : DevExpress.XtraEditors.XtraForm
    {
        public kh()
        {
            InitializeComponent();
        }
        /*页面载入*/
        private void kh_Load(object sender, EventArgs e)
        {
            string sql = mysql.getSqlPager("*", "gl_kh", "", " id ", "asc", pagerControl1.PageIndex, pagerControl1.PageSize);            
            pagerControl1.OnPageChanged += new EventHandler(pagerControl1_OnPageChanged);
            databind(gridControl1, sql);

        }
        void pagerControl1_OnPageChanged(object sender, EventArgs e)
        {
            btn_search_Click(sender, e);
        }
        /*数据绑定*/
        void databind(DevExpress.XtraGrid.GridControl control, string sql)
        {
            DataTable dt_kh = mysql.dt(confighelper.connStr, sql);
            control.DataSource = dt_kh;
            string field = txt_field.Text;
            string sql1 = "select * from gl_kh where kh_name like '%" + field + "%' or kh_lxr like '%" + field + "%' or kh_lxr_sj like '%" + field + "%' order by id desc";
            DataTable dy_total = mysql.dt(confighelper.connStr, sql1);
            pagerControl1.DrawControl(dy_total.Rows.Count);
        }
        /*搜索功能*/
        private void btn_search_Click(object sender, EventArgs e)
        {
            string field = txt_field.Text;
            string sql = mysql.getSqlPager("*", "gl_kh", " and kh_name like '%" + field + "%' or kh_lxr like '%" + field + "%' or kh_lxr_sj like '%" + field + "%' ", " id ", "asc", pagerControl1.PageIndex, pagerControl1.PageSize);          
            databind(gridControl1, sql);
            
        }
        /*新增功能*/
        private void btn_add_Click(object sender, EventArgs e)
        {
            kh_detail kh_add = new kh_detail("add", "");
            kh_add.btn_search_Click += new DelegateReflash(btn_search_Click);
            kh_add.ShowDialog();
        }
        /*修改功能*/
        private void btn_edt_Click(object sender, EventArgs e)
        {
            try
            {
                kh_detail kh_add = new kh_detail("edit", gridView1.GetFocusedDataRow()["id"].ToString());
                kh_add.btn_search_Click += new DelegateReflash(btn_search_Click);
                kh_add.ShowDialog();
            }
            catch (Exception ex)
            {
                status.Text = "请选择一行数据！";
            }
        }
        /*删除功能*/
        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                status.Text = "";
                string id = gridView1.GetFocusedDataRow()["id"].ToString();
                string sql = "delete from gl_kh where id=" + id + "";
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