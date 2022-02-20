using ShapeUp.Desktop.Helpers;
using ShapeUp.Model.Models;
using ShapeUp.Model.Request;
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
    public partial class frmCRUDRecenzija : Form
    {
        public MRecenzija _recenzija;
        private readonly APIService _recenzijaService = new APIService("Recenzija");
        private readonly APIService _mentorstvoService = new APIService("Mentorstvo");
        private bool _isUpdate = false;
        private bool _feeldsEmpty = true;
        private MBoxHelper _mboxHelper = new MBoxHelper();
        public frmCRUDRecenzija(MRecenzija recenzija = null)
        {
            InitializeComponent();

            if (recenzija != null)
            {
                _recenzija = recenzija;
                _isUpdate = true;
            }

        }

        private void frmCRUDRecenzija_Load(object sender, EventArgs e)
        {
            loadData();

            if(_isUpdate)
                bindData();
        }

        private async void loadData()
        {
            var mentorstva = await _mentorstvoService.Get<List<MMentorstvo>>(null);

            cmbMentorstvo.Items.Add(new SelectListItem()
            {
                Text = "-- N/A --",
                Value = null
            });

            foreach (var item in mentorstva)
            {
                var selectItem = new SelectListItem()
                {
                    Value = item.Id.ToString(),
                    Text = $"{item.NazivKlijenta} {item.DatumPocetka.ToString("dd.MM.yyyy")} | {item.DatumZavrsetka.ToString("dd.MM.yyyy")}"
                };

                cmbMentorstvo.Items.Add(selectItem);

                if(_recenzija != null)
                {
                    if(_recenzija.MentorstvoId == item.Id)
                    {
                        cmbMentorstvo.SelectedItem = selectItem;
                    }
                }
            }

            cmbMentorstvo.DisplayMember = "text";
            if(_recenzija == null)
                cmbMentorstvo.SelectedIndex = 0;

            for (int i = 1; i <= 5; i++)
            {
                cmbOcjena.Items.Add(i);
            }

            if (_recenzija != null)
            {
                cmbOcjena.SelectedItem = _recenzija.Ocjena;
            }
        }

        private void bindData()
        {
            txtOpis.Text = _recenzija.Opis;
            dtmRecenzija.Value = _recenzija.Datum;
        }

        private async void btnSpasi_Click(object sender, EventArgs e)
        {
            FeeldsNotEmpty();

            if (!_feeldsEmpty)
            {
                if (_isUpdate)
                {
                    RecenzijaUpdateRequest update = new RecenzijaUpdateRequest()
                    {
                        Opis = txtOpis.Text,
                        Ocjena = Int32.Parse(cmbOcjena.SelectedItem.ToString()),
                        Datum = dtmRecenzija.Value,
                        MentorstvoId = Int32.Parse(((SelectListItem)cmbMentorstvo.SelectedItem).Value.ToString())
                    };

                    var result = await _recenzijaService.Update<RecenzijaUpdateRequest>(_recenzija.Id, update);

                    _mboxHelper.Inform("Uspjesno izmijenjena recenzija.");
                }
                else
                {
                    RecenzijaInsertRequest insert = new RecenzijaInsertRequest()
                    {
                        Opis = txtOpis.Text,
                        Ocjena = Int32.Parse(cmbOcjena.SelectedItem.ToString()),
                        Datum = dtmRecenzija.Value,
                        MentorstvoId = Int32.Parse(((SelectListItem)cmbMentorstvo.SelectedItem).Value.ToString())
                    };

                    var result = await _recenzijaService.Insert<RecenzijaInsertRequest>(insert);

                    _mboxHelper.Inform("Uspjesno dodana recenzija.");
                }

                frmShowRecenzije frm = new frmShowRecenzije();
                frm.MdiParent = this.ParentForm;
                frm.Text = "Recenzije";

                this.Close();
                frm.Show();
            }

        }

        private void FeeldsNotEmpty()
        {
            if (string.IsNullOrEmpty(txtOpis.Text))
            {
                _feeldsEmpty = true;
                errProvider.SetError(txtOpis, "Polje obavezno!");
                return;
            }
            else if (cmbOcjena.SelectedItem == null)
            {
                _feeldsEmpty = true;
                errProvider.SetError(cmbOcjena, "Polje obavezno!");
                return;
            }
            else if (dtmRecenzija.Value == null)
            {
                _feeldsEmpty = true;
                errProvider.SetError(dtmRecenzija, "Polje obavezno!");
                return;
            }
            else if (cmbMentorstvo.SelectedItem == null || ((SelectListItem)cmbMentorstvo.SelectedItem).Value == null)
            {
                _feeldsEmpty = true;
                errProvider.SetError(cmbMentorstvo, "Polje obavezno!");
                return;
            }

            _feeldsEmpty = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_recenzija != null)
            {
                bool confirmation = _mboxHelper.Delete("Da li ste sigurni?");

                if (confirmation)
                {
                    object result = _recenzijaService.Delete(_recenzija.Id);
                    _mboxHelper.Inform("Uspjesno obrisana recenzija.");

                    frmShowRecenzije frm = new frmShowRecenzije();
                    frm.MdiParent = this.ParentForm;
                    frm.Text = "Recenzije";

                    this.Close();
                    frm.Show();
                }
            }
            else
            {
                _mboxHelper.Error("Recenzija ne postoji.");
            }
        }
    }
}
