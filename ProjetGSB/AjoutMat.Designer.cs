
namespace ProjetGSB
{
    partial class AjoutMat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBProcesseur = new System.Windows.Forms.TextBox();
            this.TBMemoire = new System.Windows.Forms.TextBox();
            this.TBDisque = new System.Windows.Forms.TextBox();
            this.TBDateAchat = new System.Windows.Forms.TextBox();
            this.TBGarantie = new System.Windows.Forms.TextBox();
            this.TBFournisseur = new System.Windows.Forms.TextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.TBId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Processeur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Memoire :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Disque :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date d\'achat :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Garantie :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fournisseur :";
            // 
            // TBProcesseur
            // 
            this.TBProcesseur.Location = new System.Drawing.Point(161, 59);
            this.TBProcesseur.Name = "TBProcesseur";
            this.TBProcesseur.Size = new System.Drawing.Size(100, 22);
            this.TBProcesseur.TabIndex = 6;
            // 
            // TBMemoire
            // 
            this.TBMemoire.Location = new System.Drawing.Point(161, 97);
            this.TBMemoire.Name = "TBMemoire";
            this.TBMemoire.Size = new System.Drawing.Size(100, 22);
            this.TBMemoire.TabIndex = 7;
            // 
            // TBDisque
            // 
            this.TBDisque.Location = new System.Drawing.Point(161, 139);
            this.TBDisque.Name = "TBDisque";
            this.TBDisque.Size = new System.Drawing.Size(100, 22);
            this.TBDisque.TabIndex = 8;
            // 
            // TBDateAchat
            // 
            this.TBDateAchat.Location = new System.Drawing.Point(161, 181);
            this.TBDateAchat.Name = "TBDateAchat";
            this.TBDateAchat.Size = new System.Drawing.Size(100, 22);
            this.TBDateAchat.TabIndex = 9;
            // 
            // TBGarantie
            // 
            this.TBGarantie.Location = new System.Drawing.Point(161, 223);
            this.TBGarantie.Name = "TBGarantie";
            this.TBGarantie.Size = new System.Drawing.Size(100, 22);
            this.TBGarantie.TabIndex = 10;
            // 
            // TBFournisseur
            // 
            this.TBFournisseur.Location = new System.Drawing.Point(161, 260);
            this.TBFournisseur.Name = "TBFournisseur";
            this.TBFournisseur.Size = new System.Drawing.Size(100, 22);
            this.TBFournisseur.TabIndex = 11;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(296, 49);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(114, 86);
            this.buttonAjouter.TabIndex = 12;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(296, 181);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(114, 86);
            this.buttonAnnuler.TabIndex = 13;
            this.buttonAnnuler.Text = "Annuler/retour au menus";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // TBId
            // 
            this.TBId.Location = new System.Drawing.Point(161, 22);
            this.TBId.Name = "TBId";
            this.TBId.Size = new System.Drawing.Size(100, 22);
            this.TBId.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Id :";
            // 
            // AjoutMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 318);
            this.Controls.Add(this.TBId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.TBFournisseur);
            this.Controls.Add(this.TBGarantie);
            this.Controls.Add(this.TBDateAchat);
            this.Controls.Add(this.TBDisque);
            this.Controls.Add(this.TBMemoire);
            this.Controls.Add(this.TBProcesseur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjoutMat";
            this.Text = "Ajout d\'un matériel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBProcesseur;
        private System.Windows.Forms.TextBox TBMemoire;
        private System.Windows.Forms.TextBox TBDisque;
        private System.Windows.Forms.TextBox TBDateAchat;
        private System.Windows.Forms.TextBox TBGarantie;
        private System.Windows.Forms.TextBox TBFournisseur;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.TextBox TBId;
        private System.Windows.Forms.Label label7;
    }
}