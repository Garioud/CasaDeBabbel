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
        }
        public Image setImage
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
    }
}
