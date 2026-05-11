using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace BH_vegzosok
{
    public partial class Form1 : Form
    {
        private DataTable tabla;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void betolt_Click(object sender, EventArgs e)
        {
            string filePath = "vegzosok.txt"; // Itt legyen a CSV fájlod

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Nem található a CSV fájl!");
                return;
            }

            var sorok = File.ReadAllLines(filePath, System.Text.Encoding.Default);
            var fejlec = sorok[0].Trim().Split();

            tabla = new DataTable();
            foreach (var oszlop in fejlec)
                tabla.Columns.Add(oszlop);

            foreach (var sor in sorok.Skip(1))
                tabla.Rows.Add(sor.Split('\t'));

            dataGridView1.DataSource = tabla;
            dataGridView1.Sort(dataGridView1.Columns[0], System.ComponentModel.ListSortDirection.Descending);
        }

        private void a_Click(object sender, EventArgs e)
        {
            if (tabla == null)
            {
                MessageBox.Show("Előbb töltsd be a CSV fájlt!");
                return;
            }

            var szurt = tabla.AsEnumerable()
                             .Where(r => int.Parse(r["evfolyam"].ToString()) == 2005)
                             .Where(r => r["nem"].ToString() == "L");
            dataGridView1.DataSource = tabla;
            dataGridView1.Sort(dataGridView1.Columns[1], System.ComponentModel.ListSortDirection.Ascending);

            if (szurt.Any())
                dataGridView1.DataSource = szurt.CopyToDataTable();
            else
                MessageBox.Show("Nincs találat!");
        }
    }
}
