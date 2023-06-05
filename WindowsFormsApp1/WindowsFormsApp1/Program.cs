using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormUser());
        }

        public static NpgsqlConnection connection = new NpgsqlConnection("Server = localhost; Port = 5432; Database = trade; Username = postgres; Password = 1234");

        public static object userID = null;
        public static object userName = null;
        public static object userSurame = null;
        public static object userPatronymic = null;
        public static object userRole = null;
    }
}
