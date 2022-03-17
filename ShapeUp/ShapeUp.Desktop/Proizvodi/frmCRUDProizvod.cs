using ShapeUp.Desktop.Helpers;
using ShapeUp.Helpers;
using ShapeUp.Model.Models;
using ShapeUp.Model.Request;
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
    public partial class frmCRUDProizvod : Form
    {
        public MProizvodi _proizvod;
        public List<MKategorijaProizvodum> _kategorije;
        private readonly APIService _kategorijaProizvoda = new APIService("KategProizvoda");
        private readonly APIService _proizvodService = new APIService("Proizvodi");
        private bool _isUpdate = false;
        private bool _feeldsEmpty = true;
        private MBoxHelper _mboxHelper = new MBoxHelper();

        public frmCRUDProizvod(List<MKategorijaProizvodum> kategorije = null, MProizvodi proizvod = null)
        {
            InitializeComponent();
            _proizvod = proizvod;
            _kategorije = kategorije;
            if (_proizvod == null)
            {
                lblProsjecnaOcjena.Visible = false;
                txtProsjecnaOcjena.Visible = false;
            }
        }

        private void frmCRUDProizvod_Load(object sender, EventArgs e)
        {
            if (_proizvod != null)
                BindData();
            if (_kategorije == null)
                LoadKategorije();
            else
            {
                cmbKategorije.DataSource = _kategorije;
                cmbKategorije.DisplayMember = "naziv";
                cmbKategorije.ValueMember = "id";
                if(_proizvod != null)
                    cmbKategorije.SelectedValue = _proizvod.KategorijaProizvodaId;
            }
        }

        private async void LoadKategorije()
        {
            try
            {
                _kategorije = await _kategorijaProizvoda.Get<List<MKategorijaProizvodum>>(null);

                foreach (var item in _kategorije)
                {
                    item.Naziv = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item.Naziv.ToLower());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            cmbKategorije.DataSource = _kategorije;
            cmbKategorije.DisplayMember = "naziv";
            cmbKategorije.ValueMember = "id";
        }

        private void BindData()
        {
            _isUpdate = true;

            txtNaziv.Text = _proizvod.Naziv;
            txtOpis.Text = _proizvod.Opis;
            txtProsjecnaOcjena.Text = _proizvod.ProsjecnaOcjena.ToString();
            txtCijena.Text = _proizvod.Cijena.ToString();
            if(_proizvod.Slika != null && _proizvod.Slika.Length > 0)
            {
                pbProizvod.Image = ImageHelper.FromByteToImage(_proizvod.Slika);
                pbProizvod.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pbProizvod.Image = ShapeUp.Desktop.Properties.Resources.no_image;
                pbProizvod.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            FeeldsNotEmpty();

            if (!_feeldsEmpty)
            {
                if (_isUpdate)
                {
                    ProizvodiUpdateRequest update = new ProizvodiUpdateRequest
                    {
                        Naziv = txtNaziv.Text,
                        Opis = txtOpis.Text,
                        Cijena = decimal.Parse(txtCijena.Text),
                        KategorijaProizvodaId = Int32.Parse(cmbKategorije.SelectedValue.ToString()),
                        ProsjecnaOcjena = decimal.Parse(txtProsjecnaOcjena.Text)
                    };

                    if (pbProizvod.Image != null)
                        update.Slika = ImageHelper.FromImageToByte(pbProizvod?.Image);

                    var result = _proizvodService.Update<ProizvodiUpdateRequest>(_proizvod.Id, update);

                    _mboxHelper.Inform("Uspjesno izmijenjen proizvod.");
                }
                else
                {
                    ProizvodiInsertRequest insert = new ProizvodiInsertRequest
                    {
                        Naziv = txtNaziv.Text,
                        Opis = txtOpis.Text,
                        Cijena = decimal.Parse(txtCijena.Text),
                        KategorijaProizvodaId = Int32.Parse(cmbKategorije.SelectedValue.ToString()),
                    };

                    if (pbProizvod.Image != null)
                        insert.Slika = ImageHelper.FromImageToByte(pbProizvod.Image);

                    var result = _proizvodService.Insert<ProizvodiInsertRequest>(insert);

                    _mboxHelper.Inform("Uspjesno dodan proizvod.");
                }

                frmShowProizvodi frm = new frmShowProizvodi(_kategorije);
                frm.MdiParent = this.ParentForm;
                this.Close();
                frm.Show();
            }
        }

        private void FeeldsNotEmpty()
        {
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                _feeldsEmpty = true;
                errProvider.SetError(txtNaziv, "Polje obavezno!");
                return;
            }
            else if (string.IsNullOrEmpty(txtOpis.Text))
            {
                _feeldsEmpty = true;
                errProvider.SetError(txtOpis, "Polje obavezno!");
                return;
            }
            else if (string.IsNullOrEmpty(txtCijena.Text))
            {
                _feeldsEmpty = true;
                errProvider.SetError(txtCijena, "Polje obavezno!");
                return;
            }
            else if (cmbKategorije.SelectedValue == null)
            {
                _feeldsEmpty = true;
                errProvider.SetError(cmbKategorije, "Polje obavezno!");
                return;
            }

            _feeldsEmpty = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_proizvod != null)
            {
                bool confirmation = _mboxHelper.Delete("Da li ste sigurni?");

                if (confirmation)
                {
                    object result = _proizvodService.Delete<MProizvodi>(_proizvod.Id);
                    _mboxHelper.Inform("Uspjesno obrisan proizvod.");

                    frmShowProizvodi frm = new frmShowProizvodi(_kategorije);
                    frm.MdiParent = this.ParentForm;
                    this.Close();
                    frm.Show();
                }
            }
            else
            {
                _mboxHelper.Error("Proizvod ne postoji.");
            }
        }

        private void pbProizvod_Click(object sender, EventArgs e)
        {
            if (ofdProizvod.ShowDialog() == DialogResult.OK)
            {
                string location = ofdProizvod.FileName;
                pbProizvod.SizeMode = PictureBoxSizeMode.StretchImage;
                pbProizvod.Image = Image.FromFile(location);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmShowProizvodi frm = new frmShowProizvodi(_kategorije);
            frm.MdiParent = this.ParentForm;
            this.Close();
            frm.Show();
        }
    }
}
