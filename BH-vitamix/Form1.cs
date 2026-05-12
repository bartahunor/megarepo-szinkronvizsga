using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace BH_vitamix
{
    public partial class Form1: Form
    {
        // Kapcsolat beállítása a helyi szerverhez 
        MySqlConnectionStringBuilder serv = new MySqlConnectionStringBuilder
        {
            Server = "127.0.0.1",
            UserID = "root",
            Password = "mysql"
        };
        MySqlConnection kapcsolat;
        public Form1()
        {
            InitializeComponent();
            kapcsolat = new MySqlConnection(serv.ConnectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //kapcsolat ellenőrzése
            
            try
            {
                kapcsolat.Open();
                MessageBox.Show("Kapcsolat sikeres!", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                kapcsolat.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba: " + ex.Message, "Kapcsolódási hiba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Text = "Vitamin Készlet";  //Ablak cím
            btnExit.BackColor = Color.Yellow; // Sárga Kilépés gomb
            if (File.Exists("logo.png"))    //Logó betöltés
            {
                logo.Image = Image.FromFile("logo.png");
                logo.SizeMode = PictureBoxSizeMode.Zoom;
            }

            AdatbazisInit();
            KiszerelesekBetoltese();
            vasarloBetoltes();
        }


        private void btnExit_MouseLeave(object sender, EventArgs e) //Kilépés gomb eseménykezelője MOUSELEAVE
        {
            Application.Exit();
        }

        private void AdatbazisInit()    //Adatbázis inicializálása a forrás.sql fájl alapján
        {
            try
            {
                kapcsolat.Open();
                MySqlCommand parancs = kapcsolat.CreateCommand();

                if (File.Exists("forras.sql"))
                {
                    string sql = File.ReadAllText("forras.sql", Encoding.UTF8);
                    parancs.CommandText = sql;
                    parancs.ExecuteNonQuery();  //ExecuteNonQuery nem visszaadó lekérésnél, pl. CREATE, INSERT, UPDATE, DELETE
                }
                kapcsolat.Close();
            }
            catch (Exception ex) { MessageBox.Show("Hiba: " + ex.Message); }
        }

        private void KiszerelesekBetoltese()    // Egyedi kiszerelések betöltése csökkenő sorrendben 
        {
            try
            {
                kapcsolat.Open();
                MySqlCommand parancs = new MySqlCommand("SELECT DISTINCT kiszereles FROM termek ORDER BY kiszereles DESC", kapcsolat);
                MySqlDataReader olvaso = parancs.ExecuteReader();
                termekek.Items.Clear();
                while (olvaso.Read()) termekek.Items.Add(olvaso["kiszereles"].ToString());
                olvaso.Close();
                kapcsolat.Close();
                if (termekek.Items.Count > 0) termekek.SelectedIndex = 0; 
            }
            catch (Exception) { kapcsolat.Close(); }
        }

        private void termekek_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                kapcsolat.Open();
                // Kiválasztott kiszerelés darabszámának lekérdezése [8]
                MySqlCommand parancs = new MySqlCommand($"SELECT COUNT(id) FROM termek WHERE kiszereles = {termekek.SelectedItem}", kapcsolat);
                kiszerelesdb.Text = $"Ebből a kiszerelésből {parancs.ExecuteScalar()} db van készleten.";
                kapcsolat.Close();
            }
            catch (Exception) { kapcsolat.Close(); }
        }

        private void vasarloBetoltes()
        {
            try
            {
                kapcsolat.Open();
                string sql = @"SELECT vasarlo.nev
                               FROM vasarlo 
                               INNER JOIN eladas ON vasarlo.id = eladas.vasarloId 
                               INNER JOIN termek ON termek.id = eladas.termekId
                               GROUP BY vasarlo.id, vasarlo.nev
                               ORDER BY SUM(termek.egysegar * eladas.mennyiseg) DESC;"
                ;

                MySqlCommand parancs = new MySqlCommand(sql, kapcsolat);
                MySqlDataReader olvaso = parancs.ExecuteReader();   //ExecteReader több értéket visszaadó lekérésnél

                vasarlok.Items.Clear();
                while (olvaso.Read()) vasarlok.Items.Add(olvaso["nev"].ToString());
                olvaso.Close();
                kapcsolat.Close();
            }
            catch (Exception) { kapcsolat.Close(); }
        }

        private void vasarlok_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                kapcsolat.Open();
                string sql = @"SELECT SUM(termek.egysegar * eladas.mennyiseg) AS osszErtek
                       FROM vasarlo 
                       INNER JOIN eladas ON vasarlo.id = eladas.vasarloId 
                       INNER JOIN termek ON termek.id = eladas.termekId
                       WHERE vasarlo.nev = @nev;";

                MySqlCommand parancs = new MySqlCommand(sql, kapcsolat);
                parancs.Parameters.AddWithValue("@nev", vasarlok.SelectedItem.ToString());

                object eredmeny = parancs.ExecuteScalar();  //ExecuteScalar és object csak egy értéket visszaadó lekérezésnél

                if (eredmeny == null || eredmeny == DBNull.Value)   //ha nincs találat, nem dob hibát
                {  
                    osszertek.Text = "";
                    MessageBox.Show("Nincs vásárlási előzmény ezen a néven!", "OK",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    osszertek.Text = eredmeny.ToString() + " Ft";

                kapcsolat.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba: " + ex.Message);
                kapcsolat.Close();
            }
        }
    }
}
