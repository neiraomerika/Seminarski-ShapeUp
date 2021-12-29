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

namespace ShapeUp.Desktop.Training
{
    public partial class frmCRUDTraining : Form
    {
        private MTrening _training;
        private readonly APIService _kategorijaTreninga = new APIService("KategTreninga");
        private readonly APIService _cilj = new APIService("Cilj");

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
            txtDesc.Text = obj.Opis;
            if(obj.Slika != null)
                pbTrainingPicture.Image = Image.FromFile(obj.Slika);
            txtVideo.Text = obj.VideoUrl;
        }

        private async void loadTrainingCategories()
        {
            try
            {
                cmbCategories.DataSource = await _kategorijaTreninga.Get<List<MKategorijaTreninga>>(null);
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
                cmbGoal.DataSource = await _cilj.Get<List<MCilj>>(null);
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

    }
}
