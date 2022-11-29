using System.Drawing.Configuration;

namespace WinFormsApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Cornsilk;
            this.ForeColor = Color.Chocolate;
            this.Width = 1080;
            btnExec.BackColor = Color.Red;
            btnExec.ForeColor = Color.Cornsilk;
            // Fonte do formulário
            this.Font = new System.Drawing.Font(
                "Arial",
                16F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte) (0))
                );
         }

        private void btnExec_Click(object sender, EventArgs e)
        {
            string[] linhas = new string[10];
            int cnt = 0;
            DialogResult dlgRes = MessageBox.Show("Mensagem extensa","Título",MessageBoxButtons.YesNo);
            txtExibir.Text = dlgRes.ToString();
            foreach (Control c in this.Controls)
            {
                linhas[cnt] = c.Name;
                cnt++;
            }
            textBox1.Lines = linhas;
        }

    }
}