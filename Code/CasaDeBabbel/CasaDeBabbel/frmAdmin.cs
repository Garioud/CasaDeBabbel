using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        private int nbExo;
        private int nbMax;
        List<string> EnonceExo = new List<string>();
        List<string> NumExo = new List<string>();
        List<string> Phrase = new List<string>();
        List<string> PhraseTrad = new List<string>();
        private string ennonce;
        private string phrase;
        private string trad;
        private string regle;
        private string[][] tabMot;


        public frmAdmin()
        {
            InitializeComponent();
        }
        public frmAdmin(DataSet ds)
        {
            InitializeComponent();
            lblNomPersonne.Text = Application.OpenForms.Cast<frmLogin>().First().GetCurrentUser;
            dsExo = ds;
            
            nbExo = 1;
            NommerBoutons(this, dsExo);
            NomCours = "PAYSCULT";
            FillListBox(dsExo, NomCours);
            affichageExos(nbExo);
            pgB_Progres.Maximum = nbMax;

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
                        item.Text = Cours[i - 1];
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
            nbExo = 1;
            NomCours = "PAYSCULT";
            FillListBox(dsExo, NomCours);

            affichageExos(nbExo);
            generateCoursLabel();
            generateLeconLabel();
        }

        private void btnCours2_Click(object sender, EventArgs e)
        {
            nbExo = 1;
            NomCours = "GRAMM1";
            FillListBox(dsExo, NomCours);

            affichageExos(nbExo);
            generateCoursLabel();
            generateLeconLabel();
        }

        private void btnCours3_Click(object sender, EventArgs e)
        {
            nbExo = 1;
            NomCours = "DEBUT1";
            FillListBox(dsExo, NomCours);

            affichageExos(nbExo);
            generateCoursLabel();
            generateLeconLabel();
        }

        private void btnCours4_Click(object sender, EventArgs e)
        {
            nbExo = 1;
            NomCours = "DEBUT2";
            FillListBox(dsExo, NomCours);

            affichageExos(nbExo);
            generateCoursLabel();
            generateLeconLabel();
        }

        private void lb_Lecons_SelectedIndexChanged(object sender, EventArgs e)
        {
            nbExo = 1;
            int num = lb_Lecons.SelectedIndex;
            num += 1;
            NumLecon = num.ToString();
            affichageExos(nbExo);
            pgB_Progres.Maximum = nbMax;
            generateCoursLabel();
            generateLeconLabel();

        }

     

        private void btnDebut_Click(object sender, EventArgs e)
        {
            nbExo = 1;

            affichageExos(nbExo);

        }

        private void btnAvant_Click(object sender, EventArgs e)
        {
            if (nbExo > 1)
            {
                nbExo--;
                affichageExos(nbExo);
            }
            else
            {

            }
        }

        private void btnApres_Click(object sender, EventArgs e)
        {
            if (nbExo > 0 && nbExo < nbMax)
            {
                nbExo++;
                affichageExos(nbExo);
            }
            else
            {

            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            nbExo = nbMax;
            affichageExos(nbExo);
        }

        private void affichageExos(int num)
        {
            pgB_Progres.Value = nbExo;
            lblNumberExo.Text = (nbExo).ToString() + "/" + nbMax.ToString(); ;
            lblPhrase.Text = null;
            lblEnonce.Text = null;
            lblPhraseTrad.Text = null;
            lblRegle.Text = null;
            using (DataTable temporaryTable = dsExo.Tables["Exercices"])
            {
                DataRow[] temporaryRow = temporaryTable.Select($"numCours='{NomCours}' and numLecon='{NumLecon}'");
                nbMax = temporaryRow.Length;
                temporaryRow = temporaryTable.Select($"numExo='{nbExo}' and numCours='{NomCours}' and numLecon='{NumLecon}'");

                ennonce = temporaryRow[0].Field<string>("enonceExo");

                if (!temporaryRow[0].IsNull("codeRegle"))
                {
                    using (DataTable temporaryTable2 = dsExo.Tables["Regles"])
                    {
                        DataRow[] temporaryRow2 = temporaryTable2.Select($"codeRegle='{temporaryRow[0].Field<string>("codeRegle")}'");
                        regle = temporaryRow2[0].Field<string>("texteRegle");
                        lblRegle.Text = regle;
                    }

                }
                if (temporaryRow[0].Field<bool>("completeOn") || temporaryRow[0].Field<string>("listeMots") != null)
                {


                    using (DataTable temporyTable2 = dsExo.Tables["Phrases"])
                    {
                        DataRow[] temporaryRow2 = temporyTable2.Select($"codePhrase={temporaryRow[0].Field<int>("codePhrase")}");
                        phrase = temporaryRow2[0].Field<string>("textePhrase");
                        trad = temporaryRow2[0].Field<string>("traducPhrase");
                        lblPhrase.Text = phrase;
                        lblEnonce.Text = ennonce;
                        lblPhraseTrad.Text = trad;
                    }

                }

                else if (!temporaryRow[0].IsNull("codeVerbe"))
                {
                    if (temporaryRow[0].Field<int>("codeVerbe") > 0)
                    {
                        phrase = "Exercice Verbe";
                        lblPhrase.Text = phrase;
                        lblEnonce.Text = ennonce;
                       
                    }
                    else
                    {

                        int taille;


                        using (DataTable temporaryTable2 = dsExo.Tables["ConcerneMots"])
                        {
                            DataRow[] temporaryRow2 = temporaryTable2.Select($"numCours='{NomCours}' and numLecon={NumLecon} and numExo={nbExo}");
                            taille = temporaryRow2.GetLength(0);
                            tabMot = new string[taille][];
                            using (DataTable temporaryTable3 = dsExo.Tables["Mots"])
                            {
                                for (int i = 0; i < taille; i++)
                                {
                                    int codeMots = temporaryRow2[i].Field<int>("numMot");
                                    DataRow[] temporaryRow3 = temporaryTable3.Select($"numMot={codeMots}");
                                    if (!temporaryRow3[0].IsNull("cheminPhoto"))
                                        tabMot[i] = new string[4] { temporaryRow3[0].Field<string>("libMot"), temporaryRow3[0].Field<string>("traducMot"), temporaryRow3[0].Field<string>("origine"), temporaryRow3[0].Field<string>("cheminPhoto") };
                                    else
                                        tabMot[i] = new string[4] { temporaryRow3[0].Field<string>("libMot"), temporaryRow3[0].Field<string>("traducMot"), temporaryRow3[0].Field<string>("origine"), null };

                                }

                            }
                        }
                        lblEnonce.Text = ennonce;
                        for (int i = 0; i < tabMot.GetLength(0); i++)
                        {
                            if(lblPhrase.Width < 500)
                            {
                              
                                lblPhrase.Text += $"    {tabMot[i][0]}/{tabMot[i][1]}/{tabMot[i][2]}";
                             }
                            else
                            {
                                lblPhraseTrad.Text += $"    {tabMot[i][0]}/{tabMot[i][1]}/{tabMot[i][2]}";
                            }

                        }
                    }
                }

                else
                {
                    int taille;


                    using (DataTable temporaryTable2 = dsExo.Tables["ConcerneMots"])
                    {
                        DataRow[] temporaryRow2 = temporaryTable2.Select($"numCours='{NomCours}' and numLecon={NumLecon} and numExo={nbExo}");
                        taille = temporaryRow2.Length;
                        tabMot = new string[taille][];
                        using (DataTable temporaryTable3 = dsExo.Tables["Mots"])
                        {
                            for (int i = 0; i < taille; i++)
                            {
                                int codeMots = temporaryRow2[i].Field<int>("numMot");
                                DataRow[] temporaryRow3 = temporaryTable3.Select($"numMot={codeMots}");
                                if (!temporaryRow3[0].IsNull("cheminPhoto"))
                                    tabMot[i] = new string[4] { temporaryRow3[0].Field<string>("libMot"), temporaryRow3[0].Field<string>("traducMot"), temporaryRow3[0].Field<string>("origine"), temporaryRow3[0].Field<string>("cheminPhoto") };
                                else
                                    tabMot[i] = new string[4] { temporaryRow3[0].Field<string>("libMot"), temporaryRow3[0].Field<string>("traducMot"), temporaryRow3[0].Field<string>("origine"), null };

                            }

                        }

                    }
                    lblEnonce.Text = ennonce;
                    for (int i = 0; i < tabMot.GetLength(0); i++)
                    {
                        if (lblPhrase.Width < 500)
                        {
                            lblPhrase.Text += $"    {tabMot[i][0]}/{tabMot[i][1]}/{tabMot[i][2]}";
                        }
                        else
                        {
                            lblPhraseTrad.Text += $"    {tabMot[i][0]}/{tabMot[i][1]}/{tabMot[i][2]}";
                        }

                    }
                }


            }
        }
        private void generateCoursLabel()
        {
            using (DataTable temporaryTable = dsExo.Tables["Cours"])
            {
              
                DataRow[] temporaryRow = temporaryTable.Select($"numCours= '{NomCours}'");
                lblActualCours.Text = temporaryRow[0].Field<String>("titreCours");
              
            }
        }
        private void generateLeconLabel()
        {
            using (DataTable temporaryTable = dsExo.Tables["Lecons"])
            {
                DataRow[] temporaryRow = temporaryTable.Select($"numLecon = {NumLecon} AND numCours = '{NomCours}'");
                lblActLec.Text = temporaryRow[0].Field<String>("titreLecon");
            
                if (temporaryRow[0].Field<String>("commentLecon") != null)
                {
                    lblDesc.Text = "--->" + temporaryRow[0].Field<String>("commentLecon");
                   
                }
                else
                {
                    lblDesc.Text = null;
                }
            }
           
        }
    }
}
    

