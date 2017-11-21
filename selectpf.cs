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
    public delegate void delegatepfbhins(string pfbh);
    public partial class selectpf : DevExpress.XtraEditors.XtraForm
    {
        private string kh = "";
        public event delegatepfbhins pfbhins;
        public selectpf(string khname)
        {
            InitializeComponent();
            kh = khname;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string key = txt_key.Text.Trim();
            string where = " ";
            if (key != "")
            {
                where += "and pf_bh like '%" + key + "%' or pf_ys like '%" + key + "%' or pf_jz like '%" + key + "%' or pf_sbbh like '%" + key + "%'";
            }
            string sql = "select * from gl_pf where pf_kh='" + kh + "' "+where+"";
            DataTable dt = mysql.dt(confighelper.connStr, sql);
            gridControl1.DataSource = dt;
            status.Text = "记录数：" + dt.Rows.Count + "";
        }

        private void selectpf_Load(object sender, EventArgs e)
        {
            lab_kh.Text = kh;
            string sql = "select * from gl_pf where pf_kh='" + kh + "'";
            DataTable dt = mysql.dt(confighelper.connStr, sql);
            gridControl1.DataSource = dt;
            status.Text = "记录数：" + dt.Rows.Count + "";
            this.Text = "选择配方";
        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hInfo = gridView1.CalcHitInfo(new Point(e.X, e.Y));
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                //判断光标是否在行范围内 
                if (hInfo.InRow)
                {
                    pfbhins(gridView1.GetFocusedDataRow()["pf_bh"].ToString());
                    this.Close();
                }
            }
        }
    }
}