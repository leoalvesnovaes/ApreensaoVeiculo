using ApreensaoVeiculo.Repositorio;
using ApreensaoVeiculo.RepositorioADO;

namespace ApreensaoVeiculo.Aplicacao
{
    public class ConsultaAplicacaoConstrutor
    {

        public static ConsultaAplicacao ConsultaApADO()
        {
            return new ConsultaAplicacao(new ConsultaDAO(), new ApreensaoADO(), new TabelaPrecoADO());
        }

    }
}
