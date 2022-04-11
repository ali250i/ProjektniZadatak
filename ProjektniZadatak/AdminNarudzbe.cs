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
    public partial class AdminNarudzbe : Form
    {
        public AdminNarudzbe()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 lo = new Form1();
            this.Hide();
            lo.Show();
        }

        private void PrikazNarudzbi()
        {
            string query = "SELECT n.narudzbenica_ID, n.kupac_ID, n.datum_narudzbe, k.ime, k.prezime "+
            " FROM narudzbenica n, kupac k  WHERE  "+
            " n.kupac_ID=k.kupac_ID;";
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

        private void AdminNarudzbe_Load(object sender, EventArgs e)
        {
            PrikazNarudzbi();
        }

        private void AdminNarudzbe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        int idNar;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    idNar = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                }

                textBox1.Text = idNar.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show("Trebate odabrati polje u tabeli!");
            }
        }

        private void buttonBrisanje_Click(object sender, EventArgs e)
        {
            try
            {

                String upit = "DELETE FROM narudzbenica WHERE narudzbenica_ID='" + idNar + "';";

                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Uspješno ste obrisali narudzbu!!!");
                konekcija.Close();


                PrikazNarudzbi();
                textBox1.Text = "";
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void artikliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminArtikli aa = new AdminArtikli();
            this.Hide();
            aa.Show();
        }

        private void kupciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminKupci ak = new AdminKupci();
            this.Hide();
            ak.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
