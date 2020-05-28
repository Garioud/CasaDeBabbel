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
        public frmMotM()
        {
            InitializeComponent();
        }
        public frmMotM(string phrase, string trad, string pos,string enonce)
        {
            InitializeComponent();
            generatePhrase(phrase, pos);
        }

        private void frmMotM_Load(object sender, EventArgs e)
        {

        }
        private void generatePhrase(string phrase,string pos)
        {
            string[] tabPhrase = phrase.Split(' ');
            string[] intPos = pos.Split('/');
            int[] tabPos = new int[intPos.Length];

            for(int i = 0; i < intPos.Length; i++)
            {
                tabPos[i] = int.Parse(intPos[i]);
            }
            
            for(int i = 0; i < tabPhrase.Length; i++)
            {
                if (tabPos.Contains(i))
                {

                    pnlListe.Controls.Add(new TextBox() {
                        Name = "tbxMot" + i,
                        Width = 30,
                        Height = 40,
                        Location = new Point(10 + i * 30, 20)
                    });
                }
                else
                {
                    
                   pnlListe.Controls.Add(new Label() {
                        Name = "lblMot" + i,
                        Width = 30,
                        Height = 40,
                        Location = new Point(10 + i * 30, 20),
                        Text = Convert.ToString(tabPhrase[i])
                    }); ;
                }
                
            }

        }

        private void frmMotM_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.ActiveForm.Activate();
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
