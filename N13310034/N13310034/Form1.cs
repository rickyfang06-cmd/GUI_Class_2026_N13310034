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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Change_Label_Click(object sender, EventArgs e)
        {
            lab_ChangeLabel.Text="我已經被按過了";
        }

        private void btn_Counter_Click(object sender, EventArgs e)
        {
            String count=lab__Counter.Text;
            int sum=Int32.Parse(count)+1;
            lab__Counter.Text=sum.ToString();
        }

        private void btnBigger_Click(object sender, EventArgs e)
        {
            new FormBtnBigger().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str=textBox1.Text;
            label2.Text=str;
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            new FormCalculator().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new 期中考_攝氏轉華氏().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FormTimer().Show();
        }
    }
}
