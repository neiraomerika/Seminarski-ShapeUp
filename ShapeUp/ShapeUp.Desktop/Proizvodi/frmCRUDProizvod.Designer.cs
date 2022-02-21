
namespace ShapeUp.Desktop.Proizvodi
{
    partial class frmCRUDProizvod
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblProsjecnaOcjena = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtProsjecnaOcjena = new System.Windows.Forms.TextBox();
            this.sfdProizvod = new System.Windows.Forms.SaveFileDialog();
            this.ofdProizvod = new System.Windows.Forms.OpenFileDialog();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSpasi = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.cmbKategorije = new System.Windows.Forms.ComboBox();
            this.pbProizvod = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProizvod)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(26, 76);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(40, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv: ";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(26, 119);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(34, 13);
            this.lblOpis.TabIndex = 1;
            this.lblOpis.Text = "Opis: ";
            // 
            // lblProsjecnaOcjena
            // 
            this.lblProsjecnaOcjena.AutoSize = true;
            this.lblProsjecnaOcjena.Location = new System.Drawing.Point(26, 268);
            this.lblProsjecnaOcjena.Name = "lblProsjecnaOcjena";
            this.lblProsjecnaOcjena.Size = new System.Drawing.Size(92, 13);
            this.lblProsjecnaOcjena.TabIndex = 2;
            this.lblProsjecnaOcjena.Text = "Prosjecna ocjena:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Slika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cijena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategorija proizvoda:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(72, 73);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(155, 20);
            this.txtNaziv.TabIndex = 6;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(72, 116);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(155, 133);
            this.txtOpis.TabIndex = 7;
            // 
            // txtProsjecnaOcjena
            // 
            this.txtProsjecnaOcjena.Location = new System.Drawing.Point(132, 265);
            this.txtProsjecnaOcjena.Name = "txtProsjecnaOcjena";
            this.txtProsjecnaOcjena.ReadOnly = true;
            this.txtProsjecnaOcjena.Size = new System.Drawing.Size(95, 20);
            this.txtProsjecnaOcjena.TabIndex = 8;
            // 
            // ofdProizvod
            // 
            this.ofdProizvod.FileName = "openFileDialog1";
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(368, 316);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(120, 23);
            this.btnSpasi.TabIndex = 9;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(239, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Obrisi";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(293, 221);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(195, 20);
            this.txtCijena.TabIndex = 16;
            // 
            // cmbKategorije
            // 
            this.cmbKategorije.FormattingEnabled = true;
            this.cmbKategorije.Location = new System.Drawing.Point(361, 265);
            this.cmbKategorije.Name = "cmbKategorije";
            this.cmbKategorije.Size = new System.Drawing.Size(127, 21);
            this.cmbKategorije.TabIndex = 17;
            // 
            // pbProizvod
            // 
            this.pbProizvod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbProizvod.Image = global::ShapeUp.Desktop.Properties.Resources.upload;
            this.pbProizvod.InitialImage = global::ShapeUp.Desktop.Properties.Resources.upload;
            this.pbProizvod.Location = new System.Drawing.Point(293, 73);
            this.pbProizvod.Name = "pbProizvod";
            this.pbProizvod.Size = new System.Drawing.Size(195, 126);
            this.pbProizvod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProizvod.TabIndex = 18;
            this.pbProizvod.TabStop = false;
            this.pbProizvod.Click += new System.EventHandler(this.pbProizvod_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "<  Nazad";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmCRUDProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbProizvod);
            this.Controls.Add(this.cmbKategorije);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.txtProsjecnaOcjena);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProsjecnaOcjena);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblNaziv);
            this.Name = "frmCRUDProizvod";
            this.Text = "frmCRUDProizvod";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCRUDProizvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProizvod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblProsjecnaOcjena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtProsjecnaOcjena;
        private System.Windows.Forms.SaveFileDialog sfdProizvod;
        private System.Windows.Forms.OpenFileDialog ofdProizvod;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbKategorije;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.PictureBox pbProizvod;
        private System.Windows.Forms.Button btnBack;
    }
}