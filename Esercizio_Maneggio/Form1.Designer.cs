namespace Esercizio_Maneggio
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBNome = new System.Windows.Forms.TextBox();
            this.txtBRazza = new System.Windows.Forms.TextBox();
            this.txtBAnno = new System.Windows.Forms.TextBox();
            this.rdBM = new System.Windows.Forms.RadioButton();
            this.rdBF = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCavalli = new System.Windows.Forms.ListBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnCambia = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.btnRimuovi = new System.Windows.Forms.Button();
            this.pnlCerca = new System.Windows.Forms.Panel();
            this.btnCercaNome = new System.Windows.Forms.Button();
            this.txtCerca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStalle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlCerca.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBNome
            // 
            this.txtBNome.Location = new System.Drawing.Point(12, 54);
            this.txtBNome.Name = "txtBNome";
            this.txtBNome.Size = new System.Drawing.Size(142, 22);
            this.txtBNome.TabIndex = 0;
            this.txtBNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBNome_KeyPress);
            // 
            // txtBRazza
            // 
            this.txtBRazza.Location = new System.Drawing.Point(228, 54);
            this.txtBRazza.Name = "txtBRazza";
            this.txtBRazza.Size = new System.Drawing.Size(143, 22);
            this.txtBRazza.TabIndex = 1;
            this.txtBRazza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBRazza_KeyPress);
            // 
            // txtBAnno
            // 
            this.txtBAnno.Location = new System.Drawing.Point(424, 54);
            this.txtBAnno.Name = "txtBAnno";
            this.txtBAnno.Size = new System.Drawing.Size(123, 22);
            this.txtBAnno.TabIndex = 2;
            this.txtBAnno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBAnno_KeyPress);
            // 
            // rdBM
            // 
            this.rdBM.AutoSize = true;
            this.rdBM.Location = new System.Drawing.Point(575, 56);
            this.rdBM.Name = "rdBM";
            this.rdBM.Size = new System.Drawing.Size(89, 20);
            this.rdBM.TabIndex = 3;
            this.rdBM.TabStop = true;
            this.rdBM.Text = "MASCHIO";
            this.rdBM.UseVisualStyleBackColor = true;
            this.rdBM.CheckedChanged += new System.EventHandler(this.rdBM_CheckedChanged);
            // 
            // rdBF
            // 
            this.rdBF.AutoSize = true;
            this.rdBF.Location = new System.Drawing.Point(679, 54);
            this.rdBF.Name = "rdBF";
            this.rdBF.Size = new System.Drawing.Size(89, 20);
            this.rdBF.TabIndex = 4;
            this.rdBF.TabStop = true;
            this.rdBF.Text = "FEMMINA";
            this.rdBF.UseVisualStyleBackColor = true;
            this.rdBF.CheckedChanged += new System.EventHandler(this.rdBF_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOME DEL CAVALLO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "RAZZA DEL CAVALLO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "ANNO DI NASCITA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "SESSO:";
            // 
            // lbCavalli
            // 
            this.lbCavalli.FormattingEnabled = true;
            this.lbCavalli.ItemHeight = 16;
            this.lbCavalli.Location = new System.Drawing.Point(15, 117);
            this.lbCavalli.Name = "lbCavalli";
            this.lbCavalli.Size = new System.Drawing.Size(913, 212);
            this.lbCavalli.TabIndex = 12;
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(15, 357);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(139, 23);
            this.btnSalva.TabIndex = 13;
            this.btnSalva.Text = "SALVA CAVALLO";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnCambia
            // 
            this.btnCambia.Location = new System.Drawing.Point(187, 357);
            this.btnCambia.Name = "btnCambia";
            this.btnCambia.Size = new System.Drawing.Size(172, 23);
            this.btnCambia.TabIndex = 14;
            this.btnCambia.Text = "CAMBIA DATI CAVALLO ";
            this.btnCambia.UseVisualStyleBackColor = true;
            this.btnCambia.Click += new System.EventHandler(this.btnCambia_Click);
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(380, 357);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(167, 23);
            this.btnCerca.TabIndex = 15;
            this.btnCerca.Text = "CERCA UN CAVALLO:";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // btnRimuovi
            // 
            this.btnRimuovi.Location = new System.Drawing.Point(564, 357);
            this.btnRimuovi.Name = "btnRimuovi";
            this.btnRimuovi.Size = new System.Drawing.Size(150, 23);
            this.btnRimuovi.TabIndex = 16;
            this.btnRimuovi.Text = "RIMUOVI CAVALLO";
            this.btnRimuovi.UseVisualStyleBackColor = true;
            this.btnRimuovi.Click += new System.EventHandler(this.btnRimuovi_Click);
            // 
            // pnlCerca
            // 
            this.pnlCerca.Controls.Add(this.label6);
            this.pnlCerca.Controls.Add(this.btnCercaNome);
            this.pnlCerca.Controls.Add(this.txtCerca);
            this.pnlCerca.Location = new System.Drawing.Point(380, 395);
            this.pnlCerca.Name = "pnlCerca";
            this.pnlCerca.Size = new System.Drawing.Size(167, 132);
            this.pnlCerca.TabIndex = 18;
            // 
            // btnCercaNome
            // 
            this.btnCercaNome.Location = new System.Drawing.Point(44, 75);
            this.btnCercaNome.Name = "btnCercaNome";
            this.btnCercaNome.Size = new System.Drawing.Size(75, 23);
            this.btnCercaNome.TabIndex = 1;
            this.btnCercaNome.Text = "CERCA";
            this.btnCercaNome.UseVisualStyleBackColor = true;
            this.btnCercaNome.Click += new System.EventHandler(this.btnCercaNome_Click);
            // 
            // txtCerca
            // 
            this.txtCerca.Location = new System.Drawing.Point(20, 41);
            this.txtCerca.Name = "txtCerca";
            this.txtCerca.Size = new System.Drawing.Size(133, 22);
            this.txtCerca.TabIndex = 0;
            this.txtCerca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCerca_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "NUMERO STALLE RIEMPITE SUL TOTALE (10):";
            // 
            // lblStalle
            // 
            this.lblStalle.AutoSize = true;
            this.lblStalle.Location = new System.Drawing.Point(585, 439);
            this.lblStalle.Name = "lblStalle";
            this.lblStalle.Size = new System.Drawing.Size(14, 16);
            this.lblStalle.TabIndex = 20;
            this.lblStalle.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "NOME DEL CAVALLO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 539);
            this.Controls.Add(this.lblStalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlCerca);
            this.Controls.Add(this.btnRimuovi);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.btnCambia);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.lbCavalli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdBF);
            this.Controls.Add(this.rdBM);
            this.Controls.Add(this.txtBAnno);
            this.Controls.Add(this.txtBRazza);
            this.Controls.Add(this.txtBNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCerca.ResumeLayout(false);
            this.pnlCerca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBNome;
        private System.Windows.Forms.TextBox txtBRazza;
        private System.Windows.Forms.TextBox txtBAnno;
        private System.Windows.Forms.RadioButton rdBM;
        private System.Windows.Forms.RadioButton rdBF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbCavalli;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnCambia;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Button btnRimuovi;
        private System.Windows.Forms.Panel pnlCerca;
        private System.Windows.Forms.Button btnCercaNome;
        private System.Windows.Forms.TextBox txtCerca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStalle;
        private System.Windows.Forms.Label label6;
    }
}

