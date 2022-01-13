
namespace ShapeUp.Desktop
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.treninziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziSveTreningeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviTreningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziSveKorisnikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.treninziToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(765, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // treninziToolStripMenuItem
            // 
            this.treninziToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziSveTreningeToolStripMenuItem,
            this.dodajNoviTreningToolStripMenuItem});
            this.treninziToolStripMenuItem.Name = "treninziToolStripMenuItem";
            this.treninziToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.treninziToolStripMenuItem.Text = "Treninzi";
            // 
            // prikaziSveTreningeToolStripMenuItem
            // 
            this.prikaziSveTreningeToolStripMenuItem.Name = "prikaziSveTreningeToolStripMenuItem";
            this.prikaziSveTreningeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prikaziSveTreningeToolStripMenuItem.Text = "Prikazi sve treninge";
            this.prikaziSveTreningeToolStripMenuItem.Click += new System.EventHandler(this.prikaziSveTreningeToolStripMenuItem_Click);
            // 
            // dodajNoviTreningToolStripMenuItem
            // 
            this.dodajNoviTreningToolStripMenuItem.Name = "dodajNoviTreningToolStripMenuItem";
            this.dodajNoviTreningToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajNoviTreningToolStripMenuItem.Text = "Dodaj novi trening";
            this.dodajNoviTreningToolStripMenuItem.Click += new System.EventHandler(this.dodajNoviTreningToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(765, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziSveKorisnikeToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // prikaziSveKorisnikeToolStripMenuItem
            // 
            this.prikaziSveKorisnikeToolStripMenuItem.Name = "prikaziSveKorisnikeToolStripMenuItem";
            this.prikaziSveKorisnikeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prikaziSveKorisnikeToolStripMenuItem.Text = "Prikazi sve korisnike";
            this.prikaziSveKorisnikeToolStripMenuItem.Click += new System.EventHandler(this.prikaziSveKorisnikeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(765, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem treninziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziSveTreningeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviTreningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziSveKorisnikeToolStripMenuItem;
    }
}



