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
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("Server=127.0.0.1; Database = gsb; Uid = root; Password=; SSL Mode = None");
        MySqlDataReader dr;
        MySqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }
        List<Technicien> lesTechniciens;
        List<Responsable> lesResponsables;
        List<Materiel> lesMaterieles;
        private void Form1_Load(object sender, EventArgs e)
        {
            lesResponsables = new List<Responsable>();
            lesTechniciens = new List<Technicien>();
            lesMaterieles = new List<Materiel>();

            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT matriculeTechnicien FROM technicien";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBoxsuppTech.Items.Add(dr["matriculeTechnicien"]);
            }
            con.Close();

            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT numeroTicket FROM ticket";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListeBoxMateriels.Items.Add(dr["numeroTicket"]);
            }
            con.Close();


        }

        private void buttonCreationTicket_Click(object sender, EventArgs e)
        {
            CreationTicket creationTicket = new CreationTicket();
            creationTicket.Show();
        }

        private void buttonSuiviTickets_Click(object sender, EventArgs e)
        {
            SuiviTicket suiviTicket = new SuiviTicket();
            suiviTicket.Show();
        }

        private void buttonAjoutMat_Click(object sender, EventArgs e)
        {
            AjoutMat ajoutMat = new AjoutMat();
            ajoutMat.Show();
        }

        private void buttonModifTechUtil_Click(object sender, EventArgs e)
        {
            AjoutModifTechnicienUtilisateur ajoutModifTechnicienUtilisateur = new AjoutModifTechnicienUtilisateur();
            ajoutModifTechnicienUtilisateur.Show();
        }

        private void ButtonSupprTech_Click(object sender, EventArgs e)
        {
            int rangT;
            rangT = listBoxsuppTech.SelectedIndex;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM technicien";
            dr = cmd.ExecuteReader();
            rangT = rangT + 1;
            while (dr.Read())
            {
                if (rangT == Convert.ToInt32(dr["id"]))
                {
                    BdGSB.supprTechnicien(rangT);
                }
            }
        }

        private void buttonConsultIncident_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(ListeBoxMateriels.SelectedIndex.ToString());
            Detail detail = new Detail(id);
            detail.Show();
        }
    }
}
