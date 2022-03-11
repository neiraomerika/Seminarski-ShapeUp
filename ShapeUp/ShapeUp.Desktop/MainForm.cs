using ShapeUp.Desktop.PlanPrehrane;
using ShapeUp.Desktop.Proizvodi;
using ShapeUp.Desktop.Recenzija;
using ShapeUp.Desktop.Training;
using ShapeUp.Desktop.Uplata;
using ShapeUp.Desktop.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeUp.Desktop
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void prikaziSveKorisnikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUsers frm = new frmShowUsers();
            frm.MdiParent = this;
            frm.Text = "Korisnici";

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frm.Show();
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajKlijenta frm = new frmDodajKlijenta();
            frm.MdiParent = this;
            frm.Text = "Dodaj Klijenta";

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frm.Show();
        }

        private void prikaziSveTreningeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowTrainings frm = new frmShowTrainings();
            frm.MdiParent = this;
            frm.Text = "Treninzi";

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frm.Show();
        }

        private void dodajTreningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDTraining frm = new frmCRUDTraining();
            frm.MdiParent = this;
            frm.Text = "Trening";

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frm.Show();
        }

        private void prikaziSveObrokeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPlanPrehrane frm = new frmShowPlanPrehrane();
            frm.MdiParent = this;
            frm.Text = "Obroci";

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frm.Show();
        }

        private void dodajObrokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDPlanPrehrane frm = new frmCRUDPlanPrehrane();
            frm.MdiParent = this;
            frm.Text = "Obrok";

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frm.Show();
        }

        private void prikaziSveRecenzijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowRecenzije frm = new frmShowRecenzije();
            frm.MdiParent = this;
            frm.Text = "Recenzije";

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frm.Show();
        }

        private void dodajRecenzijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDRecenzija frm = new frmCRUDRecenzija();
            frm.MdiParent = this;
            frm.Text = "Recenzija";

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frm.Show();
        }

        private void prikaziSveUplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUplate frm = new frmShowUplate();
            frm.MdiParent = this;
            frm.Text = "Uplate";

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frm.Show();
        }

        private void prikaziSveProizvodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowProizvodi frm = new frmShowProizvodi();
            frm.MdiParent = this;
            frm.Text = "Proizvodi";

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frm.Show();
        }

        private void dodajProizvodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDProizvod frm = new frmCRUDProizvod();
            frm.MdiParent = this;
            frm.Text = "Proizvod";

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frm.Show();
        }
    }
}
