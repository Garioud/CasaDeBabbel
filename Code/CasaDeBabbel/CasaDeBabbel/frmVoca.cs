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
    public partial class frmVoca : Form
    {
        private int nbExo;
        private int nbExoTotal;
        private DataSet dsEsp;
        private int numLeçon;
        private string codeCours;
        private string[][] tabVoca;
        private string titreCours;
        private string titreLecon;
        private string descLecon;
        int xi = 30;
        int xy = 30;
        private Dictionary<String, int> codeUser = new Dictionary<string, int>();
        private string actualUser;
        public frmVoca()
        {
            dsEsp = Application.OpenForms.Cast<frmLogin>().First().GetDataSet;
            nbExo = Application.OpenForms.Cast<frmLogin>().First().getNumExo;
            numLeçon = Application.OpenForms.Cast<frmLogin>().First().getNumLecon;
            codeCours = Application.OpenForms.Cast<frmLogin>().First().getCodeCours;
            codeUser = Application.OpenForms.Cast<frmLogin>().First().GetDictionnary;
            actualUser = Application.OpenForms.Cast<frmLogin>().First().GetCurrentUser;
            titreCours = Application.OpenForms.Cast<frmLogin>().First().getTitreCours;
            titreLecon = Application.OpenForms.Cast<frmLogin>().First().getTitreLecon;
            descLecon = Application.OpenForms.Cast<frmLogin>().First().getDescLecon;
            nbExoTotal = Application.OpenForms.Cast<frmLogin>().First().getNumExoTotal;
            InitializeComponent();
        }
        public frmVoca(string[][] mot)
        {
            InitializeComponent();
            dsEsp = Application.OpenForms.Cast<frmLogin>().First().GetDataSet;
            nbExo = Application.OpenForms.Cast<frmLogin>().First().getNumExo;
            numLeçon = Application.OpenForms.Cast<frmLogin>().First().getNumLecon;
            codeCours = Application.OpenForms.Cast<frmLogin>().First().getCodeCours;
            codeUser = Application.OpenForms.Cast<frmLogin>().First().GetDictionnary;
            actualUser = Application.OpenForms.Cast<frmLogin>().First().GetCurrentUser;
            titreCours = Application.OpenForms.Cast<frmLogin>().First().getTitreCours;
            titreLecon = Application.OpenForms.Cast<frmLogin>().First().getTitreLecon;
            descLecon = Application.OpenForms.Cast<frmLogin>().First().getDescLecon;
            nbExoTotal = Application.OpenForms.Cast<frmLogin>().First().getNumExoTotal;
            tabVoca = mot;
            generateImg();
        }



        private void frmVoca_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Application.OpenForms.Cast<frmLogin>().First().Activate();
            Application.OpenForms.Cast<frmLogin>().First().Visible = true;
            this.Close();
        }
        private void generateImg()
        {
            for (int i=0; i<tabVoca.GetLength(0);i++)
            {
                string fileAdress = tabVoca[i][3];
                if(fileAdress!=null)
                {
                    Image img = Image.FromFile(@"..\baseImages\" + fileAdress);
                    FicheVoca fch = new FicheVoca();
                    fch.Image = img;
                    fch.Origin = tabVoca[i][2];
                    fch.Word = tabVoca[i][0];
                    fch.Trad = tabVoca[i][1];
                    fch.Location = new Point(xi, xy);
                    xi += 50 + fch.Width;
                    pnlVoca.Controls.Add(fch);

                }
                else
                {               
                        FicheVoca fch = new FicheVoca(); 
                        fch.Origin = tabVoca[i][2];
                        fch.Word = tabVoca[i][0];
                        fch.Trad = tabVoca[i][1];
                        fch.Location = new Point(xi, xy);
                         xi += 50 + fch.Width;
                    pnlVoca.Controls.Add(fch);

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
