using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDeBabbel
{
    public partial class frmDeso : Form
    {
        private int nbExo;
        private DataSet dsEsp;
        private int numLeçon;
        private string codeCours;
        private int numPhrase;
        private string phrase;
        private string phraseEsp;
        private Dictionary<String, int> codeUser = new Dictionary<string, int>();
        private string actualUser;
        private string enonce;
        private string[] tabMot;
        int x = 10;
        int y = 10;
        int lx = 75;
        int ly = 15;

        public frmDeso()
        {
            InitializeComponent();
            dsEsp = Application.OpenForms.Cast<frmLogin>().First().GetDataSet;
            nbExo= Application.OpenForms.Cast<frmLogin>().First().getNumExo;
            numLeçon = Application.OpenForms.Cast<frmLogin>().First().getNumLecon;
            codeCours = Application.OpenForms.Cast<frmLogin>().First().getCodeCours;
            codeUser= Application.OpenForms.Cast<frmLogin>().First().GetDictionnary;
            actualUser= Application.OpenForms.Cast<frmLogin>().First().GetCurrentUser;
            lblNomPersonne.Text = actualUser;
        }
    
        public frmDeso(string phrase, string trad, string enonce)
        {
            InitializeComponent();
            dsEsp = Application.OpenForms.Cast<frmLogin>().First().GetDataSet;
            nbExo = Application.OpenForms.Cast<frmLogin>().First().getNumExo;
            numLeçon = Application.OpenForms.Cast<frmLogin>().First().getNumLecon;
            codeCours = Application.OpenForms.Cast<frmLogin>().First().getCodeCours;
            codeUser = Application.OpenForms.Cast<frmLogin>().First().GetDictionnary;
            actualUser = Application.OpenForms.Cast<frmLogin>().First().GetCurrentUser;
            lblNomPersonne.Text = actualUser;
            this.phraseEsp = phrase;
            this.phrase = trad;
            this.enonce = enonce;
            generatePhrase();
        }
        

     
        private void generatePhrase()
        {
            tabMot = phraseEsp.Split(' ');
            int ix = x;
            int iy = y;
            for (int i=0;i<tabMot.Length; i++)
            {
                Label lbl = new Label();
                lbl.Name = "lbl" + i;
                lbl.Text = tabMot[i];
                lbl.Size = new Size(lx, ly);
                lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.Location = new Point(ix, iy);
                pnlDesordre.Controls.Add(lbl);
                ix += 110;
                if(i%8==0&&i!=0)
                {
                    ix = x;
                    iy += 30;
                }
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHideWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
