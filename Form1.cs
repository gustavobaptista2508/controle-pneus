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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
