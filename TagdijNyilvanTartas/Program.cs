using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TagdijNyilvanTartas
{
    static class Program
    {
        public static TagModositas tagModositas = null;
        public static TagUj tagUj = null;
        public static Form1 nyito = null;
        public static MySqlConnection mySqlConnection = null;
        public static MySqlCommand mySqlCommand = null;
        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tagdij";
            mySqlConnection = new MySqlConnection(sb.ToString());
            try
            {
                mySqlConnection.Open();
                mySqlCommand = mySqlConnection.CreateCommand();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            tagModositas = new TagModositas();
            tagUj = new TagUj();
            nyito = new Form1();
            Application.Run(nyito);
        }
    }
}
