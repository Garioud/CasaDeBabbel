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
        public frmDeso()
        {
            InitializeComponent();
            dsEsp = Application.OpenForms.Cast<frmLogin>().First().GetDataSet;
            nbExo= Application.OpenForms.Cast<frmLogin>().First().getExoN();
            numLeçon = Application.OpenForms.Cast<frmLogin>().First().getCodeLeçon();
            codeCours = Application.OpenForms.Cast<frmLogin>().First().getNumCours();
            codeUser= Application.OpenForms.Cast<frmLogin>().First().GetDictionnary;
            actualUser= Application.OpenForms.Cast<frmLogin>().First().GetCurrentUser;
            lblNomPersonne.Text = actualUser;
        }
        private int nbExo;
        private DataSet dsEsp;
        private int numLeçon;
        private string codeCours;
        private int numPhrase;
        private string phrase;
        private string phraseEsp;
        private Dictionary<String, int> codeUser = new Dictionary<string, int>();
        private string actualUser;

        private void frmDeso_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.ActiveForm.Activate();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void getPhrase()
        {









        }

        
    }
}
