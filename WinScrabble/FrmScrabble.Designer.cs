
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Jeu = new System.Windows.Forms.TabPage();
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
            this.tabControl.Size = new System.Drawing.Size(531, 297);
            this.tabControl.TabIndex = 0;
            // 
            // Jeu
            // 
            this.Jeu.Controls.Add(this.gpJ2);
            this.Jeu.Controls.Add(this.gpJ1);
            this.Jeu.Location = new System.Drawing.Point(4, 22);
            this.Jeu.Name = "Jeu";
            this.Jeu.Padding = new System.Windows.Forms.Padding(3);
            this.Jeu.Size = new System.Drawing.Size(523, 271);
            this.Jeu.TabIndex = 0;
            this.Jeu.Text = "Jeu";
            this.Jeu.UseVisualStyleBackColor = true;
            // 
            // gpJ2
            // 
            this.gpJ2.Location = new System.Drawing.Point(314, 7);
            this.gpJ2.Name = "gpJ2";
            this.gpJ2.Size = new System.Drawing.Size(201, 259);
            this.gpJ2.TabIndex = 1;
            this.gpJ2.TabStop = false;
            this.gpJ2.Text = "Joueur :";
            // 
            // gpJ1
            // 
            this.gpJ1.Location = new System.Drawing.Point(8, 6);
            this.gpJ1.Name = "gpJ1";
            this.gpJ1.Size = new System.Drawing.Size(175, 259);
            this.gpJ1.TabIndex = 0;
            this.gpJ1.TabStop = false;
            this.gpJ1.Text = "Joueur : ";
            // 
            // Joueurs
            // 
            this.Joueurs.BackColor = System.Drawing.Color.Transparent;
            this.Joueurs.Controls.Add(this.groupBox1);
            this.Joueurs.Location = new System.Drawing.Point(4, 22);
            this.Joueurs.Name = "Joueurs";
            this.Joueurs.Padding = new System.Windows.Forms.Padding(3);
            this.Joueurs.Size = new System.Drawing.Size(523, 271);
            this.Joueurs.TabIndex = 1;
            this.Joueurs.Text = "Joueurs";
            this.Joueurs.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.ValiderJoueur);
            this.groupBox1.Controls.Add(this.J2label);
            this.groupBox1.Controls.Add(this.J1label);
            this.groupBox1.Controls.Add(this.txtJ2);
            this.groupBox1.Controls.Add(this.txtJ1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Joueurs";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ValiderJoueur
            // 
            this.ValiderJoueur.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValiderJoueur.Location = new System.Drawing.Point(163, 138);
            this.ValiderJoueur.Name = "ValiderJoueur";
            this.ValiderJoueur.Size = new System.Drawing.Size(165, 39);
            this.ValiderJoueur.TabIndex = 4;
            this.ValiderJoueur.Text = "Valider";
            this.ValiderJoueur.UseVisualStyleBackColor = true;
            this.ValiderJoueur.Click += new System.EventHandler(this.button1_Click);
            // 
            // J2label
            // 
            this.J2label.AutoSize = true;
            this.J2label.BackColor = System.Drawing.Color.Transparent;
            this.J2label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.J2label.Location = new System.Drawing.Point(247, 54);
            this.J2label.Name = "J2label";
            this.J2label.Size = new System.Drawing.Size(90, 18);
            this.J2label.TabIndex = 3;
            this.J2label.Text = "Joueur 2 :";
            // 
            // J1label
            // 
            this.J1label.AutoSize = true;
            this.J1label.BackColor = System.Drawing.Color.Transparent;
            this.J1label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.J1label.Location = new System.Drawing.Point(28, 54);
            this.J1label.Name = "J1label";
            this.J1label.Size = new System.Drawing.Size(90, 18);
            this.J1label.TabIndex = 2;
            this.J1label.Text = "Joueur 1 :";
            this.J1label.Click += new System.EventHandler(this.J1label_Click);
            // 
            // txtJ2
            // 
            this.txtJ2.Location = new System.Drawing.Point(343, 50);
            this.txtJ2.Name = "txtJ2";
            this.txtJ2.Size = new System.Drawing.Size(104, 22);
            this.txtJ2.TabIndex = 1;
            this.txtJ2.TextChanged += new System.EventHandler(this.txtJ2_TextChanged);
            // 
            // txtJ1
            // 
            this.txtJ1.Location = new System.Drawing.Point(124, 54);
            this.txtJ1.Name = "txtJ1";
            this.txtJ1.Size = new System.Drawing.Size(90, 22);
            this.txtJ1.TabIndex = 0;
            this.txtJ1.TextChanged += new System.EventHandler(this.txtJ1_TextChanged);
            // 
            // Gagnant
            // 
            this.Gagnant.Location = new System.Drawing.Point(4, 22);
            this.Gagnant.Name = "Gagnant";
            this.Gagnant.Padding = new System.Windows.Forms.Padding(3);
            this.Gagnant.Size = new System.Drawing.Size(523, 271);
            this.Gagnant.TabIndex = 2;
            this.Gagnant.Text = "Gagnant";
            this.Gagnant.UseVisualStyleBackColor = true;
            // 
            // FrmScrabble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 300);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmScrabble";
            this.Text = "JEU DU SCRABBLE - MODE 2 JOUEURS";
            this.tabControl.ResumeLayout(false);
            this.Jeu.ResumeLayout(false);
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
    }
}

