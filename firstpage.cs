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
    public partial class firstpage : DevExpress.XtraEditors.XtraForm
    {
        public firstpage()
        {
            InitializeComponent();
        }

        private void firstpage_Load(object sender, EventArgs e)
        {
            labelControl1.Text = "copyright@2015-2016 塑联科技";
        }
    }
}