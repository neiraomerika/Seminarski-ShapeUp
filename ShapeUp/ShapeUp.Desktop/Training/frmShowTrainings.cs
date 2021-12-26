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
    public partial class frmShowTrainings : Form
    {
        APIService trainingService = new APIService("Trening");
        APIService kategTService = new APIService("KategTreninga");
        public frmShowTrainings()
        {
            InitializeComponent();
        }

        private async void frmShowTrainings_Load(object sender, EventArgs e)
        {
            dgvTrainings.DataSource = await trainingService.Get<List<MTrening>>(null);

            cmbTCateg.DataSource = await kategTService.Get<List<MKategorijaTreninga>>(null);
            cmbTCateg.DisplayMember = "naziv";
            cmbTCateg.ValueMember = "Id";
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = cmbTCateg.SelectedValue;

            dgvTrainings.DataSource = await trainingService.Get<List<MTrening>>(search);
        }

        private async void btnClearSearch_Click(object sender, EventArgs e)
        {
            dgvTrainings.DataSource = await trainingService.Get<List<MTrening>>(null);
            cmbTCateg.SelectedIndex = 0;
        }
    }
}
