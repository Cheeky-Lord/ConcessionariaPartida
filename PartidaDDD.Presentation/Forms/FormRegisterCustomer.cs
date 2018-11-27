using PartidaDDD.Domain.Commands.Handlers;
using PartidaDDD.Domain.Commands.Inputs;
using PartidaDDD.Domain.Helpers;
using System;
using System.Windows.Forms;

namespace PartidaDDD.Presentation.Forms
{
    public partial class FormRegisterCustomer : Form
    {
        private readonly ValidateHelper validateHelper = new ValidateHelper();
        private readonly CustomerHandler _customerHandler;

        public FormRegisterCustomer(CustomerHandler customerHandler)
        {
            _customerHandler = customerHandler;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var registerCustomer = (RegisterCustomer)registerCustomerBindingSource.Current;
                _customerHandler.Handler(registerCustomer);
                MessageBox.Show("Cadastro", "Cliente cadastrado com sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanForm();
                CleanValidate();
            }
        }

        private bool ValidateForm()
        {
            bool validated = true;

            if (nameTextBox.Text.Length < 2)
            {
                lblValidateName.Text = "Nome inválido";
                validated = false;
            }
            if (validateHelper.ValidateDocumet(typeComboBox.Text, documentMaskedTextBox.Text) == false)
            {
                lblValidateDocument.Text = "Documento inválido";
                validated = false;
            }
            if (socialNameTextBox.Text.Length < 2)
            {
                lblValidateSocial.Text = "Razão Social inválida";
                validated = false;
            }
            if (typeComboBox.Text == "")
            {
                lblValidateType.Text = "Tipo inválido";
                validated = false;
            }
            if (emailTextBox.Text.Length < 5 || !emailTextBox.Text.Contains("@"))
            {
                lblValidateEmail.Text = "E-mail inválido";
                validated = false;
            }


            return validated;
        }

        private void CleanForm()
        {
            registerCustomerBindingSource.Clear();
        }

        private void CleanValidate()
        {
            lblValidateDocument.Text = "";
            lblValidateEmail.Text = "";
            lblValidateName.Text = "";
            lblValidateSocial.Text = "";
            lblValidateType.Text = "";
        }

        private void Type()
        {
            if (typeComboBox.Text == "Pessoa Física")
            {
                documentMaskedTextBox.Enabled = true;
                documentMaskedTextBox.Mask = "000.000.000-00";
            }
            if (typeComboBox.Text == "Pessoa Jurídica")
            {
                documentMaskedTextBox.Enabled = true;
                documentMaskedTextBox.Mask = "00.000.000/0000-00";
            }
        }

        private void FormRegisterCustomer_Load(object sender, EventArgs e)
        {
            CleanValidate();
            documentMaskedTextBox.Enabled = false;
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type();
        }
    }
}
