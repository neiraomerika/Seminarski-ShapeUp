
namespace ShapeUp.Desktop.Mentorstvo
{
    partial class frmCreateMentorstvo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtmPocetak = new System.Windows.Forms.DateTimePicker();
            this.dtmZavrsetak = new System.Windows.Forms.DateTimePicker();
            this.cmbKlijenti = new System.Windows.Forms.ComboBox();
            this.dtmUplata = new System.Windows.Forms.DateTimePicker();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum pocetka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum zavrsetka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Klijent:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum uplate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cijena mentorstva:";
            // 
            // dtmPocetak
            // 
            this.dtmPocetak.Location = new System.Drawing.Point(143, 60);
            this.dtmPocetak.Name = "dtmPocetak";
            this.dtmPocetak.Size = new System.Drawing.Size(200, 20);
            this.dtmPocetak.TabIndex = 5;
            // 
            // dtmZavrsetak
            // 
            this.dtmZavrsetak.Location = new System.Drawing.Point(143, 117);
            this.dtmZavrsetak.Name = "dtmZavrsetak";
            this.dtmZavrsetak.Size = new System.Drawing.Size(200, 20);
            this.dtmZavrsetak.TabIndex = 6;
            // 
            // cmbKlijenti
            // 
            this.cmbKlijenti.FormattingEnabled = true;
            this.cmbKlijenti.Location = new System.Drawing.Point(143, 177);
            this.cmbKlijenti.Name = "cmbKlijenti";
            this.cmbKlijenti.Size = new System.Drawing.Size(200, 21);
            this.cmbKlijenti.TabIndex = 7;
            // 
            // dtmUplata
            // 
            this.dtmUplata.Location = new System.Drawing.Point(143, 231);
            this.dtmUplata.Name = "dtmUplata";
            this.dtmUplata.Size = new System.Drawing.Size(200, 20);
            this.dtmUplata.TabIndex = 8;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(143, 291);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(200, 20);
            this.txtCijena.TabIndex = 9;
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(239, 350);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(104, 23);
            this.btnSpasi.TabIndex = 10;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // frmCreateMentorstvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 497);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.dtmUplata);
            this.Controls.Add(this.cmbKlijenti);
            this.Controls.Add(this.dtmZavrsetak);
            this.Controls.Add(this.dtmPocetak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCreateMentorstvo";
            this.Text = "frmCreateMentorstvo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCreateMentorstvo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtmPocetak;
        private System.Windows.Forms.DateTimePicker dtmZavrsetak;
        private System.Windows.Forms.ComboBox cmbKlijenti;
        private System.Windows.Forms.DateTimePicker dtmUplata;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}