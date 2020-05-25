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
    public partial class frmDeso : Form
    {
        public frmDeso()
        {
            InitializeComponent();
        }

        private void frmDeso_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.ActiveForm.Activate();
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            label2.DoDragDrop(label2.Text, DragDropEffects.Copy |
      DragDropEffects.Move);
        }
    }
}
