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
    public partial class frmVerbe : Form
    {
        private int nbExo;
        private int nbExoMax;
        private DataSet dsEsp;
        private int numLeçon;
        private string codeCours;
        private string phrase;
        private string phraseEsp;
        private Dictionary<String, int> codeUser = new Dictionary<string, int>();
        private string actualUser;
        private string nomDT;

        public frmVerbe()
        {

            InitializeComponent();
            dsEsp = Application.OpenForms.Cast<frmLogin>().First().GetDataSet;
            nbExo = Application.OpenForms.Cast<frmLogin>().First().getNumExo;
            numLeçon = Application.OpenForms.Cast<frmLogin>().First().getNumLecon;
            codeCours = Application.OpenForms.Cast<frmLogin>().First().getCodeCours;
            codeUser = Application.OpenForms.Cast<frmLogin>().First().GetDictionnary;
            actualUser = Application.OpenForms.Cast<frmLogin>().First().GetCurrentUser;
            nbExoMax = Application.OpenForms.Cast<frmLogin>().First().getNumExoTotal;
        }
        public frmVerbe(string nomTable)
        {

            InitializeComponent();
            dsEsp = Application.OpenForms.Cast<frmLogin>().First().GetDataSet;
            nbExo = Application.OpenForms.Cast<frmLogin>().First().getNumExo;
            numLeçon = Application.OpenForms.Cast<frmLogin>().First().getNumLecon;
            codeCours = Application.OpenForms.Cast<frmLogin>().First().getCodeCours;
            codeUser = Application.OpenForms.Cast<frmLogin>().First().GetDictionnary;
            actualUser = Application.OpenForms.Cast<frmLogin>().First().GetCurrentUser;
            nbExoMax = Application.OpenForms.Cast<frmLogin>().First().getNumExoTotal;
            nomDT = nomTable;
        }


        private void frmVerbe_FormClosed(object sender, FormClosedEventArgs e)
        {
            
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
                    this.Close();
                    dsEsp.Tables[nomDT].Rows.Add(nbExo, true, null, null);

                    Application.OpenForms.Cast<frmLogin>().First().afficheRecap(dsEsp);

                }
            }
        }
    }
}
