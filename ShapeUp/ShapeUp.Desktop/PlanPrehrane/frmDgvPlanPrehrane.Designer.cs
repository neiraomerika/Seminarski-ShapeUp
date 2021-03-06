
namespace ShapeUp.Desktop.PlanPrehrane
{
    partial class frmDgvPlanPrehrane
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
            this.dgvPlanPrehrane = new System.Windows.Forms.DataGridView();
            this.mPlanPrehraneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nutritivneVrijednostiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciljIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanPrehrane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPlanPrehraneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(17, 39);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(221, 17);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Dupli klik selektuje plan prehrane:";
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
            this.dgvPlanPrehrane.Location = new System.Drawing.Point(17, 63);
            this.dgvPlanPrehrane.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPlanPrehrane.Name = "dgvPlanPrehrane";
            this.dgvPlanPrehrane.ReadOnly = true;
            this.dgvPlanPrehrane.RowHeadersWidth = 51;
            this.dgvPlanPrehrane.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanPrehrane.Size = new System.Drawing.Size(1033, 452);
            this.dgvPlanPrehrane.TabIndex = 2;
            this.dgvPlanPrehrane.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPlanPrehrane_MouseDoubleClick);
            // 
            // mPlanPrehraneBindingSource
            // 
            this.mPlanPrehraneBindingSource.DataSource = typeof(ShapeUp.Model.Models.MPlanPrehrane);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 48;
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
            this.nutritivneVrijednostiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nutritivneVrijednostiDataGridViewTextBoxColumn.DataPropertyName = "NutritivneVrijednosti";
            this.nutritivneVrijednostiDataGridViewTextBoxColumn.HeaderText = "NutritivneVrijednosti";
            this.nutritivneVrijednostiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nutritivneVrijednostiDataGridViewTextBoxColumn.Name = "nutritivneVrijednostiDataGridViewTextBoxColumn";
            this.nutritivneVrijednostiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciljIdDataGridViewTextBoxColumn
            // 
            this.ciljIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ciljIdDataGridViewTextBoxColumn.DataPropertyName = "CiljId";
            this.ciljIdDataGridViewTextBoxColumn.HeaderText = "CiljId";
            this.ciljIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ciljIdDataGridViewTextBoxColumn.Name = "ciljIdDataGridViewTextBoxColumn";
            this.ciljIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ciljIdDataGridViewTextBoxColumn.Width = 66;
            // 
            // frmDgvPlanPrehrane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 528);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvPlanPrehrane);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDgvPlanPrehrane";
            this.Text = "frmDgvPlanPrehrane";
            this.Load += new System.EventHandler(this.frmDgvPlanPrehrane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanPrehrane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPlanPrehraneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dgvPlanPrehrane;
        private System.Windows.Forms.BindingSource mPlanPrehraneBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nutritivneVrijednostiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciljIdDataGridViewTextBoxColumn;
    }
}