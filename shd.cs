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
    public partial class shd : DevExpress.XtraEditors.XtraForm
    {
        public static DataTable dt_pf;
        public shd()
        {
            InitializeComponent();
        }
        private void MakeDataTable()
        {
            dt_pf = new DataTable();
            DataColumn column;

            // Create new DataColumn, set DataType, ColumnName
            // and add to DataTable.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "shd_pf_bh";
            dt_pf.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "shd_pf_jz";
            dt_pf.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "shd_pf_ys";
            dt_pf.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "shd_pf_sl";
            dt_pf.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "shd_pf_dw";
            dt_pf.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "shd_pf_jg";
            dt_pf.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "shd_je";
            dt_pf.Columns.Add(column);


        }
        private void shd_Load(object sender, EventArgs e)
        {
            gridControl1.Enabled = false;
            txt_bzgs.Enabled = false;
            txt_pfbh.Enabled = false;
            txt_pfjg.Enabled = false;
            txt_pfsl.Enabled = false;
            txt_zdsj.Enabled = false;
            txt_shdbh.Enabled = false;
            cb_kh.Enabled = false;
            txt_zj.Enabled = false;
            btn_select.Enabled = false;
            btn_save.Enabled = false;
            btn_rev.Enabled = false;
            btn_print.Enabled = false ;
            txt_pfys.Enabled = false;
            txt_jz.Enabled = false;
            btn_cle.Enabled = false;
            btn_ins.Enabled = false;
            this.txt_zdsj.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.txt_zdsj.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.True;
            bindcmb();
            MakeDataTable();
            gridControl1.DataSource = dt_pf;
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
            btn_ins.Enabled = true;
            btn_cle.Enabled = true;
        }
        private void txt_pfbh_Leave(object sender, EventArgs e)
        {
            status.Text = "";
            pfbhins(txt_pfbh.Text);
        }
        private void txt_pfsl_TextChanged(object sender, EventArgs e)
        {
            if (txt_pfjg.Text != "" && txt_pfsl.Text != "")
            {
                txt_zj.Text = (Convert.ToDouble(txt_pfjg.Text) * Convert.ToDouble(txt_pfsl.Text)).ToString();
            }
        }
        private void empty()
        {
            txt_zdsj.Text = "";
            txt_shdbh.Text = "";
            cb_kh.Text = "";
            txt_pfbh.Text = "";
            txt_jz.Text = "";
            txt_pfsl.Text = "";
            txt_pfjg.Text = "";
            txt_bzgs.Text = "";
            txt_zj.Text = "";
            txt_pfys.Text = "";
            gridControl1.Enabled = false;
            txt_bzgs.Enabled = false;
            txt_pfbh.Enabled = false;
            txt_pfjg.Enabled = false;
            txt_pfsl.Enabled = false;
            txt_zdsj.Enabled = false;
            txt_shdbh.Enabled = false;
            cb_kh.Enabled = false;
            txt_zj.Enabled = false;
            btn_select.Enabled = false;
            txt_pfys.Enabled = false;
            txt_jz.Enabled = false;
            btn_create.Enabled = true;
            btn_save.Enabled = false;
            btn_rev.Enabled = false;
            btn_print.Enabled = false;
            btn_cle.Enabled = false;
            btn_ins.Enabled = false;
            gridControl1.DataSource = DBNull.Value;
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
        private void btn_select_Click(object sender, EventArgs e)
        {
            status.Text = "";
            if (cb_kh.Text == "")
            {
                status.Text = "请选择客户！";
                status.ForeColor = Color.Red;
                return;
            }
            selectpf f = new selectpf(cb_kh.Text.Trim());
            f.pfbhins += new delegatepfbhins(pfbhins);
            f.ShowDialog();

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            status.Text = "";
            MakeDataTable();
            gridControl1.DataSource = dt_pf;
            DateTime now = System.DateTime.Now;
            txt_shdbh.Text = "SHD" + now.ToString("yyyyMMddHHmmss");
            txt_zdsj.DateTime = now;
            btn_create.Enabled = false;
            btn_create.Enabled = false;
            txt_bzgs.Text = "份";
            txt_bzgs.Enabled = true;
            txt_pfbh.Enabled = true;
            txt_pfjg.Enabled = true;
            txt_pfsl.Enabled = true;
            txt_zdsj.Enabled = true;
            cb_kh.Enabled = true;
            txt_zj.Enabled = true;
            btn_select.Enabled = true;
            btn_save.Enabled = true;
            btn_rev.Enabled = false;
            gridControl1.Enabled = true;
            cb_kh.Text = "";
            txt_pfbh.Text = "";
            txt_jz.Text = "";
            txt_pfsl.Text = "";
            txt_pfjg.Text = "";
            txt_zj.Text = "";
            txt_pfys.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            status.Text = "";
            string shdbh = txt_shdbh.Text;
            string shdsj = txt_zdsj.DateTime.ToString();
            string shdkh = cb_kh.Text;
            //string pfbh = txt_pfbh.Text;
            //string pfjz = txt_jz.Text;
            //string pfsl = txt_pfsl.Text;
            //string pfjg = txt_pfjg.Text;
            //string shddw = txt_bzgs.Text;
            //string shdzj = txt_zj.Text;
            //string pfys = txt_pfys.Text;
            try
            {
                if (gridView1.RowCount == 0)
                {
                    status.Text = "该送货单未添加配方！";
                    status.ForeColor = Color.Red;
                    return;
                }
                if (txt_pfjg.Text == "")
                {
                    status.Text = "配方价格不能为空！";
                    status.ForeColor = Color.Red;
                    return;
                }
                if (shdkh == "")
                {
                    status.Text = "请选择客户！";
                    status.ForeColor = Color.Red;
                    return;
                }
                if (btn_save.Text == "保存送货单")
                {
                    if (checkshd(shdbh) == 0)
                    {
                        
                        double shd_je = 0;
                        string sql = "";
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            sql = "insert into gl_shd_detail(shd_bh,shd_pf_bh,shd_pf_sl,shd_pf_jg,shd_pf_ys,shd_pf_jz,shd_pf_dw)values('" + shdbh + "','" + gridView1.GetDataRow(i)["shd_pf_bh"].ToString() + "'," + gridView1.GetDataRow(i)["shd_pf_sl"].ToString() + "," + gridView1.GetDataRow(i)["shd_pf_jg"].ToString() + ",'" + gridView1.GetDataRow(i)["shd_pf_ys"].ToString() + "','" + gridView1.GetDataRow(i)["shd_pf_jz"].ToString() + "','" + gridView1.GetDataRow(i)["shd_pf_dw"].ToString() + "')";
                            mysql.ExecuteNonQuery(confighelper.connStr, sql);
                            shd_je += Convert.ToDouble(gridView1.GetDataRow(i)["shd_pf_sl"].ToString()) * Convert.ToDouble(gridView1.GetDataRow(i)["shd_pf_jg"].ToString());
                        }
                        sql = "INSERT INTO gl_shd(shd_bh,shd_rq,shd_kh,shd_je)values('" + shdbh + "','" + shdsj + "','" + shdkh + "'," + shd_je + ")";
                        mysql.ExecuteNonQuery(confighelper.connStr, sql);
                        status.Text = "送货单保存成功！";
                        status.ForeColor = Color.Black;
                    }
                    else
                    {
                        double shd_je = 0;
                        string sql = "";
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            sql = "update gl_shd_detail set  shd_pf_sl=" + gridView1.GetDataRow(i)["shd_pf_sl"].ToString() + ",shd_pf_jg=" + gridView1.GetDataRow(i)["shd_pf_jg"].ToString() + ",shd_pf_ys='" + gridView1.GetDataRow(i)["shd_pf_ys"].ToString() + "',shd_pf_jz='" + gridView1.GetDataRow(i)["shd_pf_jz"].ToString() + "',shd_pf_dw='" + gridView1.GetDataRow(i)["shd_pf_dw"].ToString() + "' where shd_bh='" + shdbh + "' and shd_pf_bh='" + gridView1.GetDataRow(i)["shd_pf_bh"].ToString() + "'";
                            mysql.ExecuteNonQuery(confighelper.connStr, sql);
                            shd_je += Convert.ToDouble(gridView1.GetDataRow(i)["shd_pf_sl"].ToString()) * Convert.ToDouble(gridView1.GetDataRow(i)["shd_pf_jg"].ToString());
                        }
                        sql = "update gl_shd set shd_rq='" + shdsj + "',shd_kh='" + shdkh + "',shd_je=" + shd_je + "  where shd_bh='" + shdbh + "'";
                        mysql.ExecuteNonQuery(confighelper.connStr, sql);
                        status.Text = "送货单修改成功！";
                        status.ForeColor = Color.Black;
                    }
                    btn_save.Text = "修改送货单";
                    System.ComponentModel.ComponentResourceManager resources = new ComponentResourceManager(typeof(shd));
                    btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
                    gridControl1.Enabled = false;
                    txt_pfbh.Enabled = false;
                    cb_kh.Enabled = false;
                    btn_rev.Enabled = true;
                    btn_print.Enabled = true;
                    txt_pfjg.Enabled = false;
                    txt_pfsl.Enabled = false;
                    txt_zj.Enabled = false;
                    txt_bzgs.Enabled = false;
                    btn_cle.Enabled = false;
                    btn_ins.Enabled = false;
                    btn_select.Enabled = false;
                }
                else
                {

                    btn_save.Text = "保存送货单";
                    System.ComponentModel.ComponentResourceManager resources = new ComponentResourceManager(typeof(shd));
                    btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
                    gridControl1.Enabled = true;
                    txt_pfbh.Enabled = false;
                    cb_kh.Enabled = true;
                    txt_pfbh.Enabled = true;
                    status.ForeColor = Color.Black;
                    btn_print.Enabled = false;
                    txt_pfjg.Enabled = true;
                    txt_pfsl.Enabled = true;
                    txt_zj.Enabled = true;
                    btn_ins.Enabled = true;
                    btn_cle.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /*检查是否存在送货单*/
        private int checkshd(string shdbh)
        {
            string sql = "select * from gl_shd where shd_bh='" + shdbh + "'";
            return mysql.dt(confighelper.connStr, sql).Rows.Count;
        }
        private void btn_rev_Click(object sender, EventArgs e)
        {
            status.Text = "";
            string sql = "delete from gl_shd where shd_bh='" + txt_shdbh.Text + "'";
            mysql.ExecuteNonQuery(confighelper.connStr, sql);
            sql = "delete from gl_shd_detail where shd_bh='" + txt_shdbh.Text + "'";
            mysql.ExecuteNonQuery(confighelper.connStr, sql);
            btn_save.Text = "保存送货单";
            System.ComponentModel.ComponentResourceManager resources = new ComponentResourceManager(typeof(shd));
            btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            empty();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            string sql = "select *,shd_pf_jg*shd_pf_sl shd_pf_je from gl_shd_detail where shd_bh='" + txt_shdbh.Text + "'";
            DataTable dt = mysql.dt(confighelper.connStr, sql);
            dt.TableName = "shd_detail";
            sql = "select  a.* ,b.kh_address shd_kh_dz, DATE_FORMAT(shd_rq,'%Y-%m-%d') shd_sj from gl_shd a,gl_kh b where a.shd_kh=b.kh_name and a.shd_bh='"+txt_shdbh.Text+"'";
            DataTable dt1 = mysql.dt(confighelper.connStr, sql);
            dt1.TableName = "shd";
            DataSet ds = new DataSet();
            DataRow dr = null;
            int count = dt.Rows.Count;
            int blank_count = 6 - count % 6;
            for (int i = 0; i < blank_count;i++ )
            {
                dr = dt.NewRow();
                dt.Rows.Add(dr);
            }
            
            ds.Tables.Add(dt);
            ds.Tables.Add(dt1);
            Report report = new Report();

            report.Load(@"shd.frx");

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
        /*把配方写入TABLE*/
        private void insertINTOtable()
        {
            //string shdbh = txt_shdbh.Text;
            //string shdsj = txt_zdsj.DateTime.ToString();
            //string shdkh = cb_kh.Text;
            string pfbh = txt_pfbh.Text;
            string pfjz = txt_jz.Text;
            string pfsl = txt_pfsl.Text;
            string pfjg = txt_pfjg.Text;
            string shddw = txt_bzgs.Text;
            string shdzj = txt_zj.Text;
            string pfys = txt_pfys.Text;
            DataRow newrow = dt_pf.NewRow();
            newrow["shd_pf_bh"] = pfbh;
            newrow["shd_je"] = shdzj;
            newrow["shd_pf_jz"] = pfjz;
            newrow["shd_pf_ys"] = pfys;
            newrow["shd_pf_sl"] = pfsl;
            newrow["shd_pf_dw"] = shddw;
            newrow["shd_pf_jg"] = pfjg;

            dt_pf.Rows.Add(newrow);
            gridControl1.DataSource = dt_pf;
        }
        /*配方添加*/
        private void btn_ins_Click(object sender, EventArgs e)
        {
            status.Text = "";
            //判断是否有重复配方添加
            if (dt_pf.Select("shd_pf_bh='" + txt_pfbh.Text + "'").Length > 0)
            {
                status.Text = "该配方已存在！";
                status.ForeColor = Color.Red;
            }
            else
            {
                insertINTOtable();
            }
        }
        /*配方删除*/
        private void btn_cle_Click(object sender, EventArgs e)
        {
            string pfbh = gridView1.GetFocusedDataRow()["shd_pf_bh"].ToString();
            DataRow selectrow = dt_pf.Select("shd_pf_bh='" + txt_pfbh.Text + "'")[0];
            dt_pf.Rows.Remove(selectrow);
            gridControl1.DataSource = dt_pf;
        }

        private void txt_pfjg_TextChanged(object sender, EventArgs e)
        {
            if (txt_pfjg.Text != "" && txt_pfsl.Text != "")
            {
                txt_zj.Text = (Convert.ToDouble(txt_pfjg.Text) * Convert.ToDouble(txt_pfsl.Text)).ToString();
            }
        }
    }
}