using ApreensaoVeiculo.Repositorio;
using ApreensaoVeiculo.RepositorioADO;

namespace ApreensaoVeiculo.Aplicacao
{
    public class TabelaPrecoAplicacaoConstrutor
    {
        public static TabelaPrecoAplicacao TabelaPrecoApADO()
        {
            return new TabelaPrecoAplicacao(new TabelaPrecoADO());
        }
    }
}
