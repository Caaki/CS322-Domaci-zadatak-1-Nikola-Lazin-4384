using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_Domaci_zadatak_1_Nikola_Lazin_4384
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var add = new Form1();
            add.ShowDialog();
            Student student = add.ReturnStudent();
            if (student.Ime != null || student.Prezime != null)
            {
                dataGridView1.Rows.Add(student.Ime, student.Prezime, student.Adresa, student.Pol);
            }

        }

        private void ukloni_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                dataGridView1.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Select rows for removal");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var add = new Form1();
            add.ShowDialog();
            Student student = add.ReturnStudent();
            
            if (student.Ime !=null || student.Prezime != null)
            {
                dataGridView1.Rows.Add(student.Ime, student.Prezime, student.Adresa, student.Pol);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
