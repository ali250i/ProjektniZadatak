using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjektniZadatak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int kupacID;
        public static String konekcioniString = "Server=localhost; Port=3306; Database=projektnizadatak; Uid=root;" +
            "Pwd=1234";

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
             errorProvider1.Clear();

            String korisnickoIme = textBoxUsername.Text;
            String sifra = textBoxLozinka.Text;

            String query = "SELECT password, CONCAT(ime, ' ', prezime), kupac_ID " +
                " FROM kupac WHERE username ='" + korisnickoIme + "' ";

            try
            {

                MySqlConnection konekcija = new MySqlConnection(konekcioniString);


                konekcija.Open();


                MySqlCommand cmd = new MySqlCommand(query, konekcija);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (!reader.HasRows)
                {
                    errorProvider1.SetError(textBoxUsername, "Pogrešno korisničko ime !!!");
                }
                else
                {


                    String passwd = reader[0].ToString();
                    String imePrez = reader[1].ToString();
                    kupacID = Convert.ToInt32(reader[2]);


                    if (sifra == passwd)
                    {
                        if (kupacID == 1)
                        {
                            AdminKupci ak = new AdminKupci();
                            this.Hide();
                            ak.Show();
                        }
                        else
                        {
                            KupacKreiranjeNarudzbe kkn = new KupacKreiranjeNarudzbe();
                            this.Hide();
                            kkn.Show();
                        }

                    }
                    else

                        errorProvider1.SetError(textBoxLozinka, "Pogrešan password !!!");
                }
                reader.Close();
                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
