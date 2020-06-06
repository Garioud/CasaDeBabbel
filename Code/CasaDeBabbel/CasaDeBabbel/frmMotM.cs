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
    public partial class frmMotM : Form
    {

        List<TextBox> textBoxList = new List<TextBox>();
        private string phrase;
        private string trad;
        private string pos;
        private string enonce;
        private int nbExo;
        private int nbExoMax;
        private DataSet dsEsp;
        private int numLeçon;
        private string codeCours;     
        private Dictionary<String, int> codeUser = new Dictionary<string, int>();
        private string actualUser;
        private bool EstJuste;
        private string nomDT;
        private string listmot;

     
        public frmMotM()
        {
            InitializeComponent();
        }
        public frmMotM(string phrase, string trad, string pos, string enonce, string nomTable, string regle)
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
            generatePhrase(phrase, pos, trad);
            this.phrase = phrase;
            this.trad = trad;
            this.pos = pos;
            this.enonce = enonce;
            lblEnnonce.Text = enonce;
            lblDesc.Text = Application.OpenForms.Cast<frmLogin>().First().getDescLecon;
            lblRegle.Text = regle;
            EstJuste = true;
            nomDT = nomTable;
            pgB_Progres.Maximum = nbExoMax;
            pgB_Progres.Value = nbExo;
        }
        public frmMotM(string phrase, string trad, string pos, string enonce,string nomTable)
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
            generatePhrase(phrase, pos, trad);
            nomDT = nomTable;
            this.phrase = phrase;
            this.trad = trad;
            this.pos = pos;
            this.enonce = enonce;
            lblEnnonce.Text = enonce;
            lblDesc.Text = Application.OpenForms.Cast<frmLogin>().First().getDescLecon;
            EstJuste = true;
            pgB_Progres.Maximum = nbExoMax;
            pgB_Progres.Value = nbExo;
        }

        private void frmMotM_Load(object sender, EventArgs e)
        {

        }
        private void generatePhrase(string phrase,string pos, string traduction)
        {
            string[] tabPhrase = phrase.Split(' ');
            string[] intPos = pos.Split('/');
            int[] tabPos = new int[intPos.Length];
            
            int position = 50;
            int ligne = 200;

            for(int i = 0; i < intPos.Length; i++)
            {
                tabPos[i] = int.Parse(intPos[i])-1;
            }
            
            for(int i = 0; i < tabPhrase.Length; i++)
            {
                if (tabPos.Contains(i))
                {
                    if (position+15*15 >= 900)
                    {
                        ligne += 40;
                        position = 50;
                    }
                    TextBox txtb = new TextBox();
                    pnlListe.Controls.Add(txtb);
                    txtb.Name = "txtMot" + i;
                    txtb.Width = 15 * 15;
                    txtb.Font = new Font("Arial", 14);
                    txtb.Location = new Point(position, ligne);
                    position += 15 * 15;
                    txtb.TextChanged += new EventHandler(this.checkTXT);
                    textBoxList.Add(txtb);

                    if (listmot==null)
                        listmot = tabPhrase[i];
                    else
                        listmot += "/" + tabPhrase[i];


                    
                }
                else
                {
                    if (position >= 800)
                    {
                        ligne += 40;
                        position = 50;
                    }
                    Label lbl = new Label();
                    pnlListe.Controls.Add(lbl);
                    lbl.Name = "lblMot" + i;
                    lbl.AutoSize = true;             
                    lbl.Font = new Font("Arial", 14);
                    lbl.Location = new Point(position, ligne);
                    lbl.Text = tabPhrase[i];
                    position += lbl.Width;

                    
                }
            }
            
            pnlListe.Controls.Add(new Label()
            {
                Name = "lblPhrase",
                Height = 30,
                AutoSize = true,               
                Font = new Font("Arial", 14),
                TextAlign = ContentAlignment.TopLeft,
                Location = new Point(50, 100),
                Text = Convert.ToString(traduction)
            });
        }

        private void frmMotM_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        

        
        private void btnAide_Click(object sender, EventArgs e)
        {
            EstJuste = false;
            pnlListe.Controls.Add(new Label()
            {
                Name = "lblReponse",
                Height = 30,
                Font = new Font("Arial", 14),
                TextAlign = ContentAlignment.TopLeft,
                Location = new Point(50, 300),
                AutoSize = true,
                Text = Convert.ToString(phrase)
            }); ;
            
        }

        private void verif(string phrase, string pos)
        {
            string[] tabPhrase = phrase.Split(' ');
            string[] intPos = pos.Split('/');

            for (int i = 0; i < intPos.Length; i++) {
                if (textBoxList[i].Text == tabPhrase[int.Parse(intPos[i])-1])
                {
                    textBoxList[i].BackColor = Color.LightGreen;
                }
                else
                {
                    textBoxList[i].BackColor = Color.Pink;
                }
            }

        }
        private void verify()
        {
            string[] tabPhrase = phrase.Split(' ');
            string[] intPos = pos.Split('/');

            for (int i = 0; i < intPos.Length && EstJuste; i++ )
            {
                if (textBoxList[i].Text == tabPhrase[int.Parse(intPos[i]) - 1])
                {
                    textBoxList[i].BackColor = Color.LightGreen;
                }
                else
                {
                    EstJuste = false;
                    textBoxList[i].BackColor = Color.Pink;
                }
            }
        }
        private void checkTXT(object sebder, EventArgs e)
        {
            verif(this.phrase, this.pos);
        }
        private void btnHideWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                verify();
                this.Close();
       
                if (EstJuste)
                    dsEsp.Tables[nomDT].Rows.Add(nbExo, true, null, listmot);
                else
                    dsEsp.Tables[nomDT].Rows.Add(nbExo, false, null, listmot);

                Application.OpenForms.Cast<frmLogin>().First().Actualize(dsEsp);

            }
            else
            {
                verify();
                this.Close();
                if (EstJuste)
                    dsEsp.Tables[nomDT].Rows.Add(nbExo, true, null, listmot);
                else
                    dsEsp.Tables[nomDT].Rows.Add(nbExo, false, null, listmot);

                this.Close();
                dsEsp.Tables[nomDT].Rows.Add(nbExo, true, null, null);
                Application.OpenForms.Cast<frmLogin>().First().afficheRecap(dsEsp);



            }
        }
    }
}
