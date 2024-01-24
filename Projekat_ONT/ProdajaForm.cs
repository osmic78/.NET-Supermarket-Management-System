using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace Projekat_ONT
{
    public partial class ProdajaForm : Form
    {
        public ProdajaForm()
        {
            InitializeComponent();
            popunj_dgv();
            racu_dgv();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\root\trgovina.mdf;Integrated Security=True;Connect Timeout=30");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            datelabel.Text = DateTime.Today.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }


        private void popunj_dgv()
        {
            Con.Open();
            SqlDataAdapter adapter;
            DataSet dataset = new DataSet();

            string query = "SELECT * FROM TableProizvodi";
            adapter = new SqlDataAdapter(query, Con);
            adapter.Fill(dataset, "TableProizvodi");

            dgv.DataSource = dataset.Tables["TableProizvodi"];
            Con.Close();
        }

        private void racu_dgv()
        {
            Con.Open();
            SqlDataAdapter adapter;
            DataSet dataset = new DataSet();

            string query = "SELECT * FROM TableRacuni";
            adapter = new SqlDataAdapter(query, Con);
            adapter.Fill(dataset, "TableRacuni");

            dgvrac.DataSource = dataset.Tables["TableRacuni"];
            Con.Close();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgv.SelectedRows[0];
                ArtikalTB.Text = dr.Cells[0].Value.ToString();

                ArtikalTB.Text = dr.Cells["NazivProizvoda"].Value.ToString();
                CijenaTB.Text = dr.Cells["CijenaProizvoda"].Value.ToString();
            }
        }
        private void NazivProizvodaTB_TextChanged(object sender, EventArgs e)
        {

        }





        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CijenaProizvodaTB_TextChanged(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            Con.Open();
            string query = "select NazivProizvoda,KoličinaProizvoda from TableProizvodi";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder bd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }




        private void ProdajaForm_Load(object sender, EventArgs e)
        {

        }


        double ukupno = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ArtikalTB.Text == "" || KolicinaTB.Text == "")
            {
                MessageBox.Show("Unesite sve podatke");
            }
            else
            {
                int n = 0;

                double cijena = Convert.ToDouble(CijenaTB.Text);
                int količina = Convert.ToInt32(KolicinaTB.Text);
                ukupno = cijena * količina;
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(dataGridView1);
                dr.Cells[0].Value = n + 1;
                dr.Cells[1].Value = ArtikalTB.Text;
                dr.Cells[2].Value = CijenaTB.Text;
                dr.Cells[3].Value = KolicinaTB.Text;
                dr.Cells[4].Value = ukupno;
                dataGridView1.Rows.Add(dr);



                RecalculateTotal();

                // ukupnLB.Text = ukupno +  "KM";
            }
        }
        private void RecalculateTotal()
        {
            double ukupnaCifra = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null)  // Provjeri da li ćelija ima vrijednost
                {
                    double ukupnoReda;
                    if (double.TryParse(row.Cells[4].Value.ToString(), out ukupnoReda))
                    {
                        ukupnaCifra += ukupnoReda;
                    }
                }
            }
            ukupnLB.Text = ukupnaCifra.ToString() + " KM";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            printDocument.Print();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(bitmap, new Point(10, 10));
            e.Graphics.DrawString("UKUPNO:" + ukupnLB.Text, new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(100, 350));
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            /*   e.Graphics.DrawString("TRGOVINA MARKET",new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
               e.Graphics.DrawString(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 70));
               e.Graphics.DrawString("Artikal"+dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100,100));
               e.Graphics.DrawString("Cijena"+dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
               e.Graphics.DrawString("Količina"+dataGridView1.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 160));

               */



        }


        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 odjava = new Form1();
            odjava.Show();
        }

        private void ukupnLB_Click(object sender, EventArgs e)
        {

        }

        private void BrojracTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BrojracTB.Text == "")
            {
                MessageBox.Show("Nedostaje broj račuan");
            }
            else
            {
                try
                {
                    int brojrac = Convert.ToInt32(BrojracTB.Text);
                    // double ukupno=Convert.ToDouble(ukupnLB.Text);

                    //  string ukupnoText = ukupnLB.Text.Replace("KM", "").Trim();
                    //decimal ukupno = decimal.Parse(ukupnoText);

                    Con.Open();
                    string query = "insert into TableRacuni values(" + brojrac + ",'" + trgovacime.Text + "','" + datelabel.Text + "','" + ukupno + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.Parameters.AddWithValue("@BrojRacuna", brojrac);
                    cmd.Parameters.AddWithValue("@TrgovacIme", trgovacime.Text);
                    cmd.Parameters.AddWithValue("@Datum", datelabel.Text);
                    cmd.Parameters.AddWithValue("@Ukupno", ukupno);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Račun uspješno spremljen");

                    //populateracuni();
                    Con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Provjeri da li je odabrana ćelija u stupcu (ako je potrebno)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Dohvati podatke iz odabranog reda
                DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];

                // Popuni TextBoxe sa podacima iz reda
                ArtikalTB.Text = selectedRow.Cells[1].Value.ToString();
                CijenaTB.Text = selectedRow.Cells[3].Value.ToString();


            }
        }
    }
}
