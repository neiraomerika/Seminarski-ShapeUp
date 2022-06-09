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

namespace ShapeUp.Desktop.Mentorstvo
{
    public partial class frmCreateMentorstvo : Form
    {
        private readonly APIService _klijentService = new APIService("Users");
        private readonly APIService _mentorstvoService = new APIService("Mentorstvo");
        private MBoxHelper _mboxHelper = new MBoxHelper();
        private bool _feeldsEmpty = true;
        private bool _isValid = false;

        public frmCreateMentorstvo()
        {
            InitializeComponent();
        }

        private async  void btnSpasi_Click(object sender, EventArgs e)
        {
            FeeldsNotEmpty();

            if (!_feeldsEmpty && _isValid)
            {
                MentorstvoInsertRequest insert = new MentorstvoInsertRequest()
                {
                    DatumPocetka = dtmPocetak.Value,
                    DatumZavrsetka = dtmZavrsetak.Value,
                    DatumUplate = dtmUplata.Value,
                    NazivKlijenta = ((SelectListItem)cmbKlijenti.SelectedItem).Text.ToString(),
                    Iznos = decimal.Parse(txtCijena.Text)
                };

                var result = await _mentorstvoService.Insert<MentorstvoInsertRequest>(insert);

                _mboxHelper.Inform("Uspjesno dodano mentorstvo.");

                frmShowMentorstva frm = new frmShowMentorstva();
                frm.MdiParent = this.ParentForm;
                frm.Text = "Mentorstva";

                this.Close();
                frm.Show();
            }
        }

        private void frmCreateMentorstvo_Load(object sender, EventArgs e)
        {
            LoadKlijenti();
        }

        private async void LoadKlijenti()
        {
            try
            {
                var klijenti = await _klijentService.Get<List<MKlijent>>(null);

                List<SelectListItem> list = new List<SelectListItem>();

                foreach (var item in klijenti)
                {
                    list.Add(new SelectListItem
                    {
                        Value = item.Id,
                        Text = item.FirstName + " " + item.LastName
                    });
                }
            
                cmbKlijenti.DataSource =  list;
                cmbKlijenti.DisplayMember = "text";
                cmbKlijenti.ValueMember = "value";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void FeeldsNotEmpty()
        {
            if (dtmPocetak.Value == null)
            {
                _feeldsEmpty = true;
                errProvider.SetError(dtmPocetak, "Polje obavezno!");
                return;
            }
            else
            {
                errProvider.SetError(dtmPocetak, "");
            }

            if (dtmZavrsetak.Value == null)
            {
                _feeldsEmpty = true;
                errProvider.SetError(dtmZavrsetak, "Polje obavezno!");
                return;
            }
            else
            {
                errProvider.SetError(dtmZavrsetak, "");
            }

            if (dtmUplata.Value == null)
            {
                _feeldsEmpty = true;
                errProvider.SetError(dtmUplata, "Polje obavezno!");
                return;
            }
            else
            {
                errProvider.SetError(dtmUplata, "");
            }

            if (cmbKlijenti.SelectedItem == null || ((SelectListItem)cmbKlijenti.SelectedItem).Value == null)
            {
                _feeldsEmpty = true;
                errProvider.SetError(cmbKlijenti, "Polje obavezno!");
                return;
            }
            else
            {
                errProvider.SetError(cmbKlijenti, "");
            }

            if (string.IsNullOrEmpty(txtCijena.Text))
            {
                _feeldsEmpty = true;
                errProvider.SetError(txtCijena, "Polje obavezno!");
                return;
            }
            else
            {
                errProvider.SetError(txtCijena, "");
            }

            if (dtmPocetak.Value.Date == dtmZavrsetak.Value.Date)
            {
                _isValid = false;
                _mboxHelper.Error("Datumi ne mogu biti isti.");
            }

            _feeldsEmpty = false;
        }

        private void dtmPocetak_ValueChanged(object sender, EventArgs e)
        {
            if(dtmPocetak.Value < DateTime.Now.Date || dtmZavrsetak.Value == dtmPocetak.Value)
            {
                _isValid = false;
                errProvider.SetError(dtmPocetak, "Datum nije odgovarajući.");
                return;
            }
            _isValid = true;
            errProvider.SetError(dtmPocetak, "");
        }

        private void dtmZavrsetak_ValueChanged(object sender, EventArgs e)
        {
            if (dtmZavrsetak.Value < DateTime.Now.Date || dtmZavrsetak.Value == dtmPocetak.Value)
            {
                _isValid = false;
                errProvider.SetError(dtmZavrsetak, "Datum nije odgovarajući.");
                return;
            }
            _isValid = true;
            errProvider.SetError(dtmZavrsetak, "");
        }
    }
}
