using FP_Group_27.ERMS;
using FP_Group_27.ERMS.Data;
using FP_Group_27.ERMS.ResOp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FP_Group_27.ERMS.Data.LoginManager;

namespace FP_Group_27
{
    public partial class LoginForm : Form
    {

        private LoginManager man = new LoginManager();
        private bool _showPass = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            _showPass = !_showPass;
            if (_showPass)
            {
                txtPass.PasswordChar = '\0';
            }
            else 
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _user, _pass;

            _user = txtUser.Text;
            _pass = txtPass.Text;

            LoginResult lr;

            try
            {
                lr = man.LoginRequest(_user, _pass);
            }
            catch
            {
                MessageBox.Show("Operation Failed, \nPlease check database connections.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            switch(lr)
            {
                case LoginResult.Factory:
                    MessageBox.Show("Action Not Supported, \nThis application no longer supports the Employee Management.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case LoginResult.Depot:
                    Program.newForm(new ResMainForm());
                    clearControls();
                    break;
                case LoginResult.Unauthorized:
                    MessageBox.Show("Unauthorized Login, \nPlease check your user name or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void clearControls()
        {
            txtUser.Text = "";
            txtPass.Text = "";
            btnLogin.Enabled = false;
        }

        private bool checkEmpty()
        {
            return !string.IsNullOrEmpty(txtUser.Text) && !string.IsNullOrEmpty(txtPass.Text);
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = checkEmpty();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = checkEmpty();
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form f = new Helpform();
            f.ShowDialog();
        }
    }
}
