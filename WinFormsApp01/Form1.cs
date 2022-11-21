using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace WinFormsApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickBtnExec(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            string sNome = inputNome.Text;
            DialogResult mbox = MessageBox.Show("Olah. To aki.", sNome, buttons, MessageBoxIcon.Question);
            if (mbox == DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }
        }


    }
}
