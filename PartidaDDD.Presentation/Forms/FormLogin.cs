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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormMainPage mainPage = new FormMainPage();
            if (emailTextBox.Text == "admin@admin.com" && passwordTextBox.Text == "123")
            {
                this.Hide();
                mainPage.Show();
            }
        }
    }
}
