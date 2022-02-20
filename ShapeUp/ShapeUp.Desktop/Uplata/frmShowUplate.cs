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

namespace ShapeUp.Desktop.Uplata
{
    public partial class frmShowUplate : Form
    {
        private APIService _paymentService = new APIService("Payment");

        public frmShowUplate()
        {
            InitializeComponent();
            dgvPayment.AutoGenerateColumns = false;
        }

        private async void frmShowUplate_Load(object sender, EventArgs e)
        {
            try
            {
                List<MPayment> payments = await _paymentService.Get<List<MPayment>>(null);
                payments.AsQueryable();
                dgvPayment.DataSource = payments;
                txtUplate.Text = payments.Count.ToString();
                txtIznos.Text = payments.Where(x => x.Status == "succeeded").Sum(x => x.Amount).ToString() + " KM";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
