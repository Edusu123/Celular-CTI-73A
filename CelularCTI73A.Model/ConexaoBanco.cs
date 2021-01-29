using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;


namespace CelularCTI73A.Model.Suporte
{
    public static class ConexaoBanco
    {
        //Variavel que contem os dados da conexão ao banco
        //postgres utilizando o npgsql que é um drive nativo
        //para acesso ao postgres para o C#
        static string stringConexao =
                        "Server = localhost; " +
                        "Database = Celular73A; Port=5432;" +
                        "User ID= postgres; password = postgres;";
        /*
        static string stringConexao =
        "Server = 200.145.153.172; " +
        "Database = turma73b ;" +
        "User ID= turma73b; password = chuchuverde;";
        */
        static NpgsqlConnection cn;
        public static void conectar()
        {
            if (cn == null)
                cn = new NpgsqlConnection();
            try
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.ConnectionString = stringConexao;
                    cn.Open();
                }
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
        public static void desconectar()
        {
            cn.Close(); // fecha a conexão com o banco de dados
            cn.Dispose(); // libera os recursos utilizados
            cn = null;
        }
        //Executa uma query no banco de dados. (Sem retorno)
        // insert - update - delete
        public static void executar(string sql)
        {
            try
            {
                conectar();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                desconectar();
            }
        }
        //Executa uma query no banco de dados com parametros
        public static void executar(string sql, List<object> parametros)
        {
            try
            {
                conectar();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cn;
                int i = 1;
                foreach (object parametro in parametros)
                    cmd.Parameters.AddWithValue(i++.ToString(), parametro);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                desconectar();
            }
        }
        //Executa uma query no banco de dados com parametros retornando 'campoRetorno'
        public static int executar(string sql, List<object> parametros, string campoRetorno)
        {
            try
            {
                conectar();
                NpgsqlCommand cmd = new NpgsqlCommand();
                int modificado = 0;
                cmd.CommandText = sql + " RETURNING " + campoRetorno;
                cmd.Connection = cn;
                int i = 1;
                foreach (object parametro in parametros)
                    cmd.Parameters.AddWithValue(i++.ToString(), parametro);
                modificado = Convert.ToInt32(cmd.ExecuteScalar());
                return modificado;
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                desconectar();
            }
        }
        //Select simples retornando um DataReader
        public static NpgsqlDataReader selecionar(string sql)
        {
            try
            {
                conectar();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (NpgsqlException ex)
            {
                desconectar();
                throw new ApplicationException(ex.Message);
            }
        }
        //Select com parametros retornando um DataReader
        public static NpgsqlDataReader selecionar(string sql, List<object> parametros)
        {
            try
            {
                conectar();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cn;
                int i = 1;
                foreach (object parametro in parametros)
                    cmd.Parameters.AddWithValue(i++.ToString(), parametro);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (NpgsqlException ex)
            {
                desconectar();
                throw new ApplicationException(ex.Message);
            }
        }
        // Select retornando os dados em um DataTable
        public static DataTable selecionarDataTable(string sql)
        {
            try
            {
                conectar();
                // Cria o objeto DataTable
                DataTable dt = new DataTable();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                desconectar();
            }
        }
        public static DataSet selecionarDataSet(string sql)
        {
            try
            {
                conectar();
                // Cria o objeto DataSet
                DataSet ds = new DataSet();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                desconectar();
            }
        }
        public static DataSet selecionarDataSet(string tabela, string campos, string where = "", string orderBy = "")
        {
            try
            {
                conectar();
                // Cria o objeto DataSet
                DataSet ds = new DataSet();
                string sql = @"select " + campos + " from " + tabela;
                if (where != "")
                    sql += @" where " + where + " ";
                if (orderBy != "")
                    sql += @" order by " + orderBy + " ";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(ds, tabela);
                return ds;
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                desconectar();
            }
        }
    }
}
