﻿using System;
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

        List<TextBox> textBoxList = new List<TextBox>();
        private string phrase;
        private string trad;
        private string pos;
        private string enonce;
        public frmMotM()
        {
            InitializeComponent();
        }
        public frmMotM(string phrase, string trad, string pos, string enonce)
        {
            InitializeComponent();
            generatePhrase(phrase, pos, trad);
            this.phrase = phrase;
            this.trad = trad;
            this.pos = pos;
            this.enonce = enonce;
        }

        private void frmMotM_Load(object sender, EventArgs e)
        {

        }
        private void generatePhrase(string phrase,string pos, string traduction)
        {
            string[] tabPhrase = phrase.Split(' ');
            string[] intPos = pos.Split('/');
            int[] tabPos = new int[intPos.Length];
            
            int position = 50;
            int ligne = 200;

            for(int i = 0; i < intPos.Length; i++)
            {
                tabPos[i] = int.Parse(intPos[i]);
            }
            
            for(int i = 0; i < tabPhrase.Length; i++)
            {
                if (tabPos.Contains(i))
                {
                    TextBox txtb = new TextBox();
                    pnlListe.Controls.Add(txtb);
                    txtb.Name = "txtMot" + i;
                    txtb.Width = 15 * 15;
                    txtb.Font = new Font("Arial", 14);
                    txtb.Location = new Point(position, ligne);
                    position += 15 * 15;
                    txtb.TextChanged += new EventHandler(this.checkTXT);
                    textBoxList.Add(txtb);

                    if (position >= 900)
                    {
                        ligne += 40;
                        position = 50;
                    }
                }
                else
                {
                    Label lbl = new Label();
                    pnlListe.Controls.Add(lbl);
                    lbl.Name = "lblMot" + i;
                    lbl.AutoSize = true;             
                    lbl.Font = new Font("Arial", 14);
                    lbl.Location = new Point(position, ligne);
                    lbl.Text = tabPhrase[i];
                    position += lbl.Width;

                    if (position >= 900)
                    {
                        ligne += 40;
                        position = 50;
                    }
                }
            }
            
            pnlListe.Controls.Add(new Label()
            {
                Name = "lblPhrase",
                Height = 30,
                AutoSize = true,               
                Font = new Font("Arial", 14),
                TextAlign = ContentAlignment.TopLeft,
                Location = new Point(50, 100),
                Text = Convert.ToString(traduction)
            });
        }

        private void frmMotM_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.ActiveForm.Activate();
        }

        

        
        private void btnAide_Click(object sender, EventArgs e)
        {

            pnlListe.Controls.Add(new Label()
            {
                Name = "lblReponse",
                Height = 30,
                Font = new Font("Arial", 14),
                TextAlign = ContentAlignment.TopLeft,
                Location = new Point(50, 300),
                AutoSize = true,
                Text = Convert.ToString(phrase)
            }); ;
            
        }

        private void verif(string phrase, string pos)
        {
            string[] tabPhrase = phrase.Split(' ');
            string[] intPos = pos.Split('/');
            int[] tabPos = new int[intPos.Length];

            for (int i = 0; i < intPos.Length; i++) {
                if (textBoxList[i].Text == tabPhrase[int.Parse(intPos[i])])
                {
                    textBoxList[i].BackColor = Color.LightGreen;
                }
                else
                {
                    textBoxList[i].BackColor = Color.Pink;
                }
            }

        }
        private void checkTXT(object sebder, EventArgs e)
        {
            verif(this.phrase, this.pos);
        }
        private void btnHideWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmLogin exer = new frmLogin();
            this.Hide();

            exer.Show();
        }
    }
}
