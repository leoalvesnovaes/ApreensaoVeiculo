using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApreensaoVeiculo.Repositorio;
using ApreensaoVeiculo.RepositorioADO;

namespace ApreensaoVeiculo.Aplicacao
{
    public class ApreensaoAplicacaoConstrutor
    {
        public static ApreensaoAplicacao ApreensaoADO()
        {
            return new ApreensaoAplicacao(new ApreensaoADO());
        }
    }
}
