namespace MTP_petshop
{
    partial class Form2_Shop
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
            this.components = new System.ComponentModel.Container();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.lblHrana = new System.Windows.Forms.Label();
            this.lblAccesorii = new System.Windows.Forms.Label();
            this.cmbHrana = new System.Windows.Forms.ComboBox();
            this.cmbAccesorii = new System.Windows.Forms.ComboBox();
            this.dgvProduse = new System.Windows.Forms.DataGridView();
            this.radioPisica = new System.Windows.Forms.RadioButton();
            this.radioCaine = new System.Windows.Forms.RadioButton();
            this.panelCategorii = new System.Windows.Forms.Panel();
            this.lblCategorii = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnVizualizareCos = new System.Windows.Forms.Button();
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblInreg = new System.Windows.Forms.Label();
            this.lblStoc = new System.Windows.Forms.Label();
            this.panelCos = new System.Windows.Forms.Panel();
            this.flpCos = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOra = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduse)).BeginInit();
            this.panelCategorii.SuspendLayout();
            this.panelCos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInapoi
            // 
            this.btnInapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInapoi.Location = new System.Drawing.Point(-1, -2);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(85, 34);
            this.btnInapoi.TabIndex = 1;
            this.btnInapoi.Text = "Logout";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // lblHrana
            // 
            this.lblHrana.AutoSize = true;
            this.lblHrana.Location = new System.Drawing.Point(235, 93);
            this.lblHrana.Name = "lblHrana";
            this.lblHrana.Size = new System.Drawing.Size(47, 17);
            this.lblHrana.TabIndex = 3;
            this.lblHrana.Text = "Hrana";
            // 
            // lblAccesorii
            // 
            this.lblAccesorii.AutoSize = true;
            this.lblAccesorii.Location = new System.Drawing.Point(453, 93);
            this.lblAccesorii.Name = "lblAccesorii";
            this.lblAccesorii.Size = new System.Drawing.Size(65, 17);
            this.lblAccesorii.TabIndex = 4;
            this.lblAccesorii.Text = "Accesorii";
            // 
            // cmbHrana
            // 
            this.cmbHrana.FormattingEnabled = true;
            this.cmbHrana.Location = new System.Drawing.Point(238, 114);
            this.cmbHrana.Name = "cmbHrana";
            this.cmbHrana.Size = new System.Drawing.Size(201, 24);
            this.cmbHrana.TabIndex = 5;
            this.cmbHrana.SelectedIndexChanged += new System.EventHandler(this.cmbHrana_SelectedIndexChanged);
            // 
            // cmbAccesorii
            // 
            this.cmbAccesorii.FormattingEnabled = true;
            this.cmbAccesorii.Location = new System.Drawing.Point(456, 113);
            this.cmbAccesorii.Name = "cmbAccesorii";
            this.cmbAccesorii.Size = new System.Drawing.Size(201, 24);
            this.cmbAccesorii.TabIndex = 6;
            this.cmbAccesorii.SelectedIndexChanged += new System.EventHandler(this.cmbAccesorii_SelectedIndexChanged);
            // 
            // dgvProduse
            // 
            this.dgvProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduse.Location = new System.Drawing.Point(53, 154);
            this.dgvProduse.Name = "dgvProduse";
            this.dgvProduse.RowTemplate.Height = 24;
            this.dgvProduse.Size = new System.Drawing.Size(604, 312);
            this.dgvProduse.TabIndex = 7;
            // 
            // radioPisica
            // 
            this.radioPisica.AutoSize = true;
            this.radioPisica.Location = new System.Drawing.Point(3, 5);
            this.radioPisica.Name = "radioPisica";
            this.radioPisica.Size = new System.Drawing.Size(66, 21);
            this.radioPisica.TabIndex = 8;
            this.radioPisica.TabStop = true;
            this.radioPisica.Text = "Pisica";
            this.radioPisica.UseVisualStyleBackColor = true;
            this.radioPisica.CheckedChanged += new System.EventHandler(this.radioPisica_CheckedChanged);
            // 
            // radioCaine
            // 
            this.radioCaine.AutoSize = true;
            this.radioCaine.Location = new System.Drawing.Point(94, 5);
            this.radioCaine.Name = "radioCaine";
            this.radioCaine.Size = new System.Drawing.Size(65, 21);
            this.radioCaine.TabIndex = 9;
            this.radioCaine.TabStop = true;
            this.radioCaine.Text = "Caine";
            this.radioCaine.UseVisualStyleBackColor = true;
            this.radioCaine.CheckedChanged += new System.EventHandler(this.radioCaine_CheckedChanged);
            // 
            // panelCategorii
            // 
            this.panelCategorii.Controls.Add(this.radioPisica);
            this.panelCategorii.Controls.Add(this.radioCaine);
            this.panelCategorii.Location = new System.Drawing.Point(53, 109);
            this.panelCategorii.Name = "panelCategorii";
            this.panelCategorii.Size = new System.Drawing.Size(179, 29);
            this.panelCategorii.TabIndex = 10;
            // 
            // lblCategorii
            // 
            this.lblCategorii.AutoSize = true;
            this.lblCategorii.Location = new System.Drawing.Point(50, 78);
            this.lblCategorii.Name = "lblCategorii";
            this.lblCategorii.Size = new System.Drawing.Size(64, 17);
            this.lblCategorii.TabIndex = 11;
            this.lblCategorii.Text = "Categorii";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(53, 487);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(291, 31);
            this.btnAdauga.TabIndex = 12;
            this.btnAdauga.Text = "Adaugare produs in cos";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnVizualizareCos
            // 
            this.btnVizualizareCos.Location = new System.Drawing.Point(366, 487);
            this.btnVizualizareCos.Name = "btnVizualizareCos";
            this.btnVizualizareCos.Size = new System.Drawing.Size(291, 30);
            this.btnVizualizareCos.TabIndex = 13;
            this.btnVizualizareCos.Text = "Vizualizare Cos";
            this.btnVizualizareCos.UseVisualStyleBackColor = true;
            this.btnVizualizareCos.Click += new System.EventHandler(this.btnVizualizareCos_Click);
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.Location = new System.Drawing.Point(109, 13);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(67, 17);
            this.lblUtilizator.TabIndex = 14;
            this.lblUtilizator.Text = "Utilizator:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(183, 12);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(13, 17);
            this.lblUser.TabIndex = 15;
            this.lblUser.Text = "-";
            // 
            // lblInreg
            // 
            this.lblInreg.AutoSize = true;
            this.lblInreg.Location = new System.Drawing.Point(560, 15);
            this.lblInreg.Name = "lblInreg";
            this.lblInreg.Size = new System.Drawing.Size(13, 17);
            this.lblInreg.TabIndex = 17;
            this.lblInreg.Text = "-";
            // 
            // lblStoc
            // 
            this.lblStoc.AutoSize = true;
            this.lblStoc.Location = new System.Drawing.Point(453, 15);
            this.lblStoc.Name = "lblStoc";
            this.lblStoc.Size = new System.Drawing.Size(101, 17);
            this.lblStoc.TabIndex = 18;
            this.lblStoc.Text = "Stoc Produse: ";
            // 
            // panelCos
            // 
            this.panelCos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCos.Controls.Add(this.flpCos);
            this.panelCos.Location = new System.Drawing.Point(691, -2);
            this.panelCos.Name = "panelCos";
            this.panelCos.Size = new System.Drawing.Size(658, 569);
            this.panelCos.TabIndex = 16;
            // 
            // flpCos
            // 
            this.flpCos.Location = new System.Drawing.Point(38, 80);
            this.flpCos.Name = "flpCos";
            this.flpCos.Size = new System.Drawing.Size(563, 388);
            this.flpCos.TabIndex = 0;
            // 
            // lblOra
            // 
            this.lblOra.AutoSize = true;
            this.lblOra.Location = new System.Drawing.Point(50, 44);
            this.lblOra.Name = "lblOra";
            this.lblOra.Size = new System.Drawing.Size(32, 17);
            this.lblOra.TabIndex = 19;
            this.lblOra.Text = "Ora";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2_Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 566);
            this.Controls.Add(this.lblOra);
            this.Controls.Add(this.lblStoc);
            this.Controls.Add(this.lblInreg);
            this.Controls.Add(this.panelCos);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUtilizator);
            this.Controls.Add(this.btnVizualizareCos);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lblCategorii);
            this.Controls.Add(this.panelCategorii);
            this.Controls.Add(this.dgvProduse);
            this.Controls.Add(this.cmbAccesorii);
            this.Controls.Add(this.cmbHrana);
            this.Controls.Add(this.lblAccesorii);
            this.Controls.Add(this.lblHrana);
            this.Controls.Add(this.btnInapoi);
            this.Name = "Form2_Shop";
            this.Text = "Form2_Shop";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduse)).EndInit();
            this.panelCategorii.ResumeLayout(false);
            this.panelCategorii.PerformLayout();
            this.panelCos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Label lblHrana;
        private System.Windows.Forms.Label lblAccesorii;
        private System.Windows.Forms.ComboBox cmbHrana;
        private System.Windows.Forms.ComboBox cmbAccesorii;
        private System.Windows.Forms.DataGridView dgvProduse;
        private System.Windows.Forms.RadioButton radioPisica;
        private System.Windows.Forms.RadioButton radioCaine;
        private System.Windows.Forms.Panel panelCategorii;
        private System.Windows.Forms.Label lblCategorii;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnVizualizareCos;
        private System.Windows.Forms.Label lblUtilizator;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panelCos;
        private System.Windows.Forms.Label lblInreg;
        private System.Windows.Forms.Label lblStoc;
        private System.Windows.Forms.FlowLayoutPanel flpCos;
        private System.Windows.Forms.Label lblOra;
        private System.Windows.Forms.Timer timer1;
    }
}