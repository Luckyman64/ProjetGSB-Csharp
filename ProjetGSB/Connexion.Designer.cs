
namespace ProjetGSB
{
    partial class Connexion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxMdpConn = new System.Windows.Forms.TextBox();
            this.textBoxIdConn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonTech = new System.Windows.Forms.RadioButton();
            this.radioButtonResp = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonResp);
            this.groupBox1.Controls.Add(this.radioButtonTech);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBoxMdpConn);
            this.groupBox1.Controls.Add(this.textBoxIdConn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 371);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connexion";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(128, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Connexion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxMdpConn
            // 
            this.textBoxMdpConn.Location = new System.Drawing.Point(210, 99);
            this.textBoxMdpConn.Name = "textBoxMdpConn";
            this.textBoxMdpConn.Size = new System.Drawing.Size(100, 22);
            this.textBoxMdpConn.TabIndex = 3;
            // 
            // textBoxIdConn
            // 
            this.textBoxIdConn.Location = new System.Drawing.Point(210, 54);
            this.textBoxIdConn.Name = "textBoxIdConn";
            this.textBoxIdConn.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdConn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant :";
            // 
            // radioButtonTech
            // 
            this.radioButtonTech.AutoSize = true;
            this.radioButtonTech.Location = new System.Drawing.Point(41, 168);
            this.radioButtonTech.Name = "radioButtonTech";
            this.radioButtonTech.Size = new System.Drawing.Size(98, 21);
            this.radioButtonTech.TabIndex = 2;
            this.radioButtonTech.TabStop = true;
            this.radioButtonTech.Text = "Technicien";
            this.radioButtonTech.UseVisualStyleBackColor = true;
            // 
            // radioButtonResp
            // 
            this.radioButtonResp.AutoSize = true;
            this.radioButtonResp.Location = new System.Drawing.Point(200, 168);
            this.radioButtonResp.Name = "radioButtonResp";
            this.radioButtonResp.Size = new System.Drawing.Size(112, 21);
            this.radioButtonResp.TabIndex = 5;
            this.radioButtonResp.TabStop = true;
            this.radioButtonResp.Text = "Responsable";
            this.radioButtonResp.UseVisualStyleBackColor = true;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 391);
            this.Controls.Add(this.groupBox1);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxMdpConn;
        private System.Windows.Forms.TextBox textBoxIdConn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonResp;
        private System.Windows.Forms.RadioButton radioButtonTech;
    }
}