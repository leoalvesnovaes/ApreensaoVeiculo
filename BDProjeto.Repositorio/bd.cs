using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ApreensaoVeiculo.Repositorio
{
    public class bd : IDisposable
    {

        private readonly SqlConnection conexao;

        public bd()
        {

            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString);
            conexao.Open();
        }

        public bool ExecutaComando(string strQuery)
        {
            using (var cmdComando = new SqlCommand())
            {
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = conexao;

                using (var reader = cmdComando.ExecuteReader())
                {
                    return reader.Read();
                }
            }
            //var cmdComando = new SqlCommand
            //{
            //    CommandText = strQuery,
            //    CommandType = CommandType.Text,
            //    Connection = conexao
            //};
        }

        public SqlDataReader ExecutaComandoComRetorno(string strQuery)
        {
            var cmdComandoSelect = new SqlCommand(strQuery, conexao);
            return cmdComandoSelect.ExecuteReader();

        }

        public void Dispose()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }

        }
    }
}
