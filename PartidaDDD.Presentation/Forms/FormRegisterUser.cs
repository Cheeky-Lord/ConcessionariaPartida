using PartidaDDD.Domain.Commands.Handlers;
using PartidaDDD.Domain.Commands.Inputs;
using PartidaDDD.Domain.Helpers;
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
        private readonly ValidateHelper validateHelper = new ValidateHelper();
        private UserHandler _handler;

        public FormRegisterUser(UserHandler handler)
        {
            _handler = handler;

            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            CleanValidationForm();
            bool isValid = ValidateForm();
            if (isValid == true)
            {
                var registerUser = (RegisterUser)registerUserBindingSource.Current;
                _handler.Handler(registerUser);
                MessageBox.Show("Usuário cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanFields();
            }
        }

        private void FormRegisterUser_Load(object sender, EventArgs e)
        {
            registerUserBindingSource.AddNew();
            CleanValidationForm();
        }

        private bool ValidateForm()
        {
            var validated = true;

            if (!emailTextBox.Text.Contains("@"))
            {
                validated = false;
                lblValidateEmail.Text = "E-mail inválido";
            }
            if (nameTextBox.Text.Length < 2)
            {
                validated = false;
                lblValidateName.Text = "A propriedade Nome deve ter no mínimo 2 caracteres";
            }
            if (validateHelper.ValidateCPF(cPFMaskedTextBox.Text) == false)
            {
                validated = false;
                lblValidateCPF.Text = "CPF inválido";
            }
            if (rGTextBox.Text.Length < 7)
            {
                validated = false;
                lblValidateRG.Text = "RG inválido";
            }
            if (passwordTextBox.Text.Length < 3)
            {
                validated = false;
                lblValidatePassword.Text = "A propriedade senha deve ter no mínimo 3 caracteres";
            }
            if (functionComboBox == null)
            {
                validated = false;
                lblValidateFunction.Text = "A propriedade Função é obrigatória";
            }

            return validated;
        }

        private void CleanValidationForm()
        {
            lblValidateCPF.Text = "";
            lblValidateEmail.Text = "";
            lblValidateFunction.Text = "";
            lblValidateName.Text = "";
            lblValidatePassword.Text = "";
            lblValidateRG.Text = "";
        }

        private void CleanFields()
        {
            registerUserBindingSource.Clear();
        }
    }
}
