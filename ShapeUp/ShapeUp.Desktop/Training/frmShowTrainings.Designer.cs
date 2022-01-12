
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTrainings = new System.Windows.Forms.DataGridView();
            this.cmbTCateg = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.mTreningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvTrainings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrainings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Slika,
            this.opisDataGridViewTextBoxColumn,
            this.videoUrlDataGridViewTextBoxColumn,
            this.ciljIdDataGridViewTextBoxColumn,
            this.kategorijaTreningaIdDataGridViewTextBoxColumn});
            this.dgvTrainings.Location = new System.Drawing.Point(13, 47);
            this.dgvTrainings.Name = "dgvTrainings";
            this.dgvTrainings.ReadOnly = true;
            this.dgvTrainings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrainings.Size = new System.Drawing.Size(643, 303);
            this.dgvTrainings.TabIndex = 0;
            this.dgvTrainings.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTrainings_MouseDoubleClick);
            // 
            // cmbTCateg
            // 
            this.cmbTCateg.FormattingEnabled = true;
            this.cmbTCateg.Location = new System.Drawing.Point(13, 10);
            this.cmbTCateg.Name = "cmbTCateg";
            this.cmbTCateg.Size = new System.Drawing.Size(180, 21);
            this.cmbTCateg.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(199, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Pretrazi";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(340, 9);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(135, 23);
            this.btnClearSearch.TabIndex = 4;
            this.btnClearSearch.Text = "Ocisti Filtere";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // mTreningBindingSource
            // 
            this.mTreningBindingSource.DataSource = typeof(ShapeUp.Model.Models.MTrening);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle2.NullValue = "byte[0]";
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Visible = false;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // videoUrlDataGridViewTextBoxColumn
            // 
            this.videoUrlDataGridViewTextBoxColumn.DataPropertyName = "VideoUrl";
            this.videoUrlDataGridViewTextBoxColumn.HeaderText = "VideoUrl";
            this.videoUrlDataGridViewTextBoxColumn.Name = "videoUrlDataGridViewTextBoxColumn";
            this.videoUrlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciljIdDataGridViewTextBoxColumn
            // 
            this.ciljIdDataGridViewTextBoxColumn.DataPropertyName = "CiljId";
            this.ciljIdDataGridViewTextBoxColumn.HeaderText = "Cilj";
            this.ciljIdDataGridViewTextBoxColumn.Name = "ciljIdDataGridViewTextBoxColumn";
            this.ciljIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategorijaTreningaIdDataGridViewTextBoxColumn
            // 
            this.kategorijaTreningaIdDataGridViewTextBoxColumn.DataPropertyName = "KategorijaTreningaId";
            this.kategorijaTreningaIdDataGridViewTextBoxColumn.HeaderText = "Kategorija Treninga";
            this.kategorijaTreningaIdDataGridViewTextBoxColumn.Name = "kategorijaTreningaIdDataGridViewTextBoxColumn";
            this.kategorijaTreningaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmShowTrainings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(669, 362);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnSearch);
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

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrainings;
        private System.Windows.Forms.ComboBox cmbTCateg;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.BindingSource mTreningBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciljIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaTreningaIdDataGridViewTextBoxColumn;
    }
}