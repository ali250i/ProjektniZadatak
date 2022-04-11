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
    public partial class KupacPrikazNarudzbi : Form
    {
        public KupacPrikazNarudzbi()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void kreiranjeNarudzbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KupacKreiranjeNarudzbe kkn = new KupacKreiranjeNarudzbe();
            this.Hide();
            kkn.Show();
        }

        private void PrikazNarudzbi() 
        {
            string query = "SELECT n.narudzbenica_ID, n.kupac_ID, n.datum_narudzbe, k.ime, k.prezime FROM narudzbenica n, kupac k WHERE n.kupac_ID=k.kupac_ID AND n.kupac_ID='"+Form1.kupacID+"';";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);

                konekcija.Open();


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);


                DataTable tabela = new DataTable();


                dataAdapter.Fill(tabela);


                dataGridViewNarudzbe.DataSource = tabela;

                dataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrikazStavki() 
        {
            string query = "SELECT s.stavka_ID, s.narudzbenica_ID, s.artikal_ID, s.kolicina, a.naziv_artikla FROM stavka s, artikal a WHERE s.artikal_ID=a.artikal_ID AND s.narudzbenica_ID='"+narudzbenicaID+"';";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);

                konekcija.Open();


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);


                DataTable tabela = new DataTable();


                dataAdapter.Fill(tabela);


                dataGridViewStavke.DataSource = tabela;

                dataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        double ukCijena;
        private void UkupnaCijena()
        {
            try
            {

                String upit = "SELECT SUM(a.cijena*s.kolicina) FROM artikal a, stavka s WHERE s.artikal_ID=a.artikal_ID AND narudzbenica_ID='" + narudzbenicaID + "';";


                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ukCijena = Convert.ToDouble(reader[0]);
                reader.Close();
                konekcija.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void KupacPrikazNarudzbi_Load(object sender, EventArgs e)
        {
            PrikazNarudzbi();
        }

        private void KupacPrikazNarudzbi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        int narudzbenicaID;
        private void dataGridViewNarudzbe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewNarudzbe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    narudzbenicaID = int.Parse(dataGridViewNarudzbe.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                PrikazStavki();
                UkupnaCijena();
                textBoxTotal.Text = ukCijena.ToString();
            }
            catch
            {
                MessageBox.Show("Trebate odabrati polje u tabeli!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewStavke.DataSource = null;
            textBoxTotal.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
