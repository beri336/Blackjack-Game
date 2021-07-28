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
    public partial class frmHauptmenue : Form
    {
        public frmHauptmenue()
        {
            InitializeComponent();
        }


        private void btnSpielStarten_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmSpielStarten formstart = new frmSpielStarten();
            formstart.Show();
        }

        private void btnHilfe_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmHilfe formhelp = new frmHilfe();
            formhelp.Show();
        }
    }
}
