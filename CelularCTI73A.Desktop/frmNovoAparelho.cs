using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CelularCTI73A.Model.Entidades;
using CelularCTI73A.Model;

namespace CelularCTI73A.Desktop
{
    public partial class frmNovoAparelho : Form
    {
        private List<Fabricante> fabricantes = new List<Fabricante>();
        public frmNovoAparelho()
        {
            InitializeComponent();
        }

        private void frmNovoAparelho_Load(object sender, EventArgs e)
        {
            fabricantes = Servico.BuscarFabricante();
            foreach(Fabricante f in fabricantes)
            {
                cmbFabricante.Items.Add(f.Nome);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aparelho novo = new Aparelho();
            novo.Modelo = txtModelo.Text;
            novo.Largura = Convert.ToDecimal(txtLargura.Text);
            novo.Altura = Convert.ToDecimal(txtAltura.Text);
            novo.Espessura = Convert.ToDecimal(txtEspessura.Text);
            novo.Peso = Convert.ToInt16(txtPeso.Text);
            novo.Quantidade = Convert.ToInt16(txtQuantidade.Text);
            novo.Preco = Convert.ToDecimal(txtPreco.Text);
            novo.Desconto = Convert.ToDecimal(txtDesconto.Text);
            novo.Fabricante = fabricantes[cmbFabricante.SelectedIndex];
            Servico.Salvar(novo);
            MessageBox.Show("O aparelho foi salvo com sucesso!");
            this.Close();
        }
    }
}
