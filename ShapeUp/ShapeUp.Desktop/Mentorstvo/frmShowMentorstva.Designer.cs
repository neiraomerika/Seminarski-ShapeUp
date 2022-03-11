
namespace ShapeUp.Desktop.Mentorstvo
{
    partial class frmShowMentorstva
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
            this.dgvMentorstva = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPocetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumZavrsetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uplataIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivKlijentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mMentorstvoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodajMentorstvo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMentorstva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMentorstvoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMentorstva
            // 
            this.dgvMentorstva.AllowUserToAddRows = false;
            this.dgvMentorstva.AllowUserToDeleteRows = false;
            this.dgvMentorstva.AutoGenerateColumns = false;
            this.dgvMentorstva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMentorstva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.datumPocetkaDataGridViewTextBoxColumn,
            this.datumZavrsetkaDataGridViewTextBoxColumn,
            this.uplataIdDataGridViewTextBoxColumn,
            this.nazivKlijentaDataGridViewTextBoxColumn});
            this.dgvMentorstva.DataSource = this.mMentorstvoBindingSource;
            this.dgvMentorstva.Location = new System.Drawing.Point(13, 128);
            this.dgvMentorstva.Name = "dgvMentorstva";
            this.dgvMentorstva.ReadOnly = true;
            this.dgvMentorstva.Size = new System.Drawing.Size(924, 386);
            this.dgvMentorstva.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumPocetkaDataGridViewTextBoxColumn
            // 
            this.datumPocetkaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumPocetkaDataGridViewTextBoxColumn.DataPropertyName = "DatumPocetka";
            this.datumPocetkaDataGridViewTextBoxColumn.HeaderText = "DatumPocetka";
            this.datumPocetkaDataGridViewTextBoxColumn.Name = "datumPocetkaDataGridViewTextBoxColumn";
            this.datumPocetkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumZavrsetkaDataGridViewTextBoxColumn
            // 
            this.datumZavrsetkaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumZavrsetkaDataGridViewTextBoxColumn.DataPropertyName = "DatumZavrsetka";
            this.datumZavrsetkaDataGridViewTextBoxColumn.HeaderText = "DatumZavrsetka";
            this.datumZavrsetkaDataGridViewTextBoxColumn.Name = "datumZavrsetkaDataGridViewTextBoxColumn";
            this.datumZavrsetkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uplataIdDataGridViewTextBoxColumn
            // 
            this.uplataIdDataGridViewTextBoxColumn.DataPropertyName = "UplataId";
            this.uplataIdDataGridViewTextBoxColumn.HeaderText = "UplataId";
            this.uplataIdDataGridViewTextBoxColumn.Name = "uplataIdDataGridViewTextBoxColumn";
            this.uplataIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivKlijentaDataGridViewTextBoxColumn
            // 
            this.nazivKlijentaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivKlijentaDataGridViewTextBoxColumn.DataPropertyName = "NazivKlijenta";
            this.nazivKlijentaDataGridViewTextBoxColumn.HeaderText = "NazivKlijenta";
            this.nazivKlijentaDataGridViewTextBoxColumn.Name = "nazivKlijentaDataGridViewTextBoxColumn";
            this.nazivKlijentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mMentorstvoBindingSource
            // 
            this.mMentorstvoBindingSource.DataSource = typeof(ShapeUp.Model.Models.MMentorstvo);
            // 
            // btnDodajMentorstvo
            // 
            this.btnDodajMentorstvo.Location = new System.Drawing.Point(781, 94);
            this.btnDodajMentorstvo.Name = "btnDodajMentorstvo";
            this.btnDodajMentorstvo.Size = new System.Drawing.Size(155, 23);
            this.btnDodajMentorstvo.TabIndex = 3;
            this.btnDodajMentorstvo.Text = "Dodaj mentorstvo";
            this.btnDodajMentorstvo.UseVisualStyleBackColor = true;
            this.btnDodajMentorstvo.Click += new System.EventHandler(this.btnDodajMentorstvo_Click);
            // 
            // frmShowMentorstva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 526);
            this.Controls.Add(this.btnDodajMentorstvo);
            this.Controls.Add(this.dgvMentorstva);
            this.Name = "frmShowMentorstva";
            this.Text = "frmShowMentorstva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmShowMentorstva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMentorstva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMentorstvoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMentorstva;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPocetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumZavrsetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uplataIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivKlijentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mMentorstvoBindingSource;
        private System.Windows.Forms.Button btnDodajMentorstvo;
    }
}