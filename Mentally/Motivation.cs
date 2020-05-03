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
    public partial class Motivation : Form
    {
        //Windows untuk memberikan motivasi kepada user
        public Motivation()
        {
            InitializeComponent();
        }

        private void btn_Motivation_Click(object sender, EventArgs e)
        {
            Motivate motivate = new Motivate();
            lb_Motivation.Text = motivate.showMotivasi(motivate.kalimatMotivasi);
        }

        private void btn_Motivation_Back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
