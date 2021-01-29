using CelularCTI73A.Model;
using CelularCTI73A.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CelularCTI73A.Desktop
{
    public partial class frmPrincipal : Form
    {
        private List<Aparelho> aparelho = new List<Aparelho>();
        private List<Fabricante> fabricante = new List<Fabricante>();

        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            aparelho = Servico.BuscarAparelho();
            foreach (Aparelho ap in aparelho)
            {
                lstCelular.Items.Add(ap.ToString());
            }
            fabricante = Servico.BuscarFabricante();
            foreach (Fabricante fab in fabricante)
            {
                cmbFabricante.Items.Add(fab.Nome);
            }
        }
        private void preencherLista()
        {
            lstCelular.Items.Clear();
            foreach (Aparelho a in aparelho)
            {
                lstCelular.Items.Add(a);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new frmNovoAparelho().Show();
        }
        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            aparelho = Servico.BuscarAparelho("");
            preencherLista();
        }

        private void btnBuscaPreco_Click(object sender, EventArgs e)
        {
            float precoMin = (float)Convert.ToDouble(txtPrecoMin.Text);
            float precoMax = (float)Convert.ToDouble(txtPrecoMax.Text);
            aparelho = Servico.BuscarAparelho(precoMin, precoMax);
            preencherLista();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Aparelho selecionado = aparelho[lstCelular.SelectedIndex];
            if (selecionado.Quantidade > 0)
            {
                new frmComprar(selecionado).Show();
            }
            else
            {
                MessageBox.Show("Não há aparelhos deste modelo no estoque!");
            }
        }

        private void btnBuscaModelo_Click(object sender, EventArgs e)
        {
            aparelho = Servico.BuscarAparelho(txtBuscarModelo.Text);
            preencherLista();
        }

        private void btnBuscaFabricante_Click_1(object sender, EventArgs e)
        {
            Fabricante selecionado = Servico.BuscarFabricante(cmbFabricante.SelectedItem.ToString())[0];
            aparelho = Servico.BuscarAparelho(selecionado);
            preencherLista();
        }

        private void btnNovoFabricante_Click(object sender, EventArgs e)
        {
            new frmNovoFabricante().Show();
        }
    }
}
