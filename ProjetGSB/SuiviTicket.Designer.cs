
namespace ProjetGSB
{
    partial class SuiviTicket
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
            this.listBoxSuiviTicket = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxSuiviTicket
            // 
            this.listBoxSuiviTicket.FormattingEnabled = true;
            this.listBoxSuiviTicket.ItemHeight = 16;
            this.listBoxSuiviTicket.Location = new System.Drawing.Point(47, 39);
            this.listBoxSuiviTicket.Name = "listBoxSuiviTicket";
            this.listBoxSuiviTicket.Size = new System.Drawing.Size(189, 212);
            this.listBoxSuiviTicket.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Le ticket est au stade :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "En attente ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SuiviTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSuiviTicket);
            this.Name = "SuiviTicket";
            this.Text = "Suivi des tickets";
            this.Load += new System.EventHandler(this.SuiviTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSuiviTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}