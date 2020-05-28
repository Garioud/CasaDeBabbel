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
            int position = 50;
            int ligne = 10;

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
                        Width = 15 * 15,
                        Font = new Font("Arial", 14),
                        Location = new Point(position, ligne)
                    });
                    position += 15 * 15;
                    if (position >= 900)
                    {
                        ligne += 40;
                        position = 50;
                    }
                }
                else
                {
                   pnlListe.Controls.Add(new Label() {
                        Name = "lblMot" + i,
                        Width = tabPhrase[i].Length * 15,
                        Height = 30,
                        Font = new Font("Arial", 14),
                        TextAlign = ContentAlignment.TopCenter,
                        Location = new Point(position, ligne),
                        Text = Convert.ToString(tabPhrase[i])
                    });
                    position += tabPhrase[i].Length * 15;
                    if (position >= 900)
                    {
                        ligne += 40;
                        position = 50;
                    }
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
