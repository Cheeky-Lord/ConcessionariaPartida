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
    public partial class FormRegisterCustomer : Form
    {
        private readonly CustomerHandler _customerHandler;

        public FormRegisterCustomer(CustomerHandler customerHandler)
        {
            _customerHandler = customerHandler;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool validated = ValidateForm();
            if (validated)
            {
                var registerCustomer = (RegisterCustomer)registerCustomerBindingSource.Current;
                _customerHandler.Handler(registerCustomer);
                MessageBox.Show("Cadastro", "Cliente cadastrado com sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanForm();
            }
        }

        private bool ValidateForm()
        {
            return true;
        }

        private void CleanForm()
        {

        }
    }
}
