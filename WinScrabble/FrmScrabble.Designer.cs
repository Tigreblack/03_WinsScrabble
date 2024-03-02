
namespace WinScrabble
{
    partial class FrmScrabble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScrabble));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Jeu = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Joueurtxt = new System.Windows.Forms.TextBox();
            this.gpJ2 = new System.Windows.Forms.GroupBox();
            this.gpJ1 = new System.Windows.Forms.GroupBox();
            this.Joueurs = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ValiderJoueur = new System.Windows.Forms.Button();
            this.J2label = new System.Windows.Forms.Label();
            this.J1label = new System.Windows.Forms.Label();
            this.txtJ2 = new System.Windows.Forms.TextBox();
            this.txtJ1 = new System.Windows.Forms.TextBox();
            this.Gagnant = new System.Windows.Forms.TabPage();
            this.txtlettres = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.Jeu.SuspendLayout();
            this.Joueurs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Jeu);
            this.tabControl.Controls.Add(this.Joueurs);
            this.tabControl.Controls.Add(this.Gagnant);
            this.tabControl.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(573, 325);
            this.tabControl.TabIndex = 0;
            // 
            // Jeu
            // 
            this.Jeu.Controls.Add(this.txtlettres);
            this.Jeu.Controls.Add(this.label2);
            this.Jeu.Controls.Add(this.label1);
            this.Jeu.Controls.Add(this.Joueurtxt);
            this.Jeu.Controls.Add(this.gpJ2);
            this.Jeu.Controls.Add(this.gpJ1);
            this.Jeu.Location = new System.Drawing.Point(4, 22);
            this.Jeu.Name = "Jeu";
            this.Jeu.Padding = new System.Windows.Forms.Padding(3);
            this.Jeu.Size = new System.Drawing.Size(565, 299);
            this.Jeu.TabIndex = 0;
            this.Jeu.Text = "Jeu";
            this.Jeu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lettres choisis :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Au tour du Joueur :";
            // 
            // Joueurtxt
            // 
            this.Joueurtxt.Location = new System.Drawing.Point(225, 67);
            this.Joueurtxt.Name = "Joueurtxt";
            this.Joueurtxt.Size = new System.Drawing.Size(100, 22);
            this.Joueurtxt.TabIndex = 0;
            this.Joueurtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gpJ2
            // 
            this.gpJ2.Location = new System.Drawing.Point(349, 9);
            this.gpJ2.Name = "gpJ2";
            this.gpJ2.Size = new System.Drawing.Size(210, 287);
            this.gpJ2.TabIndex = 1;
            this.gpJ2.TabStop = false;
            this.gpJ2.Text = "Joueur :";
            // 
            // gpJ1
            // 
            this.gpJ1.Location = new System.Drawing.Point(8, 9);
            this.gpJ1.Name = "gpJ1";
            this.gpJ1.Size = new System.Drawing.Size(191, 287);
            this.gpJ1.TabIndex = 0;
            this.gpJ1.TabStop = false;
            this.gpJ1.Text = "Joueur : ";
            // 
            // Joueurs
            // 
            this.Joueurs.BackColor = System.Drawing.Color.Transparent;
            this.Joueurs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Joueurs.BackgroundImage")));
            this.Joueurs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Joueurs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Joueurs.Controls.Add(this.groupBox1);
            this.Joueurs.Location = new System.Drawing.Point(4, 22);
            this.Joueurs.Name = "Joueurs";
            this.Joueurs.Padding = new System.Windows.Forms.Padding(3);
            this.Joueurs.Size = new System.Drawing.Size(565, 299);
            this.Joueurs.TabIndex = 1;
            this.Joueurs.Text = "Joueurs";
            this.Joueurs.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.ValiderJoueur);
            this.groupBox1.Controls.Add(this.J2label);
            this.groupBox1.Controls.Add(this.J1label);
            this.groupBox1.Controls.Add(this.txtJ2);
            this.groupBox1.Controls.Add(this.txtJ1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Joueurs";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ValiderJoueur
            // 
            this.ValiderJoueur.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValiderJoueur.Image = ((System.Drawing.Image)(resources.GetObject("ValiderJoueur.Image")));
            this.ValiderJoueur.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ValiderJoueur.Location = new System.Drawing.Point(195, 182);
            this.ValiderJoueur.Name = "ValiderJoueur";
            this.ValiderJoueur.Size = new System.Drawing.Size(156, 45);
            this.ValiderJoueur.TabIndex = 4;
            this.ValiderJoueur.Text = "Valider";
            this.ValiderJoueur.UseVisualStyleBackColor = true;
            this.ValiderJoueur.Click += new System.EventHandler(this.button1_Click);
            // 
            // J2label
            // 
            this.J2label.AutoSize = true;
            this.J2label.BackColor = System.Drawing.Color.Transparent;
            this.J2label.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.J2label.Location = new System.Drawing.Point(379, 54);
            this.J2label.Name = "J2label";
            this.J2label.Size = new System.Drawing.Size(105, 29);
            this.J2label.TabIndex = 3;
            this.J2label.Text = "Joueur 2 :";
            // 
            // J1label
            // 
            this.J1label.AutoSize = true;
            this.J1label.BackColor = System.Drawing.Color.Transparent;
            this.J1label.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.J1label.Location = new System.Drawing.Point(64, 54);
            this.J1label.Name = "J1label";
            this.J1label.Size = new System.Drawing.Size(102, 29);
            this.J1label.TabIndex = 2;
            this.J1label.Text = "Joueur 1 :";
            this.J1label.Click += new System.EventHandler(this.J1label_Click);
            // 
            // txtJ2
            // 
            this.txtJ2.Location = new System.Drawing.Point(377, 105);
            this.txtJ2.Name = "txtJ2";
            this.txtJ2.Size = new System.Drawing.Size(107, 22);
            this.txtJ2.TabIndex = 1;
            this.txtJ2.TextChanged += new System.EventHandler(this.txtJ2_TextChanged);
            // 
            // txtJ1
            // 
            this.txtJ1.Location = new System.Drawing.Point(63, 105);
            this.txtJ1.Name = "txtJ1";
            this.txtJ1.Size = new System.Drawing.Size(103, 22);
            this.txtJ1.TabIndex = 0;
            this.txtJ1.TextChanged += new System.EventHandler(this.txtJ1_TextChanged);
            // 
            // Gagnant
            // 
            this.Gagnant.Location = new System.Drawing.Point(4, 22);
            this.Gagnant.Name = "Gagnant";
            this.Gagnant.Padding = new System.Windows.Forms.Padding(3);
            this.Gagnant.Size = new System.Drawing.Size(565, 299);
            this.Gagnant.TabIndex = 2;
            this.Gagnant.Text = "Gagnant";
            this.Gagnant.UseVisualStyleBackColor = true;
            // 
            // txtlettres
            // 
            this.txtlettres.Location = new System.Drawing.Point(225, 231);
            this.txtlettres.Name = "txtlettres";
            this.txtlettres.Size = new System.Drawing.Size(100, 22);
            this.txtlettres.TabIndex = 4;
            // 
            // FrmScrabble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 329);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmScrabble";
            this.Text = "JEU DU SCRABBLE - MODE 2 JOUEURS";
            this.tabControl.ResumeLayout(false);
            this.Jeu.ResumeLayout(false);
            this.Jeu.PerformLayout();
            this.Joueurs.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Jeu;
        private System.Windows.Forms.TabPage Joueurs;
        private System.Windows.Forms.TabPage Gagnant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label J2label;
        private System.Windows.Forms.Label J1label;
        private System.Windows.Forms.TextBox txtJ2;
        private System.Windows.Forms.TextBox txtJ1;
        private System.Windows.Forms.Button ValiderJoueur;
        private System.Windows.Forms.GroupBox gpJ2;
        private System.Windows.Forms.GroupBox gpJ1;
        private System.Windows.Forms.TextBox Joueurtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlettres;
    }
}

