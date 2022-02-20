using ShapeUp.Desktop.Helpers;
using ShapeUp.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            cmbMentorstvo.DataSource = await _mentorstvoService.Get<List<MMentorstvo>>(null);
            for (int i = 1; i <= 5; i++)
            {
                cmbOcjena.Items.Add(i);
            }
        }

        private void bindData()
        {
            txtOpis.Text = _recenzija.Opis;
            cmbOcjena.SelectedIndex = _recenzija.Ocjena - 1;
            dtmRecenzija.Value = _recenzija.Datum;
            cmbMentorstvo.SelectedItem = _recenzija.MentorstvoId;
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            FeeldsNotEmpty();

            if (!_feeldsEmpty)
            {
                _mboxHelper.Inform("spaseno je");

            }

        }

        private void FeeldsNotEmpty()
        {
            if (string.IsNullOrEmpty(txtOpis.Text))
            {
                _feeldsEmpty = true;
                errProvider.SetError(txtOpis, "Polje obavezno!");
                _mboxHelper.Error("Opis je obavezan!");
                return;
            }
            else if (cmbOcjena.SelectedItem == null)
            {
                _feeldsEmpty = true;
                errProvider.SetError(cmbOcjena, "Polje obavezno!");
                _mboxHelper.Error("Ocjena je obavezna!");
                return;
            }
            else if (dtmRecenzija.Value == null)
            {
                _feeldsEmpty = true;
                errProvider.SetError(dtmRecenzija, "Polje obavezno!");
                _mboxHelper.Error("Datum je obavezan!");
                return;
            }
            else if (cmbMentorstvo.SelectedItem == null)
            {
                _feeldsEmpty = true;
                errProvider.SetError(cmbMentorstvo, "Polje obavezno!");
                _mboxHelper.Error("Mentorstvo je obavezno!");
                return;
            }

            _feeldsEmpty = false;
        }
    }
}
