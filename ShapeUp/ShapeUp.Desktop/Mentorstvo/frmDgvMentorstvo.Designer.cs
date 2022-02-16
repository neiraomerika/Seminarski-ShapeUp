
namespace ShapeUp.Desktop.Mentorstvo
{
    partial class frmDgvMentorstvo
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.mMentorstvoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMentorstvoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMentorstvo = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPocetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumZavrsetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uplataIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mMentorstvoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mMentorstvoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMentorstvoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMentorstvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMentorstvoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(13, 32);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(153, 13);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Dupli klik selektuje mentorstvo:";
            // 
            // mMentorstvoBindingSource
            // 
            this.mMentorstvoBindingSource.DataSource = typeof(ShapeUp.Model.Models.MMentorstvo);
            // 
            // mMentorstvoBindingSource1
            // 
            this.mMentorstvoBindingSource1.DataSource = typeof(ShapeUp.Model.Models.MMentorstvo);
            // 
            // dgvMentorstvo
            // 
            this.dgvMentorstvo.AllowUserToAddRows = false;
            this.dgvMentorstvo.AllowUserToDeleteRows = false;
            this.dgvMentorstvo.AutoGenerateColumns = false;
            this.dgvMentorstvo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMentorstvo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.datumPocetkaDataGridViewTextBoxColumn,
            this.datumZavrsetkaDataGridViewTextBoxColumn,
            this.uplataIdDataGridViewTextBoxColumn});
            this.dgvMentorstvo.DataSource = this.mMentorstvoBindingSource2;
            this.dgvMentorstvo.Location = new System.Drawing.Point(13, 62);
            this.dgvMentorstvo.Name = "dgvMentorstvo";
            this.dgvMentorstvo.ReadOnly = true;
            this.dgvMentorstvo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMentorstvo.Size = new System.Drawing.Size(590, 359);
            this.dgvMentorstvo.TabIndex = 4;
            this.dgvMentorstvo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMentorstvo_MouseDoubleClick_1);
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
            // mMentorstvoBindingSource2
            // 
            this.mMentorstvoBindingSource2.DataSource = typeof(ShapeUp.Model.Models.MMentorstvo);
            // 
            // frmDgvMentorstvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 433);
            this.Controls.Add(this.dgvMentorstvo);
            this.Controls.Add(this.lblInfo);
            this.Name = "frmDgvMentorstvo";
            this.Text = "frmDgvMentorstvo";
            this.Load += new System.EventHandler(this.frmDgvMentorstvo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mMentorstvoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMentorstvoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMentorstvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMentorstvoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mMentorstvoBindingSource;
        private System.Windows.Forms.BindingSource mMentorstvoBindingSource1;
        private System.Windows.Forms.DataGridView dgvMentorstvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPocetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumZavrsetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uplataIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mMentorstvoBindingSource2;
    }
}