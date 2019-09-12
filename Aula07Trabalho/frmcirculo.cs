using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula07Trabalho
{
    public partial class frmcirculo : Form
    {
        public frmcirculo()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double raio = Convert.ToDouble(txtConfirmar.Text);
            double area = 3.14 * (raio * raio);
            double perimetro = 3.14 * 2 * raio;

            MessageBox.Show("Área do circulo é: " + area);
            MessageBox.Show("Perímetro do circulo é: " + perimetro);
        }
    }
}
