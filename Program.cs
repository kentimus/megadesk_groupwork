using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Roper
{
    static class Program
    {
       // if quotes.json exists then put it inside the DeskQuotes object
       

        public static DeskQuotes Quotes = new DeskQuotes();
        public static string TestString = "hello Kent";


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
