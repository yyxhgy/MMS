using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace DXApplication4
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
            
        }
        //客户管理
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraTabPage page in xtraTabControl1.TabPages)
            {
                if (page.Text == barButtonItem2.Caption)
                {
                    xtraTabControl1.SelectedTabPage = page;//显示该页
                    return;
                }
            }
            XtraTabPage xpage = new XtraTabPage();
            xpage.Name = "kh";
            xpage.Text = "客户管理";
            kh kh_form = new kh
            {
                Visible = true,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false//在这里一定要注意  负责是加载不出来的
            };
            xpage.Controls.Add(kh_form);//添加要增加的控件  
            xtraTabControl1.TabPages.Add(xpage);
            xtraTabControl1.SelectedTabPage = xpage;//显示该页

        }
        private void Main_Load(object sender, EventArgs e)
        {
            firstpage.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.Text = confighelper.bbh;
            this.DoubleBuffered = true;
            //firstpage first = new firstpage
            //{
            //    Visible = true,
            //    Dock = DockStyle.Fill,
            //    FormBorderStyle = FormBorderStyle.None,
            //    TopLevel = false//在这里一定要注意  负责是加载不出来的
            //};
            //firstpage.Controls.Add(first);
        }
        //原粉入库
        private void btn_rk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraTabPage page in xtraTabControl1.TabPages)
            {
                if (page.Text == btn_rk.Caption)
                {
                    xtraTabControl1.SelectedTabPage = page;//显示该页
                    return;
                }
            }
            XtraTabPage xpage = new XtraTabPage();
            xpage.Name = "rk";
            xpage.Text = "原粉入库";
            rk rk_form = new rk
            {
                Visible = true,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false//在这里一定要注意  负责是加载不出来的
            };
            xpage.Controls.Add(rk_form);//添加要增加的控件  
            xtraTabControl1.TabPages.Add(xpage);
            xtraTabControl1.SelectedTabPage = xpage;//显示该页
        }
        //库存查询
        private void btn_kc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraTabPage page in xtraTabControl1.TabPages)
            {
                if (page.Text == btn_kc.Caption)
                {
                    xtraTabControl1.SelectedTabPage = page;//显示该页
                    return;
                }
            }
            XtraTabPage xpage = new XtraTabPage();
            xpage.Name = "kc";
            xpage.Text = "库存查询";
            kc kc_form = new kc
            {
                Visible = true,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false//在这里一定要注意  负责是加载不出来的
            };
            xpage.Controls.Add(kc_form);//添加要增加的控件  
            xtraTabControl1.TabPages.Add(xpage);
            xtraTabControl1.SelectedTabPage = xpage;//显示该页
        }
        /*关闭选项卡*/
        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs EArg = (DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs)e;
            string name = EArg.Page.Text;//得到关闭的选项卡的text
            foreach (XtraTabPage page in xtraTabControl1.TabPages)//遍历得到和关闭的选项卡一样的Text
            {
                if (page.Text == name)
                {
                    xtraTabControl1.TabPages.Remove(page);
                    page.Dispose();
                    return;
                }
            }
        }
        //配方管理
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraTabPage page in xtraTabControl1.TabPages)
            {
                if (page.Text == barButtonItem3.Caption)
                {
                    xtraTabControl1.SelectedTabPage = page;//显示该页
                    return;
                }
            }
            XtraTabPage xpage = new XtraTabPage();
            xpage.Name = "pfgl";
            xpage.Text = "配方管理";
            pfgl pfgl_form = new pfgl
            {
                Visible = true,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false//在这里一定要注意  否则是加载不出来的
            };
            xpage.Controls.Add(pfgl_form);//添加要增加的控件  
            xtraTabControl1.TabPages.Add(xpage);
            xtraTabControl1.SelectedTabPage = xpage;//显示该页
        }
        //新增做货单
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraTabPage page in xtraTabControl1.TabPages)
            {
                if (page.Text == barButtonItem4.Caption)
                {
                    xtraTabControl1.SelectedTabPage = page;//显示该页
                    return;
                }
            }
            XtraTabPage xpage = new XtraTabPage();
            xpage.Name = "zhd";
            xpage.Text = "新增做货单";
            zhd zhd_form = new zhd
            {
                Visible = true,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false//在这里一定要注意  否则是加载不出来的
            };
            xpage.Controls.Add(zhd_form);//添加要增加的控件  
            xtraTabControl1.TabPages.Add(xpage);
            xtraTabControl1.SelectedTabPage = xpage;//显示该页
        }
        //做货单查询
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraTabPage page in xtraTabControl1.TabPages)
            {
                if (page.Text == barButtonItem5.Caption)
                {
                    xtraTabControl1.SelectedTabPage = page;//显示该页
                    return;
                }
            }
            XtraTabPage xpage = new XtraTabPage();
            xpage.Name = "zhd_cx";
            xpage.Text = "查询做货单";
            zhd_cx zhdcx_form = new zhd_cx
            {
                Visible = true,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false//在这里一定要注意  否则是加载不出来的
            };
            xpage.Controls.Add(zhdcx_form);//添加要增加的控件  
            xtraTabControl1.TabPages.Add(xpage);
            xtraTabControl1.SelectedTabPage = xpage;//显示该页
        }
        //新增送货单
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraTabPage page in xtraTabControl1.TabPages)
            {
                if (page.Text == barButtonItem6.Caption)
                {
                    xtraTabControl1.SelectedTabPage = page;//显示该页
                    return;
                }
            }
            XtraTabPage xpage = new XtraTabPage();
            xpage.Name = "shd";
            xpage.Text = "新增送货单";
            shd shd_form = new shd
            {
                Visible = true,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false//在这里一定要注意  否则是加载不出来的
            };
            xpage.Controls.Add(shd_form);//添加要增加的控件  
            xtraTabControl1.TabPages.Add(xpage);
            xtraTabControl1.SelectedTabPage = xpage;//显示该页
        }
        //送货单查询
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (XtraTabPage page in xtraTabControl1.TabPages)
            {
                if (page.Text == barButtonItem7.Caption)
                {
                    xtraTabControl1.SelectedTabPage = page;//显示该页
                    return;
                }
            }
            XtraTabPage xpage = new XtraTabPage();
            xpage.Name = "shd_cx";
            xpage.Text = "查询送货单";
            shd_cx shdcx_form = new shd_cx
            {
                Visible = true,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false//在这里一定要注意  否则是加载不出来的
            };
            xpage.Controls.Add(shdcx_form);//添加要增加的控件  
            xtraTabControl1.TabPages.Add(xpage);
            xtraTabControl1.SelectedTabPage = xpage;//显示该页
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.R)
            {
                jm a = new jm();
                a.ShowDialog();
            }
        }


    }
}
