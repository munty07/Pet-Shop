namespace MTP_petshop
{
    partial class Form5_FinalizareComanda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInapoi = new System.Windows.Forms.Button();
            this.lblNr = new System.Windows.Forms.Label();
            this.lblNrComanda = new System.Windows.Forms.Label();
            this.lblPlata = new System.Windows.Forms.Label();
            this.txtPosta = new System.Windows.Forms.TextBox();
            this.lblPosta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioPosta = new System.Windows.Forms.RadioButton();
            this.radioCurier = new System.Windows.Forms.RadioButton();
            this.txtReducere = new System.Windows.Forms.TextBox();
            this.lblReducere = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.btnComanda = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblFinalizareComanda = new System.Windows.Forms.Label();
            this.dgvCosProduse = new System.Windows.Forms.DataGridView();
            this.lblSuma = new System.Windows.Forms.Label();
            this.txtOras = new System.Windows.Forms.TextBox();
            this.lblOras = new System.Windows.Forms.Label();
            this.lblEroareCod = new System.Windows.Forms.Label();
            this.lblEroareNume = new System.Windows.Forms.Label();
            this.lblEroarePrenume = new System.Windows.Forms.Label();
            this.lblEroareTelefon = new System.Windows.Forms.Label();
            this.lblEroareAdresa = new System.Windows.Forms.Label();
            this.lblEroareOras = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCosProduse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInapoi
            // 
            this.btnInapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInapoi.Location = new System.Drawing.Point(1, 1);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(85, 34);
            this.btnInapoi.TabIndex = 2;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // lblNr
            // 
            this.lblNr.AutoSize = true;
            this.lblNr.Location = new System.Drawing.Point(98, 15);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(146, 17);
            this.lblNr.TabIndex = 60;
            this.lblNr.Text = "Nr comenzi efectuate:";
            // 
            // lblNrComanda
            // 
            this.lblNrComanda.AutoSize = true;
            this.lblNrComanda.Location = new System.Drawing.Point(250, 15);
            this.lblNrComanda.Name = "lblNrComanda";
            this.lblNrComanda.Size = new System.Drawing.Size(13, 17);
            this.lblNrComanda.TabIndex = 59;
            this.lblNrComanda.Text = "-";
            // 
            // lblPlata
            // 
            this.lblPlata.AutoSize = true;
            this.lblPlata.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPlata.Location = new System.Drawing.Point(392, 312);
            this.lblPlata.Name = "lblPlata";
            this.lblPlata.Size = new System.Drawing.Size(128, 17);
            this.lblPlata.TabIndex = 58;
            this.lblPlata.Text = "Modalitate de plata";
            // 
            // txtPosta
            // 
            this.txtPosta.Enabled = false;
            this.txtPosta.Location = new System.Drawing.Point(495, 440);
            this.txtPosta.Name = "txtPosta";
            this.txtPosta.Size = new System.Drawing.Size(196, 22);
            this.txtPosta.TabIndex = 57;
            this.txtPosta.MouseLeave += new System.EventHandler(this.txtPosta_MouseLeave);
            // 
            // lblPosta
            // 
            this.lblPosta.AutoSize = true;
            this.lblPosta.Location = new System.Drawing.Point(390, 443);
            this.lblPosta.Name = "lblPosta";
            this.lblPosta.Size = new System.Drawing.Size(75, 17);
            this.lblPosta.TabIndex = 56;
            this.lblPosta.Text = "Cod postal";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioPosta);
            this.panel1.Controls.Add(this.radioCurier);
            this.panel1.Location = new System.Drawing.Point(395, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 72);
            this.panel1.TabIndex = 55;
            // 
            // radioPosta
            // 
            this.radioPosta.AutoSize = true;
            this.radioPosta.Location = new System.Drawing.Point(16, 41);
            this.radioPosta.Name = "radioPosta";
            this.radioPosta.Size = new System.Drawing.Size(84, 21);
            this.radioPosta.TabIndex = 26;
            this.radioPosta.TabStop = true;
            this.radioPosta.Text = "La posta";
            this.radioPosta.UseVisualStyleBackColor = true;
            this.radioPosta.CheckedChanged += new System.EventHandler(this.radioPosta_CheckedChanged);
            // 
            // radioCurier
            // 
            this.radioCurier.AutoSize = true;
            this.radioCurier.Location = new System.Drawing.Point(16, 14);
            this.radioCurier.Name = "radioCurier";
            this.radioCurier.Size = new System.Drawing.Size(141, 21);
            this.radioCurier.TabIndex = 25;
            this.radioCurier.TabStop = true;
            this.radioCurier.Text = "Ramburs la curier";
            this.radioCurier.UseVisualStyleBackColor = true;
            this.radioCurier.CheckedChanged += new System.EventHandler(this.radioCurier_CheckedChanged);
            // 
            // txtReducere
            // 
            this.txtReducere.Enabled = false;
            this.txtReducere.Location = new System.Drawing.Point(497, 539);
            this.txtReducere.Name = "txtReducere";
            this.txtReducere.Size = new System.Drawing.Size(196, 22);
            this.txtReducere.TabIndex = 54;
            // 
            // lblReducere
            // 
            this.lblReducere.AutoSize = true;
            this.lblReducere.Location = new System.Drawing.Point(392, 542);
            this.lblReducere.Name = "lblReducere";
            this.lblReducere.Size = new System.Drawing.Size(70, 17);
            this.lblReducere.TabIndex = 53;
            this.lblReducere.Text = "Reducere";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(497, 579);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(194, 22);
            this.txtTotal.TabIndex = 52;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(391, 579);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 17);
            this.lblTotal.TabIndex = 51;
            this.lblTotal.Text = "Total plata";
            // 
            // txtTransport
            // 
            this.txtTransport.Enabled = false;
            this.txtTransport.Location = new System.Drawing.Point(495, 498);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(196, 22);
            this.txtTransport.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Taxa transport";
            // 
            // txtSuma
            // 
            this.txtSuma.Enabled = false;
            this.txtSuma.Location = new System.Drawing.Point(143, 626);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(227, 22);
            this.txtSuma.TabIndex = 48;
            // 
            // btnComanda
            // 
            this.btnComanda.Location = new System.Drawing.Point(553, 617);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(140, 31);
            this.btnComanda.TabIndex = 47;
            this.btnComanda.Text = "Plaseaza Comanda";
            this.btnComanda.UseVisualStyleBackColor = true;
            this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(395, 617);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 31);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Actualizeaza datele";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(143, 394);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(227, 22);
            this.txtNume.TabIndex = 45;
            this.txtNume.MouseLeave += new System.EventHandler(this.txtNume_MouseLeave);
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(143, 440);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(227, 22);
            this.txtPrenume.TabIndex = 44;
            this.txtPrenume.MouseLeave += new System.EventHandler(this.txtPrenume_MouseLeave);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(143, 485);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(227, 22);
            this.txtTelefon.TabIndex = 43;
            this.txtTelefon.MouseLeave += new System.EventHandler(this.txtTelefon_MouseLeave);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(143, 531);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(227, 22);
            this.txtAdresa.TabIndex = 42;
            this.txtAdresa.MouseLeave += new System.EventHandler(this.txtAdresa_MouseLeave);
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(143, 352);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(227, 22);
            this.txtMail.TabIndex = 41;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(60, 485);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(56, 17);
            this.lblTelefon.TabIndex = 40;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(60, 531);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(53, 17);
            this.lblAdresa.TabIndex = 39;
            this.lblAdresa.Text = "Adresa";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(60, 352);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(47, 17);
            this.lblMail.TabIndex = 38;
            this.lblMail.Text = "E-mail";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(60, 394);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(45, 17);
            this.lblNume.TabIndex = 37;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(60, 440);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(65, 17);
            this.lblPrenume.TabIndex = 36;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDate.Location = new System.Drawing.Point(60, 312);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(90, 17);
            this.lblDate.TabIndex = 35;
            this.lblDate.Text = "Date Contact";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Location = new System.Drawing.Point(60, 97);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(231, 17);
            this.lblProd.TabIndex = 34;
            this.lblProd.Text = "Produsele din cosul de cumparaturi";
            // 
            // lblFinalizareComanda
            // 
            this.lblFinalizareComanda.AutoSize = true;
            this.lblFinalizareComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFinalizareComanda.Location = new System.Drawing.Point(274, 39);
            this.lblFinalizareComanda.Name = "lblFinalizareComanda";
            this.lblFinalizareComanda.Size = new System.Drawing.Size(193, 24);
            this.lblFinalizareComanda.TabIndex = 33;
            this.lblFinalizareComanda.Text = "Finalizare comanda";
            // 
            // dgvCosProduse
            // 
            this.dgvCosProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCosProduse.Location = new System.Drawing.Point(63, 130);
            this.dgvCosProduse.Name = "dgvCosProduse";
            this.dgvCosProduse.RowTemplate.Height = 24;
            this.dgvCosProduse.Size = new System.Drawing.Size(630, 160);
            this.dgvCosProduse.TabIndex = 32;
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(60, 631);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(44, 17);
            this.lblSuma.TabIndex = 61;
            this.lblSuma.Text = "Suma";
            // 
            // txtOras
            // 
            this.txtOras.Location = new System.Drawing.Point(143, 578);
            this.txtOras.Name = "txtOras";
            this.txtOras.Size = new System.Drawing.Size(227, 22);
            this.txtOras.TabIndex = 63;
            this.txtOras.MouseLeave += new System.EventHandler(this.txtOras_MouseLeave);
            // 
            // lblOras
            // 
            this.lblOras.AutoSize = true;
            this.lblOras.Location = new System.Drawing.Point(60, 578);
            this.lblOras.Name = "lblOras";
            this.lblOras.Size = new System.Drawing.Size(39, 17);
            this.lblOras.TabIndex = 62;
            this.lblOras.Text = "Oras";
            // 
            // lblEroareCod
            // 
            this.lblEroareCod.AutoSize = true;
            this.lblEroareCod.Location = new System.Drawing.Point(494, 467);
            this.lblEroareCod.Name = "lblEroareCod";
            this.lblEroareCod.Size = new System.Drawing.Size(0, 17);
            this.lblEroareCod.TabIndex = 64;
            // 
            // lblEroareNume
            // 
            this.lblEroareNume.AutoSize = true;
            this.lblEroareNume.Location = new System.Drawing.Point(163, 417);
            this.lblEroareNume.Name = "lblEroareNume";
            this.lblEroareNume.Size = new System.Drawing.Size(0, 17);
            this.lblEroareNume.TabIndex = 65;
            // 
            // lblEroarePrenume
            // 
            this.lblEroarePrenume.AutoSize = true;
            this.lblEroarePrenume.Location = new System.Drawing.Point(163, 467);
            this.lblEroarePrenume.Name = "lblEroarePrenume";
            this.lblEroarePrenume.Size = new System.Drawing.Size(0, 17);
            this.lblEroarePrenume.TabIndex = 66;
            // 
            // lblEroareTelefon
            // 
            this.lblEroareTelefon.AutoSize = true;
            this.lblEroareTelefon.Location = new System.Drawing.Point(163, 511);
            this.lblEroareTelefon.Name = "lblEroareTelefon";
            this.lblEroareTelefon.Size = new System.Drawing.Size(0, 17);
            this.lblEroareTelefon.TabIndex = 67;
            // 
            // lblEroareAdresa
            // 
            this.lblEroareAdresa.AutoSize = true;
            this.lblEroareAdresa.Location = new System.Drawing.Point(166, 558);
            this.lblEroareAdresa.Name = "lblEroareAdresa";
            this.lblEroareAdresa.Size = new System.Drawing.Size(0, 17);
            this.lblEroareAdresa.TabIndex = 68;
            // 
            // lblEroareOras
            // 
            this.lblEroareOras.AutoSize = true;
            this.lblEroareOras.Location = new System.Drawing.Point(169, 603);
            this.lblEroareOras.Name = "lblEroareOras";
            this.lblEroareOras.Size = new System.Drawing.Size(0, 17);
            this.lblEroareOras.TabIndex = 69;
            // 
            // Form5_FinalizareComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 696);
            this.Controls.Add(this.lblEroareOras);
            this.Controls.Add(this.lblEroareAdresa);
            this.Controls.Add(this.lblEroareTelefon);
            this.Controls.Add(this.lblEroarePrenume);
            this.Controls.Add(this.lblEroareNume);
            this.Controls.Add(this.lblEroareCod);
            this.Controls.Add(this.txtOras);
            this.Controls.Add(this.lblOras);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblNr);
            this.Controls.Add(this.lblNrComanda);
            this.Controls.Add(this.lblPlata);
            this.Controls.Add(this.txtPosta);
            this.Controls.Add(this.lblPosta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtReducere);
            this.Controls.Add(this.lblReducere);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTransport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.btnComanda);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.lblFinalizareComanda);
            this.Controls.Add(this.dgvCosProduse);
            this.Controls.Add(this.btnInapoi);
            this.Name = "Form5_FinalizareComanda";
            this.Text = "Form5_FinalizareComanda";
            this.Load += new System.EventHandler(this.Form5_FinalizareComanda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCosProduse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Label lblNr;
        private System.Windows.Forms.Label lblNrComanda;
        private System.Windows.Forms.Label lblPlata;
        private System.Windows.Forms.TextBox txtPosta;
        private System.Windows.Forms.Label lblPosta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioPosta;
        private System.Windows.Forms.RadioButton radioCurier;
        private System.Windows.Forms.TextBox txtReducere;
        private System.Windows.Forms.Label lblReducere;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Button btnComanda;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblFinalizareComanda;
        private System.Windows.Forms.DataGridView dgvCosProduse;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.TextBox txtOras;
        private System.Windows.Forms.Label lblOras;
        private System.Windows.Forms.Label lblEroareCod;
        private System.Windows.Forms.Label lblEroareNume;
        private System.Windows.Forms.Label lblEroarePrenume;
        private System.Windows.Forms.Label lblEroareTelefon;
        private System.Windows.Forms.Label lblEroareAdresa;
        private System.Windows.Forms.Label lblEroareOras;
    }
}