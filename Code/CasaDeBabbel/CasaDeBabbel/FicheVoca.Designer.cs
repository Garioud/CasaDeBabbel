namespace CasaDeBabbel
{
    partial class FicheVoca
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctbVoca = new System.Windows.Forms.PictureBox();
            this.lblMot = new System.Windows.Forms.Label();
            this.lblTrad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctbVoca)).BeginInit();
            this.SuspendLayout();
            // 
            // pctbVoca
            // 
            this.pctbVoca.Location = new System.Drawing.Point(0, 0);
            this.pctbVoca.Name = "pctbVoca";
            this.pctbVoca.Size = new System.Drawing.Size(150, 150);
            this.pctbVoca.TabIndex = 0;
            this.pctbVoca.TabStop = false;
            // 
            // lblMot
            // 
            this.lblMot.AutoSize = true;
            this.lblMot.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMot.Location = new System.Drawing.Point(4, 153);
            this.lblMot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMot.Name = "lblMot";
            this.lblMot.Size = new System.Drawing.Size(50, 22);
            this.lblMot.TabIndex = 19;
            this.lblMot.Text = "label";
            // 
            // lblTrad
            // 
            this.lblTrad.AutoSize = true;
            this.lblTrad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrad.Location = new System.Drawing.Point(4, 175);
            this.lblTrad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrad.Name = "lblTrad";
            this.lblTrad.Size = new System.Drawing.Size(50, 22);
            this.lblTrad.TabIndex = 20;
            this.lblTrad.Text = "label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "label";
            // 
            // FicheVoca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTrad);
            this.Controls.Add(this.lblMot);
            this.Controls.Add(this.pctbVoca);
            this.Name = "FicheVoca";
            this.Size = new System.Drawing.Size(150, 250);
            ((System.ComponentModel.ISupportInitialize)(this.pctbVoca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctbVoca;
        private System.Windows.Forms.Label lblMot;
        private System.Windows.Forms.Label lblTrad;
        private System.Windows.Forms.Label label2;
    }
}
