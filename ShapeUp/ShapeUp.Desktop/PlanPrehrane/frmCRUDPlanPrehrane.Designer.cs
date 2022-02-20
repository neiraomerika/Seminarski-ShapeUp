namespace ShapeUp.Desktop.PlanPrehrane
{
    partial class frmCRUDPlanPrehrane
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblPicture = new System.Windows.Forms.Label();
            this.ofdLoadPicture = new System.Windows.Forms.OpenFileDialog();
            this.sfdPicture = new System.Windows.Forms.SaveFileDialog();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbPlanPrehranePicture = new System.Windows.Forms.PictureBox();
            this.lblNutritivnaVrijednost = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.txtNutritivnaDesc = new System.Windows.Forms.TextBox();
            this.cmbGoal = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanPrehranePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 206);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(37, 17);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Opis";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(13, 237);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(286, 183);
            this.txtDesc.TabIndex = 1;
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Location = new System.Drawing.Point(12, 19);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(38, 17);
            this.lblPicture.TabIndex = 2;
            this.lblPicture.Text = "Slika";
            // 
            // ofdLoadPicture
            // 
            this.ofdLoadPicture.FileName = "SlikaPrehrane";
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // pbPlanPrehranePicture
            // 
            this.pbPlanPrehranePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPlanPrehranePicture.Image = global::ShapeUp.Desktop.Properties.Resources.upload;
            this.pbPlanPrehranePicture.InitialImage = global::ShapeUp.Desktop.Properties.Resources.upload;
            this.pbPlanPrehranePicture.Location = new System.Drawing.Point(15, 49);
            this.pbPlanPrehranePicture.Name = "pbPlanPrehranePicture";
            this.pbPlanPrehranePicture.Size = new System.Drawing.Size(284, 141);
            this.pbPlanPrehranePicture.TabIndex = 3;
            this.pbPlanPrehranePicture.TabStop = false;
            this.pbPlanPrehranePicture.Click += new System.EventHandler(this.pbPlanPrehranePicture_Click);
            // 
            // lblNutritivnaVrijednost
            // 
            this.lblNutritivnaVrijednost.AutoSize = true;
            this.lblNutritivnaVrijednost.Location = new System.Drawing.Point(397, 19);
            this.lblNutritivnaVrijednost.Name = "lblNutritivnaVrijednost";
            this.lblNutritivnaVrijednost.Size = new System.Drawing.Size(137, 17);
            this.lblNutritivnaVrijednost.TabIndex = 4;
            this.lblNutritivnaVrijednost.Text = "Nutritivna vrijednost:";
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Location = new System.Drawing.Point(397, 206);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(26, 17);
            this.lblGoal.TabIndex = 5;
            this.lblGoal.Text = "Cilj";
            // 
            // txtNutritivnaDesc
            // 
            this.txtNutritivnaDesc.Location = new System.Drawing.Point(400, 49);
            this.txtNutritivnaDesc.Multiline = true;
            this.txtNutritivnaDesc.Name = "txtNutritivnaDesc";
            this.txtNutritivnaDesc.Size = new System.Drawing.Size(286, 141);
            this.txtNutritivnaDesc.TabIndex = 6;
            // 
            // cmbGoal
            // 
            this.cmbGoal.FormattingEnabled = true;
            this.cmbGoal.Location = new System.Drawing.Point(400, 237);
            this.cmbGoal.Name = "cmbGoal";
            this.cmbGoal.Size = new System.Drawing.Size(286, 24);
            this.cmbGoal.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(417, 382);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 38);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Obrisi";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(558, 382);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 38);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Spasi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmCRUDPlanPrehrane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbGoal);
            this.Controls.Add(this.txtNutritivnaDesc);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.lblNutritivnaVrijednost);
            this.Controls.Add(this.pbPlanPrehranePicture);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDescription);
            this.Name = "frmCRUDPlanPrehrane";
            this.Text = "frmCRUDPlanPrehrane";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCRUDPlanPrehrane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanPrehranePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.PictureBox pbPlanPrehranePicture;
        private System.Windows.Forms.OpenFileDialog ofdLoadPicture;
        private System.Windows.Forms.SaveFileDialog sfdPicture;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblNutritivnaVrijednost;
        private System.Windows.Forms.TextBox txtNutritivnaDesc;
        private System.Windows.Forms.ComboBox cmbGoal;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}