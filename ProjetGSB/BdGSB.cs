using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGSB
{
    class BdGSB 
    {
        public static void ajoutMateriel(Materiel unMateriel)
        {
            string connString = "Server = 127.0.0.1; Database = gsb; Uid = root; Password=; SSL Mode = None";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            string requeteMat = "INSERT INTO materiel VALUES(@process, @memoire, @disque, @dateAchat, @garantie, @fournisseur)";
            MySqlCommand command1 = conn.CreateCommand();
            command1.CommandTimeout = 200;
            command1.CommandText = requeteMat;
            command1.Parameters.AddWithValue("@process", unMateriel.Processeur);
            command1.Parameters.AddWithValue("@memoire", unMateriel.Memoire);
            command1.Parameters.AddWithValue("@disque", unMateriel.Disque);
            command1.Parameters.AddWithValue("@dateAchat", unMateriel.Date_achat);
            command1.Parameters.AddWithValue("@garantie", unMateriel.Garantie);
            command1.Parameters.AddWithValue("@fournisseur", unMateriel.Fournisseur);
            command1.ExecuteNonQuery();
            conn.Close();
        }
        public static void ajoutTicket(Ticket unTicket)
        {
            string connString = "Server = 127.0.0.1; Database = gsb; Uid = root; Password=; SSL Mode = None";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            string requeteTicket = "INSERT INTO ticket VALUES (@numeroTicket, @objet, @niveauUrgence, @date, @idMat, @matriculePersonnel)";
            MySqlCommand command2 = conn.CreateCommand();
            command2.CommandTimeout = 200;
            command2.CommandText = requeteTicket;
            command2.Parameters.AddWithValue("@numeroTicket", unTicket.NumeroTicket);
            command2.Parameters.AddWithValue("@objet", unTicket.Objet);
            command2.Parameters.AddWithValue("@niveauUrgence", unTicket.NiveauUrgence);
            command2.Parameters.AddWithValue("@date", unTicket.Date);
            command2.Parameters.AddWithValue("@idMat", unTicket.IdMat);
            command2.Parameters.AddWithValue("@matriculePersonnel", unTicket.MatriculePersonnel);
            command2.ExecuteNonQuery();
            conn.Close();
        }
        public static void ajoutTechnicien(Technicien unTechnicien)
        {
            string connString = "Server = 127.0.0.1; Database = gsb; Uid = root; Password=; SSL Mode = None";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            string requeteTechnicien = "INSERT INTO technicien VALUES(@matriculeTechnicien, @nom, @prenom, @adresse, @cp, @ville, @dateEmbaucheTechnicien, @niveauIntervention, @formation, @matriculeResponsable)";
            MySqlCommand command3 = conn.CreateCommand();
            command3.CommandTimeout = 200;
            command3.CommandText = requeteTechnicien;
            command3.Parameters.AddWithValue("@matriculeTechnicien", unTechnicien.Matricule);
            command3.Parameters.AddWithValue("@nom", unTechnicien.Nom);
            command3.Parameters.AddWithValue("@prenom", unTechnicien.Prenom);
            command3.Parameters.AddWithValue("@adresse", unTechnicien.Adresse);
            command3.Parameters.AddWithValue("@cp", unTechnicien.Cp);
            command3.Parameters.AddWithValue("@ville", unTechnicien.Ville);
            command3.Parameters.AddWithValue("@dateEmbaucheTechnicien", unTechnicien.DateEmbauche);
            command3.Parameters.AddWithValue("@niveauIntervention", unTechnicien.NiveauIntervention);
            command3.Parameters.AddWithValue("@formation", unTechnicien.Formation);
            command3.Parameters.AddWithValue("@matriculeResponsable", unTechnicien.MatriculeResponsable);
            command3.ExecuteNonQuery();
            conn.Close();
        }
        public static void ajoutUtilisateur(MembrePersonnel unMembrePersonnel)
        {
            string connString = "Server = 127.0.0.1; Database = gsb; Uid = root; Password=; SSL Mode = None";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            string requeteUtilisateur = "INSERT INTO menbrepersonnel VALUES(@matriculePersonnel, @poste, @nom, @prenom, @dateEmbauchePersonnel, @adresse, @cp, @ville, @idMat, @matriculeResponsable";
            MySqlCommand command4 = conn.CreateCommand();
            command4.CommandText = requeteUtilisateur;
            command4.Parameters.AddWithValue("@matriculePersonnel", unMembrePersonnel.Matricule);
            command4.Parameters.AddWithValue("@poste", unMembrePersonnel.Poste);
            command4.Parameters.AddWithValue("@nom", unMembrePersonnel.Nom);
            command4.Parameters.AddWithValue("@prenom", unMembrePersonnel.Prenom);
            command4.Parameters.AddWithValue("@dateEmbauchePersonnel", unMembrePersonnel.DateEmbauche);
            command4.Parameters.AddWithValue("@adresse", unMembrePersonnel.Adresse);
            command4.Parameters.AddWithValue("@cp", unMembrePersonnel.Cp);
            command4.Parameters.AddWithValue("@ville", unMembrePersonnel.Ville);
            command4.Parameters.AddWithValue("@idMat", unMembrePersonnel.IdMat);
            command4.Parameters.AddWithValue("@matriculeResponsable", unMembrePersonnel.MatriculeResponsable);
            command4.ExecuteNonQuery();
            conn.Close();
        }
        public static void modifTechnicien(Technicien unTechnicien)
        {
            string connString = "Server = 127.0.0.1; Database = gsb; Uid = root; Password=; SSL Mode = None";
            MySqlConnection conn = new MySqlConnection(connString);
                    conn.Open();

                    string requeteModifTech = "UPDATE technicien SET nom = @nom, prenom = @prenom, adresse = @adresse, cp = @cp, ville = @ville, dateEmbaucheTechnicien = @dateEmbaucheTechnicien, niveauIntervention = @niveauIntervention, formation = @formation, matriculeResponsable = @matriculeResponsable WHERE nom=" + unTechnicien.Nom;
                    MySqlCommand command5 = conn.CreateCommand();
                    command5.CommandText = requeteModifTech;
                    command5.Parameters.AddWithValue("@nom", unTechnicien.Nom);
                    command5.Parameters.AddWithValue("@prenom", unTechnicien.Prenom);
            command5.Parameters.AddWithValue("@adresse", unTechnicien.Adresse);
            command5.Parameters.AddWithValue("@cp", unTechnicien.Cp);
            command5.Parameters.AddWithValue("@ville", unTechnicien.Ville);
            command5.Parameters.AddWithValue("@dateEmbaucheTechnicien", unTechnicien.DateEmbauche);
            command5.Parameters.AddWithValue("@niveauIntervention", unTechnicien.NiveauIntervention);
            command5.Parameters.AddWithValue("@formation", unTechnicien.Formation);
            command5.Parameters.AddWithValue("@matriculeResponsable", unTechnicien.Matricule);
            conn.Close();
        }
        public static void modifResponsable(Responsable unResponsable)
        {
            string connString = "Server = 127.0.0.1; Database = gsb; Uid = root; Password=; SSL Mode = None";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            string requeteModifTech = "UPDATE responsable SET nom = @nom, prenom = @prenom, adresse = @adresse, cp = @cp, ville = @ville, dateEmbaucheTechnicien = @dateEmbaucheTechnicien, matriculeResponsable = @matriculeResponsable WHERE nom=" + unResponsable.Nom;
            MySqlCommand command8 = conn.CreateCommand();
            command8.CommandText = requeteModifTech;
            command8.Parameters.AddWithValue("@nom", unResponsable.Nom);
            command8.Parameters.AddWithValue("@prenom", unResponsable.Prenom);
            command8.Parameters.AddWithValue("@adresse", unResponsable.Adresse);
            command8.Parameters.AddWithValue("@cp", unResponsable.Cp);
            command8.Parameters.AddWithValue("@ville", unResponsable.Ville);
            command8.Parameters.AddWithValue("@dateEmbaucheTechnicien", unResponsable.DateEmbauche);
            command8.Parameters.AddWithValue("@matriculeResponsable", unResponsable.Matricule);
            conn.Close();
        }
        public static void modifUtilisateur(MembrePersonnel unUtilisateur)
        {
            string connString = "Server = 127.0.0.1; Database = gsb; Uid = root; Password=; SSL Mode = None";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            string requeteModifTech = "UPDATE membrepersonnel SET nom = @nom, prenom = @prenom, adresse = @adresse, cp = @cp, ville = @ville, dateEmbaucheTechnicien = @dateEmbaucheTechnicien, matriculeResponsable = @matriculeResponsable WHERE nom=" + unUtilisateur.Nom;
            MySqlCommand command9 = conn.CreateCommand();
            command9.CommandText = requeteModifTech;
            command9.Parameters.AddWithValue("@nom", unUtilisateur.Nom);
            command9.Parameters.AddWithValue("@prenom", unUtilisateur.Prenom);
            command9.Parameters.AddWithValue("@adresse", unUtilisateur.Adresse);
            command9.Parameters.AddWithValue("@cp", unUtilisateur.Cp);
            command9.Parameters.AddWithValue("@ville", unUtilisateur.Ville);
            command9.Parameters.AddWithValue("@dateEmbaucheTechnicien", unUtilisateur.DateEmbauche);
            command9.Parameters.AddWithValue("@matriculeResponsable", unUtilisateur.Matricule);
            conn.Close();
        }
        public static void supprTechnicien(int rang)
        {
            string connString = "Server = 127.0.0.1; Database = gsb; Uid = root; Password=; SSL Mode = None";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            string requeteSuppTech = "DELETE FROM technicien WHERE id=" + rang;

            MySqlCommand command6 = conn.CreateCommand();
            command6.CommandText = requeteSuppTech;
            command6.ExecuteNonQuery();
            conn.Close();
        }
        public static void supprUtilisateur(int rang)
        {
            string connString = "Server = 127.0.0.1; Database = gsb; Uid = root; Password=; SSL Mode = None";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            string requeteSuppTech = "DELETE FROM membrepersonnel WHERE id=" + rang;

            MySqlCommand command6 = conn.CreateCommand();
            command6.CommandText = requeteSuppTech;
            command6.ExecuteNonQuery();
            conn.Close();
        }
        public static void supprMateriel(int rang)
        {
            string connString = "Server = 127.0.0.1; Database = gsb; Uid = root; Password=; SSL Mode = None";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            string requeteSuppTech = "DELETE FROM materiel WHERE id=" + rang;

            MySqlCommand command9 = conn.CreateCommand();
            command9.CommandText = requeteSuppTech;
            command9.ExecuteNonQuery();
            conn.Close();
        }
        public static void afficher(Technicien unTechnicien)
        {
            string connString = "Server = 127.0.0.1; Database = gsb; Uid = root; Password=; SSL Mode = None";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            string requeteAfficheTech = "SELECT * FROM technicien WHERE matriculeTechnicien=" + unTechnicien.Matricule;

            MySqlCommand command7 = conn.CreateCommand();
            command7.CommandText = requeteAfficheTech;
            command7.ExecuteNonQuery();
            conn.Close ();
        }

        public static void afficherTechniciens()
        {
            string connString = "Server = 127.0.0.1; Database = gsb; Uid = root; Password=; SSL Mode = None";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            string requeteAfficheTech = "SELECT * FROM technicien ";

            MySqlCommand command8 = conn.CreateCommand();
            command8.CommandText = requeteAfficheTech;
            command8.ExecuteNonQuery();
            conn.Close();
        }

        public static void afficherTicket()
        {
            /*string connString = "Server=127.0.0.1; Database = gsb; Uid = root; Password=; SSL Mode = None";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open ();

            string requeteAffichTicket = "SELECT numeroTicket FROM Ticket";

            MySqlCommand command9 = conn.CreateCommand();
            command9.CommandText = requeteAffichTicket;
            command9.ExecuteNonQuery();
            conn.Close();*/
            

        }
    }
}
