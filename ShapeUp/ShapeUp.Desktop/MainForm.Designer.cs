
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treninziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planPrehraneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recenzijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziSveKorisnikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziSveTreningeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajTreningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziSveObrokeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajObrokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziSveRecenzijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajRecenzijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.treninziToolStripMenuItem,
            this.planPrehraneToolStripMenuItem,
            this.recenzijaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(862, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziSveKorisnikeToolStripMenuItem,
            this.dodajKorisnikaToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // treninziToolStripMenuItem
            // 
            this.treninziToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziSveTreningeToolStripMenuItem,
            this.dodajTreningToolStripMenuItem});
            this.treninziToolStripMenuItem.Name = "treninziToolStripMenuItem";
            this.treninziToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.treninziToolStripMenuItem.Text = "Treninzi";
            // 
            // planPrehraneToolStripMenuItem
            // 
            this.planPrehraneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziSveObrokeToolStripMenuItem,
            this.dodajObrokToolStripMenuItem});
            this.planPrehraneToolStripMenuItem.Name = "planPrehraneToolStripMenuItem";
            this.planPrehraneToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.planPrehraneToolStripMenuItem.Text = "Obroci";
            // 
            // recenzijaToolStripMenuItem
            // 
            this.recenzijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziSveRecenzijeToolStripMenuItem,
            this.dodajRecenzijuToolStripMenuItem});
            this.recenzijaToolStripMenuItem.Name = "recenzijaToolStripMenuItem";
            this.recenzijaToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.recenzijaToolStripMenuItem.Text = "Recenzija";
            // 
            // prikaziSveKorisnikeToolStripMenuItem
            // 
            this.prikaziSveKorisnikeToolStripMenuItem.Name = "prikaziSveKorisnikeToolStripMenuItem";
            this.prikaziSveKorisnikeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prikaziSveKorisnikeToolStripMenuItem.Text = "Prikazi sve korisnike";
            this.prikaziSveKorisnikeToolStripMenuItem.Click += new System.EventHandler(this.prikaziSveKorisnikeToolStripMenuItem_Click);
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajKorisnikaToolStripMenuItem_Click);
            // 
            // prikaziSveTreningeToolStripMenuItem
            // 
            this.prikaziSveTreningeToolStripMenuItem.Name = "prikaziSveTreningeToolStripMenuItem";
            this.prikaziSveTreningeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prikaziSveTreningeToolStripMenuItem.Text = "Prikazi sve treninge";
            this.prikaziSveTreningeToolStripMenuItem.Click += new System.EventHandler(this.prikaziSveTreningeToolStripMenuItem_Click);
            // 
            // dodajTreningToolStripMenuItem
            // 
            this.dodajTreningToolStripMenuItem.Name = "dodajTreningToolStripMenuItem";
            this.dodajTreningToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajTreningToolStripMenuItem.Text = "Dodaj trening";
            this.dodajTreningToolStripMenuItem.Click += new System.EventHandler(this.dodajTreningToolStripMenuItem_Click);
            // 
            // prikaziSveObrokeToolStripMenuItem
            // 
            this.prikaziSveObrokeToolStripMenuItem.Name = "prikaziSveObrokeToolStripMenuItem";
            this.prikaziSveObrokeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prikaziSveObrokeToolStripMenuItem.Text = "Prikazi sve obroke";
            this.prikaziSveObrokeToolStripMenuItem.Click += new System.EventHandler(this.prikaziSveObrokeToolStripMenuItem_Click);
            // 
            // dodajObrokToolStripMenuItem
            // 
            this.dodajObrokToolStripMenuItem.Name = "dodajObrokToolStripMenuItem";
            this.dodajObrokToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajObrokToolStripMenuItem.Text = "Dodaj obrok";
            this.dodajObrokToolStripMenuItem.Click += new System.EventHandler(this.dodajObrokToolStripMenuItem_Click);
            // 
            // prikaziSveRecenzijeToolStripMenuItem
            // 
            this.prikaziSveRecenzijeToolStripMenuItem.Name = "prikaziSveRecenzijeToolStripMenuItem";
            this.prikaziSveRecenzijeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prikaziSveRecenzijeToolStripMenuItem.Text = "Prikazi sve recenzije";
            this.prikaziSveRecenzijeToolStripMenuItem.Click += new System.EventHandler(this.prikaziSveRecenzijeToolStripMenuItem_Click);
            // 
            // dodajRecenzijuToolStripMenuItem
            // 
            this.dodajRecenzijuToolStripMenuItem.Name = "dodajRecenzijuToolStripMenuItem";
            this.dodajRecenzijuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajRecenzijuToolStripMenuItem.Text = "Dodaj recenziju";
            this.dodajRecenzijuToolStripMenuItem.Click += new System.EventHandler(this.dodajRecenzijuToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 648);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziSveKorisnikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treninziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziSveTreningeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajTreningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planPrehraneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziSveObrokeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajObrokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recenzijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziSveRecenzijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajRecenzijuToolStripMenuItem;
    }
}



