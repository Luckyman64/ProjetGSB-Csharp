using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGSB
{
    public partial class SuiviTicket : Form
    {
        public SuiviTicket()
        {
            InitializeComponent();
        }

        private void SuiviTicket_Load(object sender, EventArgs e)
        {
            listBoxSuiviTicket.Text = Convert.ToString(BdGSB.afficherTicket());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
