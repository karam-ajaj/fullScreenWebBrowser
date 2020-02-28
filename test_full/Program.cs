using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_full
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            Application.Run(new Form1());
            
            SendKeys.Send("{ENTER}");
            /*for (int i = 0; i < 20; i++)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {

                    //if(MessageBox.Equals)
                    //MessageBox.Equals("security warning");
                    //SendKeys.Send("{ENTER}");
                }
            }*/
        }
    }
}
