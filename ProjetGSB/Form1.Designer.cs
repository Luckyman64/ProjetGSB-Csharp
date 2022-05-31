
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonConsultIncident = new System.Windows.Forms.Button();
            this.ListeBoxMateriels = new System.Windows.Forms.ListBox();
            this.buttonAjoutMat = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxsuppTech = new System.Windows.Forms.ListBox();
            this.ButtonSupprTech = new System.Windows.Forms.Button();
            this.buttonModifTechUtil = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.buttonAjoutMat.Location = new System.Drawing.Point(539, 415);
            this.buttonAjoutMat.Name = "buttonAjoutMat";
            this.buttonAjoutMat.Size = new System.Drawing.Size(129, 46);
            this.buttonAjoutMat.TabIndex = 1;
            this.buttonAjoutMat.Text = "Ajout d\'un matériel";
            this.buttonAjoutMat.UseVisualStyleBackColor = true;
            this.buttonAjoutMat.Click += new System.EventHandler(this.buttonAjoutMat_Click);
            // 
            // tabPage3
            // 
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxsuppTech);
            this.groupBox4.Controls.Add(this.ButtonSupprTech);
            this.groupBox4.Location = new System.Drawing.Point(154, 108);
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
            this.buttonModifTechUtil.Location = new System.Drawing.Point(882, 199);
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox ListeBoxMateriels;
        private System.Windows.Forms.Button buttonAjoutMat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxsuppTech;
        private System.Windows.Forms.Button ButtonSupprTech;
        private System.Windows.Forms.Button buttonModifTechUtil;
    }
}

