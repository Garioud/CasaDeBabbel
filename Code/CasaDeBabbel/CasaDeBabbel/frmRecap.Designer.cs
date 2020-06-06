namespace CasaDeBabbel
{
    partial class frmRecap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecap));
            this.pnlImage = new System.Windows.Forms.Panel();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnHideWindow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlFull = new System.Windows.Forms.Panel();
            this.pnlBad = new System.Windows.Forms.Panel();
            this.pnlGood = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblNomPersonne = new System.Windows.Forms.Label();
            this.lblCours = new System.Windows.Forms.Label();
            this.lblActualCours = new System.Windows.Forms.Label();
            this.lblActLec = new System.Windows.Forms.Label();
            this.lblAcLec = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pnlToolbar.SuspendLayout();
            this.pnlFull.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlImage
            // 
            this.pnlImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlImage.BackgroundImage")));
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(220, 135);
            this.pnlImage.TabIndex = 16;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.Controls.Add(this.lblName);
            this.pnlToolbar.Controls.Add(this.btnHideWindow);
            this.pnlToolbar.Controls.Add(this.btnExit);
            this.pnlToolbar.Location = new System.Drawing.Point(220, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(780, 35);
            this.pnlToolbar.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Récapitulatif";
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
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(846, 407);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(140, 50);
            this.btnMenu.TabIndex = 17;
            this.btnMenu.Text = "MENU";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlFull
            // 
            this.pnlFull.Controls.Add(this.pnlBad);
            this.pnlFull.Controls.Add(this.pnlGood);
            this.pnlFull.Controls.Add(this.btnContinue);
            this.pnlFull.Controls.Add(this.btnMenu);
            this.pnlFull.Location = new System.Drawing.Point(0, 135);
            this.pnlFull.Name = "pnlFull";
            this.pnlFull.Size = new System.Drawing.Size(1000, 465);
            this.pnlFull.TabIndex = 18;
            // 
            // pnlBad
            // 
            this.pnlBad.Location = new System.Drawing.Point(515, 29);
            this.pnlBad.Name = "pnlBad";
            this.pnlBad.Size = new System.Drawing.Size(473, 378);
            this.pnlBad.TabIndex = 20;
            // 
            // pnlGood
            // 
            this.pnlGood.Location = new System.Drawing.Point(27, 29);
            this.pnlGood.Name = "pnlGood";
            this.pnlGood.Size = new System.Drawing.Size(473, 378);
            this.pnlGood.TabIndex = 19;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(698, 407);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(140, 50);
            this.btnContinue.TabIndex = 18;
            this.btnContinue.Text = "Continuer le cours";
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // lblNomPersonne
            // 
            this.lblNomPersonne.AutoSize = true;
            this.lblNomPersonne.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPersonne.Location = new System.Drawing.Point(833, 38);
            this.lblNomPersonne.Name = "lblNomPersonne";
            this.lblNomPersonne.Size = new System.Drawing.Size(120, 23);
            this.lblNomPersonne.TabIndex = 30;
            this.lblNomPersonne.Text = "NomPersonne";
            this.lblNomPersonne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCours
            // 
            this.lblCours.AutoSize = true;
            this.lblCours.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCours.Location = new System.Drawing.Point(227, 44);
            this.lblCours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(172, 22);
            this.lblCours.TabIndex = 33;
            this.lblCours.Text = "Votre cours actuel :";
            // 
            // lblActualCours
            // 
            this.lblActualCours.AutoSize = true;
            this.lblActualCours.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualCours.Location = new System.Drawing.Point(403, 44);
            this.lblActualCours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActualCours.Name = "lblActualCours";
            this.lblActualCours.Size = new System.Drawing.Size(50, 22);
            this.lblActualCours.TabIndex = 34;
            this.lblActualCours.Text = "label";
            // 
            // lblActLec
            // 
            this.lblActLec.AutoSize = true;
            this.lblActLec.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActLec.Location = new System.Drawing.Point(374, 74);
            this.lblActLec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActLec.Name = "lblActLec";
            this.lblActLec.Size = new System.Drawing.Size(61, 22);
            this.lblActLec.TabIndex = 37;
            this.lblActLec.Text = "label2";
            // 
            // lblAcLec
            // 
            this.lblAcLec.AutoSize = true;
            this.lblAcLec.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcLec.Location = new System.Drawing.Point(227, 74);
            this.lblAcLec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcLec.Name = "lblAcLec";
            this.lblAcLec.Size = new System.Drawing.Size(143, 22);
            this.lblAcLec.TabIndex = 36;
            this.lblAcLec.Text = "Leçon actuelle :";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(374, 96);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(50, 22);
            this.lblDesc.TabIndex = 38;
            this.lblDesc.Text = "label";
            // 
            // frmRecap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblActLec);
            this.Controls.Add(this.lblAcLec);
            this.Controls.Add(this.lblCours);
            this.Controls.Add(this.lblActualCours);
            this.Controls.Add(this.lblNomPersonne);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlFull);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecap";
            this.Load += new System.EventHandler(this.frmRecap_Load);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.pnlFull.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnHideWindow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnlFull;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Panel pnlBad;
        private System.Windows.Forms.Panel pnlGood;
        private System.Windows.Forms.Label lblNomPersonne;
        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.Label lblActualCours;
        private System.Windows.Forms.Label lblActLec;
        private System.Windows.Forms.Label lblAcLec;
        private System.Windows.Forms.Label lblDesc;
    }
}