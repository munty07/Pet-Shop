using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using Aspose.Pdf;

namespace MTP_petshop
{
    public partial class Form1_Autentificare : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        MySqlCommand cmd;
        MySqlDataReader reader;
        public int nrDoc;

        public Form1_Autentificare()
        {
            InitializeComponent();
        }
        //functie pentru cautarea utilizatorului(daca mail ul exista in baza de date)
        public bool cauta_utilizator()
        {
            string p = "";
            bool found = false;
            cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT email FROM mtp_petshop.conturi WHERE email = '" + txtMail.Text + "';";

            try
            {
                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    p = reader.GetString(0);
                    found = true;
                }
                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Eroare cautare\n" + erro);
                this.Close();
            }

            if (found)
                return true;
            else
                return false;
        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            bool cauta = cauta_utilizator();

            if (cauta == false)
            {
                if (String.IsNullOrEmpty(txtMail.Text))
                {
                    MessageBox.Show("Introduceti adresa de mail!");
                }
                else
                {
                    MessageBox.Show("Adresa de mail nu exista!");
                }

                if (String.IsNullOrEmpty(txtParola.Text))
                {
                    MessageBox.Show("Introduceti parola!");
                }
                else
                {
                    MessageBox.Show("Parola gresita!");
                }
            }
            else
            {
                //daca exista mail ul in baza de date
                //verificam daca parola introdusa este cea corecta
                try
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT email, parola FROM mtp_petshop.conturi WHERE email = '" + txtMail.Text + "'AND parola = '" + txtParola.Text + "';";
                    reader = cmd.ExecuteReader();

                    if (!reader.Read())
                    {
                        MessageBox.Show("Parola incorecta!!\n Introduceti parola corecta!!");
                        txtParola.Text = "";
                    }
                    else
                    {
                        string utilizator;
                        utilizator = txtMail.Text;
                        this.Hide();
                        Form2_Shop f = new Form2_Shop(utilizator);
                        f.ShowDialog();
                    }
                    connection.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Eroare autentificare\n" + err);
                    this.Close();
                }
            }
        }

        private void lblModificareParola_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3_ResetareParola f = new Form3_ResetareParola();
            f.ShowDialog();
        }

        private void btnCreareCont_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4_CreareCont f = new Form4_CreareCont();
            f.ShowDialog();
        }
        //validarea mail ului
        private void txtMail_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMail.Text))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(txtMail.Text))
                {
                    lblEroare.Text = "Adresa de mail nu este valida!";
                }
                else
                {
                    lblEroare.Text = "";
                }
            }
        }
    }
}
