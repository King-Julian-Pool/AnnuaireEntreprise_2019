
namespace AnnuaireEntreprise_2019
{
    partial class Annuaire
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox_Service = new System.Windows.Forms.CheckedListBox();
            this.label_Service = new System.Windows.Forms.Label();
            this.checkedListBox_Site = new System.Windows.Forms.CheckedListBox();
            this.label_Site = new System.Windows.Forms.Label();
            this.textBox_NomPrenom = new System.Windows.Forms.TextBox();
            this.label_NomPrenom = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(786, 415);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox_Service);
            this.groupBox1.Controls.Add(this.label_Service);
            this.groupBox1.Controls.Add(this.checkedListBox_Site);
            this.groupBox1.Controls.Add(this.label_Site);
            this.groupBox1.Controls.Add(this.textBox_NomPrenom);
            this.groupBox1.Controls.Add(this.label_NomPrenom);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 415);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // checkedListBox_Service
            // 
            this.checkedListBox_Service.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBox_Service.FormattingEnabled = true;
            this.checkedListBox_Service.Location = new System.Drawing.Point(3, 180);
            this.checkedListBox_Service.Name = "checkedListBox_Service";
            this.checkedListBox_Service.Size = new System.Drawing.Size(256, 89);
            this.checkedListBox_Service.TabIndex = 5;
            // 
            // label_Service
            // 
            this.label_Service.AutoSize = true;
            this.label_Service.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Service.Location = new System.Drawing.Point(3, 163);
            this.label_Service.Name = "label_Service";
            this.label_Service.Size = new System.Drawing.Size(55, 17);
            this.label_Service.TabIndex = 4;
            this.label_Service.Text = "Service";
            // 
            // checkedListBox_Site
            // 
            this.checkedListBox_Site.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBox_Site.FormattingEnabled = true;
            this.checkedListBox_Site.Location = new System.Drawing.Point(3, 74);
            this.checkedListBox_Site.Name = "checkedListBox_Site";
            this.checkedListBox_Site.Size = new System.Drawing.Size(256, 89);
            this.checkedListBox_Site.TabIndex = 3;
            // 
            // label_Site
            // 
            this.label_Site.AutoSize = true;
            this.label_Site.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Site.Location = new System.Drawing.Point(3, 57);
            this.label_Site.Name = "label_Site";
            this.label_Site.Size = new System.Drawing.Size(32, 17);
            this.label_Site.TabIndex = 2;
            this.label_Site.Text = "Site";
            // 
            // textBox_NomPrenom
            // 
            this.textBox_NomPrenom.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_NomPrenom.Location = new System.Drawing.Point(3, 35);
            this.textBox_NomPrenom.Name = "textBox_NomPrenom";
            this.textBox_NomPrenom.Size = new System.Drawing.Size(256, 22);
            this.textBox_NomPrenom.TabIndex = 1;
            // 
            // label_NomPrenom
            // 
            this.label_NomPrenom.AutoSize = true;
            this.label_NomPrenom.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_NomPrenom.Location = new System.Drawing.Point(3, 18);
            this.label_NomPrenom.Name = "label_NomPrenom";
            this.label_NomPrenom.Size = new System.Drawing.Size(90, 17);
            this.label_NomPrenom.TabIndex = 0;
            this.label_NomPrenom.Text = "Nom/Prénom";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(520, 415);
            this.splitContainer2.SplitterDistance = 335;
            this.splitContainer2.SplitterWidth = 10;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(335, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.button4);
            this.splitContainer3.Panel2.Controls.Add(this.button3);
            this.splitContainer3.Panel2.Controls.Add(this.button2);
            this.splitContainer3.Panel2.Controls.Add(this.button1);
            this.splitContainer3.Size = new System.Drawing.Size(175, 415);
            this.splitContainer3.SplitterDistance = 214;
            this.splitContainer3.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Annuaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Annuaire";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox_Service;
        private System.Windows.Forms.Label label_Service;
        private System.Windows.Forms.CheckedListBox checkedListBox_Site;
        private System.Windows.Forms.Label label_Site;
        private System.Windows.Forms.TextBox textBox_NomPrenom;
        private System.Windows.Forms.Label label_NomPrenom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

