using ApreensaoVeiculo.Repositorio;
using ApreensaoVeiculo.RepositorioADO;


namespace ApreensaoVeiculo.Aplicacao
{
    public class MarcaAplicacaoConstrutor
    {
        public static MarcaAplicacao MarcaADO()
        {
            return new MarcaAplicacao(new MarcaADO());
        }

    }
}
