using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mentally_DB_Library;
using Mentally_Library;

namespace Mentally
{
    public partial class Register : Form
    {
        //Windows untuk melakukan registrasi user pertama kali
        Account account;
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterAccount()
        {
            if (tb_Email.Text != "" && tb_Password.Text != "" && tb_Username.Text != "" && tb_Nama.Text != "")
            {
                using (var db = new AccountModel())
                {
                    account = new Account
                    {
                        Email = tb_Email.Text,
                        Password = tb_Password.Text,
                        Username = tb_Username.Text,
                        Nama = tb_Nama.Text
                    };
                    db.Accounts.Add(account);
                    db.SaveChanges();
                    MessageBox.Show("Account created");
                }
            }
            else
            {
                MessageBox.Show("Please fill your information correctly");
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            RegisterAccount();
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btn_Register_Back_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            this.Hide();
        }
    }
}
