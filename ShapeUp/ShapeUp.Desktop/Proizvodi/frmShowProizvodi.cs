using ShapeUp.Model;
using ShapeUp.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeUp.Desktop.Proizvodi
{
    public partial class frmShowProizvodi : Form
    {
        private APIService _proizvodiService = new APIService("Proizvodi");
        private APIService _kategService = new APIService("KategProizvoda");
        ProizvodiSearchObject search = new ProizvodiSearchObject();
        List<MKategorijaProizvodum> _kategorije = new List<MKategorijaProizvodum>();
        public frmShowProizvodi(List<MKategorijaProizvodum> kategorije = null)
        {
            InitializeComponent();
            _kategorije = kategorije;
        }

        private void frmShowProizvodi_Load(object sender, EventArgs e)
        {
            LoadKategorije();
            LoadProizvodi();
        }

        private async void LoadKategorije()
        {
            try
            {
                _kategorije = await _kategService.Get<List<MKategorijaProizvodum>>(null);

                foreach (var item in _kategorije)
                {
                    item.Naziv = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item.Naziv.ToLower());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            cmbKategorijeProizvoda.DataSource = _kategorije;
            cmbKategorijeProizvoda.DisplayMember = "naziv";
            cmbKategorijeProizvoda.ValueMember = "id";
        }

        private async void LoadProizvodi(ProizvodiSearchObject search = null)
        {
            try
            {
                List<MProizvodi> proizvodi = await _proizvodiService.Get<List<MProizvodi>>(search);
                proizvodi.AsQueryable();
                
                if (_kategorije != null)
                {
                    foreach (var item in proizvodi)
                    {
                        var kategorija = _kategorije.Where(x => x.Id == item.KategorijaProizvodaId).SingleOrDefault();
                        item.KategorijaProizvoda = kategorija.Naziv;
                    }
                }

                dgvProizvodi.DataSource = proizvodi;
            }
            catch (Exception ex)
            {
                throw ex;
            }   
        }

        private void btnOcistiFiltere_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;
            cmbKategorijeProizvoda.SelectedIndex = 0;
            LoadProizvodi();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search.Naziv = txtSearch.Text;
            LoadProizvodi(search);
        }

        private void cmbKategorijeProizvoda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            search.KategorijaProizvodaId = Int32.Parse(cmbKategorijeProizvoda.SelectedValue.ToString());
            LoadProizvodi(search);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmCRUDProizvod frm = new frmCRUDProizvod(_kategorije, null);
            frm.MdiParent = this.ParentForm;

            this.Close();
            frm.Show();
        }

        private void dgvProizvodi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MProizvodi proizvod = dgvProizvodi.SelectedRows[0].DataBoundItem as MProizvodi;

            frmCRUDProizvod frm = new frmCRUDProizvod(_kategorije, proizvod);
            frm.MdiParent = this.ParentForm;

            this.Close();
            frm.Show();
        }
    }
}
