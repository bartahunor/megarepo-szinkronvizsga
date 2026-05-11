using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CsvGuiApp 
{
    public partial class MainForm : Form
    {
        private DataTable tabla;

        public MainForm()
        {
            InitializeComponent();
            
        }

        // CSV betöltése gomb eseménykezelő
       

       
        

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            
                string filePath = "adatok.csv"; // Itt legyen a CSV fájlod

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Nem található a CSV fájl!");
                    return;
                }

                var sorok = File.ReadAllLines(filePath,System.Text.Encoding.Default);
                var fejlec = sorok[0].Split(';');

                tabla = new DataTable();
                foreach (var oszlop in fejlec)
                    tabla.Columns.Add(oszlop);

                foreach (var sor in sorok.Skip(1))
                    tabla.Rows.Add(sor.Split(';'));

                dataGridView1.DataSource = tabla;
                dataGridView1.Sort(dataGridView1.Columns[0], System.ComponentModel.ListSortDirection.Descending);

        }

        // Szűrés gomb eseménykezelő
        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            if (tabla == null)
            {
                MessageBox.Show("Előbb töltsd be a CSV fájlt!");
                return;
            }

            var szurt = tabla.AsEnumerable()
                             .Where(r => int.Parse(r["Kor"].ToString()) > 25);

            if (szurt.Any())
                dataGridView1.DataSource = szurt.CopyToDataTable();
            else
                MessageBox.Show("Nincs találat!");
        }
    }
}
