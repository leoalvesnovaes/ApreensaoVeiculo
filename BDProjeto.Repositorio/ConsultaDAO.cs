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
    public class ConsultaDAO:IRepositorio<Consulta>
    {
        private bd bd;

        public void Inserir(Consulta consulta) 
        { 
        }

        public void Salvar(Consulta consulta)
        {
            //if (apreensao.Codigo > 0)
            //{
            //    Alterar(apreensao);
            //}
            //else
            //{
            //    Inserir(apreensao);
            //}
        }

        public void Excluir(Consulta consulta)
        {
            throw new NotImplementedException();
        }


        public void Alterar(Consulta consulta)
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






        public Consulta ListarPorId(string id)
        {
            using (bd = new bd())
            {
                var strQuery = string.Format("select * from apreensao where codigo = {0}", id);
                var retorno = bd.ExecutaComandoComRetorno(strQuery);
                return ReaderEmLista(retorno).FirstOrDefault();
            }
        }


        public List<Apreensao> ObterTodasAsApreensoes()
        {
            var apreensaoRetorno = new List<Apreensao>();

            using (bd = new bd())
            {
                //var strQuery = "select codigo, Placa, modelo, dataapreensao, nome from APREENSAO where dataliberacao is null";
                var strQuery = "select * from APREENSAO ";
                var reader = bd.ExecutaComandoComRetorno(strQuery);

                while (reader.Read())
	            {
	                apreensaoRetorno.Add(new Apreensao
                    {
                        Codigo = reader.GetInt32(reader.GetOrdinal("codigo")),
                        Placa = reader.GetString(reader.GetOrdinal("placa")),
                        Modelo = reader.GetString(reader.GetOrdinal("modelo")),
                        DataApreensao = reader.GetString(reader.GetOrdinal("dataapreensao")),
                        Nome = reader.GetString(reader.GetOrdinal("nome"))
                        
                    });
	            }
                
            }

            return apreensaoRetorno;
        }

        public TabelaPreco ObterTabelaPreco()
        {
            var tabelaPreco = new TabelaPreco();

            using (bd = new bd())
            {
                var strQuery = "select * from TABELAPRECO ";
                var reader = bd.ExecutaComandoComRetorno(strQuery);

                while (reader.Read())
                {
                    tabelaPreco.Codigo = reader.GetInt32(reader.GetOrdinal("codigo"));
                    tabelaPreco.ValorDiaria = reader.GetString(reader.GetOrdinal("valordiaria"));
                    tabelaPreco.ValorGuincho = reader.GetString(reader.GetOrdinal("valorguincho"));
                }

            }

            return tabelaPreco;
        }

        //public Consulta ObterConsulta()
        //{
        //    var apreensao = ObterTodasAsApreensoes();
        //    var tabelaPreco = ObterTabelaPreco();

        //    AtualizarQtdeDiasApreendidos(apreensao, tabelaPreco);

        //    return new Consulta {
        //        ListaApreensao = apreensao,
        //        TabelaPreco = tabelaPreco
        //    };
        //}

        //private void AtualizarQtdeDiasApreendidos(List<Apreensao> listaApreensao, TabelaPreco tabelaPreco)
        //{
        //    foreach (var item in listaApreensao)
        //    {
        //        var dtApreensao = default(DateTime);
        //        var dtAtual = DateTime.Now.ToLocalTime();
        //        DateTime.TryParse(item.DataApreensao, out dtApreensao);

        //        var qtdeDias = (int)(dtApreensao - dtAtual).TotalDays;

        //        item.QtdeDias = qtdeDias;
        //    }
        //}

        private List<Consulta> ReaderEmLista(SqlDataReader reader)
        {

            var consulta = new List<Consulta>();


            while (reader.Read())
            {
                var tempoObjeto = new Consulta()
                {
                    
                    //TabelaPreco. 
                    //TabelaPreco.ValorDiaria = reader["placa"].ToString()
                    //DataApreensao = reader["dataapreensao"].ToString(),
                    //DataLiberacao = reader["dataliberacao"].ToString(),
                    //GuiaRecolhimento = reader["guiarecolhimento"].ToString(),
                    //LocalRecolhimento = reader["localrecolhimento"].ToString(),
                    //Motivo = reader["motivo"].ToString(),

                    //Nome = reader["nome"].ToString(),
                    //Cnh = reader["cnh"].ToString(),
                    //Cpf = reader["cpf"].ToString(),
                    //Rg = reader["rg"].ToString(),


                    //Placa 
                    //Renavan = reader["renavan"].ToString(),
                    //Marca = reader["marca"].ToString(),
                    //Modelo = reader["modelo"].ToString(),
                    //Versao = reader["versao"].ToString(),
                    //Tipo = reader["tipo"].ToString(),
                    //Km = reader["km"].ToString(),
                    //Portas = reader["portas"].ToString(),
                    //Cor = reader["cor"].ToString(),
                    //Ano = reader["ano"].ToString(),

                };

                consulta.Add(tempoObjeto);
            }

            reader.Close();
            return consulta;
        }



        public IEnumerable<Consulta> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
