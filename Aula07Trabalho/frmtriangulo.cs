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
    public partial class frmtriangulo : Form
    {
        public frmtriangulo()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double baset = Convert.ToDouble(txtbase.Text);
            double alt = Convert.ToDouble(txtAlt.Text);
            double area = (baset * alt) / 2;

            MessageBox.Show("Área do Triângulo: " + area);
        }
    }
}
