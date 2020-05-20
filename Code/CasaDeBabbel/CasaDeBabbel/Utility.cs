using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDeBabbel
{
   public static class Utility
    {
        public  static  void FillDataSet(List<string> listName, DataSet ds, string chcon)
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









    }
}
