namespace MTP_petshop
{
    partial class Form3_ResetareParola
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
            this.btnModificare = new System.Windows.Forms.Button();
            this.txtParolaNoua = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblParolaNoua = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblRecuperare = new System.Windows.Forms.Label();
            this.lblEroareParola = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnInapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInapoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInapoi.Location = new System.Drawing.Point(0, -2);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(85, 34);
            this.btnInapoi.TabIndex = 1;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnModificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModificare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificare.Location = new System.Drawing.Point(64, 302);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(340, 34);
            this.btnModificare.TabIndex = 13;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = false;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // txtParolaNoua
            // 
            this.txtParolaNoua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtParolaNoua.Location = new System.Drawing.Point(180, 235);
            this.txtParolaNoua.Name = "txtParolaNoua";
            this.txtParolaNoua.Size = new System.Drawing.Size(224, 24);
            this.txtParolaNoua.TabIndex = 12;
            this.txtParolaNoua.MouseLeave += new System.EventHandler(this.txtParolaNoua_MouseLeave);
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMail.Location = new System.Drawing.Point(180, 184);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(224, 24);
            this.txtMail.TabIndex = 11;
            // 
            // lblParolaNoua
            // 
            this.lblParolaNoua.AutoSize = true;
            this.lblParolaNoua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblParolaNoua.Location = new System.Drawing.Point(67, 238);
            this.lblParolaNoua.Name = "lblParolaNoua";
            this.lblParolaNoua.Size = new System.Drawing.Size(91, 18);
            this.lblParolaNoua.TabIndex = 10;
            this.lblParolaNoua.Text = "Parola Noua";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMail.Location = new System.Drawing.Point(108, 187);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(50, 18);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "E-mail";
            // 
            // lblRecuperare
            // 
            this.lblRecuperare.AutoSize = true;
            this.lblRecuperare.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblRecuperare.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRecuperare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRecuperare.Location = new System.Drawing.Point(68, 103);
            this.lblRecuperare.Name = "lblRecuperare";
            this.lblRecuperare.Size = new System.Drawing.Size(281, 36);
            this.lblRecuperare.TabIndex = 8;
            this.lblRecuperare.Text = "Recuperare Parola";
            // 
            // lblEroareParola
            // 
            this.lblEroareParola.AutoSize = true;
            this.lblEroareParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEroareParola.Location = new System.Drawing.Point(191, 262);
            this.lblEroareParola.Name = "lblEroareParola";
            this.lblEroareParola.Size = new System.Drawing.Size(0, 18);
            this.lblEroareParola.TabIndex = 14;
            // 
            // Form3_ResetareParola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MTP_petshop.Properties.Resources.bg_pass;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 379);
            this.Controls.Add(this.lblEroareParola);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.txtParolaNoua);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblParolaNoua);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblRecuperare);
            this.Controls.Add(this.btnInapoi);
            this.Name = "Form3_ResetareParola";
            this.Text = "Form3_ResetareParola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.TextBox txtParolaNoua;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblParolaNoua;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblRecuperare;
        private System.Windows.Forms.Label lblEroareParola;
    }
}