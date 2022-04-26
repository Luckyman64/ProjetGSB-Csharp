
namespace ProjetGSB
{
    partial class Detail
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
            this.labelNumTicket = new System.Windows.Forms.Label();
            this.labelObjTicket = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNivUrgence = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDateHeure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° du ticket :";
            // 
            // labelNumTicket
            // 
            this.labelNumTicket.AutoSize = true;
            this.labelNumTicket.Location = new System.Drawing.Point(400, 60);
            this.labelNumTicket.Name = "labelNumTicket";
            this.labelNumTicket.Size = new System.Drawing.Size(0, 17);
            this.labelNumTicket.TabIndex = 1;
            // 
            // labelObjTicket
            // 
            this.labelObjTicket.AutoSize = true;
            this.labelObjTicket.Location = new System.Drawing.Point(400, 111);
            this.labelObjTicket.Name = "labelObjTicket";
            this.labelObjTicket.Size = new System.Drawing.Size(0, 17);
            this.labelObjTicket.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Objet du ticket :";
            // 
            // labelNivUrgence
            // 
            this.labelNivUrgence.AutoSize = true;
            this.labelNivUrgence.Location = new System.Drawing.Point(400, 165);
            this.labelNivUrgence.Name = "labelNivUrgence";
            this.labelNivUrgence.Size = new System.Drawing.Size(0, 17);
            this.labelNivUrgence.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Niveau d\'urgence :";
            // 
            // labelDateHeure
            // 
            this.labelDateHeure.AutoSize = true;
            this.labelDateHeure.Location = new System.Drawing.Point(400, 219);
            this.labelDateHeure.Name = "labelDateHeure";
            this.labelDateHeure.Size = new System.Drawing.Size(0, 17);
            this.labelDateHeure.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date et heure du ticket :";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDateHeure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelNivUrgence);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelObjTicket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNumTicket);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Détails incident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumTicket;
        private System.Windows.Forms.Label labelObjTicket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNivUrgence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDateHeure;
        private System.Windows.Forms.Label label5;
    }
}