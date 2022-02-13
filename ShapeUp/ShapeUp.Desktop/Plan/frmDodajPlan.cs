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

namespace ShapeUp.Desktop.Plan
{
    public partial class frmDodajPlan : Form
    {
        private MPlan _plan;
        APIService _usersService = new APIService("Users");

        public frmDodajPlan(MPlan plan)
        {
            InitializeComponent();
            if (plan != null)
                _plan = plan;
        }

        private void frmDodajPlan_Load(object sender, EventArgs e)
        {

        }

        private async void LoadData()
        {
            cmbKlijenti.DataSource = await _usersService.Get<List<MKlijent>>(null);

            foreach (var klijent in cmbKlijenti.Items)
            {
                if (_plan.Klijent != null)
                {
                    //cmbKlijenti.SelectedItem
                }
            }
               
        }
    }
}
