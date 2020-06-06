using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDeBabbel
{
    public partial class FicheVoca : UserControl
    {
        private Image img;
        private string origine;
        private string mot;
        private string trad;
        public FicheVoca()
        {
            InitializeComponent();
            pctbVoca.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public Image Image
        {
            get
            {
                return pctbVoca.Image;
            }
            set
            {
                pctbVoca.Image = value;
            }

     
        
        }

        public string Origin
        {
            get
            {
                return lblOrigine.Text;
            }
            set
            {
                lblOrigine.Text = value;
            }
        }

        public string Word
        {
            get
            {
                return lblMot.Text;
            }
            set
            {
                lblMot.Text = value;
            }
        }
        public string Trad
        {
            get
            {
                return lblTrad.Text;
            }
            set
            {
                lblTrad.Text = value;
            }
        }







    }
}
