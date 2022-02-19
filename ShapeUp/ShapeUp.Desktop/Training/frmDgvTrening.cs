using ShapeUp.Desktop.Plan;
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
    public partial class frmDgvTrening : Form
    {
        public MPlan _plan;
        public bool _isUpdate;
        private readonly APIService _treningService = new APIService("Trening");
        public frmDgvTrening(MPlan plan, bool isUpdate)
        {
            InitializeComponent();
            if (plan != null)
                _plan = plan;

            _isUpdate = isUpdate;
        }

        private async void frmDgvTrening_Load(object sender, EventArgs e)
        {
            dgvTreninzi.DataSource = await _treningService.Get<List<MTrening>>(null);
        }

        private void dgvTreninzi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MTrening trening = dgvTreninzi.SelectedRows[0].DataBoundItem as MTrening;

            _plan.Trening = trening;
            _plan.TreningId = trening.Id;

            frmDodajPlan frm = new frmDodajPlan(_plan, _isUpdate);
            frm.MdiParent = this.ParentForm;
            this.Close();
            frm.Show();
        }
    }
}
