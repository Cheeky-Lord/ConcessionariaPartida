using PartidaDDD.Domain.Commands.Handlers;
using PartidaDDD.Domain.Commands.Inputs;
using System;
using System.IO;
using System.Windows.Forms;

namespace PartidaDDD.Presentation.Forms
{
    public partial class FormRegisterCar : Form
    {
        private CarHandler _handler;

        public FormRegisterCar(CarHandler handler)
        {
            _handler = handler;

            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            CleanValidateForm();
            bool isValid = ValidateForm();

            if (isValid == true)
            {
                var registerCar = (RegisterCar)registerCarBindingSource.Current;
                _handler.Handler(registerCar);
                MessageBox.Show("Veículo registrado com sucesso!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanForm();
            }
        }

        private void FormRegisterCar_Load(object sender, EventArgs e)
        {
            registerCarBindingSource.AddNew();
        }

        private bool ValidateForm()
        {
            bool validated = true;

            if (nameTextBox.Text.Length < 2)
            {
                validated = false;
                lblValidateName.Text = "A propriedade Nome deve ter no mínimo 2 caracteres";
            }
            if (yearTextBox.Text.Length < 4)
            {
                validated = false;
                lblValidateYear.Text = "Ano inválido";
            }
            if (chassisTextBox.Text.Length < 5)
            {
                validated = false;
                lblValidateChassis.Text = "Chassis inválido";
            }
            if (doorsTextBox.Text.Length < 1)
            {
                validated = false;
                lblValidateDoor.Text = "Portas inválido";
            }
            if (brandTextBox.Text.Length < 2)
            {
                validated = false;
                lblValidateBrand.Text = "A propriedade Marca deve ter no mínimo 2 caracteres";
            }

            return validated;
        }

        private void CleanForm()
        {
            nameTextBox.Text = "";
            yearTextBox.Text = "";
            chassisTextBox.Text = "";
            brandTextBox.Text = "";
            hydraulicSteeringCheckBox.Checked = false;
            automaticCheckBox.Checked = false;
        }

        private void CleanValidateForm()
        {
            lblValidateBrand.Text = "";
            lblValidateChassis.Text = "";
            lblValidateDoor.Text = "";
            lblValidateName.Text = "";
            lblValidateYear.Text = "";
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImage = new OpenFileDialog();
            ofdImage.Title = "Selecione a imagem";

            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                imageTextBox.Text = ofdImage.FileName;
            }
            imageTextBox.Text = string.Empty;
        }

        private void CopyImage()
        {

        }
    }
}
