using System.Collections.Generic;
using ApreensaoVeiculo.Dominio;
using ApreensaoVeiculo.Dominio.contrato;
using System;
using System.Linq;

namespace ApreensaoVeiculo.Aplicacao
{
    public class ConsultaAplicacao
    {

        private readonly IRepositorio<Consulta> repositorio;
        private readonly IRepositorio<Apreensao> repositorioApreensao;
        private readonly IRepositorio<TabelaPreco> repositorioTabelaPreco;
        //private Repositorio.ConsultaDAO consultaDAO;

        public ConsultaAplicacao(IRepositorio<Consulta> repo, IRepositorio<Apreensao> repoApre, IRepositorio<TabelaPreco> repoTab)
        {
            repositorio = repo;
            repositorioApreensao = repoApre;
            repositorioTabelaPreco = repoTab;
        }


        public void Salvar(Consulta consulta)
        {
            repositorio.Salvar(consulta);
        }

        public void Excluir(Consulta consulta)
        {
            repositorio.Excluir(consulta);
        }

        public Consulta ListarPorId(string id)
        {
            return repositorio.ListarPorId(id);
        }




        private void AtualizarQtdeDiasApreendidos(IEnumerable<Apreensao> listaApreensao, TabelaPreco tabelaPreco)
        {
            foreach (var item in listaApreensao)
            {
                var dtApreensao = default(DateTime);
                var dtAtual = DateTime.Now.ToLocalTime();
                DateTime.TryParse(item.DataApreensao, out dtApreensao);

                var qtdeDias = (-1 * (int)(dtApreensao - dtAtual).TotalDays);

                var valorDiariaInt = Decimal.Parse(tabelaPreco.ValorDiaria);
                var valorGuinchoInt = Decimal.Parse(tabelaPreco.ValorGuincho);
                item.QtdeDias = qtdeDias;
                item.ValorTotal = ((qtdeDias * valorDiariaInt) + valorGuinchoInt);


                //regra dos 5 dias
                //if (qtdeDias >= 5)
                //{
                //    item.QtdeDias = qtdeDias;
                //    item.ValorTotal = ((qtdeDias * valorDiariaInt) + valorGuinchoInt);
                //}
                //else
                //{
                //    item.QtdeDias = qtdeDias;
                //    item.ValorTotal = valorGuinchoInt;
                //}

                //item.ValorTotal = Int32.Parse(tabelaPreco.ValorGuincho);
                //item.QtdeDias = qtdeDias;
            }
        }


        public Consulta ObterConsulta()
        {

            var apreensao = repositorioApreensao.ListarTodos();
            var tabelaPreco = repositorioTabelaPreco.ListarTodos().FirstOrDefault();

            AtualizarQtdeDiasApreendidos(apreensao, tabelaPreco);

            return new Consulta
            {
                ListaApreensao = apreensao,
                TabelaPreco = tabelaPreco
            };

        }

        //private void AtualizarQtdeDiasApreendidos(IEnumerable<Apreensao> apreensao, IEnumerable<TabelaPreco> tabelaPreco)
        //{
        //    throw new NotImplementedException();
        //}


    }
}
