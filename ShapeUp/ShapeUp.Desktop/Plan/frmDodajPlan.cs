using ShapeUp.Desktop.Helpers;
using ShapeUp.Desktop.Mentorstvo;
using ShapeUp.Desktop.PlanPrehrane;
using ShapeUp.Desktop.Training;
using ShapeUp.Desktop.Users;
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
using System.Web.Mvc;
using System.Windows.Forms;

namespace ShapeUp.Desktop.Plan
{
    public partial class frmDodajPlan : Form
    {
        public MPlan _plan;
        APIService _usersService = new APIService("Users");
        private bool _fieldsEmpty = false;
        private bool _isUpdate = false;
        private MBoxHelper _mboxHelper = new MBoxHelper();

        public frmDodajPlan(MPlan plan, bool isUpdate = false)
        {
            InitializeComponent();
            if (plan != null)
                _plan = plan;
            _isUpdate = isUpdate;
        }

        private void frmDodajPlan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            var lista = await _usersService.Get<List<MKlijent>>(null);

            foreach (var item in lista)
            {
                if(item.Id == _plan.KlijentId)
                {
                    var selectItem = new SelectListItem()
                    {
                        Text = item.FirstName + ' ' + item.LastName,
                        Value = item.Id,
                        Selected = true
                    };
                    cmbKlijenti.Items.Add(selectItem);

                    cmbKlijenti.SelectedItem = selectItem;
                }
                else
                {
                    cmbKlijenti.Items.Add(new SelectListItem()
                    {
                        Text = item.FirstName + ' ' + item.LastName,
                        Value = item.Id,
                    });
                }

            }

            cmbKlijenti.DisplayMember = "text";
            cmbKlijenti.ValueMember = "value";

            if (_plan.Datum != null)
            {
                dtmPlan.Value = _plan.Datum;
            }
            if (_plan.Trening != null)
            {
                txtTrening.Text = _plan.TreningId.ToString();
            }
            if (_plan.PlanPrehrane != null)
            {
                txtPrehrana.Text = _plan.PlanPrehraneId.ToString();
            }
            if (_plan.Mentorstvo != null)
            {
                txtMentorstvo.Text = _plan.MentorstvoId.ToString();
            }
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            FieldsNotEmpty();

            if (!_fieldsEmpty)
            {
                if (_isUpdate)
                {
                    PlanUpdateRequest update = new PlanUpdateRequest
                    {
                        Datum = dtmPlan.Value,
                        TreningId = Int32.Parse(txtTrening.Text),
                        PlanPrehraneId = Int32.Parse(txtPrehrana.Text),
                        MentorstvoId = Int32.Parse(txtMentorstvo.Text),
                        KlijentId = cmbKlijenti.SelectedItem.ToString()
                    };

                    MessageBox.Show(update.KlijentId);
                }
                else
                {
                    PlanInsertRequest update = new PlanInsertRequest
                    {
                        Datum = dtmPlan.Value,
                        TreningId = Int32.Parse(txtTrening.Text),
                        PlanPrehraneId = Int32.Parse(txtPrehrana.Text),
                        MentorstvoId = Int32.Parse(txtMentorstvo.Text),
                        KlijentId = cmbKlijenti.SelectedItem.ToString()
                    };

                    MessageBox.Show(update.KlijentId);
                }

                frmKlijent frm = new frmKlijent(null, _plan.KlijentId);

                frm.MdiParent = this.ParentForm;

                frm.Show();
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmKlijent frm = new frmKlijent(_plan.Klijent);
            frm.MdiParent = this.ParentForm;
            this.Close();
            frm.Show();
        }

        private void btnTrening_Click(object sender, EventArgs e)
        {
            frmDgvTrening frm = new frmDgvTrening(_plan);
            frm.MdiParent = this.ParentForm;
            this.Close();
            frm.Show();
        }

        private void btnObrok_Click(object sender, EventArgs e)
        {
            frmDgvPlanPrehrane frm = new frmDgvPlanPrehrane(_plan);
            frm.MdiParent = this.ParentForm;
            this.Close();
            frm.Show();
        }

        private void btnMentorstvo_Click(object sender, EventArgs e)
        {
            frmDgvMentorstvo frm = new frmDgvMentorstvo(_plan);
            frm.MdiParent = this.ParentForm;
            this.Close();
            frm.Show();
        }

        private void FieldsNotEmpty()
        {
            if (string.IsNullOrEmpty(cmbKlijenti.SelectedItem.ToString()))
            {
                _fieldsEmpty = true;
                errProvider.SetError(cmbKlijenti, "Polje obavezno!");
                _mboxHelper.Error("Klijent je obavezan!");
            }
            if (dtmPlan.Value == null)
            {
                _fieldsEmpty = true;
                errProvider.SetError(dtmPlan, "Polje obavezno!");
                _mboxHelper.Error("Datum je obavezan!");
            }
            if (string.IsNullOrEmpty(txtTrening.Text))
            {
                _fieldsEmpty = true;
                errProvider.SetError(txtTrening, "Polje obavezno!");
                _mboxHelper.Error("Trening je obavezan!");
            }
            if (string.IsNullOrEmpty(txtPrehrana.Text))
            {
                _fieldsEmpty = true;
                errProvider.SetError(txtPrehrana, "Polje obavezno!");
                _mboxHelper.Error("Plan prehrane je obavezan!");
            }
            if (string.IsNullOrEmpty(txtMentorstvo.Text))
            {
                _fieldsEmpty = true;
                errProvider.SetError(txtMentorstvo, "Polje obavezno!");
                _mboxHelper.Error("Mentorstvo je obavezno!");
            }

            if (_fieldsEmpty)
                return;
            else
            {
                _fieldsEmpty = false;
                return;
            }
        }
    }
}
