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
    public partial class AdminArtikli : Form
    {
        public AdminArtikli()
        {
            InitializeComponent();
        }

        String query = "SELECT a.artikal_ID, a.naziv_artikla, a.vrsta_artikla, a.cijena, s.kolicina_stanje FROM artikal a, skladiste s WHERE a.artikal_ID=s.artikal_ID";
        int artIDZaInsert;
        private void PrikazArtikala() 
        {
            
            try
            {

                

                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);

                konekcija.Open();


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);


                DataTable tabela = new DataTable();


                dataAdapter.Fill(tabela);


                dataGridView1.DataSource = tabela;

                dataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void AdminArtikli_Load(object sender, EventArgs e)
        {
            PrikazArtikala();
        }

        private void AdminArtikli_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonPretraga_Click(object sender, EventArgs e)
        {
            if (textBoxPID.Text != "")
            {
                query += " AND a.artikal_ID LIKE '" + textBoxPID.Text + "%' ";

            }

            else if (textBoxPNaziv.Text != "")
            {
                query += " AND a.naziv_artikla LIKE '" + textBoxPNaziv.Text + "%' ";

            }

            PrikazArtikala();
            query = "SELECT a.artikal_ID, a.naziv_artikla, a.vrsta_artikla, a.cijena, s.kolicina_stanje FROM artikal a, skladiste s WHERE a.artikal_ID=s.artikal_ID";
        }

        int id;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Odaberite polje unutar tabele!");
            }

            string upit="SELECT naziv_artikla, vrsta_artikla, cijena FROM artikal WHERE artikal_ID='"+id+"';";

            try
            {
                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();

                string naziv = reader[0].ToString();
                string vrsta = reader[1].ToString();
                string cijena = reader[2].ToString();

                textBoxNaziv.Text = naziv;
                textBoxVrsta.Text = vrsta;
                textBoxCijena.Text = cijena;
                textBoxIDD.Text = id.ToString();

                reader.Close();
                konekcija.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            Kolicina();
            
        }

        private void Kolicina() 
        {
            string upit = "SELECT kolicina_stanje FROM skladiste WHERE artikal_ID='" + id + "';";

            try
            {
                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                string kolicina = reader[0].ToString();
                textBoxKolicina.Text = kolicina;
                reader.Close();
                konekcija.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

     private void button1_Click(object sender, EventArgs e)
        {
            Double cijena = System.Convert.ToDouble(textBoxCijena.Text.Replace(".", ","));            
            try
            {

                String upit = "INSERT INTO artikal(naziv_artikla, vrsta_artikla, cijena) VALUES ('" + textBoxNaziv.Text + "', '" + textBoxVrsta.Text + "','" + cijena.ToString().Replace(",", ".") + "');";


                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dodan novi artikal !!!");

                konekcija.Close();
                PrikazArtikala();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            ArtikalID();

            int kol=Convert.ToInt32(textBoxKolicina.Text);

            try
            {

                String upit = "INSERT INTO skladiste(artikal_ID, kolicina_stanje) VALUES('"+artIDZaInsert+"','"+kol+"'); ";


                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                cmd.ExecuteNonQuery();                

                konekcija.Close();
                PrikazArtikala();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            PrikazArtikala();
        }

        private void ArtikalID() 
        {
            try
            {

                String upit = "SELECT MAX(artikal_ID) FROM artikal;";


                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);
                MySqlDataReader reader=cmd.ExecuteReader();
                reader.Read();
                artIDZaInsert=Convert.ToInt32(reader[0]);
                reader.Close();
                konekcija.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            PrikazArtikala();
        }

      private void buttonAzuriranje_Click(object sender, EventArgs e)
        {
            Double cijena = System.Convert.ToDouble(textBoxCijena.Text.Replace(".", ","));
            try
            {


                String upit = "UPDATE artikal SET " +
                    " naziv_artikla='" + textBoxNaziv.Text + "', " +
                    " vrsta_artikla='" + textBoxVrsta.Text + "', " +
                    " cijena='" + cijena.ToString().Replace(",", ".") + "' " +     
                    " WHERE artikal_ID='" + id + "' ";

                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Podaci za artikal ID=" + id + " su ažurirani!!!");

                konekcija.Close();

                textBoxNaziv.Text = "";
                textBoxCijena.Text = "";
                textBoxVrsta.Text = "";

                PrikazArtikala();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }


            try
            {


                String upit = "UPDATE skladiste SET " +
                    " kolicina_stanje='" + Convert.ToInt32( textBoxKolicina.Text) + "' " +
                    " WHERE artikal_ID='" + id + "' ";

                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                cmd.ExecuteNonQuery();

                konekcija.Close();

                textBoxNaziv.Text = "";
                textBoxCijena.Text = "";
                textBoxVrsta.Text = "";
                textBoxKolicina.Text = "";

                PrikazArtikala();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

      private void buttonOsvjezi_Click(object sender, EventArgs e)
      {
          textBoxNaziv.Text = "";
          textBoxCijena.Text = "";
          textBoxVrsta.Text = "";
          textBoxKolicina.Text = "";

          textBoxPID.Text = "";
          textBoxPNaziv.Text = "";
          textBoxIDD.Text = "";
      }

      private void buttonDodajteKolicinu_Click(object sender, EventArgs e)
      {
          try
          {
              int kolZaDodati = Convert.ToInt32( numericUpDown1.Value);

              String upit = "UPDATE skladiste SET " +
                  " kolicina_stanje= kolicina_stanje +'"+ kolZaDodati+"'" +
                  " WHERE artikal_ID='" + Convert.ToInt32(textBoxIDD.Text) + "' ";

              MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
              konekcija.Open();

              MySqlCommand cmd = new MySqlCommand(upit, konekcija);

              cmd.ExecuteNonQuery();

              MessageBox.Show("Uspješno ste dodali željenu količinu!!!");
              konekcija.Close();


              PrikazArtikala();
          }
          catch (Exception greska)
          {
              MessageBox.Show(greska.Message);
          }
      }

      private void buttonBrisanje_Click(object sender, EventArgs e)
      {
          try
          {

              String upit = "DELETE FROM artikal WHERE artikal_ID='"+id+"';";

              MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
              konekcija.Open();

              MySqlCommand cmd = new MySqlCommand(upit, konekcija);

              cmd.ExecuteNonQuery();

              MessageBox.Show("Uspješno ste obrisali artikal!!!");
              konekcija.Close();


              PrikazArtikala();
          }
          catch (Exception greska)
          {
              MessageBox.Show(greska.Message);
          }
      }

      private void loginToolStripMenuItem_Click(object sender, EventArgs e)
      {
          Form1 f1 = new Form1();
          this.Hide();
          f1.Show();
      }

      private void kupciToolStripMenuItem_Click(object sender, EventArgs e)
      {
          AdminKupci ak = new AdminKupci();
          this.Hide();
          ak.Show();
      }

      private void narudzbeToolStripMenuItem_Click(object sender, EventArgs e)
      {
          AdminNarudzbe an = new AdminNarudzbe();
          this.Hide();
          an.Show();
      }

      private void label10_Click(object sender, EventArgs e)
      {
          Application.Exit();
      }
   }
}

