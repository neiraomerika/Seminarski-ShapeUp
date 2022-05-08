using ShapeUp.Desktop.Helpers;
using ShapeUp.Desktop.Plan;
using ShapeUp.Model.Models;
using ShapeUp.Model.SearchObjects;
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
        public bool _isUpdate;
        private readonly APIService _mentorstvoService = new APIService("Mentorstvo");
        private MBoxHelper _mboxHelper = new MBoxHelper();
        public frmDgvMentorstvo(MPlan plan, bool update = false)
        {
            InitializeComponent();
            if (plan != null)
                _plan = plan;

            _isUpdate = update;
        }

        private async void frmDgvMentorstvo_Load(object sender, EventArgs e)
        {
            MentorstvoSearchObject search = new MentorstvoSearchObject
            {
                Klijent = $"{_plan.Klijent.FirstName} {_plan.Klijent.LastName}"
            };
            
            var mentorstva = await _mentorstvoService.Get<List<MMentorstvo>>(search);

            if(mentorstva.Count == 0)
            {
                lblInfo.Text = "Nema dostupnog mentorstva. \nDodajte novo mentorstvo.";
            }
            
            dgvMentorstvo.DataSource = mentorstva;
        }

        private void dgvMentorstvo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MMentorstvo mentorstvo = dgvMentorstvo.SelectedRows[0].DataBoundItem as MMentorstvo;

            var imePrezime = $"{_plan.Klijent.FirstName} {_plan.Klijent.LastName}";

            if (mentorstvo.NazivKlijenta != imePrezime)
            {
                _mboxHelper.Error($"Mozete dodijeliti mentorstvo samo od {imePrezime} klijenta.");
                return;
            }

            _plan.Mentorstvo = mentorstvo;
            _plan.MentorstvoId = mentorstvo.Id;

            frmDodajPlan frm = new frmDodajPlan(_plan, _isUpdate);
            frm.MdiParent = this.ParentForm;
            this.Close();
            frm.Show();
        }

        private void btnDodajMentorstvo_Click(object sender, EventArgs e)
        {
            frmCreateMentorstvo frm = new frmCreateMentorstvo();
            frm.MdiParent = this.ParentForm;
            frm.Text = "Mentorstvo";

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            frm.Show();
        }
    }
}
