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
        private CarHandler handler;

        public FormMainPage()
        {
            InitializeComponent();
        }

        private void concessionáriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutConcessionaria concessionaria = new FormAboutConcessionaria();
            concessionaria.Show();
        }

        private void logoutEFecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void desenvolvedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutDevelopers developers = new FormAboutDevelopers();
            developers.Show();
        }

        private void btnNewVehicle_Click(object sender, EventArgs e)
        {
            FormRegisterCar registerCar = new FormRegisterCar(handler);
            registerCar.Show();
        }
    }
}
