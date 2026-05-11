using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace papirgyujtes
{
    class Program
    {
        static void harmadik(MySqlConnection conn)  
        {
            Console.WriteLine("<----------------------------------------------------------------------------------->");
            Console.WriteLine("Készítsen lekérdezést, amely megadja, hogy az első osztályos tanulók mikor és mennyi \r\npapírt adtak le a gyűjtési időszakban! A lekérdezésben a tanuló neve, osztálya, a leadás \r\nidőpontja és a leadott papírmennyiség jelenjen meg!");
            Console.WriteLine();

            string sql_script = @"
                SELECT tanulok.nev, tanulok.osztaly, leadasok.idopont, leadasok.mennyiseg
                FROM tanulok 
                JOIN leadasok ON leadasok.tanulo = tanulok.tazon
                WHERE tanulok.osztaly LIKE '1%';
                ";

            // MySqlScript helyett MySqlCommand kell olvasáshoz
            using (MySqlCommand cmd = new MySqlCommand(sql_script, conn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                Console.WriteLine($"{"Név",-20} {"Osztály",-10} {"Időpont",-20} {"Mennyiség",16}");
                Console.WriteLine(new string('-', 70));

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["nev"],-20} {reader["osztaly"],-10} {reader["idopont"],-20} {reader["mennyiseg"],10}");
                }
            }
            Console.WriteLine("<----------------------------------------------------------------------------------->");
            Console.WriteLine();
        }

        static void negyedik(MySqlConnection conn)
        {
            Console.WriteLine("<----------------------------------------------------------------------------------->");
            Console.WriteLine("Listázza ki, hogy az átvételre megjelölt napokon átlagosan mennyi papírt adtak le! A \r\nszámított mező címkéje „napi atlag” legyen!");
            Console.WriteLine();

            string sql_script = @"
                SELECT leadasok.idopont, AVG(leadasok.mennyiseg) AS atlag
                FROM leadasok 
                GROUP BY leadasok.idopont
                ORDER BY leadasok.idopont ASC;
                ";

            // MySqlScript helyett MySqlCommand kell olvasáshoz
            using (MySqlCommand cmd = new MySqlCommand(sql_script, conn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                Console.WriteLine($"{"Időpont",-30} {"Napi átlag",-20}");
                Console.WriteLine(new string('-', 62));

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["idopont"],-30} {reader["atlag"],-20}");
                }
            }
            Console.WriteLine("<----------------------------------------------------------------------------------->");
            Console.WriteLine();
        }

        static void otodik(MySqlConnection conn)
        {
            Console.WriteLine("<----------------------------------------------------------------------------------->");
            Console.WriteLine("Készítsen lekérdezést, amely kilistázza, mely osztályokból adtak le papírt 2016. október 28\r\nán! A listában minden osztály azonosítója csak egyszer szerepeljen növekvő sorrendben!");
            Console.WriteLine();

            string sql_script = @"
                SELECT DISTINCT tanulok.osztaly
                FROM tanulok 
                JOIN leadasok ON leadasok.tanulo = tanulok.tazon
                WHERE leadasok.idopont LIKE '2016-10-28'
                ORDER BY tanulok.osztaly ASC;
                ";

            // MySqlScript helyett MySqlCommand kell olvasáshoz
            using (MySqlCommand cmd = new MySqlCommand(sql_script, conn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                Console.WriteLine($"{"Osztály",-20}");
                Console.WriteLine(new string('-', 62));

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["osztaly"],-20}");
                }
            }
            Console.WriteLine("<----------------------------------------------------------------------------------->");
            Console.WriteLine();
        }

        static void hatodik(MySqlConnection conn)
        {
            Console.WriteLine("<----------------------------------------------------------------------------------->");
            Console.WriteLine("Készítsen lekérdezést, amely megadja, hogy osztályonként hány mázsa papírt gyűjtöttek a \r\ntanulók (1 mázsa = 10000 dkg)! Az eredményt rendezze a gyűjtött mennyiség szerint \r\ncsökkenő rendbe!");
            Console.WriteLine();

            string sql_script = @"
                SELECT tanulok.osztaly, SUM(leadasok.mennyiseg) / 10000 AS mazsa
                FROM tanulok 
                JOIN leadasok ON leadasok.tanulo = tanulok.tazon
                GROUP BY tanulok.osztaly
                ORDER BY mazsa DESC;
            ";

            // MySqlScript helyett MySqlCommand kell olvasáshoz
            using (MySqlCommand cmd = new MySqlCommand(sql_script, conn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                Console.WriteLine($"{"Osztály",-30} {"Mázsa",-20}");
                Console.WriteLine(new string('-', 62));

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["osztaly"],-30} {reader["mazsa"],-20}");
                }
            }
            Console.WriteLine("<----------------------------------------------------------------------------------->");
            Console.WriteLine();
        }

        static void hetedik(MySqlConnection conn)
        {
            Console.WriteLine("<----------------------------------------------------------------------------------->");
            Console.WriteLine("A legtöbb papírt gyűjtő 10 tanuló jutalomban részesül. Készítsen lekérdezést, amely \r\nmegadja ezen tanulók nevét, osztályát és azt, hogy mekkora mennyiségű papírt gyűjtöttek! \r\nAz eredményt rendezze a gyűjtött mennyiség szerint csökkenő rendbe!");
            Console.WriteLine();

            string sql_script = @"
                SELECT tanulok.nev, tanulok.osztaly, SUM(leadasok.mennyiseg) AS osszesen
                FROM tanulok 
                JOIN leadasok ON leadasok.tanulo = tanulok.tazon
                GROUP BY tanulok.nev, tanulok.osztaly
                ORDER BY osszesen DESC
                LIMIT 10;
            ";

            // MySqlScript helyett MySqlCommand kell olvasáshoz
            using (MySqlCommand cmd = new MySqlCommand(sql_script, conn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                Console.WriteLine($"{"Név",-20} {"Osztály",-20} {"Összesen",-20}");
                Console.WriteLine(new string('-', 62));

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["nev"],-20} {reader["osztaly"],-20} {reader["osszesen"],-20}");
                }
            }
            Console.WriteLine("<----------------------------------------------------------------------------------->");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string sql_kapcsolat = "server=localhost;user=root;password=mysql;database=papirgyujtes;";
            using (MySqlConnection conn = new MySqlConnection(sql_kapcsolat))
            {
                conn.Open();
                Console.WriteLine("Sikeres kapcsolódás az adatbázishoz!");

                //3. feladat
                harmadik(conn);
                //4. feladat
                negyedik(conn);
                //5. feladat
                otodik(conn);
                //6. feladat
                hatodik(conn);
                //7. feldat
                hetedik(conn);
            }
        }
    }
}