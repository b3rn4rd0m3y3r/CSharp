namespace Sqlite01
{
    using System.Data.SQLite;
    internal static class Program
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string db = @"URI=file:C:\Users\berna\source\repos\Sqlite01\Estoque.db";
            using var con = new SQLiteConnection(db);
            con.Open();
            using var cmd = new SQLiteCommand(con);
            cmd.CommandText = "INSERT INTO fornecedores(Cod, RazaoSoc) VALUES('0022','Galiano Atacadista Ltda')";
            cmd.ExecuteNonQuery();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}