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
using System.Net.Mail;
using System.Text.RegularExpressions;
using Aspose.Pdf;

namespace MTP_petshop
{
    public partial class Form5_FinalizareComanda : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        MySqlDataAdapter dataAdapter;
        MySqlCommand cmd;
        DataSet dataSet;
        MySqlDataReader myReader;
        public int nr = 0;
        public int pretInitial;
        public int discount;

        //public string[] denumireProd;
        //public string[] pretProd;
        //public string[] nrProd;
        List<string> denumireProd = new List<string>();
        List<string> pretProd = new List<string>();
        List<string> nrProd = new List<string>();

        public Form5_FinalizareComanda(string utilizator)
        {
            InitializeComponent();
            txtMail.Text = utilizator;
        }

        private void Form5_FinalizareComanda_Load(object sender, EventArgs e)
        {
            btnComanda.Enabled = false;
            //functie pentru afisare a datelor in DataGridView
            show_db();
            //functie pentru afisarea sumei produselor, excluzand transportul si reducerea
            total();
            //functie pentru preluarea datelor utilizatorului
            dateUtilizator();
            //functie pentru aplicarea taxei de transport
            transport();
            //functie pentru aplicarea reducerii
            reducere();

            //calculam suma totala inainte de a aplica reducerea
            pretInitial = Convert.ToInt32(txtSuma.Text) + Convert.ToInt32(txtTransport.Text);
            //preluam valoarea cu care este redusa suma
            discount = Convert.ToInt32(txtReducere.Text.Substring(0, txtReducere.Text.LastIndexOf("%")));
            //calculam suma totala dupa aplicarea reducerii
            txtTotal.Text = (pretInitial - (pretInitial * discount / 100)).ToString();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2_Shop f = new Form2_Shop(txtMail.Text);
            f.ShowDialog();
        }
        //functie pentru afisarea datelor in DataGridView
        public void show_db()
        {
            string sql;
            sql = "SELECT A.email, A.id_prod, nr_prod, B.tip, B.denumire, B.pret, B.animal FROM mtp_petshop.cos AS A JOIN mtp_petshop.produse AS B ON A.id_prod = B.id WHERE A.email = '" + txtMail.Text + "';";
            dataAdapter = new MySqlDataAdapter(sql, connection);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "cos_cumparaturi");
            dgvCosProduse.DataSource = dataSet.Tables["cos_cumparaturi"];
        }
        //functie pentru calculul sumei produselor, excluzand transportul si reducerea
        public void total()
        {
            string result = "SELECT SUM(B.pret*A.nr_prod) AS pret FROM mtp_petshop.cos AS A JOIN mtp_petshop.produse AS B ON A.id_prod = B.id WHERE A.email = '" + txtMail.Text + "';";

            using (MySqlCommand showresult = new MySqlCommand(result, connection))
            {
                try
                {
                    connection.Open();
                    txtSuma.Text = showresult.ExecuteScalar().ToString();
                    //MessageBox.Show("suma totala " + txtSuma.Text);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        //functie pentru preluarea datelor utilizatorului
        public void dateUtilizator()
        {
            string sql;
            sql = "SELECT * FROM mtp_petshop.conturi WHERE email ='" + txtMail.Text + "';";

            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {
                txtNume.Text = myReader.GetString(2);
                txtPrenume.Text = myReader.GetString(3);
                txtTelefon.Text = myReader.GetString(4);
                txtOras.Text = myReader.GetString(5);
                txtAdresa.Text = myReader.GetString(6);
                txtPosta.Text = myReader.GetString(7);
                lblNrComanda.Text = myReader.GetString(8);
            }
            connection.Close();
        }
        //functie pentru aplicarea reducerii
        public void reducere()
        {
            if (Convert.ToInt32(lblNrComanda.Text) > 2)
            {
                txtReducere.Text = "10%";
            }
            else
            {
                txtReducere.Text = "0%";
            }
        }
        //functie pentru aplicarea taxei de transport la inceputul rularii
        public void transport()
        {
            if (Convert.ToInt32(txtSuma.Text) > 200)
            {
                txtTransport.Text = "0";
            }
            else
            {
                txtTransport.Text = "25";
            }
        }
        //functie pentru aplicarea taxei de transport in functie de alegerea transportului
        public void livrare()
        {
            if (Convert.ToInt32(txtSuma.Text) > 200)
            {
                if (radioPosta.Checked == true)
                {
                    txtPosta.Enabled = true;
                }
                else
                {
                    txtPosta.Enabled = false;
                }
                txtTransport.Text = "0";

                pretInitial = Convert.ToInt32(txtSuma.Text) + Convert.ToInt32(txtTransport.Text);
                discount = Convert.ToInt32(txtReducere.Text.Substring(0, txtReducere.Text.LastIndexOf("%")));

                txtTotal.Text = (pretInitial - (pretInitial * discount / 100)).ToString();
            }
            else
            {
                if (radioPosta.Checked == true)
                {
                    txtPosta.Enabled = true;
                    txtTransport.Text = "15";

                    pretInitial = Convert.ToInt32(txtSuma.Text) + Convert.ToInt32(txtTransport.Text);
                    discount = Convert.ToInt32(txtReducere.Text.Substring(0, txtReducere.Text.LastIndexOf("%")));

                    txtTotal.Text = (pretInitial - (pretInitial * discount / 100)).ToString();
                }
                else
                {
                    txtPosta.Enabled = false;
                    txtTransport.Text = "25";

                    pretInitial = Convert.ToInt32(txtSuma.Text) + Convert.ToInt32(txtTransport.Text);
                    discount = Convert.ToInt32(txtReducere.Text.Substring(0, txtReducere.Text.LastIndexOf("%")));

                    txtTotal.Text = (pretInitial - (pretInitial * discount / 100)).ToString();
                }
            }
            if (radioCurier.Checked == true || radioPosta.Checked == true)
            {
                btnComanda.Enabled = true;
            }
            else
            {
                btnComanda.Enabled = false;
            }
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            string toEmail = txtMail.Text.Trim();

            string nume = txtNume.Text;
            string prenume = txtPrenume.Text;
            string sumaTotala = txtTotal.Text;

            //introduceti adresa dvs de mail!!
            MailMessage mailMessage = new MailMessage("mira.theduet@gmail.com", toEmail);

            StringBuilder sbEmailBody = new StringBuilder();
            sbEmailBody.Append("Dl./Dna. " + nume);
            sbEmailBody.Append("<br/><br/>");
            sbEmailBody.Append("Va multumim pentru comanda plasata!");
            sbEmailBody.Append("<br/><br/>Datele de facturare:");
            sbEmailBody.Append("<br/>   Nume: " + nume);
            sbEmailBody.Append("<br/>   Prenume: " + prenume);
            sbEmailBody.Append("<br/>   Suma totala: " + sumaTotala + "lei");
            sbEmailBody.Append("<br/>Va atasam un document cu datele de facturare.");
            sbEmailBody.Append("<br/><br/>");
            sbEmailBody.Append("Cu stima, ");
            sbEmailBody.Append("Mihaela Muntyan");

            mailMessage.IsBodyHtml = true;

            mailMessage.Body = sbEmailBody.ToString();
            mailMessage.Subject = "Comanda a fost inregistrata";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            System.Net.Mail.Attachment attachment;
            //generam factura in format PDF
            genFactura();
            attachment = new System.Net.Mail.Attachment("C:\\Users\\Hp\\source\\repos\\MTP_petshop\\MTP_petshop\\bin\\Debug\\factura" + (Convert.ToInt32(lblNrComanda.Text) + 1).ToString() + txtNume.Text + ".pdf");
            mailMessage.Attachments.Add(attachment);

            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                //introduceti adresa dvs de mail si parola acesteia
                UserName = "mira.theduet@gmail.com",
                Password = "midelamimiradelaralu"
            };

            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);

            //actualizam nr de comenzi efectuate de catre utilizatorul logat
            update_nrComanda();
            //stergem datele din cosul de cumparaturi dupa plasarea comenzii
            stergereCos();

            MessageBox.Show("Comanda a fost inregistrata!");
            this.Hide();
            Form2_Shop f = new Form2_Shop(txtMail.Text);
            f.ShowDialog();
        }

        public void genFactura()
        {
            Document doc = new Document();

            Aspose.Pdf.Table table = new Aspose.Pdf.Table();
            // setam culoarea bordurii LightGray
            table.Border = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, .5f, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray));
            // setam bordurile pentru celule
            table.DefaultCellBorder = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, .5f, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray));


            Page page = doc.Pages.Add();
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(""));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("FACTURA"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(""));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Pet Shop - Mihaela Muntyan"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(""));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(""));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Date facturare:"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(""));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Nume si prenume: " + txtNume.Text + " " + txtPrenume.Text));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Adresa de mail: " + txtMail.Text));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Nr. telefon: " + txtTelefon.Text));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Oras: " + txtOras.Text));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Adresa: " + txtAdresa.Text));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Cod postal: " + txtPosta.Text));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(""));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Produse:"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(""));



            Aspose.Pdf.Row row = table.Rows.Add();

            row.Cells.Add("Denumire produs");
            row.Cells.Add("Pret");
            row.Cells.Add("Nr produse");

            
            //MessageBox.Show("nr de produse in cos:" + nrProdComanda());
            dateProd();
            for (int row_count = 0; row_count < nrProdComanda(); row_count++)
            {
                Aspose.Pdf.Row row2 = table.Rows.Add();

                row2.Cells.Add(denumireProd[row_count]);
                row2.Cells.Add(pretProd[row_count]);
                row2.Cells.Add(nrProd[row_count]);
            }
            page.Paragraphs.Add(table);

            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("\nSuma produse: " + txtSuma.Text));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Taxa transport: " + txtTransport.Text));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Reducere: " + txtReducere.Text));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(""));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Suma totala: " + txtTotal.Text));

            doc.Save("factura" + (Convert.ToInt32(lblNrComanda.Text) + 1).ToString() + txtNume.Text + ".pdf");
            MessageBox.Show("S-a generat factura");
        }

        public void dateProd()
        {
            string sql;
            sql = "SELECT B.denumire, B.pret, A.nr_prod FROM mtp_petshop.cos AS A JOIN mtp_petshop.produse AS B ON A.id_prod = B.id WHERE email ='" + txtMail.Text + "';";

            string den, pr, n;
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            myReader = cmd.ExecuteReader();
            
            while (myReader.Read())
            {
                den = myReader.GetString(0);
                denumireProd.Add(den);
                pr = myReader.GetString(1);
                pretProd.Add(pr);
                n = myReader.GetString(2);
                nrProd.Add(n);


            }
            connection.Close();
            //MessageBox.Show("Denumire: " + denumireProd + "\nPret: " + pretProd + "\nNr: " + nrProd);
        }

        public int nrProdComanda()
        {
            string sql;
            int counter;
            sql = "SELECT COUNT(*) FROM mtp_petshop.cos WHERE email = '" + txtMail.Text + "';";
            cmd = new MySqlCommand(sql, connection);
            connection.Open();

            counter = int.Parse(cmd.ExecuteScalar().ToString());

            connection.Close();
            return counter;
        }

        public void stergereCos()
        {
            string sql = "DELETE FROM mtp_petshop.cos WHERE email = @mail";
            MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@mail", txtMail.Text);
            connection.Open();
            try
            {
                if (command.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Toate datele din cosul de cumparaturi au fost sterse!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public void update_nrComanda()
        {
            int nr;
            nr = Convert.ToInt32(lblNrComanda.Text);
            nr = nr + 1;

            cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE mtp_petshop.conturi SET nr_comenzi = '" + nr.ToString() + "'WHERE email = '" + txtMail.Text + "';";

            try
            {
                connection.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read()) { }
                connection.Close();
                MessageBox.Show("Datele au fost actualizate!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Eroare\n" + erro);
                this.Close();
            }
        }

        private void radioCurier_CheckedChanged(object sender, EventArgs e)
        {
            lblEroareCod.Text = "";
            livrare();
        }

        private void radioPosta_CheckedChanged(object sender, EventArgs e)
        {
            livrare();
        }

        private void txtPosta_MouseLeave(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"\d{6}");
            if (!string.IsNullOrWhiteSpace(txtPosta.Text))
            {
                btnComanda.Enabled = true;
                
                if (!reg.IsMatch(txtPosta.Text))
                {
                    lblEroareCod.Text = "Codul postal nu este valid!";
                    lblEroareCod.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblEroareCod.ForeColor = System.Drawing.Color.Green;
                    lblEroareCod.Text = "Codul postal este valid!";
                }
            }
            else
            {
                btnComanda.Enabled = false;
            }
        }

        public void update_db(string num, string pren, string tel, string oras, string adr, string cod)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE mtp_petshop.conturi SET nume = '" + num + "',prenume = '" + pren + "',telefon = '" + tel + "', oras = '" + oras +"', adresa = '" + adr + "', cod_postal = '" + cod + "'WHERE email = '" + txtMail.Text + "';";

            try
            {
                connection.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read()) { }
                connection.Close();
                MessageBox.Show("Datele au fost actualizate!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Eroare\n" + erro);
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lblEroareNume.ForeColor == System.Drawing.Color.Red || lblEroarePrenume.ForeColor == System.Drawing.Color.Red || lblEroareTelefon.ForeColor == System.Drawing.Color.Red
            || lblEroareAdresa.ForeColor == System.Drawing.Color.Red || lblEroareOras.ForeColor == System.Drawing.Color.Red || lblEroareCod.ForeColor == System.Drawing.Color.Red)
            {
                MessageBox.Show("Datele se vor actualiza doar daca toate campurile sunt valide!");
            }
            else
            {
                string nume = txtNume.Text;
                string prenume = txtPrenume.Text;
                string telefon = txtTelefon.Text;
                string oras = txtOras.Text;
                string adresa = txtAdresa.Text;
                string cod_postal = txtPosta.Text;
                update_db(nume, prenume, telefon, oras, adresa, cod_postal);
            }
        }

        private void txtNume_MouseLeave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNume.Text))
            {
                lblEroareNume.Text = "Camp valid!";
                lblEroareNume.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblEroareNume.ForeColor = System.Drawing.Color.Red;
                lblEroareNume.Text = "Completati campul!";
            }
        }

        private void txtPrenume_MouseLeave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPrenume.Text))
            {
                lblEroarePrenume.Text = "Camp valid!";
                lblEroarePrenume.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblEroarePrenume.ForeColor = System.Drawing.Color.Red;
                lblEroarePrenume.Text = "Completati campul!";
            }
        }

        private void txtOras_MouseLeave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtOras.Text))
            {
                lblEroareOras.Text = "Camp valid!";
                lblEroareOras.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblEroareOras.ForeColor = System.Drawing.Color.Red;
                lblEroareOras.Text = "Completati campul!";
            }
        }

        private void txtAdresa_MouseLeave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAdresa.Text))
            {
                lblEroareAdresa.Text = "Camp valid!";
                lblEroareAdresa.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblEroareAdresa.ForeColor = System.Drawing.Color.Red;
                lblEroareAdresa.Text = "Completati campul!";
            }
        }

        private void txtTelefon_MouseLeave(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^(\+4|)?(07[0-8]{1}[0-9]{1}|02[0-9]{2}|03[0-9]{2}){1}?(\s|\.|\-)?([0-9]{3}(\s|\.|\-|)){2}$");
            if (reg.IsMatch(txtTelefon.Text))
            {
                lblEroareTelefon.Text = "Nr de telefon valid!";
                lblEroareTelefon.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblEroareTelefon.ForeColor = System.Drawing.Color.Red;
                lblEroareTelefon.Text = "Nr de telefon invalid!";
            }
        }
    }
}
