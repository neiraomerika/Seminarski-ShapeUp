
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblKlijent = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblTrening = new System.Windows.Forms.Label();
            this.lblPlanPrehrane = new System.Windows.Forms.Label();
            this.lblMentorstvo = new System.Windows.Forms.Label();
            this.btnTrening = new System.Windows.Forms.Button();
            this.btnObrok = new System.Windows.Forms.Button();
            this.btnMentorstvo = new System.Windows.Forms.Button();
            this.cmbKlijenti = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(59, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lblKlijent
            // 
            this.lblKlijent.AutoSize = true;
            this.lblKlijent.Location = new System.Drawing.Point(12, 9);
            this.lblKlijent.Name = "lblKlijent";
            this.lblKlijent.Size = new System.Drawing.Size(38, 13);
            this.lblKlijent.TabIndex = 1;
            this.lblKlijent.Text = "Klijent:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(12, 52);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum:";
            // 
            // lblTrening
            // 
            this.lblTrening.AutoSize = true;
            this.lblTrening.Location = new System.Drawing.Point(12, 95);
            this.lblTrening.Name = "lblTrening";
            this.lblTrening.Size = new System.Drawing.Size(46, 13);
            this.lblTrening.TabIndex = 3;
            this.lblTrening.Text = "Trening:";
            // 
            // lblPlanPrehrane
            // 
            this.lblPlanPrehrane.AutoSize = true;
            this.lblPlanPrehrane.Location = new System.Drawing.Point(12, 138);
            this.lblPlanPrehrane.Name = "lblPlanPrehrane";
            this.lblPlanPrehrane.Size = new System.Drawing.Size(77, 13);
            this.lblPlanPrehrane.TabIndex = 4;
            this.lblPlanPrehrane.Text = "Plan Prehrane:";
            // 
            // lblMentorstvo
            // 
            this.lblMentorstvo.AutoSize = true;
            this.lblMentorstvo.Location = new System.Drawing.Point(12, 181);
            this.lblMentorstvo.Name = "lblMentorstvo";
            this.lblMentorstvo.Size = new System.Drawing.Size(63, 13);
            this.lblMentorstvo.TabIndex = 5;
            this.lblMentorstvo.Text = "Mentorstvo:";
            // 
            // btnTrening
            // 
            this.btnTrening.Location = new System.Drawing.Point(64, 90);
            this.btnTrening.Name = "btnTrening";
            this.btnTrening.Size = new System.Drawing.Size(130, 23);
            this.btnTrening.TabIndex = 7;
            this.btnTrening.Text = "Izaberi Trening";
            this.btnTrening.UseVisualStyleBackColor = true;
            // 
            // btnObrok
            // 
            this.btnObrok.Location = new System.Drawing.Point(95, 133);
            this.btnObrok.Name = "btnObrok";
            this.btnObrok.Size = new System.Drawing.Size(130, 23);
            this.btnObrok.TabIndex = 8;
            this.btnObrok.Text = "Izaberi Obrok";
            this.btnObrok.UseVisualStyleBackColor = true;
            // 
            // btnMentorstvo
            // 
            this.btnMentorstvo.Location = new System.Drawing.Point(81, 176);
            this.btnMentorstvo.Name = "btnMentorstvo";
            this.btnMentorstvo.Size = new System.Drawing.Size(130, 23);
            this.btnMentorstvo.TabIndex = 9;
            this.btnMentorstvo.Text = "Izaberi Mentorstvo";
            this.btnMentorstvo.UseVisualStyleBackColor = true;
            // 
            // cmbKlijenti
            // 
            this.cmbKlijenti.FormattingEnabled = true;
            this.cmbKlijenti.Location = new System.Drawing.Point(56, 6);
            this.cmbKlijenti.Name = "cmbKlijenti";
            this.cmbKlijenti.Size = new System.Drawing.Size(203, 21);
            this.cmbKlijenti.TabIndex = 10;
            // 
            // frmDodajPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbKlijenti);
            this.Controls.Add(this.btnMentorstvo);
            this.Controls.Add(this.btnObrok);
            this.Controls.Add(this.btnTrening);
            this.Controls.Add(this.lblMentorstvo);
            this.Controls.Add(this.lblPlanPrehrane);
            this.Controls.Add(this.lblTrening);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblKlijent);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmDodajPlan";
            this.Text = "frmDodajPlan";
            this.Load += new System.EventHandler(this.frmDodajPlan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblKlijent;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblTrening;
        private System.Windows.Forms.Label lblPlanPrehrane;
        private System.Windows.Forms.Label lblMentorstvo;
        private System.Windows.Forms.Button btnTrening;
        private System.Windows.Forms.Button btnObrok;
        private System.Windows.Forms.Button btnMentorstvo;
        private System.Windows.Forms.ComboBox cmbKlijenti;
    }
}