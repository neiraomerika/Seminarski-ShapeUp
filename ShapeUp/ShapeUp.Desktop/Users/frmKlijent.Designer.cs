
namespace ShapeUp.Desktop.Users
{
    partial class frmKlijent
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblUName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dgvPlanovi = new System.Windows.Forms.DataGridView();
            this.lblDodaj = new System.Windows.Forms.Label();
            this.btnDodajPlan = new System.Windows.Forms.Button();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.pbProfilna = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.mPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treningIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planPrehraneIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mentorstvoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPlanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(175, 55);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(27, 13);
            this.lblFirst.TabIndex = 1;
            this.lblFirst.Text = "Ime:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(175, 86);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(50, 13);
            this.lblLast.TabIndex = 2;
            this.lblLast.Text = "Prezime: ";
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.Location = new System.Drawing.Point(175, 117);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(81, 13);
            this.lblUName.TabIndex = 3;
            this.lblUName.Text = "Korisnicko ime: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(175, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(175, 179);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(73, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Broj Telefona:";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(175, 210);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(46, 13);
            this.lblActive.TabIndex = 6;
            this.lblActive.Text = "Aktivan:";
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(263, 117);
            this.txtUName.Name = "txtUName";
            this.txtUName.ReadOnly = true;
            this.txtUName.Size = new System.Drawing.Size(330, 20);
            this.txtUName.TabIndex = 7;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(263, 52);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.ReadOnly = true;
            this.txtFirst.Size = new System.Drawing.Size(330, 20);
            this.txtFirst.TabIndex = 8;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(263, 83);
            this.txtLast.Name = "txtLast";
            this.txtLast.ReadOnly = true;
            this.txtLast.Size = new System.Drawing.Size(330, 20);
            this.txtLast.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(263, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(330, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(263, 176);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(330, 20);
            this.txtPhone.TabIndex = 11;
            // 
            // dgvPlanovi
            // 
            this.dgvPlanovi.AllowUserToAddRows = false;
            this.dgvPlanovi.AllowUserToDeleteRows = false;
            this.dgvPlanovi.AutoGenerateColumns = false;
            this.dgvPlanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.treningIdDataGridViewTextBoxColumn,
            this.planPrehraneIdDataGridViewTextBoxColumn,
            this.mentorstvoIdDataGridViewTextBoxColumn});
            this.dgvPlanovi.DataSource = this.mPlanBindingSource;
            this.dgvPlanovi.Location = new System.Drawing.Point(12, 339);
            this.dgvPlanovi.Name = "dgvPlanovi";
            this.dgvPlanovi.ReadOnly = true;
            this.dgvPlanovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanovi.Size = new System.Drawing.Size(581, 236);
            this.dgvPlanovi.TabIndex = 13;
            // 
            // lblDodaj
            // 
            this.lblDodaj.AutoSize = true;
            this.lblDodaj.Location = new System.Drawing.Point(10, 300);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(168, 13);
            this.lblDodaj.TabIndex = 15;
            this.lblDodaj.Text = "Dodaj plan za trenutnog korisnika:";
            // 
            // btnDodajPlan
            // 
            this.btnDodajPlan.Location = new System.Drawing.Point(184, 295);
            this.btnDodajPlan.Name = "btnDodajPlan";
            this.btnDodajPlan.Size = new System.Drawing.Size(75, 23);
            this.btnDodajPlan.TabIndex = 14;
            this.btnDodajPlan.Text = "Dodaj";
            this.btnDodajPlan.UseVisualStyleBackColor = true;
            this.btnDodajPlan.Click += new System.EventHandler(this.btnDodajPlan_Click);
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Enabled = false;
            this.cbActive.Location = new System.Drawing.Point(263, 210);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(15, 14);
            this.cbActive.TabIndex = 16;
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // pbProfilna
            // 
            this.pbProfilna.Location = new System.Drawing.Point(13, 55);
            this.pbProfilna.Name = "pbProfilna";
            this.pbProfilna.Size = new System.Drawing.Size(156, 185);
            this.pbProfilna.TabIndex = 0;
            this.pbProfilna.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "<  Nazad";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // mPlanBindingSource
            // 
            this.mPlanBindingSource.DataSource = typeof(ShapeUp.Model.Models.MPlan);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // treningIdDataGridViewTextBoxColumn
            // 
            this.treningIdDataGridViewTextBoxColumn.DataPropertyName = "TreningId";
            this.treningIdDataGridViewTextBoxColumn.HeaderText = "TreningId";
            this.treningIdDataGridViewTextBoxColumn.Name = "treningIdDataGridViewTextBoxColumn";
            this.treningIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planPrehraneIdDataGridViewTextBoxColumn
            // 
            this.planPrehraneIdDataGridViewTextBoxColumn.DataPropertyName = "PlanPrehraneId";
            this.planPrehraneIdDataGridViewTextBoxColumn.HeaderText = "PlanPrehraneId";
            this.planPrehraneIdDataGridViewTextBoxColumn.Name = "planPrehraneIdDataGridViewTextBoxColumn";
            this.planPrehraneIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mentorstvoIdDataGridViewTextBoxColumn
            // 
            this.mentorstvoIdDataGridViewTextBoxColumn.DataPropertyName = "MentorstvoId";
            this.mentorstvoIdDataGridViewTextBoxColumn.HeaderText = "MentorstvoId";
            this.mentorstvoIdDataGridViewTextBoxColumn.Name = "mentorstvoIdDataGridViewTextBoxColumn";
            this.mentorstvoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 588);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.lblDodaj);
            this.Controls.Add(this.btnDodajPlan);
            this.Controls.Add(this.dgvPlanovi);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtUName);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUName);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.pbProfilna);
            this.Name = "frmKlijent";
            this.Text = "Klijent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKlijent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPlanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProfilna;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblUName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DataGridView dgvPlanovi;
        private System.Windows.Forms.Label lblDodaj;
        private System.Windows.Forms.Button btnDodajPlan;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treningIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planPrehraneIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mentorstvoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mPlanBindingSource;
    }
}