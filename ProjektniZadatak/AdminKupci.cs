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
    public partial class AdminKupci : Form
    {
        public AdminKupci()
        {
            InitializeComponent();
        }

        String query = "SELECT * FROM kupac WHERE ime IS NOT NULL";

        private void PrikazKupaca()
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

        private void AdminKupci_Load(object sender, EventArgs e)
        {
            PrikazKupaca();
        }

        private void AdminKupci_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonPretraga_Click(object sender, EventArgs e)
        {
            if (textBoxPIme.Text != "")
            {
                query += " AND ime LIKE '" + textBoxPIme.Text + "%' ";

            }

            else if (textBoxPPrezime.Text != "")
            {
                query += " AND prezime LIKE '" + textBoxPPrezime.Text + "%' ";

            }

            PrikazKupaca();
            query="SELECT * FROM kupac WHERE ime IS NOT NULL";
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
            catch{
                MessageBox.Show("Odaberite polje unutar tabele!");
            }
           
            string upit = "SELECT ime, prezime, grad, adresa, telefon, username, password FROM kupac WHERE kupac_ID='"+id+"'";

            try
            {
                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();

                String ime = reader[0].ToString();
                String prezime = reader[1].ToString();
                String grad = reader[2].ToString();
                String adresa = reader[3].ToString();
                String telefon = reader[4].ToString();
                String username = reader[5].ToString();
                String password = reader[6].ToString();

                
                textBoxIme.Text = ime;
                textBoxPrezime.Text = prezime;
                textBoxGrad.Text = grad;
                textBoxTelefon.Text = telefon;
                textBoxAdresa.Text = adresa;
                textBoxKorIme.Text = username;
                textBoxSifra.Text = password;

                reader.Close();
                konekcija.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void buttonOsvjezi_Click(object sender, EventArgs e)
        {
            textBoxIme.Text = "";
            textBoxPrezime.Text = "";
            textBoxGrad.Text = "";
            textBoxTelefon.Text = "";
            textBoxAdresa.Text = "";
            textBoxKorIme.Text = "";
            textBoxSifra.Text = "";
        }

        private void buttonAzuriranje_Click(object sender, EventArgs e)
        {
            try
            {
                

                String upit = "UPDATE kupac SET " +
                    " ime='" + textBoxIme.Text + "', " +
                    " prezime='" + textBoxPrezime.Text + "', " +
                    " grad='" + textBoxGrad.Text + "', " +
                    " telefon='" + textBoxTelefon.Text + "', " +
                    " adresa='" + textBoxAdresa.Text + "', " +
                    " username='" + textBoxKorIme.Text + "', " +
                    " password='" + textBoxSifra.Text + "' " +
                    " WHERE kupac_ID='" + id + "' ";

                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Podaci za kupca ID=" + id + " su ažurirani!!!");

                konekcija.Close();

                textBoxIme.Text = "";
                textBoxPrezime.Text = "";
                textBoxGrad.Text = "";
                textBoxTelefon.Text = "";
                textBoxAdresa.Text = "";
                textBoxKorIme.Text = "";
                textBoxSifra.Text = "";

                PrikazKupaca();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void buttonKreiraj_Click(object sender, EventArgs e)
        {
            try
            {

                String upit = "INSERT INTO kupac(ime, prezime, grad, adresa, telefon, username, password) " +
                    "VALUES ('" + textBoxIme.Text + "', '" + textBoxPrezime.Text + "', '" + textBoxGrad.Text + "', " +
                    " '" + textBoxAdresa.Text + "', '" + textBoxTelefon.Text + "', " +
                    " '" + textBoxKorIme.Text + "', '" + textBoxSifra.Text + "');";
                    

                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dodan novi kupac !!!");

                konekcija.Close();
                PrikazKupaca();
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

                String upit = "DELETE FROM kupac WHERE kupac_ID='" + id + "';";

                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Uspješno ste obrisali kupca!!!");
                konekcija.Close();


                PrikazKupaca();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void kupciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminArtikli aa = new AdminArtikli();
            this.Hide();
            aa.Show();
        }

        private void artikliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void narudzbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminNarudzbe an = new AdminNarudzbe();
            this.Hide();
            an.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
