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
    public partial class FormaKategorije : Form
    {
        public FormaKategorije()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\root\trgovina.mdf;Integrated Security=True;Connect Timeout=30");
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into TableKategorije values(" + IdKategorijeTb.Text + ",'" + NazivKategorijeTb.Text + "','" + OpisKategorijeTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("kategorija uspješno dodana");

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
            string query = "select *from TableKategorije";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder bd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            katGDV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FormaKategorije_Load(object sender, EventArgs e)
        {
            populte();
        }

        private void katGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdKategorijeTb.Text = katGDV.SelectedRows[0].Cells[0].Value.ToString();
            NazivKategorijeTb.Text = katGDV.SelectedRows[0].Cells[1].Value.ToString();
            OpisKategorijeTb.Text = katGDV.SelectedRows[0].Cells[2].Value.ToString();
        }//ovo treba popravit program puca ovde

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdKategorijeTb.Text == "")
                {
                    MessageBox.Show("Selektujte kategoriju koju želite izbrisati");
                }
                else
                {
                    Con.Open();
                    string query = "delete from TableKategorije where IdKategorije=" + IdKategorijeTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kategorija obrisana");
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
                if (IdKategorijeTb.Text == "" || NazivKategorijeTb.Text == "" || OpisKategorijeTb.Text == "")
                {
                    MessageBox.Show("Prazna polja");
                }
                else
                {
                    Con.Open();
                    string query = "update TableKategorije set NazivKategorije='" + NazivKategorijeTb.Text + "',OpisKategorije='" + OpisKategorijeTb.Text + "'where IdKategorije=" + IdKategorijeTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kategorija je uređena");
                    Con.Close();
                    populte();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormProizvodi pro = new FormProizvodi();
            pro.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaTrgovci trgf = new FormaTrgovci();
            trgf.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
