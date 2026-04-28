using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N13310034
{
    public partial class 期中考_攝氏轉華氏 : Form
    {
        public 期中考_攝氏轉華氏()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double C=double.Parse(textBox1.Text);
            double F = C*(9/5.0)+32;
            label3.Text=F.ToString();
        }
    }
}
