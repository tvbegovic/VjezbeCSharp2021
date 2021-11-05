
namespace ListaRijeciNet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPozicija = new System.Windows.Forms.TextBox();
            this.btnDodajNaPoziciju = new System.Windows.Forms.Button();
            this.btnDodajNaKraj = new System.Windows.Forms.Button();
            this.txtJednaRijec = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDodajVise = new System.Windows.Forms.Button();
            this.txtViseRijeci = new System.Windows.Forms.TextBox();
            this.lstPopis = new System.Windows.Forms.ListBox();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPozicija);
            this.groupBox1.Controls.Add(this.btnDodajNaPoziciju);
            this.groupBox1.Controls.Add(this.btnDodajNaKraj);
            this.groupBox1.Controls.Add(this.txtJednaRijec);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jedna riječ";
            // 
            // txtPozicija
            // 
            this.txtPozicija.Location = new System.Drawing.Point(305, 52);
            this.txtPozicija.Name = "txtPozicija";
            this.txtPozicija.Size = new System.Drawing.Size(157, 20);
            this.txtPozicija.TabIndex = 2;
            // 
            // btnDodajNaPoziciju
            // 
            this.btnDodajNaPoziciju.Location = new System.Drawing.Point(150, 50);
            this.btnDodajNaPoziciju.Name = "btnDodajNaPoziciju";
            this.btnDodajNaPoziciju.Size = new System.Drawing.Size(135, 23);
            this.btnDodajNaPoziciju.TabIndex = 1;
            this.btnDodajNaPoziciju.Text = "Dodaj riječ na poziciju";
            this.btnDodajNaPoziciju.UseVisualStyleBackColor = true;
            this.btnDodajNaPoziciju.Click += new System.EventHandler(this.btnDodajNaPoziciju_Click);
            // 
            // btnDodajNaKraj
            // 
            this.btnDodajNaKraj.Location = new System.Drawing.Point(6, 50);
            this.btnDodajNaKraj.Name = "btnDodajNaKraj";
            this.btnDodajNaKraj.Size = new System.Drawing.Size(135, 23);
            this.btnDodajNaKraj.TabIndex = 1;
            this.btnDodajNaKraj.Text = "Dodaj riječ na kraj";
            this.btnDodajNaKraj.UseVisualStyleBackColor = true;
            this.btnDodajNaKraj.Click += new System.EventHandler(this.btnDodajNaKraj_Click);
            // 
            // txtJednaRijec
            // 
            this.txtJednaRijec.Location = new System.Drawing.Point(6, 19);
            this.txtJednaRijec.Name = "txtJednaRijec";
            this.txtJednaRijec.Size = new System.Drawing.Size(279, 20);
            this.txtJednaRijec.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDodajVise);
            this.groupBox2.Controls.Add(this.txtViseRijeci);
            this.groupBox2.Location = new System.Drawing.Point(33, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Više riječi";
            // 
            // btnDodajVise
            // 
            this.btnDodajVise.Location = new System.Drawing.Point(540, 29);
            this.btnDodajVise.Name = "btnDodajVise";
            this.btnDodajVise.Size = new System.Drawing.Size(148, 26);
            this.btnDodajVise.TabIndex = 1;
            this.btnDodajVise.Text = "Dodaj";
            this.btnDodajVise.UseVisualStyleBackColor = true;
            this.btnDodajVise.Click += new System.EventHandler(this.btnDodajVise_Click);
            // 
            // txtViseRijeci
            // 
            this.txtViseRijeci.Location = new System.Drawing.Point(6, 29);
            this.txtViseRijeci.Multiline = true;
            this.txtViseRijeci.Name = "txtViseRijeci";
            this.txtViseRijeci.Size = new System.Drawing.Size(502, 77);
            this.txtViseRijeci.TabIndex = 0;
            // 
            // lstPopis
            // 
            this.lstPopis.FormattingEnabled = true;
            this.lstPopis.Location = new System.Drawing.Point(39, 249);
            this.lstPopis.Name = "lstPopis";
            this.lstPopis.Size = new System.Drawing.Size(502, 173);
            this.lstPopis.TabIndex = 2;
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(573, 249);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(148, 31);
            this.btnUkloni.TabIndex = 3;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(573, 297);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(148, 31);
            this.btnOcisti.TabIndex = 3;
            this.btnOcisti.Text = "Isprazni listu";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.lstPopis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Glavna";
            this.Text = "Lista riječi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtJednaRijec;
        private System.Windows.Forms.Button btnDodajNaPoziciju;
        private System.Windows.Forms.Button btnDodajNaKraj;
        private System.Windows.Forms.TextBox txtPozicija;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDodajVise;
        private System.Windows.Forms.TextBox txtViseRijeci;
        private System.Windows.Forms.ListBox lstPopis;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnOcisti;
    }
}

