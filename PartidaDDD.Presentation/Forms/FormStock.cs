using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PartidaDDD.Domain.Entities;
using PartidaDDD.Domain.Repositories;

namespace PartidaDDD.Presentation.Forms
{
    public partial class FormStock : Form
    {
        private List<Car> cars = new List<Car>();
        private readonly ICarRepository _carRepository;

        public FormStock(ICarRepository carRepository)
        {
            _carRepository = carRepository;

            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchType = cbxSearchType.Text;

                switch (searchType)
                {
                    case "Todos":
                        cars = _carRepository.GetAll();
                        break;
                    case "Cor":
                        cars = _carRepository.FindByColor(txtSearch.Text);
                        break;
                    case "Modelo":
                        cars = _carRepository.FindByModel(txtSearch.Text);
                        break;
                    case "Origem":
                        cars = _carRepository.FindByOrigin(txtSearch.Text);
                        break;
                    case "Ano":
                        cars = _carRepository.FindByYear(Convert.ToInt32(txtSearch.Text));
                        break;
                    default:
                        MessageBox.Show("Nenhum valor informado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                dgvCars.DataSource = cars;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
        }

        private void dgvCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblModel.Text = dgvCars.CurrentCell.Value.ToString();
        }

        private void cbxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSearchType.Text == "Todos")
                txtSearch.Enabled = false;
            else
                txtSearch.Enabled = true;
        }
    }
}
