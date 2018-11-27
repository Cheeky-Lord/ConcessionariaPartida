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
        OpenFileDialog od = new OpenFileDialog();

        public FormRegisterCar(CarHandler handler)
        {
            _handler = handler;

            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            CleanValidateForm();
            bool isValid = ValidateForm();
            string fileName = Path.GetFileName(od.FileName);

            if (isValid == true)
            {
                var registerCar = (RegisterCar)registerCarBindingSource.Current;
                _handler.Handler(registerCar);

                if (imageTextBox.Text != "")
                    CopyImage(fileName);

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

            //if (nameTextBox.Text.Length < 2)
            //{
            //    validated = false;
            //    lblValidateName.Text = "A propriedade Nome deve ter no mínimo 2 caracteres";
            //}
            //if (yearTextBox.Text.Length < 4)
            //{
            //    validated = false;
            //    lblValidateYear.Text = "Ano inválido";
            //}
            //if (chassisTextBox.Text.Length < 5)
            //{
            //    validated = false;
            //    lblValidateChassis.Text = "Chassis inválido";
            //}
            //if (doorsTextBox.Text.Length < 1)
            //{
            //    validated = false;
            //    lblValidateDoor.Text = "Portas inválido";
            //}
            //if (brandTextBox.Text.Length < 2)
            //{
            //    validated = false;
            //    lblValidateBrand.Text = "A propriedade Marca deve ter no mínimo 2 caracteres";
            //}

            return validated;
        }

        private void CleanForm()
        {
            modelTextBox.Text = "";
            yearTextBox.Text = "";
            chassisTextBox.Text = "";
            brandComboBox.SelectedIndex = -1;
            steeringComboBox.SelectedIndex = -1;
            originComboBox.SelectedIndex = -1;
            transmissionComboBox.SelectedIndex = -1;
            eletronicWindowCheckBox.Checked = false;
            colorTextBox.Text = "";
            doorsComboBox.SelectedIndex = -1;
            yearTextBox.Text = "";
            imageTextBox.Text = "";
            priceTextBox.Text = "";
            pbxCarImage = null;

            modelTextBox.Focus();
        }

        private void CleanValidateForm()
        {
            //lblValidateBrand.Text = "";
            //lblValidateChassis.Text = "";
            //lblValidateDoor.Text = "";
            //lblValidateName.Text = "";
            //lblValidateYear.Text = "";
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                od.Filter = "Documento de imagem|*.png;*.jpg;*.jpeg";

                od.ShowDialog();
                if (!string.IsNullOrEmpty(od.FileName))
                {
                    imageTextBox.Text = od.FileName;
                    pbxCarImage.Load(imageTextBox.Text);
                }
            }
            catch
            {
                MessageBox.Show("Algum erro aconteceu ao selecionar a imagem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopyImage(string file)
        {
            if (imageTextBox.Text != null)
            {
                string fileName = file;
                string targetPath = @"C:\Users\Lucas\source\repos\PartidaDDD\PartidaDDD.Presentation\DBImages\Cars";
                string sourceFile = imageTextBox.Text;
                string destFile = Path.Combine(targetPath, DateTime.Now.ToString() + Path.GetExtension(imageTextBox.Text));

                if (!Directory.Exists(targetPath))
                {
                    Directory.CreateDirectory(targetPath);
                }

                FileInfo fi = new FileInfo(sourceFile);
                fi.CopyTo(@"C:\Users\Lucas\source\repos\PartidaDDD\PartidaDDD.Presentation\DBImages" + fileName + DateTime.Now.ToString());

                //File.Copy(sourceFile, destFile, true);
            }
        }
    }
}
