using ShapeUp.Desktop.Helpers;
using ShapeUp.Model.Request;
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
    public partial class frmDodajKlijenta : Form
    {
        private readonly APIService _userService = new APIService("Users");
        private MBoxHelper _mboxHelper = new MBoxHelper();
        private bool _feeldsEmpty = true;
        public frmDodajKlijenta()
        {
            InitializeComponent();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            FeeldsNotEmpty();

            if (!_feeldsEmpty)
            {

                object result;

                KlijentInsertRequest klijent = new KlijentInsertRequest
                {
                    FirstName = txtIme.Text,
                    LastName = txtPrezime.Text,
                    Email = txtEmail.Text,
                    PhoneNumber = txtBroj.Text,
                    Role = "Klijent",
                };

                result = await _userService.Insert<KlijentInsertRequest>(klijent);

                if(result == null)
                {
                    _mboxHelper.Error("Greška prilikom dodavanja klijenta.");
                }
                else
                {
                    _mboxHelper.Inform("Uspjesno dodan klijent.");

                }

                ShowUsersForm();
            }
        }

        private void ShowUsersForm()
        {
            frmShowUsers frm = new frmShowUsers();

            var parent = this.ParentForm;
            frm.MdiParent = parent;

            if (parent.ActiveMdiChild != null)
                parent.ActiveMdiChild.Close();

            frm.Show();
        }

        private void FeeldsNotEmpty()
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                _feeldsEmpty = true;
                errProvider.SetError(txtIme, "Polje obavezno!");
                _mboxHelper.Error("Ime je obavezno!");
                return;
            }
            else if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                _feeldsEmpty = true;
                errProvider.SetError(txtPrezime, "Polje obavezno!");
                _mboxHelper.Error("Prezime je obavezno!");
                return;
            }
            else if (string.IsNullOrEmpty(txtKIme.Text))
            {
                _feeldsEmpty = true;
                errProvider.SetError(txtKIme, "Polje obavezno!");
                _mboxHelper.Error("Korisnicko ime je obavezno!");
                return;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                _feeldsEmpty = true;
                errProvider.SetError(txtEmail, "Polje obavezno!");
                _mboxHelper.Error("Email je obavezan!");
                return;
            }

            _feeldsEmpty = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowUsersForm();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtKIme.Text = txtEmail.Text;
        }
    }
}
