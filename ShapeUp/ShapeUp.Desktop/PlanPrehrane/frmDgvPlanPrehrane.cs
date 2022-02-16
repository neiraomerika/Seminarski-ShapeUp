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

namespace ShapeUp.Desktop.PlanPrehrane
{
    public partial class frmDgvPlanPrehrane : Form
    {
        public MPlan _plan;
        private readonly APIService _prehranaService = new APIService("PlanPrehrane");
        public frmDgvPlanPrehrane(MPlan plan)
        {
            InitializeComponent();
            if (plan != null)
                _plan = plan;
        }

        private async void frmDgvPlanPrehrane_Load(object sender, EventArgs e)
        {
            dgvPlanPrehrane.DataSource = await _prehranaService.Get<List<MPlanPrehrane>>(null);
        }

        private void dgvPlanPrehrane_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MPlanPrehrane planPrehrane = dgvPlanPrehrane.SelectedRows[0].DataBoundItem as MPlanPrehrane;

            _plan.PlanPrehrane = planPrehrane;
            _plan.PlanPrehraneId = planPrehrane.Id;

            frmDodajPlan frm = new frmDodajPlan(_plan);
            frm.MdiParent = this.ParentForm;
            this.Close();
            frm.Show();
        }
    }
}
