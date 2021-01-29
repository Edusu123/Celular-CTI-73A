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
    public partial class frmNovoFabricante : Form
    {
        private List<Pedido> pedidos = new List<Pedido>();
        public frmNovoFabricante()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Fabricante novo = new Fabricante();
            novo.Nome = txtNomeFabricante.Text;
            novo.Cnpj = mskCnpj.Text;
            Servico.Salvar(novo);
            MessageBox.Show("O fabricante foi salvo com sucesso!");
            this.Close();
        }
    }
}
