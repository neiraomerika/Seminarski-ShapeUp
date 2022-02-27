using ShapeUp.Desktop.Helpers;
using ShapeUp.Helpers;
using ShapeUp.Model.Models;
using ShapeUp.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeUp.Desktop.Training
{
    public partial class frmCRUDTraining : Form
    {
        private MTrening _training;
        private readonly APIService _kategorijaTreningaAPI = new APIService("KategTreninga");
        private readonly APIService _ciljAPI = new APIService("Cilj");
        private readonly APIService _treningAPI = new APIService("Trening");
        private bool _isUpdate = false;
        private bool _feeldsEmpty = true;
        private MBoxHelper _mboxHelper = new MBoxHelper();

        public frmCRUDTraining(MTrening training = null)
        {
            InitializeComponent();
            _training = training;
        }

        private void frmCRUDTraining_Load(object sender, EventArgs e)
        {
            loadTrainingCategories();
            loadGoal();

            if (_training != null)
                bindData(_training);
        }

        private void pbTrainingPicture_Click(object sender, EventArgs e)
        {
            if (ofdLoadPicture.ShowDialog() == DialogResult.OK)
            {
                string location = ofdLoadPicture.FileName;
                pbTrainingPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                pbTrainingPicture.Image = Image.FromFile(location);
            }
        }

        private void bindData (MTrening obj)
        {
            _isUpdate = true;

            txtDesc.Text = obj.Opis;
            if (obj.Slika != null && obj.Slika.Length > 0)
            {
                pbTrainingPicture.Image = ImageHelper.FromByteToImage(obj.Slika);
                pbTrainingPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            txtVideo.Text = obj.VideoUrl;
        }

        private async void loadTrainingCategories()
        {
            try
            {
                cmbCategories.DataSource = await _kategorijaTreningaAPI.Get<List<MKategorijaTreninga>>(null);
                cmbCategories.DisplayMember = "naziv";
                cmbCategories.ValueMember = "id";

                if (_training != null)
                    cmbCategories.SelectedValue = _training.KategorijaTreningaId;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private async void loadGoal()
        {
            try
            {
                cmbGoal.DataSource = await _ciljAPI.Get<List<MCilj>>(null);
                cmbGoal.DisplayMember = "naziv";
                cmbGoal.ValueMember = "id";

                if (_training != null)
                    cmbGoal.SelectedValue = _training.CiljId;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            FeeldsNotEmpty();

            if (!_feeldsEmpty)
            {

                object result;

                if (_isUpdate)
                {
                    TreningUpdateRequest updateTrening = new TreningUpdateRequest
                    {
                        Opis = txtDesc.Text,
                        VideoUrl = txtVideo.Text,
                        CiljId = Int32.Parse(cmbGoal.SelectedValue.ToString()),
                        KategorijaTreningaId = Int32.Parse(cmbCategories.SelectedValue.ToString()),
                        Slika = ImageHelper.FromImageToByte(pbTrainingPicture.Image),
                    };

                    result = await _treningAPI.Update<TreningUpdateRequest>(_training.Id, updateTrening);

                    ShowTrainingsForm();

                    _mboxHelper.Inform("Uspjesno izmijenjen trening.");

                    return;
                }

                TreningInsertRequest trening = new TreningInsertRequest
                {
                    Opis = txtDesc.Text,
                    VideoUrl = txtVideo.Text,
                    CiljId = Int32.Parse(cmbGoal.SelectedValue.ToString()),
                    KategorijaTreningaId = Int32.Parse(cmbCategories.SelectedValue.ToString()),
                    Slika = ImageHelper.FromImageToByte(pbTrainingPicture.Image),
                };

                result = await _treningAPI.Insert<TreningInsertRequest>(trening);

                _mboxHelper.Inform("Uspjesno dodan trening.");

                ShowTrainingsForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(_training != null)
            {
                bool confirmation = _mboxHelper.Delete("Da li ste sigurni?");

                if (confirmation)
                {
                    object result = _treningAPI.Delete<MTrening>(_training.Id);
                    _mboxHelper.Inform("Uspjesno obrisan trening.");

                   ShowTrainingsForm();
                }
            }
            else
            {
                _mboxHelper.Error("Trening ne postoji.");
            }
        }

        private void ShowTrainingsForm ()
        {
            frmShowTrainings frm = new frmShowTrainings();

            var parent = this.ParentForm;
            frm.MdiParent = parent;

            if (parent.ActiveMdiChild != null)
                parent.ActiveMdiChild.Close();

            frm.Show();
        }

        private void FeeldsNotEmpty ()
        {
            if(string.IsNullOrEmpty(txtDesc.Text))
            {
                _feeldsEmpty = true;
                errProvider.SetError(txtDesc, "Polje obavezno!");
                _mboxHelper.Error("Opis je obavezan!");
                return;
            }
            else if (string.IsNullOrEmpty(txtVideo.Text))
            {
                _feeldsEmpty = true;
                errProvider.SetError(txtVideo, "Polje obavezno!");
                _mboxHelper.Error("Video link je obavezan!");
                return;
            }

            _feeldsEmpty = false;
        }
    }
}
