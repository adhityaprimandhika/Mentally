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

namespace Mentally
{
    public partial class Menu : Form
    {
        //Windows yang berisi Menu aplikasi Mentally
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Menu_Motivation_Click(object sender, EventArgs e)
        {
            Motivation motivation = new Motivation();
            motivation.Show();
            this.Hide();
        }

        private void btn_Menu_Check_Click(object sender, EventArgs e)
        {
            CheckUp checkUp = new CheckUp();
            checkUp.Show();
            this.Hide();
        }

        private void btn_Menu_History_Click(object sender, EventArgs e)
        {
            ShowHistory history = new ShowHistory();
            history.Show();
            this.Hide();
        }
    }
}
