
namespace ShapeUp.Desktop.Training
{
    partial class frmCRUDTraining
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
            this.txtVideo = new System.Windows.Forms.TextBox();
            this.lblVideoUrl = new System.Windows.Forms.Label();
            this.cmbGoal = new System.Windows.Forms.ComboBox();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.ofdLoadPicture = new System.Windows.Forms.OpenFileDialog();
            this.pbTrainingPicture = new System.Windows.Forms.PictureBox();
            this.sfdPicture = new System.Windows.Forms.SaveFileDialog();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrainingPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDescription.Location = new System.Drawing.Point(14, 13);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(37, 17);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Opis";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDesc.Location = new System.Drawing.Point(57, 13);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(248, 209);
            this.txtDesc.TabIndex = 1;
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPicture.Location = new System.Drawing.Point(335, 13);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(38, 17);
            this.lblPicture.TabIndex = 2;
            this.lblPicture.Text = "Slika";
            // 
            // txtVideo
            // 
            this.txtVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVideo.Location = new System.Drawing.Point(414, 141);
            this.txtVideo.Name = "txtVideo";
            this.txtVideo.Size = new System.Drawing.Size(173, 23);
            this.txtVideo.TabIndex = 5;
            // 
            // lblVideoUrl
            // 
            this.lblVideoUrl.AutoSize = true;
            this.lblVideoUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVideoUrl.Location = new System.Drawing.Point(335, 144);
            this.lblVideoUrl.Name = "lblVideoUrl";
            this.lblVideoUrl.Size = new System.Drawing.Size(74, 17);
            this.lblVideoUrl.TabIndex = 4;
            this.lblVideoUrl.Text = "Video Link";
            // 
            // cmbGoal
            // 
            this.cmbGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbGoal.FormattingEnabled = true;
            this.cmbGoal.Location = new System.Drawing.Point(414, 168);
            this.cmbGoal.Name = "cmbGoal";
            this.cmbGoal.Size = new System.Drawing.Size(173, 24);
            this.cmbGoal.TabIndex = 6;
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGoal.Location = new System.Drawing.Point(335, 172);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(26, 17);
            this.lblGoal.TabIndex = 7;
            this.lblGoal.Text = "Cilj";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCategory.Location = new System.Drawing.Point(335, 200);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 17);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Kategorija";
            // 
            // cmbCategories
            // 
            this.cmbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(414, 196);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(173, 24);
            this.cmbCategories.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(414, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 31);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Spasi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ofdLoadPicture
            // 
            this.ofdLoadPicture.FileName = "SlikaTreninga";
            // 
            // pbTrainingPicture
            // 
            this.pbTrainingPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbTrainingPicture.Image = global::ShapeUp.Desktop.Properties.Resources.upload;
            this.pbTrainingPicture.InitialImage = global::ShapeUp.Desktop.Properties.Resources.upload;
            this.pbTrainingPicture.Location = new System.Drawing.Point(414, 13);
            this.pbTrainingPicture.Name = "pbTrainingPicture";
            this.pbTrainingPicture.Size = new System.Drawing.Size(173, 122);
            this.pbTrainingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrainingPicture.TabIndex = 12;
            this.pbTrainingPicture.TabStop = false;
            this.pbTrainingPicture.Click += new System.EventHandler(this.pbTrainingPicture_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(236, 243);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(173, 31);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Obrisi";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmCRUDTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 298);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pbTrainingPicture);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.cmbGoal);
            this.Controls.Add(this.txtVideo);
            this.Controls.Add(this.lblVideoUrl);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDescription);
            this.Name = "frmCRUDTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddTraining";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCRUDTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrainingPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.TextBox txtVideo;
        private System.Windows.Forms.Label lblVideoUrl;
        private System.Windows.Forms.ComboBox cmbGoal;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbTrainingPicture;
        private System.Windows.Forms.OpenFileDialog ofdLoadPicture;
        private System.Windows.Forms.SaveFileDialog sfdPicture;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Button btnDelete;
    }
}