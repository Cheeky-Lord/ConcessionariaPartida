using PartidaDDD.Domain.Commands.Handlers;
using PartidaDDD.Domain.Commands.Inputs;
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
    public partial class FormRegisterUser : Form
    {
        private UserHandler _handler;

        public FormRegisterUser(UserHandler handler)
        {
            _handler = handler;

            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerUser = (RegisterUser)registerUserBindingSource.Current;
            _handler.Handler(registerUser);
        }

        private void FormRegisterUser_Load(object sender, EventArgs e)
        {
            registerUserBindingSource.AddNew();
        }
    }
}
