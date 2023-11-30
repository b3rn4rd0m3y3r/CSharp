namespace Sqlite01
{
    using System.Data;
    using System.Data.SQLite;
    using System.Windows.Forms;

    internal static class Program
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Form1 form1 = new Form1();
            Application.Run(form1);
        }
    }
}