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
    public partial class zhd : DevExpress.XtraEditors.XtraForm
    {
        public bool zhd_sfcz = false;
        public zhd()
        {
            InitializeComponent();
        }

        private void zhd_Load(object sender, EventArgs e)
        {
            gridControl1.Enabled = false;
            txt_bzgs.Enabled = false;
            txt_pfbh.Enabled = false;
            txt_pfjg.Enabled = false;
            txt_pfsl.Enabled = false;
            txt_zdsj.Enabled = false;
            txt_zhdbh.Enabled = false;
            txt_zhds.Enabled = false;
            cb_kh.Enabled = false;
            txt_zj.Enabled = false;
            btn_select.Enabled = false;
            btn_save.Enabled = false;
            btn_rev.Enabled = false;
            btn_print.Enabled = false;
            txt_pfys.Enabled = false;
            txt_jz.Enabled = false;
            this.txt_zdsj.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.txt_zdsj.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.True;
            bindcmb();
        }
        private void bindgrid(string pfbh)
        {
            string sql = "select a.* from gl_pf_detail a ,gl_pf b where b.pf_bh='" + pfbh + "' and a.pid=b.id ";
            DataTable dt = mysql.dt(confighelper.connStr, sql);
            gridControl1.DataSource = dt;
            gridControl1.Enabled = true;
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
        /*创建做货单*/
        private void btn_create_Click(object sender, EventArgs e)
        {
            status.Text = "";
            DateTime now = System.DateTime.Now;
            txt_zhdbh.Text = "ZHD" + now.ToString("yyyyMMddHHmmss");
            txt_zdsj.DateTime = now;
            btn_create.Enabled = false;
            btn_create.Enabled = false;
            txt_zhdbh.Enabled = false;
            txt_bzgs.Text = "袋";
            txt_pfbh.Enabled = true;
            txt_pfjg.Enabled = true;
            txt_pfsl.Enabled = true;
            txt_zdsj.Enabled = true;
            txt_zhds.Enabled = true;
            cb_kh.Enabled = true;
            txt_zj.Enabled = true;
            btn_select.Enabled = true;
            btn_save.Enabled = true;
            btn_rev.Enabled = false;
            btn_print.Enabled = false;
            cb_kh.Text = "";
            txt_pfbh.Text = "";
            txt_jz.Text = "";
            txt_pfsl.Text = "";
            txt_pfjg.Text = "";
            txt_zj.Text = "";
            txt_pfys.Text = "";
            btn_save.Text = "保存做货单";
            System.ComponentModel.ComponentResourceManager resources = new ComponentResourceManager(typeof(zhd));
            btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
        }
        /*选择配方*/
        private void btn_select_Click(object sender, EventArgs e)
        {
            status.Text = "";
            if (cb_kh.Text == "")
            {
                status.Text = "请选择客户！";
                return;
            }
            selectpf f = new selectpf(cb_kh.Text.Trim());
            f.pfbhins += new delegatepfbhins(pfbhins);
            f.ShowDialog();
        }
        /*撤销做货单*/
        private void btn_rev_Click(object sender, EventArgs e)
        {
            zhd_sfcz = false;
            status.Text = "";
            string sql = "delete from gl_zhd where zhd_bh='" + txt_zhdbh.Text + "'";
            mysql.ExecuteNonQuery(confighelper.connStr, sql);
            sql = "delete from gl_zhd_detail where zhd_bh='" + txt_zhdbh.Text + "'";
            mysql.ExecuteNonQuery(confighelper.connStr, sql);
            if (btn_save.Text != "保存做货单")
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    kczj.kc_add(gridView1.GetDataRow(i)["pf_yf_bh"].ToString(), gridView1.GetDataRow(i)["pf_yf_sl"].ToString());
                }
            }
            btn_save.Text = "保存做货单";
            System.ComponentModel.ComponentResourceManager resources = new ComponentResourceManager(typeof(zhd));
            btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            empty();
        }
        private void empty()
        {
            txt_zdsj.Text = "";
            txt_zhdbh.Text = "";
            cb_kh.Text = "";
            txt_pfbh.Text = "";
            txt_jz.Text = "";
            txt_pfsl.Text = "";
            txt_pfjg.Text = "";
            txt_zhds.Text = "";
            txt_bzgs.Text = "";
            txt_zj.Text = "";
            txt_pfys.Text = "";
            gridControl1.Enabled = false;
            txt_bzgs.Enabled = false;
            txt_pfbh.Enabled = false;
            txt_pfjg.Enabled = false;
            txt_pfsl.Enabled = false;
            txt_zdsj.Enabled = false;
            txt_zhdbh.Enabled = false;
            txt_zhds.Enabled = false;
            cb_kh.Enabled = false;
            txt_zj.Enabled = false;
            btn_select.Enabled = false;
            txt_pfys.Enabled = false;
            txt_jz.Enabled = false;
            btn_create.Enabled = true;
            btn_save.Enabled = false;
            btn_rev.Enabled = false;
            btn_print.Enabled = false;
            gridControl1.DataSource = DBNull.Value;
        }
        /*保存做货单*/
        private void btn_save_Click(object sender, EventArgs e)
        {
            status.Text = "";
            zhd_sfcz = true;
            string zhdbh = txt_zhdbh.Text;
            string zhdsj = txt_zdsj.DateTime.ToString();
            string zhdkh = cb_kh.Text;
            string pfbh = txt_pfbh.Text;
            string pfjz = txt_jz.Text;
            string pfsl = txt_pfsl.Text;
            string pfjg = txt_pfjg.Text;
            string zhdzhds = txt_zhds.Text;
            string zhdbz = txt_bzgs.Text;
            string zhdzj = txt_zj.Text;
            string pfys = txt_pfys.Text;
            try
            {
                if (pfbh == "")
                {
                    status.Text = "配方编号不能为空！";
                    return;
                }
                if (pfjg == "")
                {
                    status.Text = "配方价格不能为空！";
                    return;
                }
                if (pfsl == "")
                {
                    status.Text = "配方数量不能为空！";
                    return;
                }
                if (btn_save.Text == "保存做货单")
                {
                    if (checkzhd(zhdbh) == 0)
                    {
                        double zhd_zl = 0;
                        string sql = "";
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            sql = "insert into gl_zhd_detail(zhd_bh,zhd_yf_bh,zhd_yf_sl)values('" + zhdbh + "','" + gridView1.GetDataRow(i)["pf_yf_bh"].ToString() + "'," + (Convert.ToDouble(gridView1.GetDataRow(i)["pf_yf_sl"].ToString()) * Convert.ToDouble(txt_pfsl.Text)).ToString() + ")";
                            mysql.ExecuteNonQuery(confighelper.connStr, sql);
                            kczj.kc_reduce(gridView1.GetDataRow(i)["pf_yf_bh"].ToString(), (Convert.ToDouble(gridView1.GetDataRow(i)["pf_yf_sl"].ToString()) * Convert.ToDouble(txt_pfsl.Text)).ToString());
                            zhd_zl += Convert.ToDouble(gridView1.GetDataRow(i)["pf_yf_sl"].ToString());
                        }
                        sql = "INSERT INTO gl_zhd(zhd_bh,zhd_rq,zhd_kh,zhd_pf_bh,zhd_pf_sl,zhd_zhds,zhd_bzgs,zhd_pf_jg,zhd_pf_jz,zhd_pf_ys,zhd_zj,zhd_zl) VALUES('" + zhdbh + "','" + zhdsj + "','" + zhdkh + "','" + pfbh + "','" + pfsl + "'," + zhdzhds + ",'" + zhdbz + "'," + pfjg + ",'" + pfjz + "','" + pfys + "'," + zhdzj + "," + zhd_zl + ")";
                        mysql.ExecuteNonQuery(confighelper.connStr, sql);
                        status.Text = "做货单保存成功！";
                        status.ForeColor = Color.Black;
                    }
                    else
                    {
                        double zhd_zl = 0;
                        string sql = "";
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            sql = "update gl_zhd_detail set zhd_yf_bh='" + gridView1.GetDataRow(i)["pf_yf_bh"].ToString() + "',zhd_yf_sl=" + (Convert.ToDouble(gridView1.GetDataRow(i)["pf_yf_sl"].ToString()) * Convert.ToDouble(txt_pfsl.Text)).ToString() + " where zhd_bh='" + zhdbh + "'";
                            mysql.ExecuteNonQuery(confighelper.connStr, sql);
                            kczj.kc_reduce(gridView1.GetDataRow(i)["pf_yf_bh"].ToString(), (Convert.ToDouble(gridView1.GetDataRow(i)["pf_yf_sl"].ToString()) * Convert.ToDouble(txt_pfsl.Text)).ToString());
                            zhd_zl += Convert.ToDouble(gridView1.GetDataRow(i)["pf_yf_sl"].ToString());
                        }
                        sql = "update gl_zhd set zhd_rq='" + zhdsj + "',zhd_kh='" + zhdkh + "',zhd_pf_bh='" + pfbh + "',zhd_pf_sl=" + pfsl + ",zhd_zhds=" + zhdzhds + ",zhd_bzgs='" + zhdbz + "',zhd_pf_jg=" + pfjg + ",zhd_pf_jz='" + pfjz + "',zhd_pf_ys='" + pfys + "',zhd_zj=" + zhdzj + ",zhd_zl=" + zhd_zl + " where zhd_bh='" + zhdbh + "'";
                        mysql.ExecuteNonQuery(confighelper.connStr, sql);
                        status.Text = "做货单修改成功！";
                        status.ForeColor = Color.Black;
                    }
                    btn_save.Text = "修改做货单";
                    System.ComponentModel.ComponentResourceManager resources = new ComponentResourceManager(typeof(zhd));
                    btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
                    gridControl1.Enabled = false;
                    txt_pfbh.Enabled = false;
                    cb_kh.Enabled = false;
                    btn_rev.Enabled = true;
                    btn_print.Enabled = true;
                    txt_pfjg.Enabled = false;
                    txt_pfsl.Enabled = false;
                    txt_zhds.Enabled = false;
                    txt_zj.Enabled = false;
                    btn_select.Enabled = false;
                    txt_zdsj.Enabled = false;
                }
                else
                {
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        kczj.kc_add(gridView1.GetDataRow(i)["pf_yf_bh"].ToString(), (Convert.ToDouble(gridView1.GetDataRow(i)["pf_yf_sl"].ToString()) * Convert.ToDouble(txt_pfsl.Text)).ToString());
                    }
                    btn_save.Text = "保存做货单";
                    System.ComponentModel.ComponentResourceManager resources = new ComponentResourceManager(typeof(zhd));
                    btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
                    gridControl1.Enabled = true;
                    txt_pfbh.Enabled = false;
                    cb_kh.Enabled = false;
                    status.ForeColor = Color.Black;
                    btn_print.Enabled = false;
                    txt_pfjg.Enabled = true;
                    txt_pfsl.Enabled = true;
                    txt_zhds.Enabled = true;
                    txt_zj.Enabled = true;
                    btn_select.Enabled = true;
                    txt_zdsj.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /*检查是否存在做货单*/
        private int checkzhd(string zhdbh)
        {
            string sql = "select * from gl_zhd where zhd_bh='" + zhdbh + "'";
            return mysql.dt(confighelper.connStr, sql).Rows.Count;
        }
        private void pfbhins(string pfbh)
        {
            status.Text = "";
            txt_pfbh.Text = pfbh;
            string sql = "select * from gl_pf where pf_bh='" + pfbh + "'";
            DataTable dt = mysql.dt(confighelper.connStr, sql);
            if (dt.Rows.Count == 0)
            {
                if (txt_pfbh.Text == "")
                {

                }
                else
                {
                    status.Text = "不存在该编号的配方！";
                    txt_pfbh.Focus();
                }
                return;
            }
            cb_kh.Text = dt.Rows[0]["pf_kh"].ToString();
            txt_jz.Text = dt.Rows[0]["pf_jz"].ToString();
            txt_pfys.Text = dt.Rows[0]["pf_ys"].ToString();
            txt_pfjg.Text = dt.Rows[0]["pf_jg"].ToString();
            txt_pfsl.Text = "1";//配方数量默认为1
            txt_zhds.Text = "1";//制货袋数默认为1
            bindgrid(pfbh);
        }

        private void txt_pfsl_TextChanged(object sender, EventArgs e)
        {
            if (txt_pfjg.Text != "" && txt_pfsl.Text != "")
            {
                txt_zj.Text = (Convert.ToDouble(txt_pfjg.Text) * Convert.ToDouble(txt_pfsl.Text)).ToString();
            }
        }

        private void txt_pfbh_Leave(object sender, EventArgs e)
        {
            pfbhins(txt_pfbh.Text);
        }

        private void txt_pfjg_TextChanged(object sender, EventArgs e)
        {
            if (txt_pfjg.Text != "" && txt_pfsl.Text != "")
            {
                txt_zj.Text = (Convert.ToDouble(txt_pfjg.Text) * Convert.ToDouble(txt_pfsl.Text)).ToString();
            }
        }

        private void zhd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (zhd_sfcz == true && btn_save.Text == "保存做货单")
            {
                if (MessageBox.Show("编号为：" + txt_zhdbh.Text + "的做货单未保存，是否将其撤销？", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.OK)
                {
                    string sql = "delete from gl_zhd where zhd_bh='" + txt_zhdbh.Text + "'";
                    mysql.ExecuteNonQuery(confighelper.connStr, sql);
                    sql = "delete from gl_zhd_detail where zhd_bh='" + txt_zhdbh.Text + "'";
                    mysql.ExecuteNonQuery(confighelper.connStr, sql);
                    if (btn_save.Text != "保存做货单")
                    {
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            kczj.kc_add(gridView1.GetDataRow(i)["pf_yf_bh"].ToString(), gridView1.GetDataRow(i)["pf_yf_sl"].ToString());
                        }
                    }

                }
                else
                {
                    e.Cancel = true;
                }
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

        private void btn_print_Click(object sender, EventArgs e)
        {
            status.Text = "";
            string sql = "select * from gl_zhd_detail where zhd_bh='" + txt_zhdbh.Text + "'";
            DataTable dt = mysql.dt(confighelper.connStr, sql);
            dt.TableName = "zhd";
            
            sql = "select  * , DATE_FORMAT(zhd_rq,'%Y-%m-%d') zhd_sj from gl_zhd where zhd_bh='" + txt_zhdbh.Text + "'";
            DataTable dt1 = mysql.dt(confighelper.connStr, sql);
            dt1.TableName = "zhd_main";
            DataSet ds = new DataSet();
            DataRow dr = null;
            int count = dt.Rows.Count;
            int blank_count = 9 - count % 9;
            for (int i = 0; i < blank_count; i++)
            {
                dr = dt.NewRow();
                dt.Rows.Add(dr);
            }
            ds.Tables.Add(dt);
            ds.Tables.Add(dt1);
            Report report = new Report();

            report.Load(@"zhd.frx");

            // register the dataset
            report.RegisterData(ds);

            // run the report
            report.Show();

            // free resources used by report
            report.Dispose();
            btn_create.Enabled = true;
            btn_save.Enabled = false;
            btn_rev.Enabled = false;
        }
    }
}