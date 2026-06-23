using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if(!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv","時間,主食,配菜,飲品,甜點\n",Encoding.UTF8);
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
            DateTime currentDataime = DateTime.Now;
            string formattedDateTime = currentDataime.ToString("yyyy/MM/dd HH:mm:ss");

            string food = "", sideFood = "", dessert = "", drink = "";

            foreach (Control C in panel1. Controls )//主食區
            {
                if(C is CheckBox)
                {
                    CheckBox temp = (CheckBox)C;
                    if(temp.Checked==true )
                    {
                        //MessageBox.Show(temp.Text);
                        food+=""+temp.Text;
                    }
                }
            }
            foreach (Control C in panel2.Controls)//配菜區
            {
                if (C is CheckBox)
                {
                    CheckBox temp = (CheckBox)C;
                    if (temp.Checked==true)
                    {
                        //MessageBox.Show(temp.Text);
                        sideFood+=""+temp.Text;
                    }
                }
            }
            foreach (Control C in panel3.Controls)//甜點區
            {
                if (C is CheckBox)
                {
                    CheckBox temp = (CheckBox)C;
                    if (temp.Checked==true)
                    {
                        //MessageBox.Show(temp.Text);
                        dessert+=" "+temp.Text;
                    }
                }
            }
            foreach (Control C in panel4.Controls)//飲料區
            {
                if (C is CheckBox)
                {
                    CheckBox temp = (CheckBox)C;
                    if (temp.Checked==true)
                    {
                        //MessageBox.Show(temp.Text);
                        drink+=" "+temp.Text;
                    }
                }
            }
            File.AppendAllText("OrderData.csv",formattedDateTime+","+food+","+sideFood+","+drink+","+dessert);
            MessageBox.Show("點餐完成!製作中請稍後!");
        }
    }
}
