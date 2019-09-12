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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cálculoCirculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcirculo objTela = new frmcirculo();
            objTela.MdiParent = this;

            objTela.Show();
        }

        private void cálculoTrianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtriangulo objTela = new frmtriangulo();
            objTela.MdiParent = this;

            objTela.Show();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaluno objTela = new frmaluno();
            objTela.MdiParent = this;

            objTela.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmfuncionario objTela = new frmfuncionario();
            objTela.MdiParent = this;

            objTela.Show();
        }
    }
}
