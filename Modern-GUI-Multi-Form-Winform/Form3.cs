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
    public partial class Form3 : Form
    {
        
        public Form3()
        {    
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            this.Close();
        }

        private void objeto3_CheckedChanged(object sender, EventArgs e)
        {

            if (objeto3.Checked == true)
            {
                label1.Text = "-Licuadora $250 ";
                label5.Image = imageList1.Images[0];
            }
            else { 
                    label1.Text = " ";
                label5.Image = imageList1.Images[null];
            }

            if (objeto3.Checked == true)
            {
                label2.Text = "-Televisor $450";
                label6.Image = imageList1.Images[1];
            }
            else
            {
                label2.Text = " ";
                label6.Image = imageList1.Images[null];
            }

            if (objeto3.Checked == true)
            {
                label4.Text = "-Lampara $600";
                label7.Image = imageList1.Images[2];
            }

            else
            {
                label4.Text = " ";
                label7.Image = imageList1.Images[null];
            }
                
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
