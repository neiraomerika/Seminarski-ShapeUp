using ShapeUp.Desktop.Helpers;
using ShapeUp.Model.Models;
using ShapeUp.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Windows.Forms;

namespace ShapeUp.Desktop.Recenzija
{
    public partial class frmShowRecenzije : Form
    {
        private readonly APIService _recenzijaService = new APIService("Recenzija");

        public frmShowRecenzije()
        {
            InitializeComponent();
        }

        private void frmShowRecenzije_Load(object sender, EventArgs e)
        {
            loadRecenzije(null);

            for (int i = 1; i <= 5; i++)
            {
                cmbOcjena.Items.Add(new SelectListItem()
                { 
                    Text = i.ToString(),
                    Value = i.ToString()
                });
            }

            cmbOcjena.SelectedIndex = 0;
            cmbOcjena.DisplayMember = "text";
            cmbOcjena.ValueMember = "value";
        }

        private async void loadRecenzije(RecenzijaSearchObject search)
        {
            try
            {
                dgvRecenzija.DataSource = await _recenzijaService.Get<List<MRecenzija>>(search);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            cmbOcjena.SelectedIndex = 0;
            loadRecenzije(null);
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            try
            {
                RecenzijaSearchObject search = new RecenzijaSearchObject();
                search.Ocjena = Int32.Parse(((SelectListItem)cmbOcjena.SelectedItem).Value);
                loadRecenzije(search);
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmCRUDRecenzija frm = new frmCRUDRecenzija(null);
            frm.MdiParent = this.ParentForm;
            this.Close();
            frm.Show();
        }

        private void dgvRecenzija_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MRecenzija recenzija = dgvRecenzija.SelectedRows[0].DataBoundItem as MRecenzija;
            frmCRUDRecenzija frm = new frmCRUDRecenzija(recenzija);

            var parent = this.ParentForm;
            frm.MdiParent = parent;
            this.Close();

            frm.Show();
        }
    }
}
