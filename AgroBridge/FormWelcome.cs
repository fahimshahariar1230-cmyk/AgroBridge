using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroBridge
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void GoToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin(this);
            formLogin.Visible = true;
        }

        private void GoToRegistration_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormReg formReg = new FormReg(this);
            formReg.Visible = true;
        }

        private void WelcomeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {

        }

        private void FormWelcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
