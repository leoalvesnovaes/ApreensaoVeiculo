using ApreensaoVeiculo.Repositorio;
using ApreensaoVeiculo.RepositorioADO;

namespace ApreensaoVeiculo.Aplicacao

{
    public class UsuarioAplicacaoConstrutor
    {
        public static UsuarioAplicacao UsuarioApADO()
        {
            return new UsuarioAplicacao(new UsuarioAplicacaoADO());
        }
    }
}
