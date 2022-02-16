using ShapeUp.Desktop.Plan;
using ShapeUp.Helpers;
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

namespace ShapeUp.Desktop.Users
{
    public partial class frmKlijent : Form
    {
        private MKlijent _klijent;
        private readonly APIService _klijentService = new APIService("Users");
        public frmKlijent(MKlijent klijent)
        {
            InitializeComponent();

            if (klijent != null)
            {
                _klijent = klijent;
                this.Text = _klijent.FirstName + " " + _klijent.LastName;
            }
        }

        private void frmKlijent_Load(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void LoadUser()
        {
            txtFirst.Text = _klijent.FirstName;
            txtLast.Text = _klijent.LastName;
            txtUName.Text = _klijent.UserName;
            txtEmail.Text = _klijent.Email;
            txtPhone.Text = _klijent.PhoneNumber;
            cbActive.Checked = _klijent.Active;

            if(_klijent.Picture != null && _klijent.Picture.Length > 0)
            {
                pbProfilna.Image = ImageHelper.FromByteToImage(_klijent.Picture);
                pbProfilna.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pbProfilna.Image = ShapeUp.Desktop.Properties.Resources.profilePicture;
                pbProfilna.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            dgvPlanovi.DataSource = _klijent.Plans;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmShowUsers frm = new frmShowUsers();
            frm.MdiParent = this.ParentForm;
            this.Close();
            frm.Show();
        }

        private void btnDodajPlan_Click(object sender, EventArgs e)
        {
            MPlan plan = new MPlan() 
            {
                KlijentId = _klijent.Id,
                Klijent = _klijent,
                Datum = DateTime.Now
            };
            frmDodajPlan frm = new frmDodajPlan(plan);
            frm.MdiParent = this.ParentForm;
            this.Close();
            frm.Show();
        }

        private void dgvPlanovi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MPlan plan = dgvPlanovi.SelectedRows[0].DataBoundItem as MPlan;

            frmDodajPlan frm = new frmDodajPlan(plan, true);
            frm.MdiParent = this.ParentForm;
            this.Close();
            frm.Show();
        }
    }
}
