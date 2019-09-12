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
    public partial class frmfuncionario : Form
    {
        public frmfuncionario()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double salario = Convert.ToDouble(txtSal.Text);
            double grat = salario * 0.05;
            double imposto = (salario + grat) * 0.07;
            double resultado = salario + grat - imposto;

            MessageBox.Show("Salário a receber: " + resultado);
        }
    }
}
