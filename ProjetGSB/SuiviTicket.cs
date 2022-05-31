using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetGSB
{
    public partial class SuiviTicket : Form
    {
        MySqlConnection con = new MySqlConnection("Server=127.0.0.1; Database = gsb; Uid = root; Password=; SSL Mode = None");
        MySqlDataReader dr;
        MySqlCommand cmd;
        public SuiviTicket()
        {
            InitializeComponent();
        }

        private void SuiviTicket_Load(object sender, EventArgs e)
        {
            listBoxSuiviTicket.Text = Convert.ToString(BdGSB.afficherTicket());

            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT numeroTicket FROM Ticket";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBoxSuiviTicket.Items.Add(dr["numeroTicket"]);
            }
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void buttonActu_Click_1(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(listBoxSuiviTicket.SelectedIndex.ToString());
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM ticket";
            dr = cmd.ExecuteReader();
            id = id + 1;
            while (dr.Read())
            {
                if (id == Convert.ToInt32(dr["numeroTicket"]))
                {
                    label2.Text = Convert.ToString(dr["niveauUrgence"]);
                }
            }
            con.Close();
        }
    }
}
