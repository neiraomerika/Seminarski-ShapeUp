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
        APIService _usersApiService = new APIService("Korisnici");

        public frmShowUsers()
        {
            InitializeComponent();
        }

        private void frmShowUsers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {

        }
    }
}
