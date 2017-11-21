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
    public delegate void delegateSelectyfbh(string yfbh);
    public partial class selectyf : DevExpress.XtraEditors.XtraForm
    {
        public event delegateSelectyfbh selectyfbh;
        public selectyf()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            status.Text = "库存记录：" + bind(txt_key.Text.Trim()) ;            
        }

        private void selectyf_Load(object sender, EventArgs e)
        {
            status.Text = "库存记录：" + bind("").ToString();
            this.Text = "选择原粉";
        }
        private int bind(string key)
        {
            string str = "where 1=1 ";
            if (key != "")
            {
                str = str + "and kc_yf_bh like '%" + key + "%'";
            }
            string sql = "SELECT * from gl_kc " + str;
            DataTable table = mysql.dt(confighelper.connStr, sql);
            this.gridControl1.DataSource = table;
            return table.Rows.Count;
        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = this.gridView1.CalcHitInfo(new Point(e.X, e.Y));
            if (((e.Button == MouseButtons.Left) && (e.Clicks == 2)) && info.InRow)
            {
                this.selectyfbh(this.gridView1.GetFocusedDataRow()["kc_yf_bh"].ToString());
                base.Close();
            }
        }
    }
}