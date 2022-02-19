
namespace ShapeUp.Desktop.Recenzija
{
    partial class frmShowRecenzije
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
            this.cmbOcjena = new System.Windows.Forms.ComboBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.dgvRecenzija = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocjenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mentorstvoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRecenzijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecenzija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRecenzijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOcjena
            // 
            this.cmbOcjena.FormattingEnabled = true;
            this.cmbOcjena.Location = new System.Drawing.Point(13, 13);
            this.cmbOcjena.Name = "cmbOcjena";
            this.cmbOcjena.Size = new System.Drawing.Size(202, 21);
            this.cmbOcjena.TabIndex = 0;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(221, 12);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(98, 23);
            this.btnPretraga.TabIndex = 1;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(325, 12);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(98, 23);
            this.btnPonisti.TabIndex = 2;
            this.btnPonisti.Text = "Ponisti pretragu";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // dgvRecenzija
            // 
            this.dgvRecenzija.AllowUserToAddRows = false;
            this.dgvRecenzija.AllowUserToDeleteRows = false;
            this.dgvRecenzija.AutoGenerateColumns = false;
            this.dgvRecenzija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecenzija.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.ocjenaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.mentorstvoIdDataGridViewTextBoxColumn});
            this.dgvRecenzija.DataSource = this.mRecenzijaBindingSource;
            this.dgvRecenzija.Location = new System.Drawing.Point(13, 66);
            this.dgvRecenzija.Name = "dgvRecenzija";
            this.dgvRecenzija.ReadOnly = true;
            this.dgvRecenzija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecenzija.Size = new System.Drawing.Size(630, 372);
            this.dgvRecenzija.TabIndex = 3;
            this.dgvRecenzija.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvRecenzija_MouseDoubleClick);
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
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ocjenaDataGridViewTextBoxColumn
            // 
            this.ocjenaDataGridViewTextBoxColumn.DataPropertyName = "Ocjena";
            this.ocjenaDataGridViewTextBoxColumn.HeaderText = "Ocjena";
            this.ocjenaDataGridViewTextBoxColumn.Name = "ocjenaDataGridViewTextBoxColumn";
            this.ocjenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mentorstvoIdDataGridViewTextBoxColumn
            // 
            this.mentorstvoIdDataGridViewTextBoxColumn.DataPropertyName = "MentorstvoId";
            this.mentorstvoIdDataGridViewTextBoxColumn.HeaderText = "MentorstvoId";
            this.mentorstvoIdDataGridViewTextBoxColumn.Name = "mentorstvoIdDataGridViewTextBoxColumn";
            this.mentorstvoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mRecenzijaBindingSource
            // 
            this.mRecenzijaBindingSource.DataSource = typeof(ShapeUp.Model.Models.MRecenzija);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(497, 37);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(146, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj recenziju";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmShowRecenzije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvRecenzija);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.cmbOcjena);
            this.Name = "frmShowRecenzije";
            this.Text = "frmShowRecenzije";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmShowRecenzije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecenzija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRecenzijaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOcjena;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.DataGridView dgvRecenzija;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mentorstvoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mRecenzijaBindingSource;
        private System.Windows.Forms.Button btnDodaj;
    }
}