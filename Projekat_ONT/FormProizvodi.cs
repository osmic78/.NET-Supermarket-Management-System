using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projekat_ONT
{
    public partial class FormProizvodi : Form
    {
        public FormProizvodi()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\root\trgovina.mdf;Integrated Security=True;Connect Timeout=30");

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listacombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select NazivKategorije from TableKategorije", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("NazivKategorije", typeof(string));
            dt.Load(rdr);
            katcmb.ValueMember = "NazivKategorije";
            katcmb.DataSource = dt;
            Con.Close();
        }

        private void FormProizvodi_Load(object sender, EventArgs e)
        {
            listacombo();

        }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into TableProizvodi values(" + IdProizvodaTB.Text + ",'" + NazivProizvodaTB.Text + "','" + KolicinaProizvodaTB.Text + "','" + CijenaProizvodaTB.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Proizvod uspješno dodan");

                Con.Close();
                populte();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void populte()
        {
            Con.Open();
            string query = "select *from TableProizvodi";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder bd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            proDGV.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdProizvodaTB.Text == "" || NazivProizvodaTB.Text == "" || KolicinaProizvodaTB.Text == "" || CijenaProizvodaTB.Text == "")
                {
                    MessageBox.Show("Prazna polja");
                }
                else
                {
                    Con.Open();
                    string query = "update TableProizvodi set NazivProizvoda='" + NazivProizvodaTB.Text + "',KolicinaProizvoda='" + KolicinaProizvodaTB.Text + "',CijenaProizvoda='" + CijenaProizvodaTB.Text + "'where IdProizvoda=" + IdProizvodaTB.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kategorija je uređena");
                    Con.Close();
                    populte();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }



        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdProizvodaTB.Text == "")
                {
                    MessageBox.Show("Selektujte kategoriju koju želite izbrisati");
                }
                else
                {
                    Con.Open();
                    string query = "delete from TableProizvodi where IdProizvoda=" + IdProizvodaTB.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Proizvod izbrisan");
                    Con.Close();
                }
                populte();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaKategorije kat = new FormaKategorije();
            kat.Show();
            this.Hide();
        }

        private void proDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdProizvodaTB.Text = proDGV.SelectedRows[0].Cells[0].Value.ToString();
            NazivProizvodaTB.Text = proDGV.SelectedRows[0].Cells[1].Value.ToString();
            KolicinaProizvodaTB.Text = proDGV.SelectedRows[0].Cells[2].Value.ToString();
            CijenaProizvodaTB.Text = proDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //populte();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaTrgovci formaTrgovci = new FormaTrgovci();
            formaTrgovci.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 odjava = new Form1();
            odjava.Show();
        }
    }
}
