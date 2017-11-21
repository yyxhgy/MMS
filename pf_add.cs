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
    public delegate void delegate_pf_add(object sender, EventArgs e);
    public partial class pf_add : DevExpress.XtraEditors.XtraForm
    {
        public event delegate_pf_add btn_search_Click;
        private static string ac = "";
        private static string bh = "";
        public pf_add(string action, string pfbh)
        {
            this.InitializeComponent();
            ac = action;
            bh = pfbh;
        }

        private void pf_add_Load(object sender, EventArgs e)
        {
            if (ac == "add")
            {
                this.bindcmb();
                this.gridControl1.Enabled = false;
                this.txt_cbj.Enabled = false;
                this.txt_jg.Enabled = false;
                this.simpleButton1.Enabled = false;
                this.Text = "配方新增";
            }
            else if (ac == "edit")
            {
                this.btn_create.Text = "保存配方";
                this.txt_pfbh.Enabled = false;
                this.txt_cbj.Enabled = false;
                this.groupBox1.Enabled = true;
                this.bind(bh);
                this.edit_bind(bh);
                this.bindcmb();
                this.Text = "配方修改";
            }
        }
        private void bind(string pfbh)
        {
            string sql = "SELECT b.* from gl_pf a,gl_pf_detail b where a.id=b.pid and a.pf_bh='" + pfbh + "'";
            DataTable table = mysql.dt(confighelper.connStr, sql);
            this.gridControl1.DataSource = table;
        }
        private void edit_bind(string pfbh)
        {
            string sql = "select * from gl_pf where pf_bh='" + pfbh + "'";
            DataTable table = mysql.dt(confighelper.connStr, sql);
            this.txt_pfbh.Text = table.Rows[0]["pf_bh"].ToString();
            this.cb_kh.Text = table.Rows[0]["pf_kh"].ToString();
            this.txt_pfys.Text = table.Rows[0]["pf_ys"].ToString();
            this.txt_pfjz.Text = table.Rows[0]["pf_jz"].ToString();
            this.txt_sbbh.Text = table.Rows[0]["pf_sbbh"].ToString();
            this.txt_cbj.Text = table.Rows[0]["pf_cbj"].ToString();
            if (this.txt_cbj.Text == "")
            {
                this.txt_cbj.Text = "0.00000";
            }
            if (table.Rows[0]["pf_jsrq"].ToString() != "")
            {
                this.txt_jssj.DateTime = DateTime.Parse(table.Rows[0]["pf_jsrq"].ToString());
            }
            if (table.Rows[0]["pf_sqrq"].ToString() != "")
            {
                this.txt_sqsj.DateTime = DateTime.Parse(table.Rows[0]["pf_sqrq"].ToString());
            }
            this.txt_jg.Text = table.Rows[0]["pf_jg"].ToString();
        }
        //初始化绑定默认关键词（此数据源可以从数据库取）
        List<string> listOnit = new List<string>();
        //输入key之后，返回的关键词
        List<string> listNew = new List<string>();

        private void bindcmb()
        {
            string sql = "select '' kh_name union select kh_name from gl_kh";
            DataTable table = mysql.dt(confighelper.connStr, sql);
            if (this.listOnit.Count == 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    this.listOnit.Add(table.Rows[i]["kh_name"].ToString());
                }
                this.cb_kh.Items.AddRange(this.listOnit.ToArray());
            }
        }
        /*创建配方*/
        private void btn_create_Click(object sender, EventArgs e)
        {
            string str;
            this.status.Text = "";
            DateTime now = DateTime.Now;
            if (ac == "add")
            {
                if (this.txt_pfbh.Text.Trim() != "")
                {
                    if (this.check(this.txt_pfbh.Text.Trim()).Rows.Count != 0)
                    {
                        this.txt_pfbh.Focus();
                        this.status.Text = "配方编号已存在！";
                        return;
                    }
                    if (this.txt_sqsj.Text == "")
                    {
                        this.txt_sqsj.Text = now.ToString();
                    }
                    if (this.txt_jssj.Text == "")
                    {
                        this.txt_jssj.Text = now.ToString();
                    }
                    str = "insert into gl_pf(pf_kh,pf_bh,pf_ys,pf_jz,pf_sbbh,pf_jsrq,pf_sqrq,pf_xzrq)values('" + this.cb_kh.Text + "','" + this.txt_pfbh.Text + "','" + this.txt_pfys.Text + "','" + this.txt_pfjz.Text + "','" + this.txt_sbbh.Text + "','" + this.txt_jssj.Text + "','" + this.txt_sqsj.Text + "','" + now.ToString() + "')";
                    mysql.ExecuteNonQuery(confighelper.connStr, str);
                    bh = this.txt_pfbh.Text.Trim();
                }
                else
                {
                    this.txt_pfbh.Focus();
                    this.status.Text = "配方编号不能为空！";
                    return;
                }
                this.txt_jg.Enabled = true;
                this.simpleButton1.Enabled = true;
                this.txt_jssj.Enabled = false;
                this.txt_pfbh.Enabled = false;
                this.txt_pfjz.Enabled = false;
                this.txt_pfys.Enabled = false;
                this.txt_sbbh.Enabled = false;
                this.txt_sqsj.Enabled = false;
                this.btn_create.Enabled = false;
                this.cb_kh.Enabled = false;
                this.gridControl1.Enabled = true;
                this.groupBox1.Enabled = true;
                this.edit_bind(bh);
            }
            else if (ac == "edit")
            {
                if (this.txt_sqsj.Text == "")
                {
                    this.status.Text = "首取时间不能为空！";
                }
                else if (this.txt_jssj.Text == "")
                {
                    this.status.Text = "较色时间不能为空！";
                }
                else
                {
                    str = "update gl_pf set pf_kh='" + this.cb_kh.Text + "',pf_ys='" + this.txt_pfys.Text + "',pf_jz='" + this.txt_pfjz.Text + "',pf_sbbh='" + this.txt_sbbh.Text + "',pf_jsrq='" + this.txt_jssj.Text + "',pf_sqrq='" + this.txt_sqsj.Text + "',pf_jg='" + this.txt_cbj.Text + "',pf_xzrq='" + now.ToString() + "',pf_cbj='" + this.txt_cbj.Text + "' where pf_bh='" + this.txt_pfbh.Text + "'";
                    mysql.ExecuteNonQuery(confighelper.connStr, str);
                    this.status.Text = "配方保存成功！";
                }
            }
        }

        /*删除配方明细*/
        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                this.status.Text = "";
                string str = this.gridView1.GetFocusedDataRow()["id"].ToString();
                string sql = "delete from gl_pf_detail where id=" + str;
                mysql.ExecuteNonQuery(confighelper.connStr, sql);
                this.txt_cbj.Text = (Convert.ToDouble(this.txt_cbj.Text.Trim()) - Convert.ToDouble(this.gridView1.GetFocusedDataRow()["pf_yf_je"].ToString())).ToString();
                sql = "update gl_pf set pf_cbj ='" + this.txt_cbj.Text + "' where pf_bh='" + this.txt_pfbh.Text + "'";
                mysql.ExecuteNonQuery(confighelper.connStr, sql);
                this.bind(bh);
            }
            catch (Exception)
            {
                this.status.Text = "请选择一行数据！";
            }
        }
        /*检查配方编号是否存在*/
        private DataTable check(string pfbh)
        {
            string sql = "select * from gl_pf where pf_bh='" + pfbh + "'";
            return mysql.dt(confighelper.connStr, sql);
        }
        /*撤销配方*/
        private void btn_rev_Click(object sender, EventArgs e)
        {
            bh = "";
            this.btn_create.Enabled = true;
            this.txt_jg.Enabled = true;
            this.txt_jssj.Enabled = true;
            this.txt_pfbh.Enabled = true;
            this.txt_pfjz.Enabled = true;
            this.txt_pfys.Enabled = true;
            this.txt_sbbh.Enabled = true;
            this.txt_sqsj.Enabled = true;
            this.cb_kh.Enabled = true;
            this.gridControl1.Enabled = false;
            this.groupBox1.Enabled = false;
            string sql = "delete from gl_pf_detail where pid=" + this.check(this.txt_pfbh.Text.Trim()).Rows[0]["id"].ToString();
            mysql.ExecuteNonQuery(confighelper.connStr, sql);
            sql = "delete from gl_pf where pf_bh='" + this.txt_pfbh.Text.Trim() + "'";
            mysql.ExecuteNonQuery(confighelper.connStr, sql);
            this.bind(this.txt_pfbh.Text.Trim());
        }

        private void selectyfbh(string yfbh)
        {
            this.status.Text = "";
            this.txt_yfbh.Text = yfbh;
            this.txt_yfsl.Text = "1.00";
            this.txt_yfsl.Focus();
        }
        /*保存配方明细*/
        private void btn_save_Click(object sender, EventArgs e)
        {
            this.status.Text = "";
            if (this.check_pf(this.txt_pfbh.Text, this.txt_yfbh.Text) > 0)
            {
                this.status.Text = "该原粉已存在！";
                this.status.ForeColor = Color.Red;
            }
            else
            {
                string sql = "select * from gl_kc where kc_yf_bh='" + this.txt_yfbh.Text.Trim() + "'";
                if (mysql.dt(confighelper.connStr, sql).Rows.Count == 0)
                {
                    this.status.Text = "不存在该原粉！";
                    this.status.ForeColor = Color.Red;
                }
                else
                {

                    sql = "select yf_jg from gl_kc where kc_yf_bh='" + this.txt_yfbh.Text.Trim() + "'";
                    double num = (Convert.ToDouble(mysql.dt(confighelper.connStr, sql).Rows[0]["yf_jg"].ToString()) / 1000.0) * Convert.ToDouble(this.txt_yfsl.Text.Trim());
                    sql = string.Concat(new object[] { "insert into gl_pf_detail(pid,pf_yf_bh,pf_yf_sl,pf_yf_je)values(", this.check(bh).Rows[0]["id"].ToString(), ",'", this.txt_yfbh.Text.Trim(), "','", this.txt_yfsl.Text, "','", num, "')" });
                    mysql.ExecuteNonQuery(confighelper.connStr, sql);
                    this.txt_cbj.Text = (Convert.ToDouble(this.txt_cbj.Text.Trim()) + num).ToString();
                    sql = "update gl_pf set pf_cbj ='" + this.txt_cbj.Text + "' where pf_bh='" + this.txt_pfbh.Text + "'";
                    mysql.ExecuteNonQuery(confighelper.connStr, sql);
                    this.txt_yfbh.Text = "";
                    this.txt_yfsl.Text = "";
                    this.bind(bh);
                }
            }
        }
        /*添加配方明细*/
        private void btn_add_Click(object sender, EventArgs e)
        {
            this.status.Text = "";
            selectyf selectyf = new selectyf();
            selectyf.selectyfbh += new delegateSelectyfbh(this.selectyfbh);
            selectyf.ShowDialog();
        }

        private void pf_add_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn_search_Click(sender, e);
        }
        private int check_pf(string pf_bh, string yf_bh)
        {
            string sql = "select * from gl_pf a,gl_pf_detail b where a.id=b.pid and  a.pf_bh='" + pf_bh + "' and b.pf_yf_bh='" + yf_bh + "'";
            return mysql.dt(confighelper.connStr, sql).Rows.Count;
        }


        private void cb_kh_TextUpdate(object sender, EventArgs e)
        {
            this.cb_kh.Items.Clear();
            this.listNew.Clear();
            foreach (string str in this.listOnit)
            {
                if (str.Contains(this.cb_kh.Text))
                {
                    this.listNew.Add(str);
                }
            }
            this.cb_kh.Items.AddRange(this.listNew.ToArray());
            if (this.listNew.Count == 0)
            {
                this.bindcmb();
            }
            this.cb_kh.SelectionStart = this.cb_kh.Text.Length;
            this.Cursor = Cursors.Default;
            this.cb_kh.DroppedDown = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string sql = "update gl_pf set pf_jg ='" + this.txt_jg.Text + "' where pf_bh='" + this.txt_pfbh.Text + "'";
            mysql.ExecuteNonQuery(confighelper.connStr, sql);
            this.status.Text = "售价保存成功！";
            this.status.ForeColor = Color.Black;
        }
    }
}