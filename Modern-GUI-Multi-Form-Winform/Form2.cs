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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (objeto2.Checked == true)
                label2.Text = "-Samsung";
            else
                label2.Text = " ";

            if (objeto2.Checked == true)
                label3.Text = "-Hisense";
            else
                label3.Text = " ";

            if (objeto2.Checked == true)
                label4.Text = "-LG";
            else
                label4.Text = " ";
        }
    }
}
