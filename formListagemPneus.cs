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
    public partial class formListagemPneus : Form
    {
        public formListagemPneus()
        {
            InitializeComponent();
        }

        private void CarregarDataGrid()
        {
            dgvPneusList.AutoGenerateColumns = false;
            try
            {
                var pneus = new dsPneusTableAdapters.PneuTableAdapter();
                dgvPneusList.DataSource = pneus.ObterListaPneus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulaCombo()
        {
            try
            {
                //POPULAR CBOMARCA
                var Marca = new dsPneusTableAdapters.MarcaTableAdapter();
                cboMarca.ValueMember = "IdMarca";
                cboMarca.DisplayMember = "DescricaoMarca";
                cboMarca.DataSource = Marca.GetData();

                //POPULAR CBOMODELO
                var Modelo = new dsPneusTableAdapters.ModeloPneuTableAdapter();
                cboModelo.ValueMember = "IdModelo";
                cboModelo.DisplayMember = "DescricaoModelo";
                cboModelo.DataSource = Modelo.ObterPorMarca(1);

                //POPULAR CBOLOCAL
                var Local = new dsPneusTableAdapters.LocaisTableAdapter();
                cboLocal.ValueMember = "IdLocal";
                cboLocal.DisplayMember = "Descricao";
                cboLocal.DataSource = Local.GetData();

                //POPULAR CBOSTATUS
                var Status = new dsPneusTableAdapters.StatusPneuTableAdapter();
                cboStatus.ValueMember = "IdStatus";
                cboStatus.DisplayMember = "Descricao";
                cboStatus.DataSource = Status.GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarFogo_Enter(object sender, EventArgs e)
        {
            txtBuscarFogo.Clear();
        }

        private void cboMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //POPULAR CBOMODELO POR MARCA
            var Modelo = new dsPneusTableAdapters.ModeloPneuTableAdapter();
            cboModelo.ValueMember = "IdModelo";
            cboModelo.DisplayMember = "DescricaoModelo";
            cboModelo.DataSource = Modelo.ObterPorMarca(Convert.ToInt32(cboMarca.SelectedValue));

            //CARREGAR DATAGRID POR MARCA
            try
            {
                var pneus = new dsPneusTableAdapters.PneuTableAdapter();
                dgvPneusList.DataSource = pneus.ObterListaPorModelo((Int32)cboModelo.SelectedValue,
                    (Int32)cboMarca.SelectedValue, (Int32)cboStatus.SelectedValue, (Int32)cboLocal.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboModelo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //CARREGAR DATAGRID POR MODELO
            try
            {
                var pneus = new dsPneusTableAdapters.PneuTableAdapter();
                dgvPneusList.DataSource = pneus.ObterListaPorModelo((Int32)cboModelo.SelectedValue,
                    (Int32)cboMarca.SelectedValue, (Int32)cboStatus.SelectedValue, (Int32)cboLocal.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboLocal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //CARREGAR DATAGRID POR LOCAL
            try
            {
                var pneus = new dsPneusTableAdapters.PneuTableAdapter();
                dgvPneusList.DataSource = pneus.ObterListaPorLocal((Int32)cboModelo.SelectedValue,
                    (Int32)cboMarca.SelectedValue, (Int32)cboStatus.SelectedValue, (Int32)cboLocal.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //CARREGAR DATAGRID POR STATUS
            try
            {
                var pneus = new dsPneusTableAdapters.PneuTableAdapter();
                dgvPneusList.DataSource = pneus.ObterListaPorStatus((Int32)cboModelo.SelectedValue,
                    (Int32)cboMarca.SelectedValue, (Int32)cboStatus.SelectedValue, (Int32)cboLocal.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void formListagemPneus_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
            PopulaCombo();
        }

        private void btnNovoPneu_Click(object sender, EventArgs e)
        {
            formCadPneus cadPneus = new formCadPneus();
            if (cadPneus.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
                CarregarDataGrid();
            }
            else
            {
                MessageBox.Show("Erro, cadastro não realizado!");
                CarregarDataGrid();
            }
        }

        private void btnBuscarFogo_Click(object sender, EventArgs e)
        {
            try
            {
                var pneus = new dsPneusTableAdapters.PneuTableAdapter();
                dgvPneusList.DataSource = pneus.ObterListaPneuPorFogo(Convert.ToInt32(txtBuscarFogo.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
