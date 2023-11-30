using System.Drawing;

namespace Sqlite01
{

    using System.Drawing;

    partial class Form1
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Cod = new DataGridViewTextBoxColumn();
            RazaoSoc = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cod, RazaoSoc });
            dataGridView1.Location = new Point(26, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(556, 261);
            dataGridView1.TabIndex = 0;
            // 
            // Cod
            // 
            Cod.HeaderText = "Coluna1";
            Cod.Name = "Cod";
            // 
            // RazaoSoc
            // 
            RazaoSoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RazaoSoc.HeaderText = "Coluna2";
            RazaoSoc.Name = "RazaoSoc";
            RazaoSoc.Width = 76;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Primeiro Teste Sqlite";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        // Alterados para public
        public DataGridView dataGridView1;
        public DataGridViewTextBoxColumn Coluna1;
        public DataGridViewTextBoxColumn Coluna2;
        private DataGridViewTextBoxColumn Cod;
        private DataGridViewTextBoxColumn RazaoSoc;
    }
}
