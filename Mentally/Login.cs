using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mentally_Library;
using Mentally_DB_Library;

namespace Mentally
{
    public partial class Login : Form
    {
        //Windows untuk login user
        public Login()
        {
            InitializeComponent();
        }

        private bool ValidateUser(string username, string password)
        {
            AccountModel db = new AccountModel();
            var query = from Account in db.Accounts where Account.Username == username && Account.Password == password select Account;
            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text != "" && tb_Password.Text != "")
            {
                if(ValidateUser(tb_Username.Text, tb_Password.Text))
                {
                    MessageBox.Show("Login Succeed");
                    Menu menu = new Menu();
                    menu.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            else
            {
                MessageBox.Show("Please fill your information correctly");
            }
        }

        private void btn_Login_Back_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            this.Hide();
        }

        private void lb_Login_Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }
    }
}
