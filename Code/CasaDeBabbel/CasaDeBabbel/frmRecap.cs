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
    public partial class frmRecap : Form
    {
        public frmRecap()
        {
            InitializeComponent();
        }
 
        private DataSet dsEsp;
        private int numLeçon;
        private string codeCours;
        private Dictionary<String, int> codeUser = new Dictionary<string, int>();
        private string actualUser;
        private string nomDT;
        public frmRecap(DataSet ds, string nomTable)
        {
            dsEsp = ds;
            nomDT = nomTable;
            InitializeComponent();
            generateLabel();
            lblActualCours.Text = Application.OpenForms.Cast<frmLogin>().First().getTitreCours;
            lblActLec.Text = Application.OpenForms.Cast<frmLogin>().First().getTitreLecon;
            lblDesc.Text = Application.OpenForms.Cast<frmLogin>().First().getDescLecon;
            lblNomPersonne.Text = Application.OpenForms.Cast<frmLogin>().First().GetCurrentUser;
            numLeçon = Application.OpenForms.Cast<frmLogin>().First().getNumLecon;
            codeCours = Application.OpenForms.Cast<frmLogin>().First().getCodeCours;
            codeUser = Application.OpenForms.Cast<frmLogin>().First().GetDictionnary;
            actualUser = Application.OpenForms.Cast<frmLogin>().First().GetCurrentUser;
            int codeUtil;
            codeUser.TryGetValue(actualUser, out codeUtil);
            if (codeUtil != -1)
            {
                foreach (DataRow dr in dsEsp.Tables["Utilisateurs"].Rows)
                {
                    if (dr.Field<int>("codeUtil") == codeUtil)
                    {
                        dr["codeExo"] = Application.OpenForms.Cast<frmLogin>().First().getNumExoTotal+1;
                        dr["codeLeçon"] = numLeçon + 1;
                    }
                }
            }
        }
    
        private void frmRecap_Load(object sender, EventArgs e)
        {

        }
        private void generateLabel()
        {
            int y = 20;
            int yB = 20;
            foreach (DataRow dr in dsEsp.Tables[nomDT].Rows)
            {
                if (dr.Field<bool>("complete"))
                {
                    if (!dr.IsNull("phrase"))
                    {
                        Label lbl = new Label();
                        pnlGood.Controls.Add(lbl);
                        lbl.ForeColor = Color.Green;
                        lbl.Font = new Font("Arial", 14);
                        lbl.Text = dr.Field<string>("phrase");
                        lbl.Location = new Point(10, y);
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.BorderStyle = BorderStyle.FixedSingle;
                        lbl.AutoSize = true;
                        y += 40;

                    }
                    else if (!dr.IsNull("listMot"))
                    {
                        string mot = dr.Field<string>("listMot");
                        string[] lmot = mot.Split('/');
                        for (int i = 0; i < lmot.Length; i++)
                        {
                            Label lbl = new Label();
                            pnlGood.Controls.Add(lbl);
                            lbl.ForeColor = Color.Green;
                            lbl.Font = new Font("Arial", 14);
                            lbl.BorderStyle = BorderStyle.FixedSingle;
                            lbl.Text = lmot[i];
                            lbl.Location = new Point(10, y);
                            lbl.TextAlign = ContentAlignment.MiddleCenter;
                            lbl.AutoSize = true;
                            y += 40;

                        }
                    }
                }
                else
                {
                    if (!dr.IsNull("phrase"))
                    {
                        Label lbl = new Label();
                        pnlBad.Controls.Add(lbl);
                        lbl.ForeColor = Color.Red;
                        lbl.Font = new Font("Arial", 14);
                        lbl.AutoSize = true;
                        lbl.Text = dr.Field<string>("phrase");
                        lbl.Location = new Point(10, yB);
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.BorderStyle = BorderStyle.FixedSingle;
                        yB += 40;


                    }
                    else if (!dr.IsNull("listMot"))
                    {
                        string mot = dr.Field<string>("listMot");
                        string[] lmot = mot.Split('/');
                        for (int i = 0; i < lmot.Length; i++)
                        {
                            Label lbl = new Label();
                            lbl.AutoSize = true;
                            pnlBad.Controls.Add(lbl);
                            lbl.ForeColor = Color.Red;
                            lbl.Font = new Font("Arial", 14);
                            lbl.Text = lmot[i];
                            lbl.Location = new Point(10, yB);
                            lbl.TextAlign = ContentAlignment.MiddleCenter;
                            lbl.BorderStyle = BorderStyle.FixedSingle;
                            yB += 40;

                        }




                    }

                }
            }

        }








        private void btnMenu_Click(object sender, EventArgs e)
        {
            Application.OpenForms.Cast<frmLogin>().First().Visible = true;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHideWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            using (DataTable temporaryTable = dsEsp.Tables["Lecons"])
            {
                DataRow[] temporaryRow = temporaryTable.Select($"numCours='{codeCours}'");
                if (numLeçon < temporaryRow.GetLength(0))
                {
                    int codeUtil;
                    codeUser.TryGetValue(actualUser, out codeUtil);
                    if ( codeUtil != -1)
                    {
                        foreach (DataRow dr in dsEsp.Tables["Utilisateurs"].Rows)
                        {
                            if (dr.Field<int>("codeUtil") == codeUtil)
                            {
                                dr["codeExo"] = 1;
                                dr["codeLeçon"] = numLeçon + 1;
                            }
                        }
                    }
                }

                this.Close();
                Application.OpenForms.Cast<frmLogin>().First().startNewLeçon(dsEsp);



            }
        }
    }
}
