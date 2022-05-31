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
    public partial class Detail : Form
    {
        MySqlConnection con = new MySqlConnection("Server=127.0.0.1; Database = gsb; Uid = root; Password=; SSL Mode = None");
        MySqlDataReader dr;
        MySqlCommand cmd;
        private int id;
        public Detail(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            id = id + 1;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Ticket";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (id == Convert.ToInt32(dr["numeroTicket"]))
                {
                    labelNumTicket.Text = Convert.ToString(dr["numeroTicket"]);
                    labelObjTicket.Text = Convert.ToString(dr["objet"]);
                    labelNivUrgence.Text = Convert.ToString(dr["niveauUrgence"]);
                    labelDateHeure.Text = Convert.ToString(dr["date"]);
                }
                    
            }
            con.Close();
        }
    }
}
