using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DXApplication4
{
    public partial class kc : DevExpress.XtraEditors.XtraForm
    {
        private int isedit = 0;
        public kc()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string sql = "select kc_yf_bh,kc_yf_sl/1000 kc_yf_sl from gl_kc where kc_yf_bh like '%" + txt_yfbh.Text.Trim() + "%'";
            DataTable dt_kc = mysql.dt(confighelper.connStr, sql);
            gridControl1.DataSource = dt_kc;
        }

        private void kc_Load(object sender, EventArgs e)
        {
            string sql = "select id, kc_yf_bh,kc_yf_sl/1000 kc_yf_sl,yf_jg from gl_kc ";
            DataTable table = mysql.dt(confighelper.connStr, sql);
            this.gridControl1.DataSource = table;
            this.textEdit1.Enabled = false;
        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = this.gridView1.CalcHitInfo(new Point(e.X, e.Y));
            if (((e.Button == MouseButtons.Left) && (e.Clicks == 2)) && info.InRow)
            {
                this.textEdit1.Text = this.gridView1.GetFocusedDataRow()["yf_jg"].ToString();
                this.txt_yfbh.Text = this.gridView1.GetFocusedDataRow()["kc_yf_bh"].ToString();
                this.textEdit1.Enabled = true;
                this.isedit = 1;
            }
        }

        private void btn_editjg_Click(object sender, EventArgs e)
        {
            if (this.isedit == 1)
            {
                string str = this.textEdit1.Text.Trim();
                string sql = "update gl_kc set yf_jg='" + str + "' where id=" + this.gridView1.GetFocusedDataRow()["id"].ToString();
                mysql.ExecuteNonQuery(confighelper.connStr, sql);
                this.kc_Load(sender, e);
            }
            this.isedit = 0;
        }
    }
}