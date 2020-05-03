using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mentally_DB_Library;
using System.Data.Entity;
namespace Mentally
{
    public partial class ShowHistory : Form
    {
        //Windows untuk menampilkan hasil checkup user yang pernah dilakukan
        public ShowHistory()
        {
            InitializeComponent();
        }

        private void btn_showHistory_Click(object sender, EventArgs e)
        {
            AccountModel db = new AccountModel();
            db.openConnection();
            dtgView.DataSource = db.Read();
        }

        private void btn_Back_History_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
