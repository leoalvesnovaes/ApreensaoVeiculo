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
    public class ApreensaoADO:IRepositorio<Apreensao>
    {

        private bd bd;

        public void Inserir(Apreensao apreensao)
        {
            var strQuery = "";
            strQuery += "insert into apreensao( ";
            strQuery += "dataapreensao, ";
            strQuery += "dataliberacao, ";
            strQuery += "guirecolhimento, ";
            strQuery += "localrecolhimento, ";
            strQuery += "motivo, ";
            strQuery += "nome, ";
            strQuery += "cnh, ";
            strQuery += "cpf, ";
            strQuery += "rg, ";
            strQuery += "placa, ";
            strQuery += "renan, ";
            strQuery += "marca, ";
            strQuery += "modelo, ";
            strQuery += "versao, ";
            strQuery += "tipo, ";
            strQuery += "km, ";
            strQuery += "portas, ";
            strQuery += "cor, ";
            strQuery += "ano, ";

            strQuery += string.Format(" values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}')",
                apreensao.DataApreensao, 
                apreensao.DataLiberacao,
                apreensao.GuiaRecolhimento,
                apreensao.LocalRecolhimento, 
                apreensao.Motivo, 
                apreensao.Nome, 
                apreensao.Cnh, 
                apreensao.Cpf, 
                apreensao.Rg, 
                apreensao.Placa, 
                apreensao.Renavan, 
                apreensao.Marca, 
                apreensao.Modelo, 
                apreensao.Versao, 
                apreensao.Tipo,
                apreensao.Km, 
                apreensao.Portas, 
                apreensao.Cor,
                apreensao.Ano                
                
                );
            using (bd = new bd())
            {
                bd.ExecutaComando(strQuery);
            }
        }


        public void Alterar(Apreensao apreensao)
        {
            var strQuery = "";
            //strQuery += "update apreensao set ";
            //strQuery += string.Format("descricao = '{0}', ", apreensao.Descricao);
            //strQuery += string.Format("cargo = '{0}', ", apreensao.Cargo);
            //strQuery += string.Format("datacadastro = convert(datetime, '{0}',103), ", apreensao.Data);
            //strQuery += string.Format("login = '{0}', ", apreensao.Login);
            //strQuery += string.Format("senha = '{0}' ", apreensao.Senha);
            //strQuery += string.Format("where codigo = {0} ", apreensao.Codigo);

            using (bd = new bd())
            {
                bd.ExecutaComando(strQuery);
            }

        }


        public void Salvar(Apreensao apreensao)
        {
            if (apreensao.Codigo > 0)
            {
                Alterar(apreensao);
            }
            else
            {
                Inserir(apreensao);
            }
        }

        public void Excluir(Apreensao apreensao)
        {
            throw new NotImplementedException();
        }





        public IEnumerable<Apreensao> ListarTodos()
        {
            using (bd = new bd())
            {
                //var strQuery = "select codigo, Placa, modelo, dataapreensao, nome from APREENSAO where dataliberacao is null";
                var strQuery = "select * from APREENSAO where dataliberacao is null";
                var retorno = bd.ExecutaComandoComRetorno(strQuery);
                return ReaderEmLista(retorno);
            }
        }




        public IEnumerable<Marca> ListarMarcas()
        {
            using (bd = new bd())
            {
                //var strQuery = "select codigo, Placa, modelo, dataapreensao, nome from APREENSAO where dataliberacao is null";
                var strQuery = "select * from Marca ";
                var retorno = bd.ExecutaComandoComRetorno(strQuery);
                return ReaderEmListaMarca(retorno);
            }
        }

        private List<Marca> ReaderEmListaMarca(SqlDataReader reader)
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






        public Apreensao ListarPorId(string id)
        {
            using (bd = new bd())
            {
                var strQuery = string.Format("select * from apreensao where codigo = {0}", id);
                var retorno = bd.ExecutaComandoComRetorno(strQuery);
                return ReaderEmLista(retorno).FirstOrDefault();
            }
        }

        private List<Apreensao> ReaderEmLista(SqlDataReader reader)
        {

            var apreensao = new List<Apreensao>();

            while (reader.Read())
            {
                var tempoObjeto = new Apreensao()
                {
                    Codigo = int.Parse(reader["codigo"].ToString()),

                    DataApreensao = reader["dataapreensao"].ToString(),
                    DataLiberacao = reader["dataliberacao"].ToString(),
                    GuiaRecolhimento = reader["guiarecolhimento"].ToString(),
                    LocalRecolhimento = reader["localrecolhimento"].ToString(),
                    Motivo = reader["motivo"].ToString(),
                    
                    Nome = reader["nome"].ToString(),
                    Cnh = reader["cnh"].ToString(),
                    Cpf = reader["cpf"].ToString(),
                    Rg = reader["rg"].ToString(),
                    
                    
                    Placa = reader["placa"].ToString(),
                    Renavan = reader["renavan"].ToString(),
                    Marca = reader["marca"].ToString(),
                    Modelo = reader["modelo"].ToString(),
                    Versao = reader["versao"].ToString(),
                    Tipo = reader["tipo"].ToString(),
                    Km = reader["km"].ToString(),
                    Portas = reader["portas"].ToString(),
                    Cor = reader["cor"].ToString(),
                    Ano = reader["ano"].ToString(),

                };

                apreensao.Add(tempoObjeto);
            }

            reader.Close();
            return apreensao;
        }

    }
}
