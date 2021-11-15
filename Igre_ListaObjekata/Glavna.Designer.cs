
namespace Igre_ListaObjekata
{
    partial class Glavna
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
            this.btnUnesi = new System.Windows.Forms.Button();
            this.txtIzdavac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvIgre = new System.Windows.Forms.DataGridView();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnUcitaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(85, 149);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(217, 28);
            this.btnUnesi.TabIndex = 25;
            this.btnUnesi.Text = "Dodaj";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // txtIzdavac
            // 
            this.txtIzdavac.Location = new System.Drawing.Point(466, 106);
            this.txtIzdavac.Name = "txtIzdavac";
            this.txtIzdavac.Size = new System.Drawing.Size(217, 20);
            this.txtIzdavac.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Izdavač:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(466, 61);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(217, 20);
            this.txtCijena.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cijena:";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(466, 22);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(217, 20);
            this.txtDatum.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Datum izdavanja:";
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(85, 106);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(217, 20);
            this.txtVrsta.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Vrsta igre:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(85, 61);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(217, 39);
            this.txtOpis.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Opis:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(85, 22);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(217, 20);
            this.txtNaziv.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Naziv:";
            // 
            // dgvIgre
            // 
            this.dgvIgre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgre.Location = new System.Drawing.Point(30, 212);
            this.dgvIgre.Name = "dgvIgre";
            this.dgvIgre.Size = new System.Drawing.Size(733, 226);
            this.dgvIgre.TabIndex = 26;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(326, 149);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(164, 28);
            this.btnSpremi.TabIndex = 27;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(509, 149);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(164, 28);
            this.btnUcitaj.TabIndex = 27;
            this.btnUcitaj.Text = "Učitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dgvIgre);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.txtIzdavac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "Glavna";
            this.Text = "Popis igara";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.TextBox txtIzdavac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvIgre;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnUcitaj;
    }
}

