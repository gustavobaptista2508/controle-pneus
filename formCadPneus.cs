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
    public partial class formCadPneus : Form
    {
        public formCadPneus()
        {
            InitializeComponent();
        }

        public string NumFogo;
        public string Quilometragem;
        public DateTime DataCadastro;
        public int Marca;
        public int Modelo;
        public int Local;
        public int Status;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulaCombo();
        }

        private void cboMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //POPULAR CBOMODELO
            var Modelo = new dsPneusTableAdapters.ModeloPneuTableAdapter();
            cboModelo.ValueMember = "IdModelo";
            cboModelo.DisplayMember = "DescricaoModelo";
            cboModelo.DataSource = Modelo.ObterPorMarca(Convert.ToInt32(cboMarca.SelectedValue));
        }

        private void cboStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboStatus.Text == "NOVO")
            {
                txtQuilometragem.Text = "0";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var pneu = new dsPneusTableAdapters.PneuTableAdapter();
            int afetados = -1;
            try
            {
                afetados = pneu.InsertPneus(Convert.ToInt32(txtNumFogo.Text), (Int32)cboMarca.SelectedValue, (Int32)cboModelo.SelectedValue,
                    (Int32)cboStatus.SelectedValue, Convert.ToInt32(txtQuilometragem.Text),
                    dateTimePicker1.Value.Date.ToShortDateString(), (Int32)cboLocal.SelectedValue);
                if (afetados >= 1)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
