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

namespace BH_termekek
{
    public partial class Form1 : Form
    {
        public class Termekek
        {
            public string Vonalkód { get; set; }
            public string Márka { get; set; }
            public string Típus { get; set; }
            public string Mértékegység { get; set; }
            public string Megnevezés { get; set; }
            public string Mennyiség { get; set; }
            public int Ár { get; set; }
        }
        public List<Termekek> termekek = new List<Termekek>();
        public List<Termekek> eredetitermekek = new List<Termekek>();
        public List<Termekek> talalt = new List<Termekek>();

        public Form1()
        {
            InitializeComponent();

            termekekdgv.AutoGenerateColumns = false;
            termekekdgv.Columns.Clear();

            termekekdgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Vonalkód", DataPropertyName = "Vonalkód", Width = 100 });
            termekekdgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Márka", DataPropertyName = "Márka", Width = 120 });
            termekekdgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Típus", DataPropertyName = "Típus", Width = 150 });
            termekekdgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mértékegység", DataPropertyName = "Mértékegység", Width = 70 });
            termekekdgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Megnevezés", DataPropertyName = "Megnevezés", Width = 70 });
            termekekdgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mennyiség", DataPropertyName = "Mennyiség", Width = 70 });
            termekekdgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ár", DataPropertyName = "Ár", Width = 70 });
        }

        private void sorszam_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void beolv_Click(object sender, EventArgs e)
        {
            string filePath = "termekek.csv"; // Itt legyen a CSV fájlod
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Nem található a CSV fájl!");
                return;
            }
            var sorok = File.ReadAllLines(filePath, System.Text.Encoding.UTF8);
            var fejlec = sorok[0].Split(',');
            foreach (var sor in sorok.Skip(1))
            {
                var adatok = sor.Split(',');
                Termekek termek = new Termekek
                {
                    Vonalkód = adatok[0],
                    Márka = adatok[1],
                    Típus = adatok[2],
                    Mértékegység = adatok[3],
                    Megnevezés = adatok[4],
                    Mennyiség = adatok[5],
                    Ár = int.Parse(adatok[6])
                };
                termekek.Add(termek);
                eredetitermekek.Add(termek);
            }
            termekekdgv.DataSource = termekek;
        }

        private void mutat1_Click(object sender, EventArgs e)
        {
            termekekdgv.DataSource = null;
            termekekdgv.DataSource = new List<Termekek> { termekek[int.Parse(sorszam.Text) - 1] };
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void mutat2_Click(object sender, EventArgs e)
        {
            
        }

        private void muti_Click(object sender, EventArgs e)
        {
            int index = int.Parse(sorszam.Text) - 1;
            int szazalek = int.Parse(sorszam.Text);

            double szorzo = 1 - (szazalek / 100.0);

            termekek[index].Ár = (int)(termekek[index].Ár * szorzo);

            termekekdgv.DataSource = null;
            termekekdgv.DataSource = new List<Termekek> { termekek[index] };
        }

        private void mutika_Click(object sender, EventArgs e)
        {
            string tipusKeres = textBox3.Text;
            List<Termekek> talalatok = termekek.Where(t => t.Típus.Equals(tipusKeres, StringComparison.OrdinalIgnoreCase)).ToList();
            talalt = talalatok;
            foreach (var termek in talalatok)
            {
                termek.Ár = (int)(termek.Ár * (1 - (int.Parse(sorszam.Text) / 100.0)));
            }

            termekekdgv.DataSource = null;
            termekekdgv.DataSource = talalatok;

            string datum = DateTime.Now.ToString("yyyy-MM-dd HH-mm");
            string fileNev = $"{tipusKeres}-{datum}.txt";

            using (StreamWriter sw = new StreamWriter(fileNev, false, Encoding.UTF8))
            {

                foreach (var t in talalatok)
                {
                    sw.WriteLine(
                        $"{t.Vonalkód}; {t.Márka}; {t.Típus}; {t.Mértékegység}; {t.Megnevezés}; {t.Mennyiség}; {t.Ár} Ft"
                    );
                }
            }

            MessageBox.Show($"TXT fájl elkészült:\n{fileNev}");
        }

        private void mutatfinal_Click(object sender, EventArgs e)
        {
            datum.Text = DateTime.Now.ToString();
            int nap = DateTime.Now.Day;

            for( int i = 0; i < talalt.Count; i++)
            {
                talalt[i].Ár = (int)(eredetitermekek[i].Ár * (1 - (nap / 100.0)));
            }
            termekekdgv.DataSource = null;
            termekekdgv.DataSource = talalt;
        }
    }
}
