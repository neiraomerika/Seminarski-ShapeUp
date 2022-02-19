namespace ShapeUp.Desktop.PlanPrehrane
{
    partial class frmShowPlanPrehrane
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
            this.dgvPlanPrehrane = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nutritivneVrijednostiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciljIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPlanPrehraneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanPrehrane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPlanPrehraneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlanPrehrane
            // 
            this.dgvPlanPrehrane.AllowUserToAddRows = false;
            this.dgvPlanPrehrane.AllowUserToDeleteRows = false;
            this.dgvPlanPrehrane.AutoGenerateColumns = false;
            this.dgvPlanPrehrane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanPrehrane.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.nutritivneVrijednostiDataGridViewTextBoxColumn,
            this.ciljIdDataGridViewTextBoxColumn});
            this.dgvPlanPrehrane.DataSource = this.mPlanPrehraneBindingSource;
            this.dgvPlanPrehrane.Location = new System.Drawing.Point(2, 12);
            this.dgvPlanPrehrane.Name = "dgvPlanPrehrane";
            this.dgvPlanPrehrane.ReadOnly = true;
            this.dgvPlanPrehrane.RowHeadersWidth = 51;
            this.dgvPlanPrehrane.RowTemplate.Height = 24;
            this.dgvPlanPrehrane.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanPrehrane.Size = new System.Drawing.Size(797, 348);
            this.dgvPlanPrehrane.TabIndex = 0;
            this.dgvPlanPrehrane.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPlanPrehrane_MouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nutritivneVrijednostiDataGridViewTextBoxColumn
            // 
            this.nutritivneVrijednostiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nutritivneVrijednostiDataGridViewTextBoxColumn.DataPropertyName = "NutritivneVrijednosti";
            this.nutritivneVrijednostiDataGridViewTextBoxColumn.HeaderText = "NutritivneVrijednosti";
            this.nutritivneVrijednostiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nutritivneVrijednostiDataGridViewTextBoxColumn.Name = "nutritivneVrijednostiDataGridViewTextBoxColumn";
            this.nutritivneVrijednostiDataGridViewTextBoxColumn.ReadOnly = true;
            this.nutritivneVrijednostiDataGridViewTextBoxColumn.Width = 163;
            // 
            // ciljIdDataGridViewTextBoxColumn
            // 
            this.ciljIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ciljIdDataGridViewTextBoxColumn.DataPropertyName = "CiljId";
            this.ciljIdDataGridViewTextBoxColumn.HeaderText = "CiljId";
            this.ciljIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ciljIdDataGridViewTextBoxColumn.Name = "ciljIdDataGridViewTextBoxColumn";
            this.ciljIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ciljIdDataGridViewTextBoxColumn.Width = 66;
            // 
            // mPlanPrehraneBindingSource
            // 
            this.mPlanPrehraneBindingSource.DataSource = typeof(ShapeUp.Model.Models.MPlanPrehrane);
            // 
            // frmShowPlanPrehrane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPlanPrehrane);
            this.Name = "frmShowPlanPrehrane";
            this.Text = "frmShowPlanPrehrane";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmShowPlanPrehrane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanPrehrane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPlanPrehraneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlanPrehrane;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nutritivneVrijednostiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciljIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mPlanPrehraneBindingSource;
    }
}