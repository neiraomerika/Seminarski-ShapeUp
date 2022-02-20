
namespace ShapeUp.Desktop.Recenzija
{
    partial class frmCRUDRecenzija
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
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblOcjena = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblMentorstvo = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.cmbOcjena = new System.Windows.Forms.ComboBox();
            this.dtmRecenzija = new System.Windows.Forms.DateTimePicker();
            this.cmbMentorstvo = new System.Windows.Forms.ComboBox();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(12, 45);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(31, 13);
            this.lblOpis.TabIndex = 0;
            this.lblOpis.Text = "Opis:";
            // 
            // lblOcjena
            // 
            this.lblOcjena.AutoSize = true;
            this.lblOcjena.Location = new System.Drawing.Point(12, 183);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(44, 13);
            this.lblOcjena.TabIndex = 1;
            this.lblOcjena.Text = "Ocjena:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(12, 220);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum:";
            // 
            // lblMentorstvo
            // 
            this.lblMentorstvo.AutoSize = true;
            this.lblMentorstvo.Location = new System.Drawing.Point(12, 258);
            this.lblMentorstvo.Name = "lblMentorstvo";
            this.lblMentorstvo.Size = new System.Drawing.Size(63, 13);
            this.lblMentorstvo.TabIndex = 3;
            this.lblMentorstvo.Text = "Mentorstvo:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(75, 42);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(191, 116);
            this.txtOpis.TabIndex = 5;
            this.txtOpis.Text = "";
            // 
            // cmbOcjena
            // 
            this.cmbOcjena.FormattingEnabled = true;
            this.cmbOcjena.Location = new System.Drawing.Point(75, 175);
            this.cmbOcjena.Name = "cmbOcjena";
            this.cmbOcjena.Size = new System.Drawing.Size(191, 21);
            this.cmbOcjena.TabIndex = 6;
            // 
            // dtmRecenzija
            // 
            this.dtmRecenzija.Location = new System.Drawing.Point(75, 213);
            this.dtmRecenzija.Name = "dtmRecenzija";
            this.dtmRecenzija.Size = new System.Drawing.Size(191, 20);
            this.dtmRecenzija.TabIndex = 7;
            // 
            // cmbMentorstvo
            // 
            this.cmbMentorstvo.FormattingEnabled = true;
            this.cmbMentorstvo.Location = new System.Drawing.Point(81, 250);
            this.cmbMentorstvo.Name = "cmbMentorstvo";
            this.cmbMentorstvo.Size = new System.Drawing.Size(185, 21);
            this.cmbMentorstvo.TabIndex = 8;
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(157, 292);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(109, 23);
            this.btnSpasi.TabIndex = 9;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(15, 292);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Obrisi";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmCRUDRecenzija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.cmbMentorstvo);
            this.Controls.Add(this.dtmRecenzija);
            this.Controls.Add(this.cmbOcjena);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblMentorstvo);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblOcjena);
            this.Controls.Add(this.lblOpis);
            this.Name = "frmCRUDRecenzija";
            this.Text = "frmCRUDRecenzija";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCRUDRecenzija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblOcjena;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblMentorstvo;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.ComboBox cmbOcjena;
        private System.Windows.Forms.DateTimePicker dtmRecenzija;
        private System.Windows.Forms.ComboBox cmbMentorstvo;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Button btnDelete;
    }
}