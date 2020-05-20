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
            setTable(chcon, dsEsp);
            fillCB(cbName, "Utilisateurs", 1, 2, dsEsp) ;

        }

        private List<string> GenerateListName(string chcon)
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
                        listName.Add(line["TABLE_NAME"].ToString());

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
            return listName;
        }

        public void FillDataSet(List<string> listName, DataSet ds, string chcon)
        {
            using (OleDbConnection connec = new OleDbConnection())
            {

                for (int i = 0; i < listName.Count(); i++)
                {
                    try
                    {
                        string command = "Select * from " + listName[i];
                        connec.ConnectionString = chcon;
                        connec.Open();
                        using (OleDbDataAdapter da = new OleDbDataAdapter(command, connec))
                        {
                            da.Fill(ds, listName[i]);
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
        }
        private void setTable(string chcon, DataSet dsEsp)
        {
            List<string> nameList = GenerateListName(chcon);
            FillDataSet(nameList, dsEsp, chcon);
        }
        private void fillCB(ComboBox cb, string table,DataSet ds)
        {
            try
            {
                DataTable travelTable = ds.Tables[table];
                cb.DataSource = travelTable;
                cb.DisplayMember = travelTable.Columns[0].ColumnName;
                cb.ValueMember = travelTable.Columns[0].ColumnName;
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
                DataTable travelTable = ds.Tables[table];
                cb.DataSource = travelTable;
                cb.DisplayMember = travelTable.Columns[pos].ColumnName;
                cb.ValueMember = travelTable.Columns[pos].ColumnName;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void fillCB(ComboBox cb, string table, int pos, int pos2,DataSet ds)
        {
            try
            {
                DataTable travelTable = ds.Tables[table];
               foreach (DataRow line in travelTable.Rows)
                {
                    string str = line.Field<String>("pnUtil") + line.Field<String>("nomUtil");
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
            DataRow[] tEow = test.Select($"codeUtil = '{code}'");
            using (DataTable temporaryTable = dsEsp.Tables["Cours"])
            { 
            DataRow[] temporaryRow = temporaryTable.Select($"numCours= '{tEow[0].Field<String>("codeCours")}'");
            lblActualCours.Text = temporaryRow[0].Field<String>("titreCours");
            }

            using (DataTable temporaryTable = dsEsp.Tables["Lecons"])
            {
                DataRow[] temporaryRow = temporaryTable.Select($"numLecon = {tEow[0].Field<int>("codeLeçon")} AND numCours = '{tEow[0].Field<String>("codeCours")}'");
                lblActLec.Text = temporaryRow[0].Field<String>("titreLecon");
                if (temporaryRow[0].Field<String>("commentLecon") != null)
                    lblDesc.Text = "--->" + temporaryRow[0].Field<String>("commentLecon");
                else
                    lblDesc.Text = null;
            }
            using (DataTable temporaryTable = dsEsp.Tables["Lecons"])
            {
                DataRow[] temporaryRow = temporaryTable.Select($"numLecon = {tEow[0].Field<int>("codeLeçon")} AND numCours = '{tEow[0].Field<String>("codeCours")}'");
                lblActLec.Text = temporaryRow[0].Field<String>("titreLecon");
                if (temporaryRow[0].Field<String>("commentLecon") != null)
                    lblDesc.Text = "--->" + temporaryRow[0].Field<String>("commentLecon");
                else
                    lblDesc.Text = null;
            }
            using (DataTable temporaryTable = dsEsp.Tables["Exercices"])
            {

                DataRow[] temporaryRow = temporaryTable.Select($"numLecon = {tEow[0].Field<int>("codeLeçon")} AND numCours = '{tEow[0].Field<String>("codeCours")}'");
                int numberofExercice = temporaryRow.Length;
                int actExo = tEow[0].Field<int>("codeExo");

                lblNumberExo.Text = $"{actExo}/{numberofExercice}";
                
            }

        }
    }

}



