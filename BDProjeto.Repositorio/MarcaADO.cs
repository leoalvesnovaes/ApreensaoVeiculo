using ApreensaoVeiculo.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApreensaoVeiculo.Dominio;
using ApreensaoVeiculo.Repositorio;
using System.Data.SqlClient;

namespace ApreensaoVeiculo.Repositorio
{
    public class MarcaADO : IRepositorio<Marca>
    {
        private bd bd;


        public IEnumerable<Marca> ListarTodos()
        {
            using (bd = new bd())
            {

                var strQuery = "select * from marca ";
                var retorno = bd.ExecutaComandoComRetorno(strQuery);
                return ReaderEmLista(retorno);
            }
        }

        public Marca ListarPorId(string id)
        {
            using (bd = new bd())
            {
                var strQuery = string.Format("select * from marca where codigo = {0}", id);
                var retorno = bd.ExecutaComandoComRetorno(strQuery);
                return ReaderEmLista(retorno).FirstOrDefault();
            }

        }

        private List<Marca> ReaderEmLista(SqlDataReader reader)
        {

            var marca = new List<Marca>();

            while (reader.Read())
            {
                var tempoObjeto = new Marca()
                {
                    Codigo = int.Parse(reader["codigo"].ToString()),
                    Descricao = reader["descricao"].ToString()


                };

                marca.Add(tempoObjeto);
            }

            reader.Close();
            return marca;
        }





        public void Inserir(Marca tabelapreco)
        {
            //    var strQuery = "";
            //    strQuery += "insert into tabelapreco(descricao, valordiaria, valorguincho, datacadastro, dataalteracaocadastro)";
            //    strQuery += string.Format(" values ('{0}','{1}','{2}', convert(datetime, '{3}',103), convert(datetime, '{4}',103))", tabelapreco.Descricao, tabelapreco.ValorDiaria, tabelapreco.ValorGuincho, tabelapreco.DataCadastro, tabelapreco.DataAlteracaoCadastro
            //        );
            //    using (bd = new bd())
            //    {
            //        bd.ExecutaComando(strQuery);
            //    }
        }


        public void Alterar(Marca tabelapreco)
        {
            //var strQuery = "";
            //strQuery += "update tabelapreco set ";
            //strQuery += string.Format("descricao = '{0}', ", tabelapreco.Descricao);
            //strQuery += string.Format("valordiaria = '{0}', ", tabelapreco.ValorDiaria);
            //strQuery += string.Format("valorguincho = '{0}', ", tabelapreco.ValorGuincho);
            //strQuery += string.Format("datacadastro = convert(datetime, '{0}',103) ,", tabelapreco.DataCadastro);
            //strQuery += string.Format("dataalteracaocadastro = convert(datetime, '{0}',103) ", tabelapreco.DataAlteracaoCadastro);

            //strQuery += string.Format("where codigo = {0} ", tabelapreco.Codigo);

            //using (bd = new bd())
            //{
            //    bd.ExecutaComando(strQuery);
            //}

        }

        public void Salvar(Marca tabelapreco)
        {
            //if (tabelapreco.Codigo > 0)
            //{
            //    Alterar(tabelapreco);
            //}
            //else
            //{
            //    Inserir(tabelapreco);
            //}
        }

        public void Excluir(Marca tabelapreco)
        {
            //using (bd = new bd())
            //{
            //    var strQuery = string.Format("delete from tabelapreco where codigo = {0} ", tabelapreco.Codigo);
            //    bd.ExecutaComando(strQuery);
            //}
        }



    }
}
