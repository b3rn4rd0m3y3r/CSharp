using System.Data;
using System.Data.SQLite;

namespace Sqlite01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string db = @"URI=file:C:\Users\berna\source\repos\Sqlite01\Estoque.db";
            string strSql = "";
            SQLiteDataReader result;
            // Conexão ao banco
            using var con = new SQLiteConnection(db);
            con.Open();
            // Construção de comando de acesso ao banco
            strSql = "SELECT * FROM fornecedores";
            // Comando de acesso ao SQLite
            SQLiteCommand command = new SQLiteCommand(strSql, con);
            result = command.ExecuteReader();
            // Carrega o grid
            DataGridView dtGridV = this.dataGridView1;
            using (SQLiteDataReader read = result)
            {
                while (read.Read()){
                    dtGridV.Rows.Add(new object[] {
                        read.GetValue(read.GetOrdinal("Cod")),  // Or column name like this
                        read.GetValue(read.GetOrdinal("RazaoSoc"))
                        });
                }
            }
            con.Close();
        }
    }
}
