namespace MTP_petshop
{
    partial class Form1_Autentificare
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
            this.lblAutentificare = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblModificareParola = new System.Windows.Forms.Label();
            this.btnAutentificare = new System.Windows.Forms.Button();
            this.btnCreareCont = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.panelImag = new System.Windows.Forms.Panel();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblEroare = new System.Windows.Forms.Label();
            this.panelImag.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAutentificare
            // 
            this.lblAutentificare.AutoSize = true;
            this.lblAutentificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAutentificare.Location = new System.Drawing.Point(558, 60);
            this.lblAutentificare.Name = "lblAutentificare";
            this.lblAutentificare.Size = new System.Drawing.Size(188, 32);
            this.lblAutentificare.TabIndex = 0;
            this.lblAutentificare.Text = "Autentificare";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMail.Location = new System.Drawing.Point(472, 165);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(50, 18);
            this.lblMail.TabIndex = 1;
            this.lblMail.Text = "E-mail";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblParola.Location = new System.Drawing.Point(472, 220);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(51, 18);
            this.lblParola.TabIndex = 2;
            this.lblParola.Text = "Parola";
            // 
            // lblModificareParola
            // 
            this.lblModificareParola.AutoSize = true;
            this.lblModificareParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblModificareParola.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblModificareParola.Location = new System.Drawing.Point(551, 244);
            this.lblModificareParola.Name = "lblModificareParola";
            this.lblModificareParola.Size = new System.Drawing.Size(104, 18);
            this.lblModificareParola.TabIndex = 3;
            this.lblModificareParola.Text = "Ai uitat parola?";
            this.lblModificareParola.Click += new System.EventHandler(this.lblModificareParola_Click);
            // 
            // btnAutentificare
            // 
            this.btnAutentificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAutentificare.Location = new System.Drawing.Point(551, 283);
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.Size = new System.Drawing.Size(224, 37);
            this.btnAutentificare.TabIndex = 4;
            this.btnAutentificare.Text = "Autentificare";
            this.btnAutentificare.UseVisualStyleBackColor = true;
            this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
            // 
            // btnCreareCont
            // 
            this.btnCreareCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreareCont.Location = new System.Drawing.Point(551, 326);
            this.btnCreareCont.Name = "btnCreareCont";
            this.btnCreareCont.Size = new System.Drawing.Size(224, 35);
            this.btnCreareCont.TabIndex = 5;
            this.btnCreareCont.Text = "Creeaza cont";
            this.btnCreareCont.UseVisualStyleBackColor = true;
            this.btnCreareCont.Click += new System.EventHandler(this.btnCreareCont_Click);
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMail.Location = new System.Drawing.Point(551, 162);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(224, 24);
            this.txtMail.TabIndex = 6;
            this.txtMail.MouseLeave += new System.EventHandler(this.txtMail_MouseLeave);
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtParola.Location = new System.Drawing.Point(551, 217);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(224, 24);
            this.txtParola.TabIndex = 7;
            // 
            // panelImag
            // 
            this.panelImag.BackgroundImage = global::MTP_petshop.Properties.Resources.bg_login;
            this.panelImag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImag.Controls.Add(this.lblTitlu);
            this.panelImag.Location = new System.Drawing.Point(-3, -2);
            this.panelImag.Name = "panelImag";
            this.panelImag.Size = new System.Drawing.Size(453, 455);
            this.panelImag.TabIndex = 8;
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitlu.Location = new System.Drawing.Point(118, 62);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(207, 51);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Pet Shop";
            // 
            // lblEroare
            // 
            this.lblEroare.AutoSize = true;
            this.lblEroare.ForeColor = System.Drawing.Color.Red;
            this.lblEroare.Location = new System.Drawing.Point(551, 194);
            this.lblEroare.Name = "lblEroare";
            this.lblEroare.Size = new System.Drawing.Size(0, 17);
            this.lblEroare.TabIndex = 9;
            // 
            // Form1_Autentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.lblEroare);
            this.Controls.Add(this.panelImag);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.btnCreareCont);
            this.Controls.Add(this.btnAutentificare);
            this.Controls.Add(this.lblModificareParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblAutentificare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1_Autentificare";
            this.Text = "Form1";
            this.panelImag.ResumeLayout(false);
            this.panelImag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAutentificare;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblModificareParola;
        private System.Windows.Forms.Button btnAutentificare;
        private System.Windows.Forms.Button btnCreareCont;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Panel panelImag;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblEroare;
    }
}

