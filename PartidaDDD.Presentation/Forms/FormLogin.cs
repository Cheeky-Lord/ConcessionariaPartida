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
    public partial class FormLogin : Form
    {
        private FormMainPage _mainPage;

        public FormLogin(FormMainPage mainPage)
        {
            _mainPage = mainPage;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "admin@admin.com" && passwordTextBox.Text == "123")
            {
                this.Hide();
                _mainPage.Show();
            }
        }
    }
}
