using System;
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



        private void frmLogin_Load(object sender, EventArgs e)
        {
            FillDataSet(chcon, dsEsp);
            fillCB(cbName, "Utilisateurs", 1, 2, dsEsp);

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

      
        private void fillCB(ComboBox cb, string table, DataSet ds)
        {
            try
            {
                DataTable temporaryTable = ds.Tables[table];
                cb.DataSource = temporaryTable;
                cb.DisplayMember = temporaryTable.Columns[0].ColumnName;
                cb.ValueMember = temporaryTable.Columns[0].ColumnName;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void fillCB(ComboBox cb, string table, int pos, DataSet ds)
        {
            try
            {
                DataTable temporaryTable = ds.Tables[table];
                cb.DataSource = temporaryTable;
                cb.DisplayMember = temporaryTable.Columns[pos].ColumnName;
                cb.ValueMember = temporaryTable.Columns[pos].ColumnName;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void fillCB(ComboBox cb, string table, int pos, int pos2, DataSet ds)
        {
            try
            {
                DataTable temporaryTable = ds.Tables[table];
                foreach (DataRow line in temporaryTable.Rows)
                {
                    string str = line.Field<String>("pnUtil") +" "+ line.Field<String>("nomUtil");
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
            generateAllLabel();
        }

        private void generateAllLabel()
        {
            int code;
            codeUser.TryGetValue(cbName.SelectedItem.ToString(), out code);
            actualUser = cbName.SelectedItem.ToString();
            DataTable test = dsEsp.Tables["Utilisateurs"];
            DataRow[] tRow = test.Select($"codeUtil = '{code}'");
            generateCoursLabel(tRow);
            generateLeconLabel(tRow);
            generateExerciceLabel(tRow);
          
          


        }
        private void generateCoursLabel(DataRow[] tRow)
        {
            using (DataTable temporaryTable = dsEsp.Tables["Cours"])
            {
                codeCours = tRow[0].Field<String>("codeCours");
                DataRow[] temporaryRow = temporaryTable.Select($"numCours= '{codeCours}'");
                titreCours= temporaryRow[0].Field<String>("titreCours");
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
                    descLecon= "--->" + temporaryRow[0].Field<String>("commentLecon");
                    lblDesc.Text = descLecon;
                }
                else
                {
                    lblDesc.Text = null;
                }
            }
            using (DataTable temporaryTable = dsEsp.Tables["Lecons"])
            {
                DataRow[] temporaryRow = temporaryTable.Select($"numLecon = {numLecon} AND numCours = '{codeCours}'");
                lblActLec.Text = temporaryRow[0].Field<String>("titreLecon");
                if (temporaryRow[0].Field<String>("commentLecon") != null)
                    lblDesc.Text = "--->" + temporaryRow[0].Field<String>("commentLecon");
                else
                    lblDesc.Text = null;
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
            startExo();


        }
        public void startExo()
        {
            using (DataTable temporaryTable = dsEsp.Tables["Exercices"])
            {
                int nbExo = getExoN();
                string nbCours = getNumCours();
                int nbLeçon = getCodeLeçon();
                DataRow[] temporaryRow = temporaryTable.Select($"numExo='{nbExo}' and numCours='{nbCours}' and numLecon='{nbLeçon}'");
              

                if (temporaryRow[0].Field<bool>("completeOn"))
                {

                    frmDeso exer = new frmDeso();

                    this.Hide();

                    exer.Show();


                }
                else if (temporaryRow[0].Field<string>("listeMots") != null)
                {


                    frmMotM exer = new frmMotM();
                    this.Hide();
                    exer.ShowDialog();


                }
                else if (!temporaryRow[0].IsNull("codeVerbe"))
               {
                    if(temporaryRow[0].Field<int>("codeVerbe")>0)
                    {                     
                        frmVerbe exer = new frmVerbe();
                        this.Hide();
                        exer.ShowDialog();
                    }
                    else
                    {
                        frmVoca exer = new frmVoca();
                        this.Hide();
                        exer.ShowDialog();
                    }
                }                 
                else
                {
                    frmVoca exer = new frmVoca();
                    this.Hide();
                    exer.ShowDialog();
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
                return actualUser ;
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
        public void Actualize( DataSet ds)
        {
            this.GetDataSet = ds;
            getExoN();
            startExo();

        }
    }

}



