using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat_ONT
{
    public partial class FormaTrgovci : Form
    {
        public FormaTrgovci()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\root\trgovina.mdf;Integrated Security=True;Connect Timeout=30");
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into TableTrgovac values(" + IdTrgovcaTB.Text + ",'" + ImeTrgovcaTB.Text + "','" + GodineTrgovcaTB + "','" + TelefonTrgovcaTB.Text + "','" + SifraTrgovcaTB.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Trgovac uspješno dodan");

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
            string query = "select *from TableTrgovac";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder bd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            trgGDV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdTrgovcaTB.Text == "")
                {
                    MessageBox.Show("Selektujte trgovca kojeg želite izbrisati");
                }
                else
                {
                    Con.Open();
                    string query = "delete from TableTrgovac where IdTrgovca=" + IdTrgovcaTB.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Trgovac izbrisan");
                    Con.Close();
                }
                populte();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdTrgovcaTB.Text == "" || ImeTrgovcaTB.Text == "" || GodineTrgovcaTB.Text == "" || TelefonTrgovcaTB.Text == "" || SifraTrgovcaTB.Text == "")
                {
                    MessageBox.Show("Prazna polja");
                }
                else
                {
                    Con.Open();
                    string query = "update TableTrgovac set ImeTrgovca='" + ImeTrgovcaTB.Text + "',GodineTrgovca='" + GodineTrgovcaTB.Text + "',TelefonTrgovca='" + TelefonTrgovcaTB.Text + "',SifraTrgovca='" + SifraTrgovcaTB.Text + "'where IdTrgovca=" + IdTrgovcaTB.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Korisnik je uređen");
                    Con.Close();
                    populte();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //populte();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProizvodi formProizvodi = new FormProizvodi();
            formProizvodi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaKategorije formaKategorije = new FormaKategorije();
            formaKategorije.Show();
            this.Hide();
        }

        private void trgGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 odjava = new Form1();
            odjava.Show();
        }
    }
}
