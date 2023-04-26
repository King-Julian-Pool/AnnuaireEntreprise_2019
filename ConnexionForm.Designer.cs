
namespace AnnuaireEntreprise_2019
{
    partial class ConnexionForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Fermer = new System.Windows.Forms.Button();
            this.button_Valider = new System.Windows.Forms.Button();
            this.textBox_MotDePasse = new System.Windows.Forms.TextBox();
            this.label_MotDePasse = new System.Windows.Forms.Label();
            this.textBox_Identifiant = new System.Windows.Forms.TextBox();
            this.label_Identifiant = new System.Windows.Forms.Label();
            this.label_Erreur = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_Erreur);
            this.panel1.Controls.Add(this.button_Fermer);
            this.panel1.Controls.Add(this.button_Valider);
            this.panel1.Controls.Add(this.textBox_MotDePasse);
            this.panel1.Controls.Add(this.label_MotDePasse);
            this.panel1.Controls.Add(this.textBox_Identifiant);
            this.panel1.Controls.Add(this.label_Identifiant);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 180);
            this.panel1.TabIndex = 0;
            // 
            // button_Fermer
            // 
            this.button_Fermer.Location = new System.Drawing.Point(347, 145);
            this.button_Fermer.Name = "button_Fermer";
            this.button_Fermer.Size = new System.Drawing.Size(75, 23);
            this.button_Fermer.TabIndex = 5;
            this.button_Fermer.Text = "Fermer";
            this.button_Fermer.UseVisualStyleBackColor = true;
            this.button_Fermer.Click += new System.EventHandler(this.button_Click);
            // 
            // button_Valider
            // 
            this.button_Valider.Location = new System.Drawing.Point(243, 145);
            this.button_Valider.Name = "button_Valider";
            this.button_Valider.Size = new System.Drawing.Size(75, 23);
            this.button_Valider.TabIndex = 4;
            this.button_Valider.Text = "Valider";
            this.button_Valider.UseVisualStyleBackColor = true;
            this.button_Valider.Click += new System.EventHandler(this.button_Click);
            // 
            // textBox_MotDePasse
            // 
            this.textBox_MotDePasse.Location = new System.Drawing.Point(149, 74);
            this.textBox_MotDePasse.Name = "textBox_MotDePasse";
            this.textBox_MotDePasse.Size = new System.Drawing.Size(273, 22);
            this.textBox_MotDePasse.TabIndex = 3;
            // 
            // label_MotDePasse
            // 
            this.label_MotDePasse.AutoSize = true;
            this.label_MotDePasse.Location = new System.Drawing.Point(27, 77);
            this.label_MotDePasse.Name = "label_MotDePasse";
            this.label_MotDePasse.Size = new System.Drawing.Size(93, 17);
            this.label_MotDePasse.TabIndex = 2;
            this.label_MotDePasse.Text = "Mot de passe";
            // 
            // textBox_Identifiant
            // 
            this.textBox_Identifiant.Location = new System.Drawing.Point(149, 23);
            this.textBox_Identifiant.Name = "textBox_Identifiant";
            this.textBox_Identifiant.Size = new System.Drawing.Size(273, 22);
            this.textBox_Identifiant.TabIndex = 1;
            // 
            // label_Identifiant
            // 
            this.label_Identifiant.AutoSize = true;
            this.label_Identifiant.Location = new System.Drawing.Point(27, 26);
            this.label_Identifiant.Name = "label_Identifiant";
            this.label_Identifiant.Size = new System.Drawing.Size(69, 17);
            this.label_Identifiant.TabIndex = 0;
            this.label_Identifiant.Text = "Identifiant";
            // 
            // label_Erreur
            // 
            this.label_Erreur.AutoSize = true;
            this.label_Erreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Erreur.ForeColor = System.Drawing.Color.Red;
            this.label_Erreur.Location = new System.Drawing.Point(27, 112);
            this.label_Erreur.Name = "label_Erreur";
            this.label_Erreur.Size = new System.Drawing.Size(0, 15);
            this.label_Erreur.TabIndex = 6;
            // 
            // ConnexionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 180);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ConnexionForm";
            this.ShowInTaskbar = false;
            this.Text = "Connexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_MotDePasse;
        private System.Windows.Forms.Label label_MotDePasse;
        private System.Windows.Forms.TextBox textBox_Identifiant;
        private System.Windows.Forms.Label label_Identifiant;
        private System.Windows.Forms.Button button_Valider;
        private System.Windows.Forms.Button button_Fermer;
        private System.Windows.Forms.Label label_Erreur;
    }
}