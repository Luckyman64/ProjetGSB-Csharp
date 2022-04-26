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
    public partial class CreationTicket : Form
    {
        public CreationTicket()
        {
            InitializeComponent();
        }

        List<Ticket> lesTickets;

        private void CreationTicket_Load(object sender, EventArgs e)
        {
            lesTickets = new List<Ticket>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string niveauU;
            niveauU = "";
            if (radioButton1.Checked)
                niveauU = "Enregistrer";
            else
                if (radioButton2.Checked)
                niveauU = "En cours de traitement";
            else
                if (radioButton3.Checked)
                niveauU = "Resolu";
            else
                if (radioButton4.Checked)
                niveauU = "cloture";
            Ticket unTicket = new Ticket(textBoxDescription.Text, niveauU, dateTimePicker1.Text, textBoxM.Text, textBoxU.Text);
            BdGSB.ajoutTicket(unTicket);
            lesTickets.Add(unTicket);
        }

        
    }
}
