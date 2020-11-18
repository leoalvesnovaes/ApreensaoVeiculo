//using ApreensaoVeiculo.Dominio.contrato;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ApreensaoVeiculo.Dominio;
//using ApreensaoVeiculo.Dominio.ViewModel;
//using ApreensaoVeiculo.Repositorio;
//using System.Data.SqlClient;

//namespace ApreensaoVeiculo.Repositorio
//{
//    public  class ApreensaoComboADO:IRepositorio<ApreensaoCombo>
//    {
//        private bd bd;

//        public void Inserir(ApreensaoCombo consulta)
//        {
//        }

//        public void Salvar(ApreensaoCombo consulta)
//        {
//            //if (apreensao.Codigo > 0)
//            //{
//            //    Alterar(apreensao);
//            //}
//            //else
//            //{
//            //    Inserir(apreensao);
//            //}
//        }

//        public void Excluir(ApreensaoCombo consulta)
//        {
//            throw new NotImplementedException();
//        }


//        public void Alterar(ApreensaoCombo consulta)
//        {
//            var strQuery = "";
//            //strQuery += "update apreensao set ";
//            //strQuery += string.Format("descricao = '{0}', ", apreensao.Descricao);
//            //strQuery += string.Format("cargo = '{0}', ", apreensao.Cargo);
//            //strQuery += string.Format("datacadastro = convert(datetime, '{0}',103), ", apreensao.Data);
//            //strQuery += string.Format("login = '{0}', ", apreensao.Login);
//            //strQuery += string.Format("senha = '{0}' ", apreensao.Senha);
//            //strQuery += string.Format("where codigo = {0} ", apreensao.Codigo);

//            using (bd = new bd())
//            {
//                bd.ExecutaComando(strQuery);
//            }

//        }




//    }
//}
