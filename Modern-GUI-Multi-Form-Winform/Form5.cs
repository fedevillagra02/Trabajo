using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace ModernGUI_V3
{
    public partial class Form5 : Form
    {
        
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text == "admin" && txtpassword.Text == "admin")
            {
                new FormPrincipal().Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("El usuario o contraseña son incorrectas");
              
                txtUserName.Clear();    
                txtpassword.Clear();

                
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtpassword.Text == "CONTRASEÑA")
            {
                txtpassword.Text = "";
            }
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "USUARIO")
            {
                txtUserName.Text = "";
            }
        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
           if(txtpassword.Text == "CONTRASEÑA")
            {
                txtpassword.Text = "";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
