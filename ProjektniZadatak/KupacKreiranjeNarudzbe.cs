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
    public partial class KupacKreiranjeNarudzbe : Form
    {
        public KupacKreiranjeNarudzbe()
        {
            InitializeComponent();
        }

        private void KupacKreiranjeNarudzbe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            if(panel1.Visible==true)
            {
                Zavrseno();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            if (panel1.Visible == true)
            {
                Zavrseno();
            }
            this.Hide();
            f1.Show();
        }

        private void prikazNarudzbiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KupacPrikazNarudzbi kpn = new KupacPrikazNarudzbi();
            if (panel1.Visible == true)
            {
                Zavrseno();
            }
            this.Hide();
            kpn.Show();
        }
        
        
        //Prikaz artikala, naziva, cijene, vrste i kolicine


        private void PrikazSvihArtikala() 
        {
            string query = "SELECT a.artikal_ID, a.naziv_artikla, a.vrsta_artikla, a.cijena, s.kolicina_stanje FROM artikal a, skladiste s WHERE a.artikal_ID=s.artikal_ID AND s.kolicina_stanje >0";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);

                konekcija.Open();


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);


                DataTable tabela = new DataTable();


                dataAdapter.Fill(tabela);


                dataGridViewArtikli.DataSource = tabela;

                dataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KupacKreiranjeNarudzbe_Load(object sender, EventArgs e)
        {
            PrikazSvihArtikala();
            panel1.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime danas = DateTime.Now;
                string datum = danas.Date.ToString("yyyy-MM-dd");
                String upit = "INSERT INTO narudzbenica(kupac_ID, datum_narudzbe) VALUES ('" + Form1.kupacID + "', '" + datum + "');";


                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Napravljena je nova narudzba !!!");
                panel1.Show() ;

                konekcija.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

        }

        int artikalID;
        int narudzbenicaID;
        private void dataGridViewArtikli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewArtikli.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    artikalID = int.Parse(dataGridViewArtikli.Rows[e.RowIndex].Cells[0].Value.ToString());
                }

                textBoxID.Text = artikalID.ToString();
                textBoxBrisanje.Text = "";
            }
            catch 
            {
                MessageBox.Show("Trebate odabrati polje u tabeli!");
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            KolicinaArtikla();
            NarudzbenicaID();
            if (textBoxKol.Text == "") 
            {
                MessageBox.Show("Unesite kolicinu!!!");
            }
            else if (narudzbenicaID == 0)
            {
                MessageBox.Show("Niste napravili narudzbu!!");
            }
            else if (Convert.ToInt32(textBoxKol.Text) > kolicinaArtikla)
            {
                MessageBox.Show("Niste odabrali validnu kolicinu!");
            }
            else
            {

                try
                {
                    String upit = "INSERT INTO stavka(narudzbenica_ID, artikal_ID, kolicina) VALUES ('" + narudzbenicaID + "', '" + Convert.ToInt32(textBoxID.Text) + "', '" + Convert.ToInt32(textBoxKol.Text) + "');";


                    MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                    konekcija.Open();

                    MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                    cmd.ExecuteNonQuery();

                    PrikazStavki();
                    OduzimanjeArtikala();
                    UkupnaCijena();
                    textBoxTotal.Text = ukCijena.ToString();

                    konekcija.Close();
                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }


            }
        }

        //Pronalaženje posljednje narudzbe

        private void NarudzbenicaID() 
        {
            try
            {

                String upit = "SELECT MAX(narudzbenica_ID) FROM narudzbenica;";


                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                narudzbenicaID = Convert.ToInt32(reader[0]);
                reader.Close();
                konekcija.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void buttonZavrseno_Click(object sender, EventArgs e)
        {
            Zavrseno();
        }

        //Prikaz stavki narudžbe koje su dodane

        private void PrikazStavki() 
        {
            NarudzbenicaID();
            string query = "SELECT a.naziv_artikla, s.stavka_ID, s.narudzbenica_ID, s.artikal_ID, s.kolicina FROM artikal a, stavka s WHERE a.artikal_ID=s.artikal_ID AND s.narudzbenica_ID='"+narudzbenicaID+"';";
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

        //Oduzimanje broja artikala kada se stavka doda u narudzbu

        private void OduzimanjeArtikala() 
        {
            String upit = "UPDATE skladiste SET kolicina_stanje=kolicina_stanje-'"+Convert.ToInt32(textBoxKol.Text)+"' WHERE artikal_ID='"+Convert.ToInt32(textBoxID.Text)+"';";

            try
            {
                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                cmd.ExecuteNonQuery();



                konekcija.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        
 

        int stavkaID;
        int artikalIDStavka;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    stavkaID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    artikalIDStavka = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
                textBoxBrisanje.Text = stavkaID.ToString();
                textBoxID.Text = artikalIDStavka.ToString();
                textBoxKol.Text = "";                
            }
            catch
            {
                MessageBox.Show("Trebate odabrati polje u tabeli!");
            }

        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            
            if (textBoxBrisanje.Text == "") {
                MessageBox.Show("Unesite ID za brisanje!!!");
            }
            try
            {
                KolicinaZaBrisanje();               
                String upit = "DELETE FROM stavka WHERE stavka_ID='"+Convert.ToInt32(textBoxBrisanje.Text)+"';";

                VracanjeArtikala();
                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);
                
                cmd.ExecuteNonQuery();

                PrikazStavki();
                
                BrojanjeStavki();
                if (brojStavki < 1)
                {
                    textBoxTotal.Text = "0";
                }
                else 
                {
                    UkupnaCijena();
                    textBoxTotal.Text = ukCijena.ToString();
                }
                

                konekcija.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            textBoxBrisanje.Text = "";
        }

        //Pronalaženje kolicine koja se treba obrisati

        int kolicinaBrisanje;
        private void KolicinaZaBrisanje() 
        {
            try
            {

                String upit = "SELECT kolicina FROM stavka WHERE stavka_ID='"+Convert.ToInt32(textBoxBrisanje.Text)+"';";


                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                kolicinaBrisanje = Convert.ToInt32(reader[0]);
                reader.Close();
                konekcija.Close();
                MessageBox.Show("Kolicina za brisanje " + kolicinaBrisanje.ToString());
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        //Povećavanje broja artikala u skladištu kada se obrišu iz narudžbe

        private void VracanjeArtikala() 
        {
            
            String upit = "UPDATE skladiste SET kolicina_stanje=kolicina_stanje +'" + kolicinaBrisanje + "' WHERE artikal_ID='" + Convert.ToInt32(textBoxID.Text) + "';";

            try
            {
                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                cmd.ExecuteNonQuery();

                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            MessageBox.Show("Obrisali ste stavku iz narudzbe!!");
        }

        //Pronalaženje trenutnog broja artikala kako bi se provjerilo da li je moguće naručiti željenu količinu

        int kolicinaArtikla;
        private void KolicinaArtikla() 
        {
            try
            {

                String upit = "SELECT kolicina_stanje FROM skladiste WHERE artikal_ID='"+Convert.ToInt32(textBoxID.Text)+"';";


                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                kolicinaArtikla = Convert.ToInt32(reader[0]);
                reader.Close();
                konekcija.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        //Računanje ukupne cijene

        double ukCijena;
        private void UkupnaCijena() 
        {
            try
            {

                String upit = "SELECT SUM(a.cijena*s.kolicina) FROM artikal a, stavka s WHERE s.artikal_ID=a.artikal_ID AND narudzbenica_ID='"+narudzbenicaID+"';" ;


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

        // Brisanje naružbi koje su prazne

        private void BrisanjeNarudzbenica() 
        {
            try
            {

                String upit = "DELETE FROM narudzbenica WHERE narudzbenica_ID='" + narudzbenicaID + "';";

                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                cmd.ExecuteNonQuery();
                konekcija.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        //Brojanje stavki kako bi se lakše napisala ukupna cijena

        int brojStavki;
        private void BrojanjeStavki() 
        {
            try
            {

                String upit = "SELECT COUNT(stavka_ID) FROM stavka WHERE narudzbenica_ID='" + narudzbenicaID + "';";


                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                brojStavki = Convert.ToInt32(reader[0]);
                reader.Close();
                konekcija.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Kod koji se izvršava kada se završi narudžba

        private void Zavrseno() 
        {
            panel1.Hide();
            NarudzbenicaID();
            string upit = "SELECT n.narudzbenica_ID FROM narudzbenica n, stavka s WHERE n.narudzbenica_ID=s.narudzbenica_ID AND n.narudzbenica_ID='" + narudzbenicaID + "';";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (!reader.HasRows)
                {
                    BrisanjeNarudzbenica();
                }
                reader.Close();
                konekcija.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            textBoxID.Text = "";
            textBoxKol.Text = "";
            dataGridView1.DataSource = null;
            MessageBox.Show("Narudzba je zavrsena!!");
        }

    }
}
