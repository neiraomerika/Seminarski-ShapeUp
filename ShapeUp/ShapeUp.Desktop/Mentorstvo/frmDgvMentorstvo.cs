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

namespace ShapeUp.Desktop.Mentorstvo
{
    public partial class frmDgvMentorstvo : Form
    {
        public MPlan _plan;
        private readonly APIService _mentorstvoService = new APIService("Mentorstvo");
        public frmDgvMentorstvo(MPlan plan)
        {
            InitializeComponent();
            if (plan != null)
                _plan = plan;
        }

        private async void frmDgvMentorstvo_Load(object sender, EventArgs e)
        {
            dgvMentorstvo.DataSource = await _mentorstvoService.Get<List<MMentorstvo>>(null);
        }

        private void dgvMentorstvo_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            MMentorstvo mentorstvo = dgvMentorstvo.SelectedRows[0].DataBoundItem as MMentorstvo;

            _plan.Mentorstvo = mentorstvo;
            _plan.MentorstvoId = mentorstvo.Id;

            frmDodajPlan frm = new frmDodajPlan(_plan);
            frm.MdiParent = this.ParentForm;
            this.Close();
            frm.Show();
        }
    }
}
