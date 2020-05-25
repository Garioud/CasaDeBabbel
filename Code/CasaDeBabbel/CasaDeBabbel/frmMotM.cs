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

        private void frmMotM_Load(object sender, EventArgs e)
        {

        }
        private void generatePhrase(string phrase,string pos)
        {
           




        }

        private void frmMotM_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.ActiveForm.Activate();
        }
    }
}
