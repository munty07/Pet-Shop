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

namespace MTP_petshop
{
    public partial class Form4_CreareCont : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        MySqlCommand cmd;

        public Form4_CreareCont()
        {
            InitializeComponent();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1_Autentificare f = new Form1_Autentificare();
            f.ShowDialog();
        }

        public void reset()
        {
            txtNume.Text = "";
            txtPrenume.Text = "";
            txtMail.Text = "";
            txtOras.Text = "";
            txtAdresa.Text = "";
            txtTelefon.Text = "";
            txtCod.Text = "";
            txtParola.Text = "";
            txtConfirmareParola.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnCreeaza_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNume.Text) || string.IsNullOrEmpty(txtPrenume.Text) || string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(txtOras.Text) || string.IsNullOrEmpty(txtAdresa.Text) || string.IsNullOrEmpty(txtTelefon.Text) || string.IsNullOrEmpty(txtCod.Text) || string.IsNullOrEmpty(txtParola.Text) || string.IsNullOrEmpty(txtConfirmareParola.Text))
            {
                MessageBox.Show("Completati toate campurile!");
            }
            else
            {
                try
                {
                    connection.Open();
                    cmd = new MySqlCommand("INSERT INTO mtp_petshop.conturi (email, parola, nume, prenume, telefon, oras, adresa, cod_postal) VALUES(@email, @parola, @nume, @prenume, @telefon, @oras, @adresa, @cod) ", connection);

                    cmd.Parameters.AddWithValue("@email", txtMail.Text.Trim());
                    cmd.Parameters.AddWithValue("@parola", txtParola.Text.Trim());
                    cmd.Parameters.AddWithValue("@nume", txtNume.Text.Trim());
                    cmd.Parameters.AddWithValue("@prenume", txtPrenume.Text.Trim());
                    cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text.Trim());
                    cmd.Parameters.AddWithValue("@oras", txtOras.Text.Trim());
                    cmd.Parameters.AddWithValue("@adresa", txtAdresa.Text.Trim());
                    cmd.Parameters.AddWithValue("@cod", txtCod.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Contul a fost creat cu succes!");
                        reset();
                    }
                    else
                        MessageBox.Show("Eroare la inserare!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare\n" + ex);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void txtNume_MouseLeave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNume.Text))
            {
                lblEroareNume.Text = "Camp valid!";
                lblEroareNume.ForeColor = Color.Green;
            }
            else
            {
                lblEroareNume.ForeColor = Color.Red;
                lblEroareNume.Text = "Completati campul!";
            }
        }

        private void txtPrenume_MouseLeave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPrenume.Text))
            {
                lblEroarePrenume.Text = "Camp valid!";
                lblEroarePrenume.ForeColor = Color.Green;
            }
            else
            {
                lblEroarePrenume.ForeColor = Color.Red;
                lblEroarePrenume.Text = "Completati campul!";
            }
        }

        private void txtMail_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMail.Text))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(txtMail.Text))
                {
                    lblEroareMail.Text = "Adresa de mail nu este valida!";
                    lblEroareMail.ForeColor = Color.Red;
                }
                else
                {
                    lblEroareMail.ForeColor = Color.Green;
                    lblEroareMail.Text = "Adresa de mail valida!";
                }
            }
        }

        private void txtOras_MouseLeave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtOras.Text))
            {
                lblEroareOras.Text = "Camp valid!";
                lblEroareOras.ForeColor = Color.Green;
            }
            else
            {
                lblEroareOras.ForeColor = Color.Red;
                lblEroareOras.Text = "Completati campul!";
            }
        }

        private void txtAdresa_MouseLeave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAdresa.Text))
            {
                lblEroareAdresa.Text = "Camp valid!";
                lblEroareAdresa.ForeColor = Color.Green;
            }
            else
            {
                lblEroareAdresa.ForeColor = Color.Red;
                lblEroareAdresa.Text = "Completati campul!";
            }
        }

        private void txtParola_MouseLeave(object sender, EventArgs e)
        {
            string password = txtParola.Text;
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

        private void txtConfirmareParola_MouseLeave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtConfirmareParola.Text))
            {
                if (txtConfirmareParola.Text.Equals(txtParola.Text) == true)
                {
                    lblEroareConfirm.Text = "Parola valida!";
                    lblEroareConfirm.ForeColor = Color.Green;
                }
                else
                {
                    lblEroareConfirm.ForeColor = Color.Red;
                    lblEroareConfirm.Text = "Introduceti parola corecta!";
                }
            }
            else
            {
                lblEroareConfirm.ForeColor = Color.Red;
                lblEroareConfirm.Text = "Completati campul!";
            }
        }

        private void txtTelefon_MouseLeave(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^(\+4|)?(07[0-8]{1}[0-9]{1}|02[0-9]{2}|03[0-9]{2}){1}?(\s|\.|\-)?([0-9]{3}(\s|\.|\-|)){2}$");
            if (reg.IsMatch(txtTelefon.Text))
            {
                lblEroareTelefon.Text = "Nr de telefon valid!";
                lblEroareTelefon.ForeColor = Color.Green;
            }
            else
            {
                lblEroareTelefon.ForeColor = Color.Red;
                lblEroareTelefon.Text = "Nr de telefon invalid!";
            }
        }

        private void txtCod_MouseLeave(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"\d{6}");
            if (!reg.IsMatch(txtCod.Text))
            {
                lblEroareCod.Text = "Codul postal nu este valid!";
                lblEroareCod.ForeColor = Color.Red;
            }
            else
            {
                lblEroareCod.ForeColor = Color.Green;
                lblEroareCod.Text = "Codul postal este valid!";
            }
        }
    }
}
