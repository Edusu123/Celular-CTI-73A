using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using CelularCTI73A.Model.Entidades;
using CelularCTI73A.Model.Suporte;

namespace CelularCTI73A.Model
{
    public static class Servico
    {
        // os primeiros métodos da classe Servico
        // são métodos que criam e objetos que representam
        // as entidades envolvidas no projeto
        public static Fabricante objFabricante(ref NpgsqlDataReader dtr)
        {
            Fabricante fab = new Fabricante();

            fab.Id_Fabricante = Convert.ToInt64(dtr["id_fabricante"]);
            fab.Nome = Convert.ToString(dtr["nome"]);

            return fab;
        }

        public static Aparelho objAparelho(ref NpgsqlDataReader dtr)
        {
            Aparelho ap = new Aparelho();

            ap.Id_aparelho = Convert.ToInt64(dtr["id_aparelho"]);
            ap.Modelo = dtr["modelo"].ToString();
            ap.Altura = Convert.ToDecimal(dtr["altura"]);
            ap.Largura = Convert.ToDecimal(dtr["largura"]);
            ap.Espessura = Convert.ToDecimal(dtr["espessura"]);
            ap.Peso = Convert.ToDecimal(dtr["peso"]);
            ap.Quantidade = Convert.ToInt32(dtr["quantidade"]);
            ap.Preco = Convert.ToDecimal(dtr["preco"]);
            ap.Desconto = Convert.ToDecimal(dtr["desconto"]);

            ap.Fabricante = objFabricante(ref dtr);

            return ap;
        }

        public static Pedido objPedido(ref NpgsqlDataReader dtr)
        {
            Pedido ped = new Pedido();

            ped.Id_Pedido = Convert.ToInt64(dtr["id_pedido"]);
            ped.Datahorapedido = Convert.ToDateTime(dtr["datahorapedido"]);
            ped.Observacao = dtr["observacao"].ToString();

            ped.Aparelho = objAparelho(ref dtr);

            return ped;
        }

        public static void Salvar(Aparelho ap)
        {
            string sql;
            // se o atributo id for igual a 0, significa que é inclusão;
            if (ap.Id_aparelho == 0)
            {
                sql = "INSERT INTO aparelho(id_fabricante, modelo, altura, largura, espessura, peso, preco, " +
                    "quantidade, desconto) VALUES (" + ap.Fabricante.Id_Fabricante + ", '" + ap.Modelo + "', " + ap.Altura + ", " +
                    ap.Largura + ", " + ap.Espessura + ", " + ap.Peso + ", " + ap.Preco + ", " + ap.Quantidade + ", " + ap.Desconto + ")";
                ConexaoBanco.executar(sql);
            }
            else
            {
                sql = "UPDATE aparelho(id_fabricante, modelo, altura, largura, espessura, peso, preco, " +
                    "quantidade, desconto) SET id_fabricante = " + ap.Fabricante.Id_Fabricante + ", modelo = '" + ap.Modelo + "', " +
                    "altura = " + ap.Altura + ", largura = " + ap.Largura + ", espessura = " + ap.Espessura + ", peso = " + ap.Peso +
                    ", preco = " + ap.Preco + ", quantidade = " + ap.Quantidade + ", desconto=" + ap.Desconto + " WHERE id_aparelho= " +
                    ap.Id_aparelho + "";
                ConexaoBanco.executar(sql);
            }
        }

        public static void Salvar(Fabricante fab)
        {
            string sql;
            if (fab.Id_Fabricante == 0)
            {
                sql = "INSERT INTO fabricante(nome, cnpj) VALUES ('" + fab.Nome + "', '" + fab.Cnpj + "')";
                ConexaoBanco.executar(sql);
            }
            else
            {
                sql = "UPDATE fabricante SET nome=" + fab.Nome + " WHERE id_fabricante=" + fab.Id_Fabricante + "";
                ConexaoBanco.executar(sql);
            }
        }

        public static void Salvar(Pedido ped)
        {
            string sql;
            if (ped.Id_Pedido == 0)
            {
                sql = "INSERT INTO pedido(id_aparelho, datahorapedido, observacao) " +
                                                      "VALUES(" + ped.Aparelho.Id_aparelho + ", " +
                                                                  ped.Datahorapedido + ", '" +
                                                                  ped.Observacao + "')";

                ConexaoBanco.executar(sql);
            }
            else
            {
                sql = "UPDATE pedido SET id_aparelho = " + ped.Aparelho.Id_aparelho + ", " +
                                         "datahorapedido = " + ped.Datahorapedido + ", " +
                                         "observacao = '" + ped.Observacao + "' " +
                                         "WHERE id_pedido = " + ped.Id_Pedido + "";

                ConexaoBanco.executar(sql);
            }
        }

        public static Pedido Comprar(Aparelho ap)
        {
            Pedido ped = new Pedido();
            ped.Aparelho = ap;
            ped.Datahorapedido = DateTime.Now;
            string sql;
            sql = "INSERT INTO pedido(id_aparelho, datahorapedido) VALUES (" + ped.Aparelho.Id_aparelho + ", '" + ped.Datahorapedido + "')";
            ConexaoBanco.executar(sql);
            ap.Quantidade--; //menos um aparelho no estoque.
            string sql2;
            sql2 = "UPDATE aparelho SET quantidade = " + ap.Quantidade + " WHERE id_aparelho = " + ap.Id_aparelho + "";
            ConexaoBanco.executar(sql2);
            return ped;
        }
        public static List<Aparelho> BuscarAparelho() //busca todos os aparelhos
        {
            List<Aparelho> aparelho = new List<Aparelho>();
            string sql = "SELECT * FROM aparelho INNER JOIN fabricante ON aparelho.id_fabricante=fabricante.id_fabricante ORDER BY aparelho.modelo";
            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
            while (dtr.Read())
            {
                aparelho.Add(objAparelho(ref dtr));
            }
            dtr.Close();
            return aparelho;
        }

        public static List<Aparelho> BuscarAparelho(string modelo) //busca aparelho por modelo
        {
            List<Aparelho> aparelho = new List<Aparelho>();
            string sql = "SELECT * FROM aparelho INNER JOIN fabricante ON aparelho.id_fabricante=fabricante.id_fabricante WHERE aparelho.modelo LIKE '%" + modelo + "%' ORDER BY aparelho.modelo";
            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
            while (dtr.Read())
            {
                aparelho.Add(objAparelho(ref dtr));
            }
            dtr.Close();
            return aparelho;
        }

        public static List<Aparelho> BuscarAparelho(double precoMin, double precoMax) //busca aparelho por preço
        {
            List<Aparelho> aparelho = new List<Aparelho>();
            string sql = "SELECT * FROM aparelho INNER JOIN fabricante ON aparelho.id_fabricante = fabricante.id_fabricante WHERE aparelho.preco BETWEEN " + precoMin + " and " + precoMax + " ORDER BY aparelho.preco, aparelho.modelo";
            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
            while (dtr.Read())
            {
                aparelho.Add(objAparelho(ref dtr));
            }
            dtr.Close();
            return aparelho;
        }

        public static List<Aparelho> BuscarAparelho(Fabricante fabri) //busca aparelho por fabricante
        {
            List<Aparelho> aparelho = new List<Aparelho>();
            //string sql = "SELECT * FROM aparelho WHERE aparelho.id_fabricante = " + fab.Id_Fabricante + " ORDER BY aparelho.modelo";
            string sql = "SELECT * FROM aparelho INNER JOIN fabricante ON aparelho.id_fabricante = fabricante.id_fabricante" +
                         " WHERE aparelho.id_fabricante = " + fabri.Id_Fabricante + " ORDER BY aparelho.modelo";

            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
            while (dtr.Read())
            {
                aparelho.Add(objAparelho(ref dtr));
            }
            dtr.Close();
            return aparelho;
        }

        public static List<Fabricante> BuscarFabricante() //busca todos fabricantes
        {
            List<Fabricante> fabricante = new List<Fabricante>();
            string sql = "SELECT * FROM fabricante ORDER BY nome";
            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
            while (dtr.Read())
            {
                fabricante.Add(objFabricante(ref dtr));
            }
            dtr.Close();
            return fabricante;
        }

        public static List<Fabricante> BuscarFabricante(string nome) //busca fabricantes por nome
        {
            List<Fabricante> fabricante = new List<Fabricante>();
            string sql = "SELECT * FROM fabricante WHERE nome LIKE '%" + nome + "%' ORDER BY nome";
            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
            while (dtr.Read())
            {
                fabricante.Add(objFabricante(ref dtr));
            }
            dtr.Close();
            return fabricante;
        }

        public static List<Pedido> BuscarPedido() //busca todos pedidos
        {
            List<Pedido> pedido = new List<Pedido>();
            string sql = "SELECT * FROM pedido INNER JOIN aparelho ON pedido.id_aparelho = aparelho.id_aparelho ORDER BY pedido.observacao";
            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
            while (dtr.Read())
            {
                pedido.Add(objPedido(ref dtr));
            }
            dtr.Close();
            return pedido;
        }

        public static List<Pedido> BuscarPedido(Aparelho ap) //busca pedido por aparelho
        {
            List<Pedido> pedido = new List<Pedido>();
            string sql = "SELECT * FROM pedido INNER JOIN aparelho ON pedido.id_aparelho = aparelho.id_aparelho" + "WHERE pedido.id_aparelho = " + ap.Id_aparelho + " ORDER BY pedido.observacao";
            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
            while (dtr.Read())
            {
                pedido.Add(objPedido(ref dtr));
            }
            dtr.Close();
            return pedido;
        }
    }
}