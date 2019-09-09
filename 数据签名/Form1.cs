using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 数据签名
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private delegate void factoryKey_delegate(string key);
        public void factoryKey(string key) {
            if (!this.tb_factoryKey.InvokeRequired)
            {
                this.tb_factoryKey.Text = key;
            }
            else {
                factoryKey_delegate d = new factoryKey_delegate(factoryKey);
                d.Invoke(key);
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //Form_factoryKey frm = new Form_factoryKey(this);
            //frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hashtable dic = PluSoft.Utils.JSON.Decode(this.tb_param.Text.Replace("\r\n", "")) as Hashtable;
            if (dic == null) {
                MessageBox.Show(@"参数不可以为空！");
                return;
            }
            dic.Add("factoryKey", this.tb_factoryKey.Text);
            this.textBox2.Text = DigitalSignature.Sign.getSign(PluSoft.Utils.JSON.Encode(dic));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"LCRiderVerButton！");
            MessageBox.Show(@"警告-LCRiderVerButton！", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Console.WriteLine(1);
            
//            MessageBox.Show()的用法 - Amanda_Yt的博客 - CSDN博客
//            https://blog.csdn.net/Amanda_Yt/article/details/78115660

        }
    }
}
