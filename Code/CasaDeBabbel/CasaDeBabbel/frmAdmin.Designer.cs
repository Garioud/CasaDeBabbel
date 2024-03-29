﻿namespace CasaDeBabbel
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.lblNomPersonne = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblNumberExo = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lblPhraseTrad = new System.Windows.Forms.Label();
            this.lblPhrase = new System.Windows.Forms.Label();
            this.lblRegle = new System.Windows.Forms.Label();
            this.lblEnonce = new System.Windows.Forms.Label();
            this.btnFin = new System.Windows.Forms.Button();
            this.btnDebut = new System.Windows.Forms.Button();
            this.btnApres = new System.Windows.Forms.Button();
            this.btnAvant = new System.Windows.Forms.Button();
            this.lb_Lecons = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnHideWindow = new System.Windows.Forms.Button();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblExo = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCours = new System.Windows.Forms.Label();
            this.lblActLec = new System.Windows.Forms.Label();
            this.lblActualCours = new System.Windows.Forms.Label();
            this.lblAcLec = new System.Windows.Forms.Label();
            this.pgB_Progres = new System.Windows.Forms.ProgressBar();
            this.btnCours1 = new System.Windows.Forms.Button();
            this.btnCours2 = new System.Windows.Forms.Button();
            this.btnCours3 = new System.Windows.Forms.Button();
            this.btnCours4 = new System.Windows.Forms.Button();
            this.pnlLogo.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomPersonne
            // 
            this.lblNomPersonne.AutoSize = true;
            this.lblNomPersonne.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPersonne.Location = new System.Drawing.Point(842, 38);
            this.lblNomPersonne.Name = "lblNomPersonne";
            this.lblNomPersonne.Size = new System.Drawing.Size(120, 23);
            this.lblNomPersonne.TabIndex = 29;
            this.lblNomPersonne.Text = "NomPersonne";
            this.lblNomPersonne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(0, 520);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(220, 80);
            this.btnMenu.TabIndex = 28;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblNumberExo
            // 
            this.lblNumberExo.AutoSize = true;
            this.lblNumberExo.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberExo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberExo.Location = new System.Drawing.Point(338, 107);
            this.lblNumberExo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberExo.Name = "lblNumberExo";
            this.lblNumberExo.Size = new System.Drawing.Size(61, 22);
            this.lblNumberExo.TabIndex = 23;
            this.lblNumberExo.Text = "label2";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogo.BackgroundImage")));
            this.pnlLogo.Controls.Add(this.flowLayoutPanel1);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(220, 135);
            this.pnlLogo.TabIndex = 27;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 135);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(220, 465);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.lblPhraseTrad);
            this.pnlPrincipal.Controls.Add(this.lblPhrase);
            this.pnlPrincipal.Controls.Add(this.lblRegle);
            this.pnlPrincipal.Controls.Add(this.lblEnonce);
            this.pnlPrincipal.Controls.Add(this.btnFin);
            this.pnlPrincipal.Controls.Add(this.btnDebut);
            this.pnlPrincipal.Controls.Add(this.btnApres);
            this.pnlPrincipal.Controls.Add(this.btnAvant);
            this.pnlPrincipal.Controls.Add(this.lb_Lecons);
            this.pnlPrincipal.Location = new System.Drawing.Point(220, 135);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(780, 465);
            this.pnlPrincipal.TabIndex = 25;
            // 
            // lblPhraseTrad
            // 
            this.lblPhraseTrad.AutoSize = true;
            this.lblPhraseTrad.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhraseTrad.Location = new System.Drawing.Point(21, 364);
            this.lblPhraseTrad.Name = "lblPhraseTrad";
            this.lblPhraseTrad.Size = new System.Drawing.Size(97, 23);
            this.lblPhraseTrad.TabIndex = 19;
            this.lblPhraseTrad.Text = "PhraseTrad";
            // 
            // lblPhrase
            // 
            this.lblPhrase.AutoSize = true;
            this.lblPhrase.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhrase.Location = new System.Drawing.Point(21, 331);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(63, 23);
            this.lblPhrase.TabIndex = 18;
            this.lblPhrase.Text = "Phrase";
            // 
            // lblRegle
            // 
            this.lblRegle.AutoSize = true;
            this.lblRegle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegle.Location = new System.Drawing.Point(21, 397);
            this.lblRegle.Name = "lblRegle";
            this.lblRegle.Size = new System.Drawing.Size(47, 23);
            this.lblRegle.TabIndex = 17;
            this.lblRegle.Text = "Num";
            // 
            // lblEnonce
            // 
            this.lblEnonce.AutoSize = true;
            this.lblEnonce.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnonce.Location = new System.Drawing.Point(21, 295);
            this.lblEnonce.Name = "lblEnonce";
            this.lblEnonce.Size = new System.Drawing.Size(66, 23);
            this.lblEnonce.TabIndex = 16;
            this.lblEnonce.Text = "Enonce";
            // 
            // btnFin
            // 
            this.btnFin.BackColor = System.Drawing.Color.Transparent;
            this.btnFin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFin.BackgroundImage")));
            this.btnFin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFin.Location = new System.Drawing.Point(430, 240);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(30, 30);
            this.btnFin.TabIndex = 15;
            this.btnFin.UseVisualStyleBackColor = false;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // btnDebut
            // 
            this.btnDebut.BackColor = System.Drawing.Color.Transparent;
            this.btnDebut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDebut.BackgroundImage")));
            this.btnDebut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDebut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDebut.Location = new System.Drawing.Point(322, 240);
            this.btnDebut.Name = "btnDebut";
            this.btnDebut.Size = new System.Drawing.Size(30, 30);
            this.btnDebut.TabIndex = 14;
            this.btnDebut.UseVisualStyleBackColor = false;
            this.btnDebut.Click += new System.EventHandler(this.btnDebut_Click);
            // 
            // btnApres
            // 
            this.btnApres.BackColor = System.Drawing.Color.Transparent;
            this.btnApres.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApres.BackgroundImage")));
            this.btnApres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnApres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApres.ForeColor = System.Drawing.SystemColors.Control;
            this.btnApres.Location = new System.Drawing.Point(394, 240);
            this.btnApres.Name = "btnApres";
            this.btnApres.Size = new System.Drawing.Size(30, 30);
            this.btnApres.TabIndex = 13;
            this.btnApres.UseVisualStyleBackColor = false;
            this.btnApres.Click += new System.EventHandler(this.btnApres_Click);
            // 
            // btnAvant
            // 
            this.btnAvant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAvant.BackgroundImage")));
            this.btnAvant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAvant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvant.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAvant.Location = new System.Drawing.Point(358, 240);
            this.btnAvant.Name = "btnAvant";
            this.btnAvant.Size = new System.Drawing.Size(30, 30);
            this.btnAvant.TabIndex = 12;
            this.btnAvant.UseVisualStyleBackColor = true;
            this.btnAvant.Click += new System.EventHandler(this.btnAvant_Click);
            // 
            // lb_Lecons
            // 
            this.lb_Lecons.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Lecons.FormattingEnabled = true;
            this.lb_Lecons.ItemHeight = 29;
            this.lb_Lecons.Location = new System.Drawing.Point(98, 15);
            this.lb_Lecons.Name = "lb_Lecons";
            this.lb_Lecons.Size = new System.Drawing.Size(568, 207);
            this.lb_Lecons.TabIndex = 11;
            this.lb_Lecons.SelectedIndexChanged += new System.EventHandler(this.lb_Lecons_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Administration";
            // 
            // btnHideWindow
            // 
            this.btnHideWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnHideWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHideWindow.BackgroundImage")));
            this.btnHideWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHideWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideWindow.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHideWindow.Location = new System.Drawing.Point(715, 3);
            this.btnHideWindow.Name = "btnHideWindow";
            this.btnHideWindow.Size = new System.Drawing.Size(27, 27);
            this.btnHideWindow.TabIndex = 2;
            this.btnHideWindow.UseVisualStyleBackColor = false;
            this.btnHideWindow.Click += new System.EventHandler(this.btnHideWindow_Click);
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.Controls.Add(this.lblName);
            this.pnlToolbar.Controls.Add(this.btnHideWindow);
            this.pnlToolbar.Controls.Add(this.btnExit);
            this.pnlToolbar.Location = new System.Drawing.Point(220, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(780, 35);
            this.pnlToolbar.TabIndex = 26;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(750, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 27);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblExo
            // 
            this.lblExo.AutoSize = true;
            this.lblExo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExo.Location = new System.Drawing.Point(241, 107);
            this.lblExo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExo.Name = "lblExo";
            this.lblExo.Size = new System.Drawing.Size(89, 22);
            this.lblExo.TabIndex = 22;
            this.lblExo.Text = "Exercice:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(403, 82);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(50, 22);
            this.lblDesc.TabIndex = 19;
            this.lblDesc.Text = "label";
            // 
            // lblCours
            // 
            this.lblCours.AutoSize = true;
            this.lblCours.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCours.Location = new System.Drawing.Point(227, 38);
            this.lblCours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(172, 22);
            this.lblCours.TabIndex = 17;
            this.lblCours.Text = "Votre cours actuel :";
            // 
            // lblActLec
            // 
            this.lblActLec.AutoSize = true;
            this.lblActLec.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActLec.Location = new System.Drawing.Point(403, 60);
            this.lblActLec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActLec.Name = "lblActLec";
            this.lblActLec.Size = new System.Drawing.Size(61, 22);
            this.lblActLec.TabIndex = 21;
            this.lblActLec.Text = "label2";
            // 
            // lblActualCours
            // 
            this.lblActualCours.AutoSize = true;
            this.lblActualCours.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualCours.Location = new System.Drawing.Point(403, 38);
            this.lblActualCours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActualCours.Name = "lblActualCours";
            this.lblActualCours.Size = new System.Drawing.Size(50, 22);
            this.lblActualCours.TabIndex = 18;
            this.lblActualCours.Text = "label";
            // 
            // lblAcLec
            // 
            this.lblAcLec.AutoSize = true;
            this.lblAcLec.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcLec.Location = new System.Drawing.Point(256, 60);
            this.lblAcLec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcLec.Name = "lblAcLec";
            this.lblAcLec.Size = new System.Drawing.Size(143, 22);
            this.lblAcLec.TabIndex = 20;
            this.lblAcLec.Text = "Leçon actuelle :";
            // 
            // pgB_Progres
            // 
            this.pgB_Progres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pgB_Progres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pgB_Progres.Location = new System.Drawing.Point(407, 108);
            this.pgB_Progres.Margin = new System.Windows.Forms.Padding(4);
            this.pgB_Progres.Name = "pgB_Progres";
            this.pgB_Progres.Size = new System.Drawing.Size(479, 21);
            this.pgB_Progres.Step = 1;
            this.pgB_Progres.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgB_Progres.TabIndex = 24;
            // 
            // btnCours1
            // 
            this.btnCours1.Location = new System.Drawing.Point(0, 135);
            this.btnCours1.Name = "btnCours1";
            this.btnCours1.Size = new System.Drawing.Size(220, 80);
            this.btnCours1.TabIndex = 11;
            this.btnCours1.Text = "btnCours1";
            this.btnCours1.UseVisualStyleBackColor = true;
            this.btnCours1.Click += new System.EventHandler(this.btnCours1_Click);
            // 
            // btnCours2
            // 
            this.btnCours2.Location = new System.Drawing.Point(0, 215);
            this.btnCours2.Name = "btnCours2";
            this.btnCours2.Size = new System.Drawing.Size(220, 80);
            this.btnCours2.TabIndex = 30;
            this.btnCours2.Text = "btnCours2";
            this.btnCours2.UseVisualStyleBackColor = true;
            this.btnCours2.Click += new System.EventHandler(this.btnCours2_Click);
            // 
            // btnCours3
            // 
            this.btnCours3.Location = new System.Drawing.Point(0, 295);
            this.btnCours3.Name = "btnCours3";
            this.btnCours3.Size = new System.Drawing.Size(220, 80);
            this.btnCours3.TabIndex = 31;
            this.btnCours3.Text = "btnCours3";
            this.btnCours3.UseVisualStyleBackColor = true;
            this.btnCours3.Click += new System.EventHandler(this.btnCours3_Click);
            // 
            // btnCours4
            // 
            this.btnCours4.Location = new System.Drawing.Point(0, 375);
            this.btnCours4.Name = "btnCours4";
            this.btnCours4.Size = new System.Drawing.Size(220, 80);
            this.btnCours4.TabIndex = 32;
            this.btnCours4.Text = "btnCours4";
            this.btnCours4.UseVisualStyleBackColor = true;
            this.btnCours4.Click += new System.EventHandler(this.btnCours4_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnCours4);
            this.Controls.Add(this.btnCours3);
            this.Controls.Add(this.btnCours2);
            this.Controls.Add(this.btnCours1);
            this.Controls.Add(this.lblNomPersonne);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblNumberExo);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.lblExo);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblCours);
            this.Controls.Add(this.lblActLec);
            this.Controls.Add(this.lblActualCours);
            this.Controls.Add(this.lblAcLec);
            this.Controls.Add(this.pgB_Progres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.pnlLogo.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomPersonne;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblNumberExo;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnHideWindow;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblExo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.Label lblActLec;
        private System.Windows.Forms.Label lblActualCours;
        private System.Windows.Forms.Label lblAcLec;
        private System.Windows.Forms.ProgressBar pgB_Progres;
        private System.Windows.Forms.Button btnCours1;
        private System.Windows.Forms.Button btnCours2;
        private System.Windows.Forms.Button btnCours3;
        private System.Windows.Forms.Button btnCours4;
        private System.Windows.Forms.ListBox lb_Lecons;
        private System.Windows.Forms.Button btnApres;
        private System.Windows.Forms.Button btnAvant;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Button btnDebut;
        private System.Windows.Forms.Label lblPhrase;
        private System.Windows.Forms.Label lblRegle;
        private System.Windows.Forms.Label lblEnonce;
        private System.Windows.Forms.Label lblPhraseTrad;
    }
}