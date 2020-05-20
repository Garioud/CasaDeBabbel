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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNumberExo = new System.Windows.Forms.Label();
            this.lblExo = new System.Windows.Forms.Label();
            this.lblActLec = new System.Windows.Forms.Label();
            this.lblAcLec = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblActualCours = new System.Windows.Forms.Label();
            this.lblCours = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumberExo);
            this.groupBox1.Controls.Add(this.lblExo);
            this.groupBox1.Controls.Add(this.lblActLec);
            this.groupBox1.Controls.Add(this.lblAcLec);
            this.groupBox1.Controls.Add(this.cbName);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.lblDesc);
            this.groupBox1.Controls.Add(this.lblActualCours);
            this.groupBox1.Controls.Add(this.lblCours);
            this.groupBox1.Location = new System.Drawing.Point(45, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 536);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblNumberExo
            // 
            this.lblNumberExo.AutoSize = true;
            this.lblNumberExo.Location = new System.Drawing.Point(105, 262);
            this.lblNumberExo.Name = "lblNumberExo";
            this.lblNumberExo.Size = new System.Drawing.Size(35, 13);
            this.lblNumberExo.TabIndex = 8;
            this.lblNumberExo.Text = "label2";
            // 
            // lblExo
            // 
            this.lblExo.AutoSize = true;
            this.lblExo.Location = new System.Drawing.Point(6, 262);
            this.lblExo.Name = "lblExo";
            this.lblExo.Size = new System.Drawing.Size(51, 13);
            this.lblExo.TabIndex = 7;
            this.lblExo.Text = "Exercice:";
            // 
            // lblActLec
            // 
            this.lblActLec.AutoSize = true;
            this.lblActLec.Location = new System.Drawing.Point(104, 194);
            this.lblActLec.Name = "lblActLec";
            this.lblActLec.Size = new System.Drawing.Size(35, 13);
            this.lblActLec.TabIndex = 6;
            this.lblActLec.Text = "label2";
            // 
            // lblAcLec
            // 
            this.lblAcLec.AutoSize = true;
            this.lblAcLec.Location = new System.Drawing.Point(6, 194);
            this.lblAcLec.Name = "lblAcLec";
            this.lblAcLec.Size = new System.Drawing.Size(69, 13);
            this.lblAcLec.TabIndex = 5;
            this.lblAcLec.Text = "Leçon actuel";
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(107, 60);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(121, 21);
            this.cbName.TabIndex = 4;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 63);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(75, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Identifiez-vous";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(105, 229);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(0, 13);
            this.lblDesc.TabIndex = 2;
            // 
            // lblActualCours
            // 
            this.lblActualCours.AutoSize = true;
            this.lblActualCours.Location = new System.Drawing.Point(105, 127);
            this.lblActualCours.Name = "lblActualCours";
            this.lblActualCours.Size = new System.Drawing.Size(0, 13);
            this.lblActualCours.TabIndex = 1;
            // 
            // lblCours
            // 
            this.lblCours.AutoSize = true;
            this.lblCours.Location = new System.Drawing.Point(6, 127);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(93, 13);
            this.lblCours.TabIndex = 0;
            this.lblCours.Text = "Votre cours actuel";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 659);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLogin";
            this.Text = "La Casa de Babbel";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblActualCours;
        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.Label lblActLec;
        private System.Windows.Forms.Label lblAcLec;
        private System.Windows.Forms.Label lblNumberExo;
        private System.Windows.Forms.Label lblExo;
    }
}

