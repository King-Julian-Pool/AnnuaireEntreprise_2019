
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
            this.label_Identifiant = new System.Windows.Forms.Label();
            this.textBox_Identifiant = new System.Windows.Forms.TextBox();
            this.label_MotDePasse = new System.Windows.Forms.Label();
            this.textBox_MotDePasse = new System.Windows.Forms.TextBox();
            this.button_Valider = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Valider);
            this.panel1.Controls.Add(this.textBox_MotDePasse);
            this.panel1.Controls.Add(this.label_MotDePasse);
            this.panel1.Controls.Add(this.textBox_Identifiant);
            this.panel1.Controls.Add(this.label_Identifiant);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 135);
            this.panel1.TabIndex = 0;
            // 
            // label_Identifiant
            // 
            this.label_Identifiant.AutoSize = true;
            this.label_Identifiant.Location = new System.Drawing.Point(27, 29);
            this.label_Identifiant.Name = "label_Identifiant";
            this.label_Identifiant.Size = new System.Drawing.Size(69, 17);
            this.label_Identifiant.TabIndex = 0;
            this.label_Identifiant.Text = "Identifiant";
            // 
            // textBox_Identifiant
            // 
            this.textBox_Identifiant.Location = new System.Drawing.Point(149, 23);
            this.textBox_Identifiant.Name = "textBox_Identifiant";
            this.textBox_Identifiant.Size = new System.Drawing.Size(197, 22);
            this.textBox_Identifiant.TabIndex = 1;
            // 
            // label_MotDePasse
            // 
            this.label_MotDePasse.AutoSize = true;
            this.label_MotDePasse.Location = new System.Drawing.Point(27, 74);
            this.label_MotDePasse.Name = "label_MotDePasse";
            this.label_MotDePasse.Size = new System.Drawing.Size(93, 17);
            this.label_MotDePasse.TabIndex = 2;
            this.label_MotDePasse.Text = "Mot de passe";
            // 
            // textBox_MotDePasse
            // 
            this.textBox_MotDePasse.Location = new System.Drawing.Point(149, 74);
            this.textBox_MotDePasse.Name = "textBox_MotDePasse";
            this.textBox_MotDePasse.Size = new System.Drawing.Size(197, 22);
            this.textBox_MotDePasse.TabIndex = 3;
            // 
            // button_Valider
            // 
            this.button_Valider.Location = new System.Drawing.Point(255, 102);
            this.button_Valider.Name = "button_Valider";
            this.button_Valider.Size = new System.Drawing.Size(75, 23);
            this.button_Valider.TabIndex = 4;
            this.button_Valider.Text = "Valider";
            this.button_Valider.UseVisualStyleBackColor = true;
            this.button_Valider.Click += new System.EventHandler(this.button_Valider_Click);
            // 
            // ConnexionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 135);
            this.Controls.Add(this.panel1);
            this.Name = "ConnexionForm";
            this.Text = "ConnexionForm";
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
    }
}