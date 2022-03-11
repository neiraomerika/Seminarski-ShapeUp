using ShapeUp.Desktop.Helpers;
using ShapeUp.Helpers;
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
using System.Windows.Forms;

namespace ShapeUp.Desktop.PlanPrehrane
{
    public partial class frmCRUDPlanPrehrane : Form
    {
        private MPlanPrehrane _planPrehrane;
        private readonly APIService _ciljAPI = new APIService("Cilj");
        private readonly APIService _planPrehraneAPI = new APIService("PlanPrehrane");
        private bool _isUpdate = false;
        private bool _feeldsEmpty = true;
        private MBoxHelper _mboxHelper = new MBoxHelper();
        public frmCRUDPlanPrehrane(MPlanPrehrane planPrehrane = null)
        {
            InitializeComponent();
            _planPrehrane = planPrehrane;

        }

        private void frmCRUDPlanPrehrane_Load(object sender, EventArgs e)
        {
            loadGoal();

            if (_planPrehrane != null)
                bindData(_planPrehrane);
        }

        private async void loadGoal()
        {
            try
            {
                cmbGoal.DataSource = await _ciljAPI.Get<List<MCilj>>(null);
                cmbGoal.DisplayMember = "naziv";
                cmbGoal.ValueMember = "id";

                if (_planPrehrane != null)
                    cmbGoal.SelectedValue = _planPrehrane.CiljId;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void bindData(MPlanPrehrane planPrehrane)
        {
            _isUpdate = true;

            txtDesc.Text = planPrehrane.Opis;
            txtNutritivnaDesc.Text = planPrehrane.NutritivneVrijednosti;
            if (planPrehrane.Slika != null && planPrehrane.Slika.Length > 0)
            {
                pbPlanPrehranePicture.Image = ImageHelper.FromByteToImage(planPrehrane.Slika);
                pbPlanPrehranePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pbPlanPrehranePicture.Image = ShapeUp.Desktop.Properties.Resources.no_image;
                pbPlanPrehranePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void pbPlanPrehranePicture_Click(object sender, EventArgs e)
        {
            if (ofdLoadPicture.ShowDialog() == DialogResult.OK)
            {
                string location = ofdLoadPicture.FileName;
                pbPlanPrehranePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                pbPlanPrehranePicture.Image = Image.FromFile(location);
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
                    PlanPrehraneUpdateRequest updatePlanPrehrane = new PlanPrehraneUpdateRequest
                    {
                        Opis = txtDesc.Text,
                        NutritivneVrijednosti = txtNutritivnaDesc.Text,
                        CiljId = Int32.Parse(cmbGoal.SelectedValue.ToString()),
                        Slika = ImageHelper.FromImageToByte(pbPlanPrehranePicture.Image),
                    };

                    result = await _planPrehraneAPI.Update<PlanPrehraneUpdateRequest>(_planPrehrane.Id, updatePlanPrehrane);

                    ShowPlanPrehraneForm();

                    _mboxHelper.Inform("Uspjesno izmijenjen plan prehrane.");

                    return;
                }
                PlanPrehraneInsertRequest pPrehrane = new PlanPrehraneInsertRequest
                {
                    Opis = txtDesc.Text,
                    NutritivneVrijednosti = txtNutritivnaDesc.Text,
                    CiljId = Int32.Parse(cmbGoal.SelectedValue.ToString()),
                    Slika = ImageHelper.FromImageToByte(pbPlanPrehranePicture.Image),
                };
                result = await _planPrehraneAPI.Insert<PlanPrehraneInsertRequest>(pPrehrane);

                _mboxHelper.Inform("Uspjesno dodan plan prehrane.");

                ShowPlanPrehraneForm();
            }
        }

        private void ShowPlanPrehraneForm()
        {
            frmShowPlanPrehrane frm = new frmShowPlanPrehrane();

            var parent = this.ParentForm;
            frm.MdiParent = parent;

            if (parent.ActiveMdiChild != null)
                parent.ActiveMdiChild.Close();

            frm.Show();
        }

        private void FeeldsNotEmpty()
        {
            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                _feeldsEmpty = true;
                errProvider.SetError(txtDesc, "Polje obavezno!");
                _mboxHelper.Error("Opis je obavezan!");
                return;
            }
         _feeldsEmpty = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_planPrehrane != null)
            {
                bool confirmation = _mboxHelper.Delete("Da li ste sigurni?");

                if (confirmation)
                {
                    object result = _planPrehraneAPI.Delete<MPlanPrehrane>(_planPrehrane.Id);
                    _mboxHelper.Inform("Uspjesno obrisan plan prehrane.");

                    ShowPlanPrehraneForm();
                }
            }
            else
            {
                _mboxHelper.Error("Plan prehrane ne postoji.");
            }
        }
    }
}