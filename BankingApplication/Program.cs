using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
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
            // Application.Run(new Login_form());
            // Application.Run(new newAccount());
            // Application.Run(new CustomerList());
            // Application.Run(new UpdationForm());
            Application.Run(new Menu());


        }
    }
}
