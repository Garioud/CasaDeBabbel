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
        private int nbExo;
        private int nbExoMax;
        private DataSet dsEsp;
        private int numLeçon;
        private string codeCours;
        private string phrase;
        private string phraseEsp;
        private string actualUser;
        private string nomDT;
        public frmRecap(DataSet ds,string nomTable)
        {
            dsEsp = ds;
            nomDT=nomTable;
            InitializeComponent();
            generateLabel();
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
                        lbl.Text = dr.Field<string>("phrase");
                        lbl.Location = new Point(10, y);
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.BorderStyle = BorderStyle.FixedSingle;
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
                            lbl.BorderStyle = BorderStyle.FixedSingle;
                            lbl.Text = lmot[i];
                            lbl.Location = new Point(10, y);
                            lbl.TextAlign = ContentAlignment.MiddleCenter;
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
                            pnlBad.Controls.Add(lbl);
                            lbl.ForeColor = Color.Red;
                            lbl.Text = lmot[i];
                            lbl.Location = new Point(20, yB);
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
            frmLogin exer = new frmLogin();
            this.Hide();

            exer.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHideWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
