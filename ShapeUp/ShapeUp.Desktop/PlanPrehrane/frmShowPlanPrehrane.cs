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
    public partial class frmShowPlanPrehrane : Form
    {
        APIService planPrehraneService = new APIService("PlanPrehrane");
        public frmShowPlanPrehrane()
        {
            InitializeComponent();
        }

        private async void frmShowPlanPrehrane_Load(object sender, EventArgs e)
        {
            try
            {
                dgvPlanPrehrane.DataSource = await planPrehraneService.Get<List<MPlanPrehrane>>(null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvPlanPrehrane_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MPlanPrehrane planPrehrane = dgvPlanPrehrane.SelectedRows[0].DataBoundItem as MPlanPrehrane;
            frmCRUDPlanPrehrane frm = new frmCRUDPlanPrehrane(planPrehrane);

            var parent = this.ParentForm;
            frm.MdiParent = parent;

            if (parent.ActiveMdiChild != null)
                parent.ActiveMdiChild.Close();

            frm.Show();
        }
    }
}
