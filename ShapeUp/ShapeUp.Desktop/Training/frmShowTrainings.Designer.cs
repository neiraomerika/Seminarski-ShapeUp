
namespace ShapeUp.Desktop.Training
{
    partial class frmShowTrainings
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
            this.dgvTrainings = new System.Windows.Forms.DataGridView();
            this.cmbTCateg = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.mTreningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciljIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaTreningaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTreningBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrainings
            // 
            this.dgvTrainings.AllowUserToAddRows = false;
            this.dgvTrainings.AutoGenerateColumns = false;
            this.dgvTrainings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.slikaDataGridViewTextBoxColumn,
            this.videoUrlDataGridViewTextBoxColumn,
            this.ciljIdDataGridViewTextBoxColumn,
            this.kategorijaTreningaIdDataGridViewTextBoxColumn});
            this.dgvTrainings.DataSource = this.mTreningBindingSource;
            this.dgvTrainings.Location = new System.Drawing.Point(13, 47);
            this.dgvTrainings.Name = "dgvTrainings";
            this.dgvTrainings.Size = new System.Drawing.Size(643, 303);
            this.dgvTrainings.TabIndex = 0;
            // 
            // cmbTCateg
            // 
            this.cmbTCateg.FormattingEnabled = true;
            this.cmbTCateg.Location = new System.Drawing.Point(315, 10);
            this.cmbTCateg.Name = "cmbTCateg";
            this.cmbTCateg.Size = new System.Drawing.Size(180, 21);
            this.cmbTCateg.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(287, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(510, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // mTreningBindingSource
            // 
            this.mTreningBindingSource.DataSource = typeof(ShapeUp.Model.Models.MTrening);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // slikaDataGridViewTextBoxColumn
            // 
            this.slikaDataGridViewTextBoxColumn.DataPropertyName = "Slika";
            this.slikaDataGridViewTextBoxColumn.HeaderText = "Slika";
            this.slikaDataGridViewTextBoxColumn.Name = "slikaDataGridViewTextBoxColumn";
            // 
            // videoUrlDataGridViewTextBoxColumn
            // 
            this.videoUrlDataGridViewTextBoxColumn.DataPropertyName = "VideoUrl";
            this.videoUrlDataGridViewTextBoxColumn.HeaderText = "VideoUrl";
            this.videoUrlDataGridViewTextBoxColumn.Name = "videoUrlDataGridViewTextBoxColumn";
            // 
            // ciljIdDataGridViewTextBoxColumn
            // 
            this.ciljIdDataGridViewTextBoxColumn.DataPropertyName = "CiljId";
            this.ciljIdDataGridViewTextBoxColumn.HeaderText = "Cilj";
            this.ciljIdDataGridViewTextBoxColumn.Name = "ciljIdDataGridViewTextBoxColumn";
            // 
            // kategorijaTreningaIdDataGridViewTextBoxColumn
            // 
            this.kategorijaTreningaIdDataGridViewTextBoxColumn.DataPropertyName = "KategorijaTreningaId";
            this.kategorijaTreningaIdDataGridViewTextBoxColumn.HeaderText = "Kategorija Treninga";
            this.kategorijaTreningaIdDataGridViewTextBoxColumn.Name = "kategorijaTreningaIdDataGridViewTextBoxColumn";
            // 
            // frmShowTrainings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 362);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbTCateg);
            this.Controls.Add(this.dgvTrainings);
            this.Name = "frmShowTrainings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ShowTrainings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmShowTrainings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTreningBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrainings;
        private System.Windows.Forms.ComboBox cmbTCateg;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource mTreningBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciljIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaTreningaIdDataGridViewTextBoxColumn;
    }
}