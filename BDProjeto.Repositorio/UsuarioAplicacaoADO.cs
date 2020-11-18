using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApreensaoVeiculo.Repositorio;
using ApreensaoVeiculo.Dominio;
using ApreensaoVeiculo.Dominio.contrato;

namespace ApreensaoVeiculo.Repositorio
{
    public class UsuarioAplicacaoADO : IRepositorio<Usuarios>
    {
        private bd bd;

        public void Inserir(Usuarios usuarios)
        {
            var strQuery = "";
            strQuery += "insert into usuario(descricao, cargo, datacadastro, login, senha)";
            strQuery += string.Format(" values ('{0}','{1}',convert(datetime, '{2}',103), '{3}','{4}')", usuarios.Descricao, usuarios.Cargo, usuarios.Data, usuarios.Login, usuarios.Senha
                );
            using (bd = new bd())
            {
                bd.ExecutaComando(strQuery);
            }
        }


        public void Alterar(Usuarios usuarios)
        {
            var strQuery = "";
            strQuery += "update usuario set ";
            strQuery += string.Format("descricao = '{0}', ", usuarios.Descricao);
            strQuery += string.Format("cargo = '{0}', ", usuarios.Cargo);
            strQuery += string.Format("datacadastro = convert(datetime, '{0}',103), ", usuarios.Data);
            strQuery += string.Format("login = '{0}', ", usuarios.Login);
            strQuery += string.Format("senha = '{0}' ", usuarios.Senha);
            strQuery += string.Format("where codigo = {0} ", usuarios.Codigo);

            using (bd = new bd())
            {
                bd.ExecutaComando(strQuery);
            }

        }

        public void Salvar(Usuarios usuarios)
        {
            if (usuarios.Codigo > 0)
            {
                Alterar(usuarios);
            }
            else
            {
                Inserir(usuarios);
            }
        }

        public void Excluir(Usuarios usuarios)
        {
            using (bd = new bd())
            {
                var strQuery = string.Format("delete from usuario where codigo = {0} ", usuarios.Codigo);
                bd.ExecutaComando(strQuery);
            }
        }

        public IEnumerable<Usuarios> ListarTodos()
        {
            using (bd = new bd())
            {
                var strQuery = "select * from usuario";
                var retorno = bd.ExecutaComandoComRetorno(strQuery);
                return ReaderEmLista(retorno);
            }
        }


        public Usuarios ListarPorId(string id)
        {
            using (bd = new bd())
            {
                var strQuery = string.Format("select * from usuario where codigo = {0}", id);
                var retorno = bd.ExecutaComandoComRetorno(strQuery);
                return ReaderEmLista(retorno).FirstOrDefault();
            }
        }

        private List<Usuarios> ReaderEmLista(SqlDataReader reader)
        {

            var usuarios = new List<Usuarios>();

            while (reader.Read())
            {
                var tempoObjeto = new Usuarios()
                {
                    Codigo = int.Parse(reader["codigo"].ToString()),
                    Descricao = reader["descricao"].ToString(),
                    Cargo = reader["cargo"].ToString(),
                    Data = DateTime.Parse(reader["datacadastro"].ToString()),
                    Login = reader["login"].ToString(),
                    Senha = reader["senha"].ToString(),
                };

                usuarios.Add(tempoObjeto);
            }

            reader.Close();
            return usuarios;
        }



        public Consulta ObterConsulta()
        {
            throw new NotImplementedException();
        }


        public bool ValidarUsuario(string login, string senha)
        {
            var ret = false;
            using (bd = new bd())
            {
                
                using (var comando = new SqlCommand())
                {
                    //comando.Connection = t;
                    var strQuery = string.Format(
                        "select count(*) from usuario where login='{0}' and senha='{1}'", login, senha);
                    ret = ((int)comando.ExecuteScalar() > 0);
                }
            }

            return ret;
        }



    }
}
