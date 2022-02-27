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
        APIService _planService = new APIService("Plan");
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

        private async void btnSpasi_Click(object sender, EventArgs e)
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
                        KlijentId = ((SelectListItem)cmbKlijenti.SelectedItem).Value
                    };

                    var result = await _planService.Update<PlanUpdateRequest>(_plan.Id, update);
                    _mboxHelper.Inform("Uspjesno izmijenjen plan.");
                }
                else
                {
                    PlanInsertRequest insert = new PlanInsertRequest
                    {
                        Datum = dtmPlan.Value,
                        TreningId = Int32.Parse(txtTrening.Text),
                        PlanPrehraneId = Int32.Parse(txtPrehrana.Text),
                        MentorstvoId = Int32.Parse(txtMentorstvo.Text),
                        KlijentId = ((SelectListItem)cmbKlijenti.SelectedItem).Value
                    };

                    var result = await _planService.Insert<PlanUpdateRequest>(insert);
                    _mboxHelper.Inform("Uspjesno dodan plan.");
                }

                var klijent = await _usersService.GetById<MKlijent>(_plan.KlijentId);
                var plans = await _planService.Get<List<MPlan>>(klijent.Id);

                klijent.Plans = plans.AsQueryable().Where(x => x.KlijentId == klijent.Id).ToList();

                frmKlijent frm = new frmKlijent(klijent);

                frm.MdiParent = this.ParentForm;

                frm.Show();
                return;
            }
        }

        private async void btnBack_Click(object sender, EventArgs e)
        {
            var klijent = await _usersService.GetById<MKlijent>(_plan.KlijentId);
            var plans = await _planService.Get<List<MPlan>>(klijent.Id);

            klijent.Plans = plans;

            frmKlijent frm = new frmKlijent(klijent);
            frm.MdiParent = this.ParentForm;
            this.Close();
            frm.Show();
        }

        private void btnTrening_Click(object sender, EventArgs e)
        {
            frmDgvTrening frm = new frmDgvTrening(_plan, _isUpdate);
            frm.MdiParent = this.ParentForm;
            this.Close();
            frm.Show();
        }

        private void btnObrok_Click(object sender, EventArgs e)
        {
            frmDgvPlanPrehrane frm = new frmDgvPlanPrehrane(_plan, _isUpdate);
            frm.MdiParent = this.ParentForm;
            this.Close();
            frm.Show();
        }

        private void btnMentorstvo_Click(object sender, EventArgs e)
        {
            frmDgvMentorstvo frm = new frmDgvMentorstvo(_plan, _isUpdate);
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

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_plan != null)
            {
                bool confirmation = _mboxHelper.Delete("Da li ste sigurni?");

                if (confirmation)
                {
                    object result = _planService.Delete<MPlan>(_plan.Id);
                    _mboxHelper.Inform("Uspjesno obrisan trening.");

                    var klijent = await _usersService.GetById<MKlijent>(_plan.KlijentId);
                    var plans = await _planService.Get<List<MPlan>>(klijent.Id);

                    klijent.Plans = plans;

                    frmKlijent frm = new frmKlijent(klijent);

                    frm.MdiParent = this.ParentForm;

                    frm.Show();
                    return;
                }
            }
            else
            {
                _mboxHelper.Error("Plan ne postoji.");
            }
        }
    }
}
