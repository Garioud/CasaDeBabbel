namespace CasaDeBabbel
{
    partial class frmLogin
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
            this.lblCours = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.lblAcLec = new System.Windows.Forms.Label();
            this.lblActLec = new System.Windows.Forms.Label();
            this.lblExo = new System.Windows.Forms.Label();
            this.lblNumberExo = new System.Windows.Forms.Label();
            this.lblActualCours = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.pgB_Progres = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCours
            // 
            this.lblCours.AutoSize = true;
            this.lblCours.Location = new System.Drawing.Point(104, 183);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(93, 13);
            this.lblCours.TabIndex = 0;
            this.lblCours.Text = "Votre cours actuel";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(104, 138);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(75, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Identifiez-vous";
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(229, 135);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(121, 21);
            this.cbName.TabIndex = 4;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // lblAcLec
            // 
            this.lblAcLec.AutoSize = true;
            this.lblAcLec.Location = new System.Drawing.Point(104, 232);
            this.lblAcLec.Name = "lblAcLec";
            this.lblAcLec.Size = new System.Drawing.Size(69, 13);
            this.lblAcLec.TabIndex = 5;
            this.lblAcLec.Text = "Leçon actuel";
            // 
            // lblActLec
            // 
            this.lblActLec.AutoSize = true;
            this.lblActLec.Location = new System.Drawing.Point(226, 232);
            this.lblActLec.Name = "lblActLec";
            this.lblActLec.Size = new System.Drawing.Size(35, 13);
            this.lblActLec.TabIndex = 6;
            this.lblActLec.Text = "label2";
            // 
            // lblExo
            // 
            this.lblExo.AutoSize = true;
            this.lblExo.Location = new System.Drawing.Point(104, 299);
            this.lblExo.Name = "lblExo";
            this.lblExo.Size = new System.Drawing.Size(51, 13);
            this.lblExo.TabIndex = 7;
            this.lblExo.Text = "Exercice:";
            // 
            // lblNumberExo
            // 
            this.lblNumberExo.AutoSize = true;
            this.lblNumberExo.Location = new System.Drawing.Point(226, 299);
            this.lblNumberExo.Name = "lblNumberExo";
            this.lblNumberExo.Size = new System.Drawing.Size(35, 13);
            this.lblNumberExo.TabIndex = 8;
            this.lblNumberExo.Text = "label2";
            this.lblNumberExo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblNumberExo_MouseDown);
            // 
            // lblActualCours
            // 
            this.lblActualCours.AutoSize = true;
            this.lblActualCours.Location = new System.Drawing.Point(226, 183);
            this.lblActualCours.Name = "lblActualCours";
            this.lblActualCours.Size = new System.Drawing.Size(29, 13);
            this.lblActualCours.TabIndex = 1;
            this.lblActualCours.Text = "label";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(226, 265);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(29, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "label";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.pgB_Progres);
            this.panel1.Controls.Add(this.cbName);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.lblActualCours);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblCours);
            this.panel1.Controls.Add(this.lblNumberExo);
            this.panel1.Controls.Add(this.lblAcLec);
            this.panel1.Controls.Add(this.lblActLec);
            this.panel1.Controls.Add(this.lblExo);
            this.panel1.Location = new System.Drawing.Point(30, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 524);
            this.panel1.TabIndex = 9;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(380, 444);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 47);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Continuer";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pgB_Progres
            // 
            this.pgB_Progres.Location = new System.Drawing.Point(229, 337);
            this.pgB_Progres.Name = "pgB_Progres";
            this.pgB_Progres.Size = new System.Drawing.Size(93, 26);
            this.pgB_Progres.Step = 1;
            this.pgB_Progres.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgB_Progres.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.Location = new System.Drawing.Point(212, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 10;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 659);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.Text = "La Casa de Babbel";
            this.Activated += new System.EventHandler(this.frmLogin_Activated);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label lblAcLec;
        private System.Windows.Forms.Label lblActLec;
        private System.Windows.Forms.Label lblExo;
        private System.Windows.Forms.Label lblNumberExo;
        private System.Windows.Forms.Label lblActualCours;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar pgB_Progres;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel2;
    }
}

