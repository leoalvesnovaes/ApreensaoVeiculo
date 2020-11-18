using ApreensaoVeiculo.Dominio;
using ApreensaoVeiculo.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApreensaoVeiculo.Repositorio
{
    public class TabelaPrecoADO : IRepositorio<TabelaPreco>
    {
        private bd bd;

        public void Inserir(TabelaPreco tabelapreco)
        {
            var strQuery = "";
            strQuery += "insert into tabelapreco(descricao, valordiaria, valorguincho, datacadastro, dataalteracaocadastro)";
            strQuery += string.Format(" values ('{0}','{1}','{2}', convert(datetime, '{3}',103), convert(datetime, '{4}',103))", tabelapreco.Descricao, tabelapreco.ValorDiaria, tabelapreco.ValorGuincho, tabelapreco.DataCadastro, tabelapreco.DataAlteracaoCadastro
                );
            using (bd = new bd())
            {
                bd.ExecutaComando(strQuery);
            }
        }


        public void Alterar(TabelaPreco tabelapreco)
        {
            var strQuery = "";
            strQuery += "update tabelapreco set ";
            strQuery += string.Format("descricao = '{0}', ", tabelapreco.Descricao);
            strQuery += string.Format("valordiaria = '{0}', ", tabelapreco.ValorDiaria);
            strQuery += string.Format("valorguincho = '{0}', ", tabelapreco.ValorGuincho);
            strQuery += string.Format("datacadastro = convert(datetime, '{0}',103) ,", tabelapreco.DataCadastro);
            strQuery += string.Format("dataalteracaocadastro = convert(datetime, '{0}',103) ", tabelapreco.DataAlteracaoCadastro);

            strQuery += string.Format("where codigo = {0} ", tabelapreco.Codigo);

            using (bd = new bd())
            {
                bd.ExecutaComando(strQuery);
            }

        }

        public void Salvar(TabelaPreco tabelapreco)
        {
            if (tabelapreco.Codigo > 0)
            {
                Alterar(tabelapreco);
            }
            else
            {
                Inserir(tabelapreco);
            }
        }

        public void Excluir(TabelaPreco tabelapreco)
        {
            using (bd = new bd())
            {
                var strQuery = string.Format("delete from tabelapreco where codigo = {0} ", tabelapreco.Codigo);
                bd.ExecutaComando(strQuery);
            }
        }

        public IEnumerable<TabelaPreco> ListarTodos()
        {
            using (bd = new bd())
            {
                var strQuery = "select * from tabelapreco";
                var retorno = bd.ExecutaComandoComRetorno(strQuery);
                return ReaderEmLista(retorno);
            }
        }


        public TabelaPreco ListarPorId(string id)
        {
            using (bd = new bd())
            {
                var strQuery = string.Format("select * from tabelapreco where codigo = {0}", id);
                var retorno = bd.ExecutaComandoComRetorno(strQuery);
                return ReaderEmLista(retorno).FirstOrDefault();
            }
        }

        private List<TabelaPreco> ReaderEmLista(SqlDataReader reader)
        {

            var tabelapreco = new List<TabelaPreco>();

            while (reader.Read())
            {
                var tempoObjeto = new TabelaPreco()
                {
                    Codigo = int.Parse(reader["codigo"].ToString()),
                    Descricao = reader["descricao"].ToString(),
                    ValorDiaria = reader["valordiaria"].ToString(),
                    ValorGuincho = reader["valorguincho"].ToString(),
                    DataCadastro = DateTime.Parse(reader["datacadastro"].ToString()),
                    DataAlteracaoCadastro = DateTime.Parse(reader["dataalteracaocadastro"].ToString()),
                };

                tabelapreco.Add(tempoObjeto);
            }

            reader.Close();
            return tabelapreco;
        }

        
        
        public Consulta ObterConsulta()
        {
            throw new NotImplementedException();
        }


    }
}
