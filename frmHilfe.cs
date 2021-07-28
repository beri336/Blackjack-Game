using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack_Spiel
{
    public partial class frmHilfe : Form
    {
        public frmHilfe()
        {
            InitializeComponent();
        }

        private void btnZuruekZumMenue_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHauptmenue frm = new frmHauptmenue();
            frm.Show();
        }
    }
}
