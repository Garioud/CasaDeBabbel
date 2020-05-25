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
        }
        public DataSet dsEsp = new DataSet();
        private string chcon = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =..\baseLangue.mdb";
        private Dictionary<String, int> codeUser = new Dictionary<string, int>();
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

            DataTable test = dsEsp.Tables["Utilisateurs"];
            DataRow[] tRow = test.Select($"codeUtil = '{code}'");
            using (DataTable temporaryTable = dsEsp.Tables["Cours"])
            {
                DataRow[] temporaryRow = temporaryTable.Select($"numCours= '{tRow[0].Field<String>("codeCours")}'");
                lblActualCours.Text = temporaryRow[0].Field<String>("titreCours");
            }

            using (DataTable temporaryTable = dsEsp.Tables["Lecons"])
            {
                DataRow[] temporaryRow = temporaryTable.Select($"numLecon = {tRow[0].Field<int>("codeLeçon")} AND numCours = '{tRow[0].Field<String>("codeCours")}'");
                lblActLec.Text = temporaryRow[0].Field<String>("titreLecon");
                if (temporaryRow[0].Field<String>("commentLecon") != null)
                    lblDesc.Text = "--->" + temporaryRow[0].Field<String>("commentLecon");
                else
                    lblDesc.Text = null;
            }
            using (DataTable temporaryTable = dsEsp.Tables["Lecons"])
            {
                DataRow[] temporaryRow = temporaryTable.Select($"numLecon = {tRow[0].Field<int>("codeLeçon")} AND numCours = '{tRow[0].Field<String>("codeCours")}'");
                lblActLec.Text = temporaryRow[0].Field<String>("titreLecon");
                if (temporaryRow[0].Field<String>("commentLecon") != null)
                    lblDesc.Text = "--->" + temporaryRow[0].Field<String>("commentLecon");
                else
                    lblDesc.Text = null;
            }
            using (DataTable temporaryTable = dsEsp.Tables["Exercices"])
            {

                DataRow[] temporaryRow = temporaryTable.Select($"numLecon = {tRow[0].Field<int>("codeLeçon")} AND numCours = '{tRow[0].Field<String>("codeCours")}'");
                int numberofExercice = temporaryRow.Length;
                int actExo = tRow[0].Field<int>("codeExo");

                lblNumberExo.Text = $"{actExo}/{numberofExercice}";
                progressGeneration(actExo, numberofExercice);


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

        public int getExoN()
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

        public int getCodeLeçon()
        {
            int code;
            codeUser.TryGetValue(cbName.SelectedItem.ToString(), out code);

            DataTable test = dsEsp.Tables["Utilisateurs"];
            DataRow[] tEow = test.Select($"codeUtil = '{code}'");
            return tEow[0].Field<int>("codeLeçon");
        }

        public string getNumCours()
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
        public DataSet GetDataSet
        {
            get
            {
                return dsEsp;
            }
        }

        private void lblNumberExo_MouseDown(object sender, MouseEventArgs e)
        {

            lblNumberExo.DoDragDrop(lblNumberExo.Text, DragDropEffects.Copy |
     DragDropEffects.Move);
        }
    }

}



