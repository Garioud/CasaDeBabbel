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
            lblActualCours.Text = Application.OpenForms.Cast<frmLogin>().First().getTitreCours;
            lblActLec.Text = Application.OpenForms.Cast<frmLogin>().First().getTitreLecon;
            this.phraseEsp = phrase;
            this.phrase = trad;
            this.enonce = enonce;
            generatePhrase();
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
                pnlEndroit.Controls.Remove(lbl);
                pnlDesordre.Controls.Add(lbl);
                UpdatePanel();
                if (pnlEndroit.Controls.Count%6==0&& pnlEndroit.Controls.Count!=0)
                {
                    endX = ((Label)pnlEndroit.Controls[5]).Location.X;
                    rY -= 40;
                    rX = endX;
                }
            }







        }
    }
}
