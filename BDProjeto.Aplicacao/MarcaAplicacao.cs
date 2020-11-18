using System.Collections.Generic;
using ApreensaoVeiculo.Dominio;
using ApreensaoVeiculo.Dominio.contrato;
using System;
using System.Linq;

namespace ApreensaoVeiculo.Aplicacao
{
    public class MarcaAplicacao
    {

        private readonly IRepositorio<Marca> repoMarca;


        public MarcaAplicacao(IRepositorio<Marca>repoM)
        {
            repoMarca = repoM;
        }

        public IEnumerable<Marca> ListarTodos()
        {
            return repoMarca.ListarTodos();
        }

    }
}
