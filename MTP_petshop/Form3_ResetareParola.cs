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

namespace MTP_petshop
{
    public partial class Form3_ResetareParola : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        MySqlCommand cmd;
        MySqlDataReader reader;

        public Form3_ResetareParola()
        {
            InitializeComponent();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1_Autentificare f = new Form1_Autentificare();
            f.ShowDialog();
        }

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

        public void update(string user, string pass)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE mtp_petshop.conturi SET parola = '" + pass + "'WHERE email = '" + user + "';";

            try
            {
                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read()) { }
                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Eroare\n" + erro);
                this.Close();
            }
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            bool cauta = cauta_utilizator();
            string user = txtMail.Text;
            string pass = txtParolaNoua.Text;
            if (cauta == false)
            {
                txtMail.Text = "";
                txtParolaNoua.Text = "";
                MessageBox.Show("Utilizatorul nu exista!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Sunteti sigur ca doriti sa modificati parola?", "Resetarea Parolei", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if(lblEroareParola.ForeColor == Color.Red)
                    {
                        MessageBox.Show("Parola trebuie sa fie valida!");
                    }
                    else
                    {
                        update(user, pass);
                        MessageBox.Show("Parola a fost modificata cu succes!!");
                        this.Hide();
                        Form1_Autentificare f = new Form1_Autentificare();
                        f.ShowDialog();
                    }
                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    txtParolaNoua.Text = "";
                }
            }
        }

        private void txtParolaNoua_MouseLeave(object sender, EventArgs e)
        {
            string password = txtParolaNoua.Text;
            if (password.Length > 8 && // Must be above 8 characters
                password.Any(char.IsUpper) && //At least one uppercase
                password.Any(char.IsLower) && //At least one lowercase
                password.Any(char.IsDigit) //At least one number
                )
            {
                lblEroareParola.Text = "Parola valida!";
                lblEroareParola.ForeColor = Color.Green;
            }
            else
            {
                lblEroareParola.ForeColor = Color.Red;
                lblEroareParola.Text = "Parola trebuie sa contina > 8 litere: mari, mici si cel putin un numar";
            }
        }
    }
}
