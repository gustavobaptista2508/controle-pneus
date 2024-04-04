using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Pneus
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void TesteConexao()
        {

        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formListagemPneus listagemPneus = new formListagemPneus();
            listagemPneus.MdiParent = this;
            listagemPneus.Show();
        }

        private void btnVeiculosList_Click(object sender, EventArgs e)
        {

        }
    }
}
