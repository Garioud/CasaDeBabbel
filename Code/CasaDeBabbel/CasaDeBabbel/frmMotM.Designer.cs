namespace CasaDeBabbel
{
    partial class frmMotM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMotM));
            this.lblNomPersonne = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnHideWindow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblExo = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblNumberExo = new System.Windows.Forms.Label();
            this.pgB_Progres = new System.Windows.Forms.ProgressBar();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCours = new System.Windows.Forms.Label();
            this.lblActLec = new System.Windows.Forms.Label();
            this.lblActualCours = new System.Windows.Forms.Label();
            this.lblAcLec = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlListe = new System.Windows.Forms.Panel();
            this.btnAide = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlListe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomPersonne
            // 
            this.lblNomPersonne.AutoSize = true;
            this.lblNomPersonne.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPersonne.Location = new System.Drawing.Point(863, 48);
            this.lblNomPersonne.Name = "lblNomPersonne";
            this.lblNomPersonne.Size = new System.Drawing.Size(120, 23);
            this.lblNomPersonne.TabIndex = 29;
            this.lblNomPersonne.Text = "NomPersonne";
            this.lblNomPersonne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(908, 86);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(74, 43);
            this.btnMenu.TabIndex = 28;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 135);
            this.panel4.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.btnHideWindow);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Location = new System.Drawing.Point(220, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(780, 35);
            this.panel3.TabIndex = 26;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(141, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Mots manquants";
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
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(810, 400);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(163, 41);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Continuer";
            this.btnStart.UseVisualStyleBackColor = true;
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
            this.lblActLec.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlListe);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 465);
            this.panel1.TabIndex = 25;
            // 
            // pnlListe
            // 
            this.pnlListe.Controls.Add(this.btnAide);
            this.pnlListe.Location = new System.Drawing.Point(0, 0);
            this.pnlListe.Name = "pnlListe";
            this.pnlListe.Size = new System.Drawing.Size(1000, 376);
            this.pnlListe.TabIndex = 11;
            // 
            // btnAide
            // 
            this.btnAide.Location = new System.Drawing.Point(908, 12);
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(80, 29);
            this.btnAide.TabIndex = 0;
            this.btnAide.Text = "Aide";
            this.btnAide.UseVisualStyleBackColor = true;
            this.btnAide.Click += new System.EventHandler(this.btnAide_Click);
            // 
            // frmMotM
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblNomPersonne);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblExo);
            this.Controls.Add(this.lblNumberExo);
            this.Controls.Add(this.pgB_Progres);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblCours);
            this.Controls.Add(this.lblActLec);
            this.Controls.Add(this.lblActualCours);
            this.Controls.Add(this.lblAcLec);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMotM";
            this.Text = "frmMotM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMotM_FormClosed);
            this.Load += new System.EventHandler(this.frmMotM_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlListe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomPersonne;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnHideWindow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblExo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblNumberExo;
        private System.Windows.Forms.ProgressBar pgB_Progres;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.Label lblActLec;
        private System.Windows.Forms.Label lblActualCours;
        private System.Windows.Forms.Label lblAcLec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlListe;
        private System.Windows.Forms.Button btnAide;
    }
}