using ShapeUp.Desktop.Helpers;
using ShapeUp.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShapeUp.Desktop
{
    public partial class Login : Form
    {
        APIService _apiAuth = new APIService("auth");
        private MBoxHelper _mboxHelper = new MBoxHelper();

        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            UserLogin login = new UserLogin()
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };
            try
            {
                LoginResponse response = await _apiAuth.Login(login);

                if (response.IsAuthSuccessful)
                {
                    APIService.Token = response.Token;

                    MainForm frm = new MainForm();
                    frm.ShowDialog();
                    this.Close();
                }
            }
            catch
            {
                _mboxHelper.Error("Problem prilikom prijave!");
            }
        }
    }
}
