using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMA.FORMS
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static string username;
        public static string mail;
        public static string password;
        public static string admin;
        public static string usernameMod;
        public static string mailMod;
        public static string passwordMod;
        public static string adminMod;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome());
        }
    }
}
