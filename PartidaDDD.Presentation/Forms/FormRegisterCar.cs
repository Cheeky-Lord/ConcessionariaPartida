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
            var registerCar = (RegisterCar)registerCarBindingSource.Current;
            _handler.Handler(registerCar);
        }

        private void FormRegisterCar_Load(object sender, EventArgs e)
        {
            registerCarBindingSource.AddNew();
        }
    }
}
