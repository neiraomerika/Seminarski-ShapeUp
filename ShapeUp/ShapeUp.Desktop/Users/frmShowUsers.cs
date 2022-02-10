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

namespace ShapeUp.Desktop.Users
{
    public partial class frmShowUsers : Form
    {
        APIService _usersService = new APIService("Users");
        KlijentSearchObject searchObject = new KlijentSearchObject();

        public frmShowUsers()
        {
            InitializeComponent();
        }

        private async void frmShowUsers_Load(object sender, EventArgs e)
        {
            LoadDgv();
            LoadCmb();
        }

        private async void LoadDgv(KlijentSearchObject search = null)
        {
            try
            {
                dgvUsers.DataSource = await _usersService.Get<List<MKlijent>>(search);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LoadCmb()
        {
            cmbActive.Items.Insert(0, "Neaktivan");
            cmbActive.Items.Insert(1, "Aktivan");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchObject.FirstnameLastname = txtSearch.Text;
            LoadDgv(searchObject);
        }

        private void cmbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchObject.Active = cmbActive.SelectedIndex == 0 ? false : true;
            LoadDgv(searchObject);
        }
    }
}
