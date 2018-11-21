using PartidaDDD.Domain.Commands.Handlers;
using PartidaDDD.Presentation.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartidaDDD.Presentation
{
    public partial class FormMainPage : Form
    {
        private readonly FormRegisterCar _registerCar;
        private readonly FormRegisterUser _registerUser;
        private readonly FormRegisterCustomer _registerCustomer;

        public FormMainPage(FormRegisterCar registerCar, FormRegisterUser registerUser, FormRegisterCustomer registerCustomer)
        {
            _registerCar = registerCar;
            _registerUser = registerUser;
            _registerCustomer = registerCustomer;

            InitializeComponent();
        }

        private void concessionáriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutConcessionaria concessionaria = new FormAboutConcessionaria();
            concessionaria.ShowDialog();
        }

        private void logoutEFecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void desenvolvedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutDevelopers developers = new FormAboutDevelopers();
            developers.ShowDialog();
        }

        private void btnNewVehicle_Click(object sender, EventArgs e)
        {
            _registerCar.ShowDialog();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            _registerUser.ShowDialog();
        }

        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            _registerCustomer.ShowDialog();
        }
    }
}
