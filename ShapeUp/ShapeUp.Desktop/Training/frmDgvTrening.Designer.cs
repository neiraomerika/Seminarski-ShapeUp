
namespace ShapeUp.Desktop.Training
{
    partial class frmDgvTrening
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
            this.dgvTreninzi = new System.Windows.Forms.DataGridView();
            this.mTreningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciljIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaTreningaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTreningBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTreninzi
            // 
            this.dgvTreninzi.AllowUserToAddRows = false;
            this.dgvTreninzi.AllowUserToDeleteRows = false;
            this.dgvTreninzi.AutoGenerateColumns = false;
            this.dgvTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreninzi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.ciljIdDataGridViewTextBoxColumn,
            this.kategorijaTreningaIdDataGridViewTextBoxColumn});
            this.dgvTreninzi.DataSource = this.mTreningBindingSource;
            this.dgvTreninzi.Location = new System.Drawing.Point(13, 71);
            this.dgvTreninzi.Name = "dgvTreninzi";
            this.dgvTreninzi.ReadOnly = true;
            this.dgvTreninzi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreninzi.Size = new System.Drawing.Size(775, 367);
            this.dgvTreninzi.TabIndex = 0;
            this.dgvTreninzi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTreninzi_MouseDoubleClick);
            // 
            // mTreningBindingSource
            // 
            this.mTreningBindingSource.DataSource = typeof(ShapeUp.Model.Models.MTrening);
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
            // ciljIdDataGridViewTextBoxColumn
            // 
            this.ciljIdDataGridViewTextBoxColumn.DataPropertyName = "CiljId";
            this.ciljIdDataGridViewTextBoxColumn.HeaderText = "CiljId";
            this.ciljIdDataGridViewTextBoxColumn.Name = "ciljIdDataGridViewTextBoxColumn";
            this.ciljIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategorijaTreningaIdDataGridViewTextBoxColumn
            // 
            this.kategorijaTreningaIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.kategorijaTreningaIdDataGridViewTextBoxColumn.DataPropertyName = "KategorijaTreningaId";
            this.kategorijaTreningaIdDataGridViewTextBoxColumn.HeaderText = "KategorijaTreningaId";
            this.kategorijaTreningaIdDataGridViewTextBoxColumn.Name = "kategorijaTreningaIdDataGridViewTextBoxColumn";
            this.kategorijaTreningaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.kategorijaTreningaIdDataGridViewTextBoxColumn.Width = 130;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(13, 52);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(133, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Dupli klik selektuje trening:";
            // 
            // frmDgvTrening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvTreninzi);
            this.Name = "frmDgvTrening";
            this.Text = "frmDgvTrening";
            this.Load += new System.EventHandler(this.frmDgvTrening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTreningBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTreninzi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciljIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaTreningaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mTreningBindingSource;
        private System.Windows.Forms.Label lblInfo;
    }
}