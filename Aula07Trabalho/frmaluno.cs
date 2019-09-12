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
    public partial class frmaluno : Form
    {
        public frmaluno()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double nota = Convert.ToDouble(txtNota.Text);
            if (nota < 5)
            {
                MessageBox.Show("Reprovado");
            }
            else if (nota >= 5.0 && nota <= 6.9)
            {
                MessageBox.Show("Recuperação");
            }
            else if (nota > 6.9)
            {
                MessageBox.Show("Aprovado");
            }
        }
    }
}
