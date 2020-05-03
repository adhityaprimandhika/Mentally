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
    public partial class Solution : Form
    {
        //Windows untuk memberikan solusi untuk gangguan kesehatan mental dari user
        private string gangguan = "";

        public Solution(string Gangguan)
        {
            InitializeComponent();
            string pilihan = Gangguan;
            GiveSolution giveSolution = new GiveSolution(pilihan);
            lb_Solusi_1.Text = giveSolution.solusi_1;
            lb_Solusi_2.Text = giveSolution.solusi_2;
            lb_Solusi_3.Text = giveSolution.solusi_3;
            lb_Solusi_4.Text = giveSolution.solusi_4;
            gangguan = pilihan;
        }

        private void UploadData()
        {
            History history;
            using (var db = new AccountModel())
            {
                history = new History
                {
                    Gangguan = gangguan,
                    Solusi_1 = lb_Solusi_1.Text,
                    Solusi_2 = lb_Solusi_2.Text,
                    Solusi_3 = lb_Solusi_3.Text,
                    Solusi_4 = lb_Solusi_4.Text
                };
                db.Histories.Add(history);
                db.SaveChanges();
                MessageBox.Show("Saved");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            UploadData();
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
