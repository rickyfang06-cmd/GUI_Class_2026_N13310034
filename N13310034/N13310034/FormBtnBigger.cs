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
    public partial class FormBtnBigger : Form
    {
        public FormBtnBigger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int height = button1.Height;
            int width = button1.Width;
            button1.Size=new Size(width+10, height+10);
        }
    }
}
