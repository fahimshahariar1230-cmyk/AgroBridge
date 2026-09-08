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
    public partial class FormAdminHome : Form
    {
        private FormLogin formLogin;
        public FormAdminHome()
        {
            InitializeComponent();
        }

        public FormAdminHome(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }

        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegisteredUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegisteredUsers(this).Show();
        }

        private void FormAdminHome_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellsReport sellsReport = new SellsReport();
            sellsReport.Show();
        }
    }
}
