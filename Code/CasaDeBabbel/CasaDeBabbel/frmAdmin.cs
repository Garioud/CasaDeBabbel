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
    public partial class frmAdmin : Form
    {
        private DataSet dsExo;
        private string NomCours;
        private string NumLecon;

        List<string> EnonceExo = new List<string>();
        List<string> NumExo = new List<string>();
        List<string> Phrase = new List<string>();
        List<string> PhraseTrad = new List<string>();

        int numeroExo = 0;
        public frmAdmin()
        {
            InitializeComponent();
        }
        public frmAdmin(DataSet ds)
        {
            dsExo = ds;
            InitializeComponent();
            
            NommerBoutons(this, dsExo);
            NomCours = "PAYSCULT";
            FillListBox(dsExo, NomCours);

        }

        private void frmAdmin_Load(object sender, EventArgs e)
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmLogin exer = new frmLogin();
            this.Hide();

            exer.Show();
        }

        private void NommerBoutons(Form frmAdmin, DataSet ds)
        {
            try
            {
                int i = 4;
                List<string> Cours = new List<string>();
                DataTable temporaryTable = ds.Tables["Cours"];
                foreach (DataRow r in temporaryTable.Rows)
                {
                    Cours.Add(r["titreCours"].ToString());
                }

                foreach (Control item in frmAdmin.Controls)
                {
                    string name = "btnCours" + i.ToString();
                    if (item.Name == name)
                    {
                        item.Text = Cours[i-1];
                        i--;
                    }
                    
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void FillListBox(DataSet ds, string nomCours)
        {
            try
            {
                List<string> Lecon = new List<string>();
                DataTable temporaryTable = ds.Tables["Lecons"];
                foreach (DataRow r in temporaryTable.Rows)
                {
                    if (r["numCours"].ToString() == nomCours)
                    {
                        Lecon.Add(r["titreLecon"].ToString());
                    }
                    else
                    {

                    }
                }
                lb_Lecons.DataSource = Lecon;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }


        private void btnCours1_Click(object sender, EventArgs e)
        {
            numeroExo = 0;
            NomCours = "PAYSCULT";
            FillListBox(dsExo, NomCours);
            Exos(dsExo, NomCours, NumLecon);
            affichageExos(numeroExo);
        }

        private void btnCours2_Click(object sender, EventArgs e)
        {
            numeroExo = 0;
            NomCours = "GRAMM1";
            FillListBox(dsExo, NomCours);
            Exos(dsExo, NomCours, NumLecon);
            affichageExos(numeroExo);
        }

        private void btnCours3_Click(object sender, EventArgs e)
        {
            numeroExo = 0;
            NomCours = "DEBUT1";
            FillListBox(dsExo, NomCours);
            Exos(dsExo, NomCours, NumLecon);
            affichageExos(numeroExo);
        }

        private void btnCours4_Click(object sender, EventArgs e)
        {
            numeroExo = 0;
            NomCours = "DEBUT2";
            FillListBox(dsExo, NomCours);
            Exos(dsExo, NomCours, NumLecon);
            affichageExos(numeroExo);
        }

        private void lb_Lecons_SelectedIndexChanged(object sender, EventArgs e)
        {
            numeroExo = 0;
            int num = lb_Lecons.SelectedIndex;
            /*
            if (num == -1)
            {
                num += 2;
                NumLecon = num.ToString();
            }else if (num >= 0)
            {
                
            }*/
            num += 1;
            NumLecon = num.ToString();
            Exos(dsExo, NomCours, NumLecon);
            affichageExos(numeroExo);
        }

        private void Exos(DataSet ds, string NomCours, string NumLecon)
        {

            try
            {
                EnonceExo.Clear();
                NumExo.Clear();
                Phrase.Clear();
                PhraseTrad.Clear();

                List<string> codePhrase = new List<string>();
                DataTable temporaryTable = ds.Tables["Exercices"];
                DataTable temporaryPhrase = ds.Tables["Phrases"];

                foreach (DataRow r in temporaryTable.Rows)
                {
                    if (r["numCours"].ToString() == NomCours && r["numLecon"].ToString() == NumLecon)
                    {
                        NumExo.Add(r["numExo"].ToString());
                        EnonceExo.Add(r["enonceExo"].ToString());
                        codePhrase.Add(r["codePhrase"].ToString());
                    }
                    else
                    {

                    }
                }
                int i = 0;
                int y = 0;
                foreach (DataRow r in temporaryPhrase.Rows)
                {
                    if (codePhrase[i] == "0")
                    {
                        Phrase.Add("Aucune phrase n'est disponible");
                        PhraseTrad.Add("Aucune traduction n'est disponible");
                        i++;
                    }
                    if (r["codePhrase"].ToString() == codePhrase[i])
                    {
                        Phrase.Add(r["textePhrase"].ToString());
                        PhraseTrad.Add(r["traducPhrase"].ToString());
                        i++;
                    }
                    else
                    
                    {

                    }
                    y++;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnDebut_Click(object sender, EventArgs e)
        {
            numeroExo = 0;

            affichageExos(numeroExo);
            
        }

        private void btnAvant_Click(object sender, EventArgs e)
        {
            if (numeroExo > 0)
            {
                numeroExo--;
                affichageExos(numeroExo);
            }
            else
            {

            }
        }

        private void btnApres_Click(object sender, EventArgs e)
        {
            if (numeroExo >= 0 || numeroExo < NumExo.Count-1)
            {
                numeroExo++;
                affichageExos(numeroExo);
            }
            else
            {

            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            numeroExo = NumExo.Count - 1;
            affichageExos(numeroExo);
        }

        private void affichageExos(int num)
        {
           
            lblEnonce.Text = EnonceExo[num];
            lblNum.Text = NumExo[num];
            lblPhrase.Text = Phrase[num];
            lblPhraseTrad.Text = PhraseTrad[num];
        }
    }
}
