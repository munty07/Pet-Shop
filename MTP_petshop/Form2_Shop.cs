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
    public partial class Form2_Shop : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;
        MySqlCommand cmd;
        MySqlDataReader myReader;
        public int nr;
        public string categ;
        public string selectedProd;
        DataGridView dgvCos = new DataGridView();
        Label lblSuma = new Label();
        
        public Form2_Shop(string utilizator)
        {
            InitializeComponent();
            //incepe timer ul pentru ora si minute
            timer1.Start();
            lblUser.Text = utilizator;
            //functie de afisare a produselor in DataGridView
            afisareProduse();
            cmbHrana.Enabled = false;
            cmbAccesorii.Enabled = false;
            //calcularea nr total de produse din stoc
            lblInreg.Text = (nr_inregPisica() +  nr_inregCaine()).ToString();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1_Autentificare f = new Form1_Autentificare();
            f.ShowDialog();
        }
        //functie de afisare a produselor in DataGridView
        public void afisareProduse()
        {
            string sql;
            sql = "SELECT * FROM mtp_petshop.produse;";
            dataAdapter = new MySqlDataAdapter(sql, connection);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "produse");
            dgvProduse.DataSource = dataSet.Tables["produse"];
        }
        //functie pentru afisarea produselor pe categorii in DataGridView
        public void categorii()
        {
            if(radioPisica.Checked == true)
            {
                string sql;
                sql = "SELECT * FROM mtp_petshop.produse WHERE animal = '" + "pisica" + "';";
                dataAdapter = new MySqlDataAdapter(sql, connection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "produsepisici");
                dgvProduse.DataSource = dataSet.Tables["produsepisici"];
                categ = "pisica";
            }
            else if(radioCaine.Checked == true)
            {
                string sql;
                sql = "SELECT * FROM mtp_petshop.produse WHERE animal = '" + "caine" + "';";
                dataAdapter = new MySqlDataAdapter(sql, connection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "produsecaini");
                dgvProduse.DataSource = dataSet.Tables["produsecaini"];
                categ = "caine";
            }
        }

        private void radioPisica_CheckedChanged(object sender, EventArgs e)
        {
            cmbHrana.Enabled = true;
            cmbAccesorii.Enabled = true;
            cmbHrana.Text = "";
            cmbAccesorii.Text = "";
            categorii();//functie pentru afisarea produselor destinate pisicilor in DataGridView
            lblInreg.Text = nr_inregPisica().ToString();//calculul nr de produse destinate pisicilor
            optiuniHrana();//afisarea tuturor denumirilor produselor destinate pentru hrana pisicilor
            optiuniAccesorii();//afisarea tuturor denumirilor accesoriilor pentru pisici
        }

        private void radioCaine_CheckedChanged(object sender, EventArgs e)
        {
            cmbHrana.Enabled = true;
            cmbAccesorii.Enabled = true;
            cmbHrana.Text = "";
            cmbAccesorii.Text = "";
            categorii();//functie pentru afisarea produselor destinate cainilor in DataGridView
            lblInreg.Text = nr_inregCaine().ToString();//calculul nr de produse destinate cainilor
            optiuniHrana();//afisarea tuturor denumirilor produselor destinate pentru hrana cainilor
            optiuniAccesorii();//afisarea tuturor denumirilor accesoriilor pentru caini
        }
        //calcularea nr de produse pentru pisici din stoc
        public int nr_inregPisica()
        {
            string sql;
            int counter;
            sql = "SELECT COUNT(*) FROM mtp_petshop.produse WHERE animal = '" + "pisica" + "';";
            cmd = new MySqlCommand(sql, connection);
            connection.Open();

            counter = int.Parse(cmd.ExecuteScalar().ToString());
            
            connection.Close();
            return counter;
        }
        //calcularea nr de produse pentru caini din stoc
        public int nr_inregCaine()
        {
            string sql;
            int counter;
            sql = "SELECT COUNT(*) FROM mtp_petshop.produse WHERE animal = '" + "caine" + "';";
            cmd = new MySqlCommand(sql, connection);
            connection.Open();

            counter = int.Parse(cmd.ExecuteScalar().ToString());

            connection.Close();
            return counter;
        }
        //afisarea tuturor denumirilor produselor destinate pentru hrana animalelor
        public void optiuniHrana()
        {
            cmbHrana.Items.Clear();
            string sql;
            sql = "SELECT denumire FROM mtp_petshop.produse WHERE animal = '" + categ + "'AND tip = '" + "hrana" + "';";
            
            cmd = new MySqlCommand(sql, connection);
            string hrana = "";

            connection.Open();
            myReader = null;
            myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {
                hrana = myReader["denumire"].ToString();
                cmbHrana.Items.Add(hrana);
            }
            connection.Close();
        }
        //afisarea tuturor denumirilor accesoriilor pentru animale
        public void optiuniAccesorii()
        {
            cmbAccesorii.Items.Clear();
            string sql;
            sql = "SELECT denumire FROM mtp_petshop.produse WHERE animal = '" + categ + "'AND tip = '" + "accesorii" + "';";

            cmd = new MySqlCommand(sql, connection);
            string accesorii = "";

            connection.Open();
            myReader = null;
            myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {
                accesorii = myReader["denumire"].ToString();
                cmbAccesorii.Items.Add(accesorii);
            }
            connection.Close();
        }

        private void cmbHrana_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            if (String.IsNullOrEmpty(cmbHrana.Text))
                MessageBox.Show("Selectati produsul!");
            else
            {
                sql = "SELECT * FROM mtp_petshop.produse WHERE denumire ='" + cmbHrana.SelectedItem.ToString() + "';";
                dataAdapter = new MySqlDataAdapter(sql, connection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "hrana");
                dgvProduse.DataSource = dataSet.Tables["hrana"];
            }
        }

        private void cmbAccesorii_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            if (String.IsNullOrEmpty(cmbAccesorii.Text))
                MessageBox.Show("Selectati produsul!");
            else
            {
                sql = "SELECT * FROM mtp_petshop.produse WHERE denumire ='" + cmbAccesorii.SelectedItem.ToString() + "';";
                dataAdapter = new MySqlDataAdapter(sql, connection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "accesorii");
                dgvProduse.DataSource = dataSet.Tables["accesorii"];
            }
        }
        //verificare daca produsul selectat mai exista in baza de date
        public bool cauta_prod()
        {
            string p = "";
            bool found = false;
            cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT id_prod FROM mtp_petshop.cos WHERE email = '" + lblUser.Text + "' AND id_prod = '" + dgvProduse.CurrentRow.Cells[0].Value+ "'; ";

            try
            {
                connection.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    p = myReader.GetString(0);
                    MessageBox.Show("p=" + p);
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
        //functie pentru inserarea produselor in cosul de cumparaturi
        public void insert()
        {
            string sql = "INSERT INTO mtp_petshop.cos ( email, id_prod, nr_prod) values ( @email, @id, @nr);";
            MessageBox.Show(dgvProduse.CurrentRow.Cells[0].Value.ToString());
            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@email", lblUser.Text);
            cmd.Parameters.AddWithValue("@id", dgvProduse.CurrentRow.Cells[0].Value.ToString());

            cmd.Parameters.AddWithValue("@nr", nr);

            connection.Open();

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected == 1)
            {
                MessageBox.Show("Datele au fost introduse in baza de date");
            }
            else
                MessageBox.Show("Eroare la inserare");

            connection.Close();
        }
        //functie pentru actualizarea nr de produse din cosul de cumparaturi
        public void update()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE mtp_petshop.cos SET nr_prod = '" + nr + "'WHERE email = '" + lblUser.Text + "'AND id_prod = '" + dgvProduse.CurrentRow.Cells[0].Value+ "'; ";

            try
            {
                connection.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read()) { }
                MessageBox.Show("Datele au fost actualizate");
                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Eroare\n" + erro);
                this.Close();
            }
        }
        //functie pentru preluare nr de produse din baza de date
        public void dateProd()
        {
            string sql;
            sql = "SELECT * FROM mtp_petshop.cos WHERE email ='" + lblUser.Text + "'AND id_prod ='" + dgvProduse.CurrentRow.Cells[0].Value + "'; ";

            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {
                nr = Convert.ToInt32(myReader.GetString(2));
            }
            connection.Close();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("id " + dgvProduse.CurrentRow.Cells[0].Value);
            //MessageBox.Show(cauta_prod().ToString());
            if(cauta_prod() == true) //daca produsul selectat exista in baza de date
            {
                dateProd();//preluam nr de produse
                nr++;//incrementam nr de produse
                update();//actualizam baza de date
            }
            else//daca produsul selectat nu mai exista in baza de date
            {
                nr = 1;//nr de produse va fi 1
                insert();//vom insera in baza de date noul produs
            }
            flpCos.Controls.Clear();

            btnVizualizareCos.Enabled = true;
        }
        //functie pentru calculul sumei produselor
        public void total2()
        {
            string result = "SELECT SUM(B.pret*A.nr_prod) AS pret FROM mtp_petshop.cos AS A JOIN mtp_petshop.produse AS B ON A.id_prod = B.id WHERE A.email = '" + lblUser.Text + "';";

            using (MySqlCommand showresult = new MySqlCommand(result, connection))
            {
                try
                {
                    connection.Open();
                    lblSuma.Text = showresult.ExecuteScalar().ToString();
                    if (lblSuma.Text == "")
                    {
                        lblSuma.Text = "Suma totala: " + "0" + " lei ";
                    }
                    else
                    {
                        lblSuma.Text = "Suma totala: " + lblSuma.Text + " lei";
                    }
                    //MessageBox.Show("suma totala " + lblSuma.Text);
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
        //functie pentru calculul sumei produselor
        public string total(string suma)
        {
            string result = "SELECT SUM(B.pret*A.nr_prod) AS pret FROM mtp_petshop.cos AS A JOIN mtp_petshop.produse AS B ON A.id_prod = B.id WHERE A.email = '" + lblUser.Text + "';";

            using (MySqlCommand showresult = new MySqlCommand(result, connection))
            {
                try
                {
                    connection.Open();
                    suma = showresult.ExecuteScalar().ToString();
                    if(suma == "")
                    {
                        suma = "0";
                    }
                    //MessageBox.Show("sum " + suma);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
                return suma;
            }
        }

        //functie pentru vizualizarea cosului de cumparaturi
        public void vizualizare()
        {
            string sql;
            sql = "SELECT A.email, A.id_prod, B.tip, B.denumire, B.pret, B.animal, A.nr_prod FROM mtp_petshop.cos AS A JOIN mtp_petshop.produse AS B ON A.id_prod = B.id WHERE A.email = '" + lblUser.Text + "';";
            dataAdapter = new MySqlDataAdapter(sql, connection);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "cos_cumparaturi");
            dgvCos.DataSource = dataSet.Tables["cos_cumparaturi"];
        }

        private void btnVizualizareCos_Click(object sender, EventArgs e)
        {
            flpCos.Controls.Add(lblSuma);
            lblSuma.Name = "lblSuma";
            lblSuma.Text = "Suma totala: " + total(lblSuma.Text) + " lei";//ii setam textul ca fiind suma totala a produselor din cosul de cumparaturi
            
            flpCos.Controls.Add(dgvCos);
            dgvCos.Size = new Size(418,230);
            vizualizare(); //functie pentru vizualizarea cosului de cumparaturi in DataGridView-ul generat dinamic

            Button btnSterge = new Button();//genrarea dinamica buton
            btnSterge.Text = "Sterge Produs";
            btnSterge.Name = "btnSterge";
            btnSterge.Click += (s, en) => { sterge(); };//generarea dinamica a evenimentului de stergere a unui produs selectat din cosul de cumparaturi
            flpCos.Controls.Add(btnSterge);
            btnSterge.Size = new Size(150, 31);

            Button btnComanda = new Button();
            btnComanda.Text = "Finalizare comanda";
            btnComanda.Name = "btnComanda";
            btnComanda.Click += (s, en) => { afisFormComanda(); };//generearea dinamica a evenimentului de afisare a formului cu plasarea comenzii
            flpCos.Controls.Add(btnComanda);
            btnComanda.Size = new Size(150, 31);

            btnVizualizareCos.Enabled = false;
        }

        public void afisFormComanda()
        {
            string utilizator;
            utilizator = lblUser.Text;
            this.Hide();
            Form5_FinalizareComanda f = new Form5_FinalizareComanda(utilizator);
            f.ShowDialog();
        }

        //selecteaza nr de produse din baza de date
        public void nrProd()
        {
            MessageBox.Show(dgvCos.CurrentRow.Cells[1].Value.ToString());
            string sql;
            sql = "SELECT nr_prod FROM mtp_petshop.cos WHERE email ='" + lblUser.Text + "'AND id_prod ='" + dgvCos.CurrentRow.Cells[1].Value + "'; ";

            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {
                nr = Convert.ToInt32(myReader.GetString(0));
            }
            connection.Close();
        }

        //sterge produsul selectat din baza de date
        public void sterge()
        {
            selectedProd = this.dgvCos.CurrentRow.Cells[1].Value.ToString();
            //MessageBox.Show("Prod cu id: " + selectedProd);
            if (selectedProd != "")
            {
                DialogResult dialogResult = MessageBox.Show("Sunteti sigur ca doriti sa stergeti acest produs?", "Sterge Produs", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    nrProd();//preluam nr de produse
                    if (nr > 1)//daca nr de produse > 1 
                    {
                        nr--;//vom scadea nr de produse
                        update();//vom actualiza baza de date
                    }
                    else//daca nr de produse este == 1
                    {
                        //vom sterge definitiv produsul din baza de date
                        string sql = "DELETE FROM mtp_petshop.cos WHERE id_prod = @id";
                        MySqlCommand command = new MySqlCommand(sql, connection);

                        command.Parameters.AddWithValue("@id", selectedProd);
                        connection.Open();
                        try
                        {
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Datele au fost sterse!");
                            }
                            else
                            {
                                MessageBox.Show("Datele nu au fost sterse!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        connection.Close();
                    }
                    
                    vizualizare();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Produsul nu a fost sters!");
                    //vizualizare();
                }
                total2();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string hourMinute = DateTime.Now.ToString("HH:mm");
            this.lblOra.Text = hourMinute;
            //string ora = lblOra.Text.Substring(0, lblOra.Text.LastIndexOf(":"));
            //if(ora == "23")
            //{
            //    flpCos.BackColor = Color.Red;
            //}
            //else
            //{
            //    flpCos.BackColor = Color.Green;
            //}
        }
    }
}
