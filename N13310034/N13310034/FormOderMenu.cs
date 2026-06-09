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
    public partial class FormOderMenu : Form
    {
        public FormOderMenu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void btn_SendOder_Click(object sender, EventArgs e)
        {
            foreach(Control C in panel1. Controls )
            {
                if(C is CheckBox)
                {
                    CheckBox temp = (CheckBox)C;
                    if(temp.Checked==true )
                    {
                        MessageBox.Show(temp.Text);
                    }
                }
            }
        }
    }
}
