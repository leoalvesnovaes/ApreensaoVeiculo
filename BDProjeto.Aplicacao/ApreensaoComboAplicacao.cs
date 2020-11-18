using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApreensaoVeiculo.Dominio;
using ApreensaoVeiculo.Dominio.contrato;
using ApreensaoVeiculo.Dominio.ViewModel;

namespace ApreensaoVeiculo.RepositorioADO
{
    public class ApreensaoComboAplicacao
    {

        private readonly IRepositorio<ApreensaoCombo> repositorioMarca;

        public ApreensaoComboAplicacao(IRepositorio<ApreensaoCombo> repo)
        {
            repositorioMarca = repo;
            
        }


        public IEnumerable<ApreensaoCombo> ListarMarcas()
        {

            var listamarca = repositorioMarca.ListarTodos();

            return repositorioMarca.ListarTodos();
        }




        public void Salvar(ApreensaoCombo apreensao)
        {
            repositorioMarca.Salvar(apreensao);
        }

        public void Excluir(ApreensaoCombo apreensao)
        {
            repositorioMarca.Excluir(apreensao);
        }

        public IEnumerable<ApreensaoCombo> ListarTodos()
        {


            return repositorioMarca.ListarTodos();
        }




        public ApreensaoCombo ListarPorId(string id)
        {
            return repositorioMarca.ListarPorId(id);
        }





    }
}
