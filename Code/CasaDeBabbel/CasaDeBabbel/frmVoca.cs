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
        
        private string titreCours;
        private string titreLecon;
        private string descLecon;
        private string[][] tabVoca;

        private Dictionary<String, int> codeUser = new Dictionary<string, int>();
        private string actualUser;
        private int xi = 30;
        private int xy = 30;
       
        private int nbExoMax;
        private string nomDT;
        public frmVoca()
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
            lblActualCours.Text = titreCours;
            lblDesc.Text = descLecon;
            generateImg();
      
        }
        public frmVoca(string[][] mot,string ennonce,string nomTable)
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
            lblActualCours.Text = titreCours;
            lblDesc.Text = descLecon;
            lblNomPersonne.Text = actualUser;
            lblActLec.Text = titreLecon;
            lblDesc.Text = descLecon;
            nbExoMax = Application.OpenForms.Cast<frmLogin>().First().getNumExoTotal;
            lblNumberExo.Text = $"{nbExo}/{nbExoMax}";
            tabVoca = mot;
            generateImg();
            nomDT = nomTable;
        }
        public frmVoca(string[][] mot, string ennonce, string nomTable,string regle)
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
            lblActualCours.Text = titreCours;
            lblDesc.Text = descLecon;
            lblNomPersonne.Text = actualUser;
            lblActLec.Text = titreLecon;
            lblDesc.Text = descLecon;
            nbExoMax = Application.OpenForms.Cast<frmLogin>().First().getNumExoTotal;
            lblNumberExo.Text = $"{nbExo}/{nbExoMax}";
            tabVoca = mot;
            nomDT = nomTable;
            generateImg();
        }

        private void generateImg()
        {
            for (int i = 0; i < tabVoca.GetLength(0); i++)
            {
                string fileAdress = tabVoca[i][3];
                if (fileAdress != null)
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

        private void frmVoca_FormClosed(object sender, FormClosedEventArgs e)
        {
         

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Application.OpenForms.Cast<frmLogin>().First().Activate();
            Application.OpenForms.Cast<frmLogin>().First().Visible = true;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHideWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int codeUtil;
            codeUser.TryGetValue(actualUser, out codeUtil);
            if (nbExo + 1 <= nbExoMax && codeUtil != -1)
            {
                foreach (DataRow dr in dsEsp.Tables["Utilisateurs"].Rows)
                {
                    if (dr.Field<int>("codeUtil") == codeUtil)
                    {
                        dr["codeExo"] = nbExo + 1;
                    }
                }

                this.Close();


                dsEsp.Tables[nomDT].Rows.Add(nbExo, true, null, null);

                Application.OpenForms.Cast<frmLogin>().First().Actualize(dsEsp);

            }
            else
            {



            }
        }
    }
}
