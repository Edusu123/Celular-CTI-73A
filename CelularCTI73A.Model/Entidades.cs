using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI73A.Model.Entidades
{
    public class Fabricante
    {
        private Int64 id_Fabricante;
        private string nome;
        private string cnpj;

        public Int64 Id_Fabricante
        {
            get { return id_Fabricante; }
            set { id_Fabricante = value; }
        }

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }

    public class Aparelho
    {
        private Int64 id_aparelho;
        private Fabricante fabricante;
        private string modelo;
        private decimal altura;
        private decimal largura;
        private decimal espessura;
        private decimal peso;
        private decimal preco;
        private int quantidade;
        private decimal desconto;

        public long Id_aparelho { get { return id_aparelho; } set { id_aparelho = value; } }

        public Fabricante Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        public string Modelo { get => modelo; set => modelo = value; }
        public decimal Altura 
        { 
            get => altura;
            set
            {
                if (value <= 0)
                    throw new ApplicationException("O valor da altura não pode ser menor ou igua a zero !!!");
                else
                    altura = value;
            }
        }
        public decimal Largura { get => largura; set => largura = value; }
        public decimal Espessura { get => espessura; set => espessura = value; }
        public decimal Peso { get => peso; set => peso = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public decimal Desconto { get => desconto; set => desconto = value; }

        //MÉTODOS DA CLASSE APARELHO - OVERLOAD DE DO MÉTODO TOSTRING

        public override string ToString()
        {

            return Modelo + " - " + Fabricante.Nome + " - " + Preco.ToString("C") + " " + "(" + Quantidade + " em estoque)";
        }
    } 

    public class Pedido
    {
        private Int64 id_Pedido;
        private Aparelho aparelho;
        private DateTime datahorapedido;
        private string observacao;

        public long Id_Pedido { get => id_Pedido; set => id_Pedido = value; }
        public Aparelho Aparelho { get => aparelho; set => aparelho = value; }
        public DateTime Datahorapedido { get => datahorapedido; set => datahorapedido = value; }
        public string Observacao { get => observacao; set => observacao = value; }
    }
}
