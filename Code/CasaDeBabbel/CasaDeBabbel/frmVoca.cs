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
    public partial class frmVoca : Form
    {
        public frmVoca()
        {
            InitializeComponent();
            

        }
        private void fillCB(ComboBox cb, string table, int pos, int pos2, DataSet ds)
        {
            try
            {
                DataTable temporaryTable = ds.Tables[table];
                foreach (DataRow line in temporaryTable.Rows)
                {
                    string str = line.Field<String>("pnUtil") + " " + line.Field<String>("nomUtil");
                    int code = line.Field<int>("codeUtil");
                    cb.Items.Add(str);
                   

                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void frmVoca_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.ActiveForm.Activate();

        }
    }
}
