using MySql.Data.MySqlClient;
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
    public partial class Achats_Materiels : Form
    {
        private MySqlDataReader dr;

        public Achats_Materiels()
        {
            InitializeComponent();
        }

        private void buttonAffichAchat_Click(object sender, EventArgs e)
        {
            AchatMateriel unAchatMateriel = new AchatMateriel(Convert.ToInt32(TBAjoutId.Text), TBAjoutType.Text, TBAjoutCar.Text, TBAjoutLieu.Text, TBAjoutPrix.Text, TBAjoutDate.Text);
            BdGSB.ajouterAchat(unAchatMateriel);
        }

        private void Achats_Materiels_Load(object sender, EventArgs e)
        {
            dr = BdGSB.afficherTypeMat();
            while (dr.Read())
            {
                comboBoxType.Items.Add(dr["typeMat"]);
            }

            dr = BdGSB.afficherLieu();
            while (dr.Read())
            {
                comboBoxLieu.Items.Add(dr["lieuVente"]);
            }
        }

        private void buttonAffichType_Click(object sender, EventArgs e)
        {
            String typeSelectionner;
            typeSelectionner = Convert.ToString(comboBoxType.SelectedItem);
            label8.Text = typeSelectionner;
            dr = BdGSB.afficherTypeAll(typeSelectionner);
            while (dr.Read())
            {
                listBox1.Items.Add(dr["id"]);
            }
        }

        private void buttonAffichLieu_Click(object sender, EventArgs e)
        {
            String lieuSelectionner;
            lieuSelectionner = Convert.ToString(comboBoxLieu.SelectedItem);
            label9.Text = lieuSelectionner;
            dr = BdGSB.afficherLieuAll(lieuSelectionner);
            while (dr.Read())
            {
                listBox2.Items.Add(dr["id"]);
            }
        }
    }
}
