using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApreensaoVeiculo.Dominio;
using ApreensaoVeiculo.Dominio.contrato;
using ApreensaoVeiculo.Dominio.ViewModel;

namespace ApreensaoVeiculo.Aplicacao
{
    public class ApreensaoAplicacao
    {
        private readonly IRepositorio<Apreensao> repositorio;
        private readonly IRepositorio<ApreensaoCombo> repositorioMarca;

        public ApreensaoAplicacao(IRepositorio<Apreensao> repo)
        {
            repositorio = repo;
            
        }


        public void Salvar(Apreensao apreensao)
        {
            repositorio.Salvar(apreensao);
        }

        public void Excluir(Apreensao apreensao)
        {
            repositorio.Excluir(apreensao);
        }

        public IEnumerable<Apreensao> ListarTodos()
        {


            return repositorio.ListarTodos();
        }

       


        public Apreensao ListarPorId(string id)
        {
            return repositorio.ListarPorId(id);
        }


    }
}
