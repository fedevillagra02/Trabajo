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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (objeto4.Checked == true)
                label2.Text = "- 3 televisores samsung,Villagra Federico ";
            else
                label2.Text = " ";

            if (objeto4.Checked == true)
                label3.Text = "-2 licuadoras LG,Villagra Federico";
            else
                label3.Text = " ";

            if (objeto4.Checked == true)
                label4.Text = "-4 Lamparas Hisense,Lucas Brito ";
            else
                label4.Text = " ";
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
