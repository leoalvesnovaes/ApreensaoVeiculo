using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApreensaoVeiculo.Dominio;
using ApreensaoVeiculo.Dominio.contrato;

namespace ApreensaoVeiculo.RepositorioADO
{
    public class TabelaPrecoAplicacao
    {
         private readonly IRepositorio<TabelaPreco> repositorio;

        public TabelaPrecoAplicacao(IRepositorio<TabelaPreco>repo)
        {
            repositorio = repo;
        }


        public void Salvar(TabelaPreco tabelapreco)
        {
            repositorio.Salvar(tabelapreco);
        }

        public void Excluir(TabelaPreco tabelapreco)
        {
            repositorio.Excluir(tabelapreco);
        }

        public IEnumerable<TabelaPreco> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public TabelaPreco ListarPorId(string id)
        {
            return repositorio.ListarPorId(id);
        }


    }
}
