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
        private string[][] listeVoca;
        private string titreCours;
        private string titreLecon;
        private string descLecon;

        private Dictionary<String, int> codeUser = new Dictionary<string, int>();
        private string actualUser;
        public frmVoca()
        {           
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
            listeVoca = mot;
        }

        private void fillCB(ComboBox cb, string table, int pos, int pos2, DataSet ds)
        {
            try
            {
                DataTable temporaryTable = ds.Tables[table];
                foreach (DataRow line in temporaryTable.Rows)
                {
                    string str = line.Field<String>("pnUtil") + " " + line.Field<String>("nomUtil");
                    int code = line.Field<int>("codeUtil");
                    cb.Items.Add(str);
                   

                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
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
    }
}
