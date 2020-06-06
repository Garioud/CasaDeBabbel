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
        private int nbExoMax;
        private DataSet dsEsp;
        private int numLeçon;
        private string codeCours;
        private string phrase;
        private string phraseEsp;
        private Dictionary<String, int> codeUser = new Dictionary<string, int>();
        private string actualUser;
        private string enonce;
        private string[] tabMot;
        private string nomDT;
        
        int ix = 10;
        int iy = 10;
        int x = 10;
        int y=10;
        int riX = 10;
        int riY = 10;
        int rX = 10;
        int rY = 10;

        public frmDeso()
        {
            InitializeComponent();
            dsEsp = Application.OpenForms.Cast<frmLogin>().First().GetDataSet;
            nbExo= Application.OpenForms.Cast<frmLogin>().First().getNumExo;
            numLeçon = Application.OpenForms.Cast<frmLogin>().First().getNumLecon;
            codeCours = Application.OpenForms.Cast<frmLogin>().First().getCodeCours;
            codeUser= Application.OpenForms.Cast<frmLogin>().First().GetDictionnary;
            actualUser= Application.OpenForms.Cast<frmLogin>().First().GetCurrentUser;
            nbExoMax = Application.OpenForms.Cast<frmLogin>().First().getNumExoTotal;
            lblNomPersonne.Text = actualUser;
        }
    
        public frmDeso(string phrase, string trad, string enonce,string nomTable)
        {
            InitializeComponent();
            dsEsp = Application.OpenForms.Cast<frmLogin>().First().GetDataSet;
            nbExo = Application.OpenForms.Cast<frmLogin>().First().getNumExo;
            numLeçon = Application.OpenForms.Cast<frmLogin>().First().getNumLecon;
            codeCours = Application.OpenForms.Cast<frmLogin>().First().getCodeCours;
            codeUser = Application.OpenForms.Cast<frmLogin>().First().GetDictionnary;
            actualUser = Application.OpenForms.Cast<frmLogin>().First().GetCurrentUser;
            lblNomPersonne.Text = actualUser;
            lblActualCours.Text = Application.OpenForms.Cast<frmLogin>().First().getTitreCours;
            lblActLec.Text = Application.OpenForms.Cast<frmLogin>().First().getTitreLecon;
            nbExoMax = Application.OpenForms.Cast<frmLogin>().First().getNumExoTotal;
            lblNumberExo.Text = $"{nbExo}/{nbExoMax}";
            this.phraseEsp = phrase;
            this.phrase = trad;
            this.enonce = enonce;
            lblDesc.Text = "-->" + enonce;
            generatePhrase();
            nomDT = nomTable;
        }
        public frmDeso(string phrase, string trad, string enonce, string nomTable,string regle)
        {
            InitializeComponent();
            dsEsp = Application.OpenForms.Cast<frmLogin>().First().GetDataSet;
            nbExo = Application.OpenForms.Cast<frmLogin>().First().getNumExo;
            numLeçon = Application.OpenForms.Cast<frmLogin>().First().getNumLecon;
            codeCours = Application.OpenForms.Cast<frmLogin>().First().getCodeCours;
            codeUser = Application.OpenForms.Cast<frmLogin>().First().GetDictionnary;
            actualUser = Application.OpenForms.Cast<frmLogin>().First().GetCurrentUser;
            lblNomPersonne.Text = actualUser;
            lblActualCours.Text = Application.OpenForms.Cast<frmLogin>().First().getTitreCours;
            lblActLec.Text = Application.OpenForms.Cast<frmLogin>().First().getTitreLecon;
            nbExoMax = Application.OpenForms.Cast<frmLogin>().First().getNumExoTotal;
            lblNumberExo.Text = $"{nbExo}/{nbExoMax}";
            this.phraseEsp = phrase;
            this.phrase = trad;
            this.enonce = enonce;
            lblDesc.Text = "-->" + enonce;
            generatePhrase();
            nomDT = nomTable;
        }


        private void generatePhrase()
        {
            tabMot = phraseEsp.Split(' ');
            Random rnd = new Random();
            string[] tabMotrnd = tabMot.OrderBy(x => rnd.Next()).ToArray();
       
            for (int i=0;i< tabMotrnd.Length; i++)
            {
                Label lbl = new Label();
                pnlDesordre.Controls.Add(lbl);
                lbl.Name = "lbl" + i;
                lbl.Text = tabMotrnd[i];
                lbl.Click += new EventHandler(this.moveToPhrase);
                lbl.AutoSize = true;
                lbl.Font = new Font("Arial", 14);
                lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.Location = new Point(x, y);
                
                x += lbl.Width+50;

                if(i%6==0&&i!=0)
                {
                    x = ix;
                    y += 40;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void moveToPhrase(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            pnlDesordre.Controls.Remove(lb);
            lb.Location = new Point(rX, rY);
            lb.Click -= new EventHandler(this.moveToPhrase);
            pnlEndroit.Controls.Add(lb);

            if (pnlEndroit.Controls.Count%6==0&& pnlEndroit.Controls.Count !=0)
            {
                rX = riX;
                rY += 40;
            }
            else
            {
                rX += lb.Width + 50;
            }

            UpdatePanel();



        }
        private void btnHideWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UpdatePanel()
        {

            x = ix;
            y = iy;
            int i = 0;
            foreach(Label lbl in pnlDesordre.Controls)
            {

                lbl.Location = new Point(x, y);

                if (i % 6 == 0 &&i != 0)
                {
                    x = ix;
                    y += 40;
                }
                else
                {
                    x += lbl.Width + 50;
                }


                i++;


            }






        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            pnlDesordre.Controls.Clear();
            pnlEndroit.Controls.Clear();
            x = ix;
            y = iy;
           
            for (int i = 0;i<tabMot.Length;i++)
            {

                Label lbl = new Label();
                pnlEndroit.Controls.Add(lbl);
                lbl.Name = "lbl" + i;
                lbl.Text = tabMot[i];   
                lbl.AutoSize = true;
                lbl.Font = new Font("Arial", 14);
                lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.Location = new Point(x, y);

                x += lbl.Width + 50;

                if (i % 6 == 0 && i != 0)
                {
                    x = ix;
                    y += 40;
                }

            }
            pnlEndroit.Enabled = false;
            pnlDesordre.Enabled=false;
            btnReturn.Enabled = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (pnlEndroit.Controls.Count > 0)
            {
                int endX;
            
                   

                Label lbl = (Label)pnlEndroit.Controls[pnlEndroit.Controls.Count - 1];
                rX -= (lbl.Width + 50);
             
                if (pnlEndroit.Controls.Count%6==0&& pnlEndroit.Controls.Count!=0)
                {
                    endX = ((Label)pnlEndroit.Controls[5]).Location.X;
                    rY -= 40;
                    rX = endX;
                }
                pnlEndroit.Controls.Remove(lbl);
                pnlDesordre.Controls.Add(lbl);
                lbl.Click += new EventHandler(this.moveToPhrase);
                UpdatePanel();
            }







        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmLogin exer = new frmLogin();
            this.Hide();

            exer.Show();
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
                dsEsp.Tables[nomDT].Rows.Add(nbExo, true, phraseEsp, null);
                Application.OpenForms.Cast<frmLogin>().First().Actualize(dsEsp);
         
            }
            else { 
            
            
            
            }
        }
    }
}
