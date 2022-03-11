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
    public partial class frmShowMentorstva : Form
    {
        private APIService _mentorstvoService = new APIService("Mentorstvo");

        public frmShowMentorstva()
        {
            InitializeComponent();
        }

        private void frmShowMentorstva_Load(object sender, EventArgs e)
        {
            LoadMentorstva();
        }

        private async void LoadMentorstva(MentorstvoSearchObject search = null)
        {
            try
            {
                List<MMentorstvo> mentorstvo = await _mentorstvoService.Get<List<MMentorstvo>>(search);
                mentorstvo.AsQueryable();

                dgvMentorstva.DataSource = mentorstvo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnDodajMentorstvo_Click(object sender, EventArgs e)
        {
            frmCreateMentorstvo frm = new frmCreateMentorstvo();
            frm.MdiParent = this.ParentForm;

            this.Close();
            frm.Show();
        }
    }
}
