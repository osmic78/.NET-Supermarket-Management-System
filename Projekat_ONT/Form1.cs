using System.Data;
using System.Data.SqlClient;

namespace Projekat_ONT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\root\trgovina.mdf;Integrated Security=True;Connect Timeout=30");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            korTB.Text = "";
            sifTB.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(korTB.Text=="" || sifTB.Text == "")
            {
                MessageBox.Show("Unesite Ime korisnika i šifru");
            }
            else
            {
                if (roleCB.SelectedIndex > -1)
                {

                    if (roleCB.SelectedItem.ToString() == "ADMIN")
                    {
                        if (korTB.Text == "Admin" && sifTB.Text == "admin")
                        {
                            FormProizvodi pro = new FormProizvodi();
                            pro.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Pogrešan unos.Pokušajte ponovo!!!");
                        }
                    }
                    else
                    {
                        Con.Open();
                        SqlDataAdapter sda=new SqlDataAdapter("Select count(8)from TableTrgovac where ImeTrgovca='"+korTB.Text+ "'and SifraTrgovca='"+sifTB.Text+ "'",Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            ProdajaForm prodf = new ProdajaForm();
                            prodf.Show();
                            this.Hide();
                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Pogrešni podaci");
                        }
                        Con.Close();
                    }
     
                }
                else
                {
                    MessageBox.Show("Odaberite kategoriju");
                }
            }
        }


    }
}