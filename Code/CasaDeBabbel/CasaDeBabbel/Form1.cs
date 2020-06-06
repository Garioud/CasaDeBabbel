﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CasaDeBabbel;

namespace CasaDeBabbel
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
           
            InitializeComponent();
          
            lblNumberExo.BackColor = Color.Transparent;

        }
        private DataSet dsEsp = new DataSet();
        private string chcon = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =..\baseLangue.mdb";
        private Dictionary<String, int> codeUser = new Dictionary<string, int>();
        private string actualUser;
        private int nbExo;
        private int nbExoTotal;
        private int numLecon;
        private string codeCours;
        private string titreCours;
        private string titreLecon;
        private string descLecon;
        private int[] numAdmin;
        private string enonceExo;
        private string regle;
        private string nameDT;
        private int code;


        private void frmLogin_Load(object sender, EventArgs e)
        {
            FillDataSet(chcon, dsEsp);
            fillCB(cbName, "Utilisateurs", 1, 2, dsEsp);
            numAdmin = new int[2] { 5, 6 };
         

        }

        private void FillDataSet(string chcon, DataSet ds)
        {
            List<string> listName = new List<string>();
            using (OleDbConnection connec = new OleDbConnection())
            {
                try
                {
                    connec.ConnectionString = chcon;
                    connec.Open();
                    DataTable allTable = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                    new object[] { null, null, null, "TABLE" });
                    foreach (DataRow line in allTable.Rows)
                    {
                        string command = "Select * from " + line["TABLE_NAME"].ToString();
                        using (OleDbDataAdapter da = new OleDbDataAdapter(command, connec))
                        {
                            da.Fill(ds, line["TABLE_NAME"].ToString());
                        }


                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
                finally
                {
                    connec.Close();
                }
            }

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
                    codeUser.Add(str, code);

                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {

            codeUser.TryGetValue(cbName.SelectedItem.ToString(), out code);
            if (numAdmin.Contains(code))
            {
                lblActualCours.Visible = true;
                lblActualCours.Text = "Vous êtes administrateur";
                lblActLec.Visible = false;
                lblExo.Visible = false;
                lblCours.Visible = false;
                lblAcLec.Visible = false;
                lblDesc.Visible = false;
                lblExo.Visible = false;
                pgB_Progres.Visible = false;
                lblNumberExo.Visible = false ;

            }
            else
            {
                lblNumberExo.Visible = true;
                lblActLec.Visible = false;
                lblExo.Visible = true;
                lblCours.Visible = true;
                lblAcLec.Visible = true;
                lblDesc.Visible = true;
                lblExo.Visible = true;
                pgB_Progres.Visible = true;
                generateAllLabel();
            }
           
        }

        private void generateAllLabel()
        {

            actualUser = cbName.SelectedItem.ToString();
            DataTable test = dsEsp.Tables["Utilisateurs"];
            DataRow[] tRow = test.Select($"codeUtil = '{code}'");
            generateCoursLabel(tRow);
            generateLeconLabel(tRow);
            generateExerciceLabel(tRow);
            lblDesc.Visible = true;
            lblActualCours.Visible = true;
            lblActLec.Visible = true;
            lblNumberExo.Visible = true;

        }
        private void generateCoursLabel(DataRow[] tRow)
        {
            using (DataTable temporaryTable = dsEsp.Tables["Cours"])
            {
                codeCours = tRow[0].Field<String>("codeCours");
                DataRow[] temporaryRow = temporaryTable.Select($"numCours= '{codeCours}'");
                titreCours = temporaryRow[0].Field<String>("titreCours");
                lblActualCours.Text = titreCours;
            }
        }
        private void generateLeconLabel(DataRow[] tRow)
        {
            using (DataTable temporaryTable = dsEsp.Tables["Lecons"])
            {
                numLecon = tRow[0].Field<int>("codeLeçon");
                DataRow[] temporaryRow = temporaryTable.Select($"numLecon = {numLecon} AND numCours = '{codeCours}'");
                titreLecon = temporaryRow[0].Field<String>("titreLecon");
                lblActLec.Text = titreLecon;
                if (temporaryRow[0].Field<String>("commentLecon") != null)
                {
                    descLecon = "--->" + temporaryRow[0].Field<String>("commentLecon");
                    lblDesc.Text = descLecon;
                }
                else
                {
                    lblDesc.Text = null;
                }
            }
           
        }
        private void generateExerciceLabel(DataRow[] tRow)
        {


            using (DataTable temporaryTable = dsEsp.Tables["Exercices"])
            {

                DataRow[] temporaryRow = temporaryTable.Select($"numLecon = {tRow[0].Field<int>("codeLeçon")} AND numCours = '{tRow[0].Field<String>("codeCours")}'");
                nbExoTotal = temporaryRow.Length;
                nbExo = tRow[0].Field<int>("codeExo");

                if (nbExoTotal != 0)
                {
                    lblNumberExo.Text = $"{nbExo}/{nbExoTotal}";
                    progressGeneration(nbExo, nbExoTotal);
                }
                else
                {
                    lblNumberExo.Text = "";
                    pgB_Progres.Visible = false;
                    lblExo.Text = "";
                }


            }
        }



        private void progressGeneration(int numberEx, int validate)
        {
            pgB_Progres.Visible = true;
            pgB_Progres.Maximum = validate;
            if (numberEx < validate)
                pgB_Progres.Value = numberEx;
            else pgB_Progres.Visible = false;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (numAdmin.Contains(code))
            {

            }
            else
            { 
                generateDataTable();
                startExo();
            }

        }

        public void startExo()
        {
            using (DataTable temporaryTable = dsEsp.Tables["Exercices"])
            {
                int nbExo = getExoN();
                string nbCours = getNumCours();
                int nbLeçon = getCodeLeçon();
                DataRow[] temporaryRow = temporaryTable.Select($"numExo='{nbExo}' and numCours='{nbCours}' and numLecon='{nbLeçon}'");
                enonceExo = temporaryRow[0].Field<string>("enonceExo");
                if (!temporaryRow[0].IsNull("codeRegle"))
                {
                    using (DataTable temporaryTable2 = dsEsp.Tables["Regles"])
                    {
                        DataRow[] temporaryRow2 = temporaryTable2.Select($"codeRegle='{temporaryRow[0].Field<string>("codeRegle")}'");
                        regle = temporaryRow2[0].Field<string>("texteRegle");
                    }

                }

                if (temporaryRow[0].Field<bool>("completeOn"))
                {


                    string phrase;
                    string traduc;
                    using (DataTable temporyTable2 = dsEsp.Tables["Phrases"])
                    {
                        DataRow[] temporaryRow2 = temporyTable2.Select($"codePhrase={temporaryRow[0].Field<int>("codePhrase")}");
                        phrase = temporaryRow2[0].Field<string>("textePhrase");
                        traduc = temporaryRow2[0].Field<string>("traducPhrase");
                    }
                    frmDeso exer;
                    if (!temporaryRow[0].IsNull("codeRegle"))
                        exer = new frmDeso(phrase, traduc, enonceExo, nameDT, regle);
                    else
                        exer = new frmDeso(phrase, traduc, enonceExo, nameDT);

                    this.Hide();
                    exer.Show();


                }
                else if (temporaryRow[0].Field<string>("listeMots") != null)
                {
                    string phrase;
                    string traduc;
                    string listMot;
                    listMot = temporaryRow[0].Field<string>("listeMots");
                    using (DataTable temporyTable2 = dsEsp.Tables["Phrases"])
                    {
                        DataRow[] temporaryRow2 = temporyTable2.Select($"codePhrase={temporaryRow[0].Field<int>("codePhrase")}");
                        phrase = temporaryRow2[0].Field<string>("textePhrase");
                        traduc = temporaryRow2[0].Field<string>("traducPhrase");
                    }

                    frmMotM exer;
                    if (!temporaryRow[0].IsNull("codeRegle"))
                        exer = new frmMotM(phrase, traduc, listMot, enonceExo, nameDT, regle);
                    else
                        exer = new frmMotM(phrase, traduc, listMot, enonceExo, nameDT);

                    this.Hide();
                    exer.Show();


                }
                else if (!temporaryRow[0].IsNull("codeVerbe"))
                {
                    if (temporaryRow[0].Field<int>("codeVerbe") > 0)
                    {
                        int codeVerbe = temporaryRow[0].Field<int>("codeVerbe");
                        int codeTemp = temporaryRow[0].Field<int>("codetemps");

                        frmVerbe exer = new frmVerbe(nameDT);
                        this.Hide();
                        exer.Show();
                    }
                    else
                    {

                        int taille;
                        string[][] tabMot;

                        using (DataTable temporaryTable2 = dsEsp.Tables["ConcerneMots"])
                        {
                            DataRow[] temporaryRow2 = temporaryTable2.Select($"numCours='{nbCours}' and numLecon={nbLeçon} and numExo={nbExo}");
                            taille = temporaryRow2.Length;
                            tabMot = new string[taille][];
                            using (DataTable temporaryTable3 = dsEsp.Tables["Mots"])
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
                        frmVoca exer;
                        if (!temporaryRow[0].IsNull("codeRegle"))
                            exer = new frmVoca(tabMot, enonceExo, nameDT, regle);
                        else
                            exer = new frmVoca(tabMot, enonceExo, nameDT);
                        this.Hide();
                        exer.Show();
                    }
                }
                else
                {
                    int taille;
                    string[][] tabMot;

                    using (DataTable temporaryTable2 = dsEsp.Tables["ConcerneMots"])
                    {
                        DataRow[] temporaryRow2 = temporaryTable2.Select($"numCours='{nbCours}' and numLecon={nbLeçon} and numExo={nbExo}");
                        taille = temporaryRow2.Length;
                        tabMot = new string[taille][];
                        using (DataTable temporaryTable3 = dsEsp.Tables["Mots"])
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

                    frmVoca exer;
                    if (!temporaryRow[0].IsNull("codeRegle"))
                        exer = new frmVoca(tabMot, enonceExo, nameDT, regle);
                    else
                        exer = new frmVoca(tabMot, enonceExo, nameDT);
                    this.Hide();
                    exer.Show();
                }
            }
        }


        private int getExoN()
        {

            int code;
            codeUser.TryGetValue(cbName.SelectedItem.ToString(), out code);
            int actExo;
            DataTable test = dsEsp.Tables["Utilisateurs"];
            DataRow[] tEow = test.Select($"codeUtil = '{code}'");
            using (DataTable temporaryTable = dsEsp.Tables["Exercices"])
            {

                DataRow[] temporaryRow = temporaryTable.Select($"numLecon = {tEow[0].Field<int>("codeLeçon")} AND numCours = '{tEow[0].Field<String>("codeCours")}'");
                int numberofExercice = temporaryRow.Length;
                actExo = tEow[0].Field<int>("codeExo");

                lblNumberExo.Text = $"{actExo}/{numberofExercice}";
                progressGeneration(actExo, numberofExercice);
            }
            return actExo;
        }

        private int getCodeLeçon()
        {
            int code;
            codeUser.TryGetValue(cbName.SelectedItem.ToString(), out code);

            DataTable test = dsEsp.Tables["Utilisateurs"];
            DataRow[] tEow = test.Select($"codeUtil = '{code}'");
            return tEow[0].Field<int>("codeLeçon");
        }

        private string getNumCours()
        {
            int code;
            codeUser.TryGetValue(cbName.SelectedItem.ToString(), out code);

            DataTable test = dsEsp.Tables["Utilisateurs"];
            DataRow[] tEow = test.Select($"codeUtil = '{code}'");
            return tEow[0].Field<String>("codeCours");
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            this.Visible = true;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHideWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public DataSet GetDataSet
        {
            get
            {
                return dsEsp;
            }
            set
            {
                dsEsp = value;
            }
        }

        public Dictionary<String, int> GetDictionnary
        {
            get
            {
                return codeUser;
            }
        }

        public string GetCurrentUser
        {
            get
            {
                return actualUser;
            }
        }
        public int getNumLecon
        {
            get
            {
                return numLecon;
            }
        }
        public string getTitreLecon
        {
            get
            {
                return titreLecon;
            }

        }
        public string getDescLecon
        {
            get
            {
                return descLecon;
            }

        }
        public string getCodeCours
        {
            get
            {
                return codeCours;
            }
        }

        public string getTitreCours
        {
            get
            {
                return titreCours;
            }
        }
        public int getNumExo
        {
            get
            {
                return nbExo;
            }
        }
        public int getNumExoTotal
        {
            get
            {
                return nbExoTotal;
            }
        }
        public void Actualize(DataSet ds)
        {
            this.GetDataSet = ds;
            getExoN();
            generateAllLabel();
            startExo();

        }
        public void generateDataTable()
        {
            nameDT = code + codeCours + numLecon;
            if (!dsEsp.Tables.Contains(nameDT))
            {
                DataTable dexo = new DataTable(nameDT);
                DataColumn dcExo = new DataColumn("nExo");
                dcExo.DataType = System.Type.GetType("System.Int32");
                DataColumn dcComplete = new DataColumn("complete");
                dcComplete.DataType = System.Type.GetType("System.Boolean");
                DataColumn dcPhrase = new DataColumn("phrase");
                dcComplete.DataType = System.Type.GetType("System.Boolean");
                DataColumn dcMot = new DataColumn("listMot");
                dcComplete.DataType = System.Type.GetType("System.Boolean");
                dexo.Columns.Add(dcExo);
                dexo.Columns.Add(dcComplete);
                dexo.Columns.Add(dcPhrase);
                dexo.Columns.Add(dcMot);
                dsEsp.Tables.Add(dexo);
            }

        }

        public void afficheRecap(DataSet ds)
        {
            dsEsp = ds;
            frmRecap end= new frmRecap(dsEsp, nameDT);
            end.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmAdmin exer = new frmAdmin(dsEsp);
            this.Hide();

            exer.Show();
        }
    }
}
  



