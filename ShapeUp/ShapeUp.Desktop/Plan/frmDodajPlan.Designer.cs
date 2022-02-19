
namespace ShapeUp.Desktop.Plan
{
    partial class frmDodajPlan
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
            this.dtmPlan = new System.Windows.Forms.DateTimePicker();
            this.lblKlijent = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblTrening = new System.Windows.Forms.Label();
            this.lblPlanPrehrane = new System.Windows.Forms.Label();
            this.lblMentorstvo = new System.Windows.Forms.Label();
            this.btnTrening = new System.Windows.Forms.Button();
            this.btnObrok = new System.Windows.Forms.Button();
            this.btnMentorstvo = new System.Windows.Forms.Button();
            this.cmbKlijenti = new System.Windows.Forms.ComboBox();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtTrening = new System.Windows.Forms.TextBox();
            this.txtPrehrana = new System.Windows.Forms.TextBox();
            this.txtMentorstvo = new System.Windows.Forms.TextBox();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dtmPlan
            // 
            this.dtmPlan.Location = new System.Drawing.Point(59, 104);
            this.dtmPlan.Name = "dtmPlan";
            this.dtmPlan.Size = new System.Drawing.Size(200, 20);
            this.dtmPlan.TabIndex = 0;
            // 
            // lblKlijent
            // 
            this.lblKlijent.AutoSize = true;
            this.lblKlijent.Location = new System.Drawing.Point(12, 67);
            this.lblKlijent.Name = "lblKlijent";
            this.lblKlijent.Size = new System.Drawing.Size(38, 13);
            this.lblKlijent.TabIndex = 1;
            this.lblKlijent.Text = "Klijent:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(12, 110);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum:";
            // 
            // lblTrening
            // 
            this.lblTrening.AutoSize = true;
            this.lblTrening.Location = new System.Drawing.Point(12, 153);
            this.lblTrening.Name = "lblTrening";
            this.lblTrening.Size = new System.Drawing.Size(46, 13);
            this.lblTrening.TabIndex = 3;
            this.lblTrening.Text = "Trening:";
            // 
            // lblPlanPrehrane
            // 
            this.lblPlanPrehrane.AutoSize = true;
            this.lblPlanPrehrane.Location = new System.Drawing.Point(12, 196);
            this.lblPlanPrehrane.Name = "lblPlanPrehrane";
            this.lblPlanPrehrane.Size = new System.Drawing.Size(77, 13);
            this.lblPlanPrehrane.TabIndex = 4;
            this.lblPlanPrehrane.Text = "Plan Prehrane:";
            // 
            // lblMentorstvo
            // 
            this.lblMentorstvo.AutoSize = true;
            this.lblMentorstvo.Location = new System.Drawing.Point(12, 239);
            this.lblMentorstvo.Name = "lblMentorstvo";
            this.lblMentorstvo.Size = new System.Drawing.Size(63, 13);
            this.lblMentorstvo.TabIndex = 5;
            this.lblMentorstvo.Text = "Mentorstvo:";
            // 
            // btnTrening
            // 
            this.btnTrening.Location = new System.Drawing.Point(153, 148);
            this.btnTrening.Name = "btnTrening";
            this.btnTrening.Size = new System.Drawing.Size(106, 23);
            this.btnTrening.TabIndex = 7;
            this.btnTrening.Text = "Izaberi Trening";
            this.btnTrening.UseVisualStyleBackColor = true;
            this.btnTrening.Click += new System.EventHandler(this.btnTrening_Click);
            // 
            // btnObrok
            // 
            this.btnObrok.Location = new System.Drawing.Point(153, 191);
            this.btnObrok.Name = "btnObrok";
            this.btnObrok.Size = new System.Drawing.Size(106, 23);
            this.btnObrok.TabIndex = 8;
            this.btnObrok.Text = "Izaberi Obrok";
            this.btnObrok.UseVisualStyleBackColor = true;
            this.btnObrok.Click += new System.EventHandler(this.btnObrok_Click);
            // 
            // btnMentorstvo
            // 
            this.btnMentorstvo.Location = new System.Drawing.Point(153, 234);
            this.btnMentorstvo.Name = "btnMentorstvo";
            this.btnMentorstvo.Size = new System.Drawing.Size(106, 23);
            this.btnMentorstvo.TabIndex = 9;
            this.btnMentorstvo.Text = "Izaberi Mentorstvo";
            this.btnMentorstvo.UseVisualStyleBackColor = true;
            this.btnMentorstvo.Click += new System.EventHandler(this.btnMentorstvo_Click);
            // 
            // cmbKlijenti
            // 
            this.cmbKlijenti.FormattingEnabled = true;
            this.cmbKlijenti.Location = new System.Drawing.Point(56, 64);
            this.cmbKlijenti.Name = "cmbKlijenti";
            this.cmbKlijenti.Size = new System.Drawing.Size(203, 21);
            this.cmbKlijenti.TabIndex = 10;
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(139, 285);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(120, 23);
            this.btnSpasi.TabIndex = 11;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "<  Nazad";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtTrening
            // 
            this.txtTrening.Location = new System.Drawing.Point(59, 150);
            this.txtTrening.Name = "txtTrening";
            this.txtTrening.Size = new System.Drawing.Size(88, 20);
            this.txtTrening.TabIndex = 19;
            // 
            // txtPrehrana
            // 
            this.txtPrehrana.Location = new System.Drawing.Point(95, 193);
            this.txtPrehrana.Name = "txtPrehrana";
            this.txtPrehrana.Size = new System.Drawing.Size(52, 20);
            this.txtPrehrana.TabIndex = 20;
            // 
            // txtMentorstvo
            // 
            this.txtMentorstvo.Location = new System.Drawing.Point(81, 236);
            this.txtMentorstvo.Name = "txtMentorstvo";
            this.txtMentorstvo.Size = new System.Drawing.Size(66, 20);
            this.txtMentorstvo.TabIndex = 21;
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
            this.btnDelete.Location = new System.Drawing.Point(12, 285);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Obrisi";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDodajPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtMentorstvo);
            this.Controls.Add(this.txtPrehrana);
            this.Controls.Add(this.txtTrening);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.cmbKlijenti);
            this.Controls.Add(this.btnMentorstvo);
            this.Controls.Add(this.btnObrok);
            this.Controls.Add(this.btnTrening);
            this.Controls.Add(this.lblMentorstvo);
            this.Controls.Add(this.lblPlanPrehrane);
            this.Controls.Add(this.lblTrening);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblKlijent);
            this.Controls.Add(this.dtmPlan);
            this.Name = "frmDodajPlan";
            this.Text = "frmDodajPlan";
            this.Load += new System.EventHandler(this.frmDodajPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtmPlan;
        private System.Windows.Forms.Label lblKlijent;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblTrening;
        private System.Windows.Forms.Label lblPlanPrehrane;
        private System.Windows.Forms.Label lblMentorstvo;
        private System.Windows.Forms.Button btnTrening;
        private System.Windows.Forms.Button btnObrok;
        private System.Windows.Forms.Button btnMentorstvo;
        private System.Windows.Forms.ComboBox cmbKlijenti;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtTrening;
        private System.Windows.Forms.TextBox txtPrehrana;
        private System.Windows.Forms.TextBox txtMentorstvo;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Button btnDelete;
    }
}