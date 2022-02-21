
namespace ShapeUp.Desktop.Proizvodi
{
    partial class frmShowProizvodi
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
            this.mProizvodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbKategorijeProizvoda = new System.Windows.Forms.ComboBox();
            this.btnOcistiFiltere = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prosjecnaOcjenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaProizvodaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mProizvodiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mProizvodiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mProizvodiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mProizvodiBindingSource
            // 
            this.mProizvodiBindingSource.DataSource = typeof(ShapeUp.Model.Models.MProizvodi);
            // 
            // cmbKategorijeProizvoda
            // 
            this.cmbKategorijeProizvoda.FormattingEnabled = true;
            this.cmbKategorijeProizvoda.Location = new System.Drawing.Point(254, 14);
            this.cmbKategorijeProizvoda.Name = "cmbKategorijeProizvoda";
            this.cmbKategorijeProizvoda.Size = new System.Drawing.Size(171, 21);
            this.cmbKategorijeProizvoda.TabIndex = 1;
            this.cmbKategorijeProizvoda.SelectionChangeCommitted += new System.EventHandler(this.cmbKategorijeProizvoda_SelectionChangeCommitted);
            // 
            // btnOcistiFiltere
            // 
            this.btnOcistiFiltere.Location = new System.Drawing.Point(431, 13);
            this.btnOcistiFiltere.Name = "btnOcistiFiltere";
            this.btnOcistiFiltere.Size = new System.Drawing.Size(106, 23);
            this.btnOcistiFiltere.TabIndex = 2;
            this.btnOcistiFiltere.Text = "Ocisti Filtere";
            this.btnOcistiFiltere.UseVisualStyleBackColor = true;
            this.btnOcistiFiltere.Click += new System.EventHandler(this.btnOcistiFiltere_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(235, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToAddRows = false;
            this.dgvProizvodi.AllowUserToDeleteRows = false;
            this.dgvProizvodi.AutoGenerateColumns = false;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.prosjecnaOcjenaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.kategorijaProizvodaDataGridViewTextBoxColumn});
            this.dgvProizvodi.DataSource = this.mProizvodiBindingSource1;
            this.dgvProizvodi.Location = new System.Drawing.Point(13, 76);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.ReadOnly = true;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(815, 476);
            this.dgvProizvodi.TabIndex = 4;
            this.dgvProizvodi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvProizvodi_MouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prosjecnaOcjenaDataGridViewTextBoxColumn
            // 
            this.prosjecnaOcjenaDataGridViewTextBoxColumn.DataPropertyName = "ProsjecnaOcjena";
            this.prosjecnaOcjenaDataGridViewTextBoxColumn.HeaderText = "Prosjecna Ocjena";
            this.prosjecnaOcjenaDataGridViewTextBoxColumn.Name = "prosjecnaOcjenaDataGridViewTextBoxColumn";
            this.prosjecnaOcjenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategorijaProizvodaDataGridViewTextBoxColumn
            // 
            this.kategorijaProizvodaDataGridViewTextBoxColumn.DataPropertyName = "KategorijaProizvoda";
            this.kategorijaProizvodaDataGridViewTextBoxColumn.HeaderText = "Kategorija Proizvoda";
            this.kategorijaProizvodaDataGridViewTextBoxColumn.Name = "kategorijaProizvodaDataGridViewTextBoxColumn";
            this.kategorijaProizvodaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mProizvodiBindingSource1
            // 
            this.mProizvodiBindingSource1.DataSource = typeof(ShapeUp.Model.Models.MProizvodi);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(685, 47);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(143, 23);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj proizvod";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmShowProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 564);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnOcistiFiltere);
            this.Controls.Add(this.cmbKategorijeProizvoda);
            this.Name = "frmShowProizvodi";
            this.Text = "frmShowProizvodi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmShowProizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mProizvodiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mProizvodiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource mProizvodiBindingSource;
        private System.Windows.Forms.ComboBox cmbKategorijeProizvoda;
        private System.Windows.Forms.Button btnOcistiFiltere;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prosjecnaOcjenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaProizvodaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mProizvodiBindingSource1;
        private System.Windows.Forms.Button btnDodaj;
    }
}