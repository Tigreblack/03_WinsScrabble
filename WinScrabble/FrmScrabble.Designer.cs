
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
            this.txtround = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtlettres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Joueurtxt = new System.Windows.Forms.TextBox();
            this.gpJ2 = new System.Windows.Forms.GroupBox();
            this.nbmotsJ2 = new System.Windows.Forms.TextBox();
            this.txtmmotsJ2 = new System.Windows.Forms.TextBox();
            this.txttotalpointsJ2 = new System.Windows.Forms.TextBox();
            this.ValiderJ2 = new System.Windows.Forms.Button();
            this.txtmotsJ2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpJ1 = new System.Windows.Forms.GroupBox();
            this.nbmotsJ1 = new System.Windows.Forms.TextBox();
            this.txtmmotsJ1 = new System.Windows.Forms.TextBox();
            this.txttotalpointsJ1 = new System.Windows.Forms.TextBox();
            this.ValiderJ1 = new System.Windows.Forms.Button();
            this.txtmotsJ1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Joueurs = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ValiderJoueur = new System.Windows.Forms.Button();
            this.J2label = new System.Windows.Forms.Label();
            this.J1label = new System.Windows.Forms.Label();
            this.txtJ2 = new System.Windows.Forms.TextBox();
            this.txtJ1 = new System.Windows.Forms.TextBox();
            this.Gagnant = new System.Windows.Forms.TabPage();
            this.Gpgagnant = new System.Windows.Forms.GroupBox();
            this.Rejouer = new System.Windows.Forms.Button();
            this.txtgagnantmmot = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtgagnant = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listGagnant = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.Jeu.SuspendLayout();
            this.gpJ2.SuspendLayout();
            this.gpJ1.SuspendLayout();
            this.Joueurs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Gagnant.SuspendLayout();
            this.Gpgagnant.SuspendLayout();
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
            this.Jeu.BackgroundImage = global::WinScrabble.Properties.Resources.pngtree_scrabble_words_with_a_yellow_smiley_face_image_13206225;
            this.Jeu.Controls.Add(this.txtround);
            this.Jeu.Controls.Add(this.label9);
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
            // txtround
            // 
            this.txtround.Location = new System.Drawing.Point(242, 138);
            this.txtround.Name = "txtround";
            this.txtround.Size = new System.Drawing.Size(67, 22);
            this.txtround.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(242, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "Round :";
            // 
            // txtlettres
            // 
            this.txtlettres.Location = new System.Drawing.Point(222, 220);
            this.txtlettres.Name = "txtlettres";
            this.txtlettres.Size = new System.Drawing.Size(100, 22);
            this.txtlettres.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lettres choisis :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tour du Joueur :";
            // 
            // Joueurtxt
            // 
            this.Joueurtxt.Location = new System.Drawing.Point(225, 65);
            this.Joueurtxt.Name = "Joueurtxt";
            this.Joueurtxt.Size = new System.Drawing.Size(100, 22);
            this.Joueurtxt.TabIndex = 0;
            this.Joueurtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gpJ2
            // 
            this.gpJ2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpJ2.Controls.Add(this.nbmotsJ2);
            this.gpJ2.Controls.Add(this.txtmmotsJ2);
            this.gpJ2.Controls.Add(this.txttotalpointsJ2);
            this.gpJ2.Controls.Add(this.ValiderJ2);
            this.gpJ2.Controls.Add(this.txtmotsJ2);
            this.gpJ2.Controls.Add(this.label8);
            this.gpJ2.Controls.Add(this.label6);
            this.gpJ2.Controls.Add(this.label4);
            this.gpJ2.Location = new System.Drawing.Point(357, 9);
            this.gpJ2.Name = "gpJ2";
            this.gpJ2.Size = new System.Drawing.Size(202, 287);
            this.gpJ2.TabIndex = 1;
            this.gpJ2.TabStop = false;
            this.gpJ2.Text = "Joueur :";
            // 
            // nbmotsJ2
            // 
            this.nbmotsJ2.Location = new System.Drawing.Point(110, 107);
            this.nbmotsJ2.Name = "nbmotsJ2";
            this.nbmotsJ2.Size = new System.Drawing.Size(60, 22);
            this.nbmotsJ2.TabIndex = 11;
            // 
            // txtmmotsJ2
            // 
            this.txtmmotsJ2.Location = new System.Drawing.Point(99, 71);
            this.txtmmotsJ2.Name = "txtmmotsJ2";
            this.txtmmotsJ2.Size = new System.Drawing.Size(88, 22);
            this.txtmmotsJ2.TabIndex = 10;
            // 
            // txttotalpointsJ2
            // 
            this.txttotalpointsJ2.Location = new System.Drawing.Point(102, 33);
            this.txttotalpointsJ2.Name = "txttotalpointsJ2";
            this.txttotalpointsJ2.Size = new System.Drawing.Size(68, 22);
            this.txttotalpointsJ2.TabIndex = 9;
            // 
            // ValiderJ2
            // 
            this.ValiderJ2.Location = new System.Drawing.Point(66, 228);
            this.ValiderJ2.Name = "ValiderJ2";
            this.ValiderJ2.Size = new System.Drawing.Size(75, 23);
            this.ValiderJ2.TabIndex = 8;
            this.ValiderJ2.Text = "Valider";
            this.ValiderJ2.UseVisualStyleBackColor = true;
            this.ValiderJ2.Click += new System.EventHandler(this.ValiderJ2_Click);
            // 
            // txtmotsJ2
            // 
            this.txtmotsJ2.Location = new System.Drawing.Point(54, 186);
            this.txtmotsJ2.Name = "txtmotsJ2";
            this.txtmotsJ2.Size = new System.Drawing.Size(100, 22);
            this.txtmotsJ2.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nombre de mots :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Meilleur mot :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Points :";
            // 
            // gpJ1
            // 
            this.gpJ1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpJ1.Controls.Add(this.nbmotsJ1);
            this.gpJ1.Controls.Add(this.txtmmotsJ1);
            this.gpJ1.Controls.Add(this.txttotalpointsJ1);
            this.gpJ1.Controls.Add(this.ValiderJ1);
            this.gpJ1.Controls.Add(this.txtmotsJ1);
            this.gpJ1.Controls.Add(this.label7);
            this.gpJ1.Controls.Add(this.label5);
            this.gpJ1.Controls.Add(this.label3);
            this.gpJ1.Location = new System.Drawing.Point(8, 9);
            this.gpJ1.Name = "gpJ1";
            this.gpJ1.Size = new System.Drawing.Size(188, 287);
            this.gpJ1.TabIndex = 0;
            this.gpJ1.TabStop = false;
            this.gpJ1.Text = "Joueur : ";
            // 
            // nbmotsJ1
            // 
            this.nbmotsJ1.Location = new System.Drawing.Point(110, 107);
            this.nbmotsJ1.Name = "nbmotsJ1";
            this.nbmotsJ1.Size = new System.Drawing.Size(60, 22);
            this.nbmotsJ1.TabIndex = 10;
            this.nbmotsJ1.TextChanged += new System.EventHandler(this.nbmotsJ1_TextChanged);
            // 
            // txtmmotsJ1
            // 
            this.txtmmotsJ1.Location = new System.Drawing.Point(90, 71);
            this.txtmmotsJ1.Name = "txtmmotsJ1";
            this.txtmmotsJ1.Size = new System.Drawing.Size(84, 22);
            this.txtmmotsJ1.TabIndex = 9;
            // 
            // txttotalpointsJ1
            // 
            this.txttotalpointsJ1.Location = new System.Drawing.Point(96, 33);
            this.txttotalpointsJ1.Name = "txttotalpointsJ1";
            this.txttotalpointsJ1.Size = new System.Drawing.Size(68, 22);
            this.txttotalpointsJ1.TabIndex = 8;
            // 
            // ValiderJ1
            // 
            this.ValiderJ1.Location = new System.Drawing.Point(49, 228);
            this.ValiderJ1.Name = "ValiderJ1";
            this.ValiderJ1.Size = new System.Drawing.Size(75, 23);
            this.ValiderJ1.TabIndex = 7;
            this.ValiderJ1.Text = "Valider";
            this.ValiderJ1.UseVisualStyleBackColor = true;
            this.ValiderJ1.Click += new System.EventHandler(this.ValiderJ1_Click);
            // 
            // txtmotsJ1
            // 
            this.txtmotsJ1.Location = new System.Drawing.Point(36, 186);
            this.txtmotsJ1.Name = "txtmotsJ1";
            this.txtmotsJ1.Size = new System.Drawing.Size(100, 22);
            this.txtmotsJ1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nombre de mots :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Meilleur mot :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Points :";
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
            this.Gagnant.BackgroundImage = global::WinScrabble.Properties.Resources.city_lights_tokyo_night_wallpaper_preview;
            this.Gagnant.Controls.Add(this.Gpgagnant);
            this.Gagnant.Location = new System.Drawing.Point(4, 22);
            this.Gagnant.Name = "Gagnant";
            this.Gagnant.Padding = new System.Windows.Forms.Padding(3);
            this.Gagnant.Size = new System.Drawing.Size(565, 299);
            this.Gagnant.TabIndex = 2;
            this.Gagnant.Text = "Gagnant";
            this.Gagnant.UseVisualStyleBackColor = true;
            // 
            // Gpgagnant
            // 
            this.Gpgagnant.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Gpgagnant.Controls.Add(this.Rejouer);
            this.Gpgagnant.Controls.Add(this.txtgagnantmmot);
            this.Gpgagnant.Controls.Add(this.label11);
            this.Gpgagnant.Controls.Add(this.txtgagnant);
            this.Gpgagnant.Controls.Add(this.label10);
            this.Gpgagnant.Controls.Add(this.listGagnant);
            this.Gpgagnant.Location = new System.Drawing.Point(155, 8);
            this.Gpgagnant.Name = "Gpgagnant";
            this.Gpgagnant.Size = new System.Drawing.Size(254, 287);
            this.Gpgagnant.TabIndex = 0;
            this.Gpgagnant.TabStop = false;
            this.Gpgagnant.Text = "Gagnant";
            // 
            // Rejouer
            // 
            this.Rejouer.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rejouer.Location = new System.Drawing.Point(77, 237);
            this.Rejouer.Name = "Rejouer";
            this.Rejouer.Size = new System.Drawing.Size(89, 33);
            this.Rejouer.TabIndex = 5;
            this.Rejouer.Text = "Rejouer";
            this.Rejouer.UseVisualStyleBackColor = true;
            this.Rejouer.Click += new System.EventHandler(this.Rejouer_Click);
            // 
            // txtgagnantmmot
            // 
            this.txtgagnantmmot.Location = new System.Drawing.Point(118, 200);
            this.txtgagnantmmot.Name = "txtgagnantmmot";
            this.txtgagnantmmot.Size = new System.Drawing.Size(112, 22);
            this.txtgagnantmmot.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Meilleur mot :";
            // 
            // txtgagnant
            // 
            this.txtgagnant.Location = new System.Drawing.Point(77, 57);
            this.txtgagnant.Name = "txtgagnant";
            this.txtgagnant.Size = new System.Drawing.Size(100, 22);
            this.txtgagnant.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Le Gagnant est :";
            // 
            // listGagnant
            // 
            this.listGagnant.FormattingEnabled = true;
            this.listGagnant.Location = new System.Drawing.Point(6, 98);
            this.listGagnant.Name = "listGagnant";
            this.listGagnant.Size = new System.Drawing.Size(242, 82);
            this.listGagnant.TabIndex = 0;
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
            this.gpJ2.ResumeLayout(false);
            this.gpJ2.PerformLayout();
            this.gpJ1.ResumeLayout(false);
            this.gpJ1.PerformLayout();
            this.Joueurs.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Gagnant.ResumeLayout(false);
            this.Gpgagnant.ResumeLayout(false);
            this.Gpgagnant.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtround;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ValiderJ2;
        private System.Windows.Forms.TextBox txtmotsJ2;
        private System.Windows.Forms.Button ValiderJ1;
        private System.Windows.Forms.TextBox txtmotsJ1;
        private System.Windows.Forms.TextBox nbmotsJ2;
        private System.Windows.Forms.TextBox txtmmotsJ2;
        private System.Windows.Forms.TextBox txttotalpointsJ2;
        private System.Windows.Forms.TextBox nbmotsJ1;
        private System.Windows.Forms.TextBox txtmmotsJ1;
        private System.Windows.Forms.TextBox txttotalpointsJ1;
        private System.Windows.Forms.GroupBox Gpgagnant;
        private System.Windows.Forms.ListBox listGagnant;
        private System.Windows.Forms.Button Rejouer;
        private System.Windows.Forms.TextBox txtgagnantmmot;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtgagnant;
        private System.Windows.Forms.Label label10;
    }
}

