using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernGUI_V3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (objeto1.Checked == true)
                label2.Text = "-Lucas Brito";
            else
                label2.Text = " ";

            if (objeto1.Checked == true)
                label3.Text = "-Federico Villagra";
            else
                label3.Text = " ";

            if (objeto1.Checked == true)
                label4.Text = "-Roman Barros";
            else
                label4.Text = " ";
        }
    }
}
