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
    public partial class jm : DevExpress.XtraEditors.XtraForm
    {
        public jm()
        {
            InitializeComponent();
        }
        //加密
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(textEdit1.Text==""){
                return;
            }
            textEdit2.Text = secret.Encrypt(textEdit1.Text, "cptbtptp");
        }
        //解密
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text == "")
            {
                return;
            }
            textEdit2.Text = secret.Decrypt(textEdit1.Text, "cptbtptp");
        }

        private void jm_Load(object sender, EventArgs e)
        {

        }
    }
}