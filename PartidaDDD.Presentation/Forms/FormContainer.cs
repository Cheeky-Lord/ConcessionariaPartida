using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartidaDDD.Presentation.Forms
{
    public partial class FormContainer : Form
    {
        public FormContainer()
        {
            InitializeComponent();
        }

        private void FormContainer_Load(object sender, EventArgs e)
        {
            FormMainPage mainPage = new FormMainPage();
            mainPage.MdiParent = this;
            mainPage.Show();
        }

        private void concessionariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutConcessionaria concessionaria = new FormAboutConcessionaria();
            concessionaria.MdiParent = this;
            concessionaria.Show();
        }
    }
}
