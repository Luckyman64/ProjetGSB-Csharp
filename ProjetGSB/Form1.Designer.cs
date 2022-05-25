
namespace ProjetGSB
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSuiviTickets = new System.Windows.Forms.Button();
            this.buttonCreationTicket = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSuppMat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonConsultIncident = new System.Windows.Forms.Button();
            this.ListeBoxMateriels = new System.Windows.Forms.ListBox();
            this.buttonAjoutMat = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxsuppTech = new System.Windows.Forms.ListBox();
            this.ButtonSupprTech = new System.Windows.Forms.Button();
            this.buttonModifTechUtil = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1308, 563);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSuiviTickets);
            this.tabPage1.Controls.Add(this.buttonCreationTicket);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1300, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Acceuil";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSuiviTickets
            // 
            this.buttonSuiviTickets.Location = new System.Drawing.Point(545, 270);
            this.buttonSuiviTickets.Name = "buttonSuiviTickets";
            this.buttonSuiviTickets.Size = new System.Drawing.Size(145, 35);
            this.buttonSuiviTickets.TabIndex = 1;
            this.buttonSuiviTickets.Text = "Suivi tickets";
            this.buttonSuiviTickets.UseVisualStyleBackColor = true;
            this.buttonSuiviTickets.Click += new System.EventHandler(this.buttonSuiviTickets_Click);
            // 
            // buttonCreationTicket
            // 
            this.buttonCreationTicket.Location = new System.Drawing.Point(545, 183);
            this.buttonCreationTicket.Name = "buttonCreationTicket";
            this.buttonCreationTicket.Size = new System.Drawing.Size(145, 34);
            this.buttonCreationTicket.TabIndex = 0;
            this.buttonCreationTicket.Text = "Création ticket";
            this.buttonCreationTicket.UseVisualStyleBackColor = true;
            this.buttonCreationTicket.Click += new System.EventHandler(this.buttonCreationTicket_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonSuppMat);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.buttonAjoutMat);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1300, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Technicien";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSuppMat
            // 
            this.buttonSuppMat.Location = new System.Drawing.Point(853, 422);
            this.buttonSuppMat.Name = "buttonSuppMat";
            this.buttonSuppMat.Size = new System.Drawing.Size(129, 46);
            this.buttonSuppMat.TabIndex = 3;
            this.buttonSuppMat.Text = "Supprimer un matériel";
            this.buttonSuppMat.UseVisualStyleBackColor = true;
            this.buttonSuppMat.Click += new System.EventHandler(this.buttonSuppMat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonConsultIncident);
            this.groupBox3.Controls.Add(this.ListeBoxMateriels);
            this.groupBox3.Location = new System.Drawing.Point(59, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1105, 348);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultation";
            // 
            // buttonConsultIncident
            // 
            this.buttonConsultIncident.Location = new System.Drawing.Point(480, 267);
            this.buttonConsultIncident.Name = "buttonConsultIncident";
            this.buttonConsultIncident.Size = new System.Drawing.Size(129, 47);
            this.buttonConsultIncident.TabIndex = 4;
            this.buttonConsultIncident.Text = "Consultation d\'un incident";
            this.buttonConsultIncident.UseVisualStyleBackColor = true;
            this.buttonConsultIncident.Click += new System.EventHandler(this.buttonConsultIncident_Click);
            // 
            // ListeBoxMateriels
            // 
            this.ListeBoxMateriels.FormattingEnabled = true;
            this.ListeBoxMateriels.ItemHeight = 16;
            this.ListeBoxMateriels.Location = new System.Drawing.Point(64, 37);
            this.ListeBoxMateriels.Name = "ListeBoxMateriels";
            this.ListeBoxMateriels.Size = new System.Drawing.Size(961, 196);
            this.ListeBoxMateriels.TabIndex = 5;
            // 
            // buttonAjoutMat
            // 
            this.buttonAjoutMat.Location = new System.Drawing.Point(251, 422);
            this.buttonAjoutMat.Name = "buttonAjoutMat";
            this.buttonAjoutMat.Size = new System.Drawing.Size(129, 46);
            this.buttonAjoutMat.TabIndex = 1;
            this.buttonAjoutMat.Text = "Ajout d\'un matériel";
            this.buttonAjoutMat.UseVisualStyleBackColor = true;
            this.buttonAjoutMat.Click += new System.EventHandler(this.buttonAjoutMat_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.buttonModifTechUtil);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1300, 534);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Responsable";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Location = new System.Drawing.Point(764, 322);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(486, 168);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Stats utilisateur";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(270, 68);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 16);
            this.label20.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(76, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(178, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Nombre d\'incident déclarés :";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Location = new System.Drawing.Point(764, 36);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(486, 252);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Stats technicien";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(355, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(250, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 16);
            this.label14.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(227, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 16);
            this.label15.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(66, 193);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(298, 28);
            this.label17.TabIndex = 11;
            this.label17.Text = "Nombre de jours moyens d\'intervention :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(66, 126);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(153, 16);
            this.label18.TabIndex = 10;
            this.label18.Text = "Pourcentage en charge :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(66, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 16);
            this.label19.TabIndex = 9;
            this.label19.Text = "Pourcentage résolus :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(27, 322);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(442, 168);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Stats incidents";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(403, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(403, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(219, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 44);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nombre de jours moyens d\'intervention :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Pourcentage en charge :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pourcentage résolus :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pourcentage décalrés :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxsuppTech);
            this.groupBox4.Controls.Add(this.ButtonSupprTech);
            this.groupBox4.Location = new System.Drawing.Point(27, 36);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(442, 252);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Supprimer";
            // 
            // listBoxsuppTech
            // 
            this.listBoxsuppTech.FormattingEnabled = true;
            this.listBoxsuppTech.ItemHeight = 16;
            this.listBoxsuppTech.Location = new System.Drawing.Point(21, 33);
            this.listBoxsuppTech.Name = "listBoxsuppTech";
            this.listBoxsuppTech.Size = new System.Drawing.Size(382, 68);
            this.listBoxsuppTech.TabIndex = 4;
            // 
            // ButtonSupprTech
            // 
            this.ButtonSupprTech.Location = new System.Drawing.Point(91, 147);
            this.ButtonSupprTech.Name = "ButtonSupprTech";
            this.ButtonSupprTech.Size = new System.Drawing.Size(234, 50);
            this.ButtonSupprTech.TabIndex = 3;
            this.ButtonSupprTech.Text = "Supprimer";
            this.ButtonSupprTech.UseVisualStyleBackColor = true;
            this.ButtonSupprTech.Click += new System.EventHandler(this.ButtonSupprTech_Click);
            // 
            // buttonModifTechUtil
            // 
            this.buttonModifTechUtil.Location = new System.Drawing.Point(512, 183);
            this.buttonModifTechUtil.Name = "buttonModifTechUtil";
            this.buttonModifTechUtil.Size = new System.Drawing.Size(170, 74);
            this.buttonModifTechUtil.TabIndex = 2;
            this.buttonModifTechUtil.Text = "Ajouter et modifier un technicien/utilisateur";
            this.buttonModifTechUtil.UseVisualStyleBackColor = true;
            this.buttonModifTechUtil.Click += new System.EventHandler(this.buttonModifTechUtil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 566);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonCreationTicket;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonSuiviTickets;
        private System.Windows.Forms.Button buttonConsultIncident;
        private System.Windows.Forms.Button buttonSuppMat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox ListeBoxMateriels;
        private System.Windows.Forms.Button buttonAjoutMat;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxsuppTech;
        private System.Windows.Forms.Button ButtonSupprTech;
        private System.Windows.Forms.Button buttonModifTechUtil;
    }
}

