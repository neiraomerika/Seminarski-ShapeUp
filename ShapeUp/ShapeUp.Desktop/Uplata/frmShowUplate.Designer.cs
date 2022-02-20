
namespace ShapeUp.Desktop.Uplata
{
    partial class frmShowUplate
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
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.mPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mPaymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mPaymentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdFormattedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBrojUplata = new System.Windows.Forms.Label();
            this.lblUkupnoUplaceno = new System.Windows.Forms.Label();
            this.txtUplate = new System.Windows.Forms.TextBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPaymentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPaymentBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.AutoGenerateColumns = false;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.createdFormattedDataGridViewTextBoxColumn});
            this.dgvPayment.DataSource = this.mPaymentBindingSource;
            this.dgvPayment.Location = new System.Drawing.Point(13, 84);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            this.dgvPayment.Size = new System.Drawing.Size(882, 429);
            this.dgvPayment.TabIndex = 0;
            // 
            // mPaymentBindingSource
            // 
            this.mPaymentBindingSource.DataSource = typeof(ShapeUp.Model.Models.MPayment);
            // 
            // mPaymentBindingSource1
            // 
            this.mPaymentBindingSource1.DataSource = typeof(ShapeUp.Model.Models.MPayment);
            // 
            // mPaymentBindingSource2
            // 
            this.mPaymentBindingSource2.DataSource = typeof(ShapeUp.Model.Models.MPayment);
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
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Iznos";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdFormattedDataGridViewTextBoxColumn
            // 
            this.createdFormattedDataGridViewTextBoxColumn.DataPropertyName = "CreatedFormatted";
            this.createdFormattedDataGridViewTextBoxColumn.HeaderText = "Uplaceno";
            this.createdFormattedDataGridViewTextBoxColumn.Name = "createdFormattedDataGridViewTextBoxColumn";
            this.createdFormattedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lblBrojUplata
            // 
            this.lblBrojUplata.AutoSize = true;
            this.lblBrojUplata.Location = new System.Drawing.Point(13, 13);
            this.lblBrojUplata.Name = "lblBrojUplata";
            this.lblBrojUplata.Size = new System.Drawing.Size(83, 13);
            this.lblBrojUplata.TabIndex = 1;
            this.lblBrojUplata.Text = "Ukupno uplata: ";
            // 
            // lblUkupnoUplaceno
            // 
            this.lblUkupnoUplaceno.AutoSize = true;
            this.lblUkupnoUplaceno.Location = new System.Drawing.Point(13, 45);
            this.lblUkupnoUplaceno.Name = "lblUkupnoUplaceno";
            this.lblUkupnoUplaceno.Size = new System.Drawing.Size(95, 13);
            this.lblUkupnoUplaceno.TabIndex = 2;
            this.lblUkupnoUplaceno.Text = "Ukupno uplaceno:";
            // 
            // txtUplate
            // 
            this.txtUplate.Location = new System.Drawing.Point(103, 13);
            this.txtUplate.Name = "txtUplate";
            this.txtUplate.Size = new System.Drawing.Size(100, 20);
            this.txtUplate.TabIndex = 3;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(115, 45);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(100, 20);
            this.txtIznos.TabIndex = 4;
            // 
            // frmShowUplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 525);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.txtUplate);
            this.Controls.Add(this.lblUkupnoUplaceno);
            this.Controls.Add(this.lblBrojUplata);
            this.Controls.Add(this.dgvPayment);
            this.Name = "frmShowUplate";
            this.Text = "frmShowUplate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmShowUplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPaymentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPaymentBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.BindingSource mPaymentBindingSource;
        private System.Windows.Forms.BindingSource mPaymentBindingSource2;
        private System.Windows.Forms.BindingSource mPaymentBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdFormattedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblBrojUplata;
        private System.Windows.Forms.Label lblUkupnoUplaceno;
        private System.Windows.Forms.TextBox txtUplate;
        private System.Windows.Forms.TextBox txtIznos;
    }
}