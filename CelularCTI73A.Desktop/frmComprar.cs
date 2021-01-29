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
    public partial class frmComprar : Form
    {
        Aparelho aparelho;
        public frmComprar(Aparelho aparelho)
        {
            InitializeComponent();
            this.aparelho = aparelho;
            lblFabricante.Text = aparelho.Fabricante.Nome;
            lblModelo.Text = aparelho.Modelo;
            lblDimensoes.Text = aparelho.Largura + "x" +
            aparelho.Altura + "x" +
            aparelho.Espessura + " cm";
            lblPeso.Text = aparelho.Peso + " g";
            lblQuantidade.Text = aparelho.Quantidade + " em estoque";
            lblPreco.Text = "R$ " + aparelho.Preco;
            lblDesconto.Text = aparelho.Desconto + "% a vista";
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Servico.Comprar(aparelho);
            MessageBox.Show("Pedido cadastrado com sucesso!");
            this.Close();
        }

        private void frmComprar_Load(object sender, EventArgs e)
        {

        }
    }
}
