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
        public frmAdmin()
        {
            InitializeComponent();
        }
        public frmAdmin(DataSet ds)
        {
            dsExo = ds;
            InitializeComponent();
            FillListBox(ds);
            NommerBoutons(this, ds);
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

        private void FillListBox(DataSet ds)
        {
            try
            {
                List<string> Lecon = new List<string>();
                DataTable temporaryTable = ds.Tables["Lecons"];
                foreach (DataRow r in temporaryTable.Rows)
                {
                    Lecon.Add(r["titreLecon"].ToString());

                }
                listBox1.DataSource = Lecon;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void Exercices(DataSet ds)
        {
            try
            {
                List<string> Exo = new List<string>();
                List<string> EnonceExo = new List<string>();
                List<string> NumExo = new List<string>();
                List<string> Phrase = new List<string>();

                DataTable temporaryTable = ds.Tables["Lecons"];
                foreach (DataRow r in temporaryTable.Rows)
                {
                    exo.Add(r["titreLecon"].ToString());

                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
