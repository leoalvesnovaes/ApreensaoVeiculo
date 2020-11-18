using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApreensaoVeiculo.Dominio;
using ApreensaoVeiculo.Aplicacao;



namespace WEB.Controllers
{
    public class ApreensaoController : Controller
    {
        // GET: Apreensao
        public ActionResult Index()
        {
            var appApreensao = ApreensaoAplicacaoConstrutor.ApreensaoADO();
            var listaApreensao = appApreensao.ListarTodos();

          

            return View(listaApreensao);

        }


        public ActionResult Cadastrar()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Cadastrar(Apreensao apreensao)
        {
            if (ModelState.IsValid)
            {
                var appApreensao = ApreensaoAplicacaoConstrutor.ApreensaoADO();
                appApreensao.Salvar(apreensao);
                return RedirectToAction("Index");
            }

            return View(apreensao);
        }


        public ActionResult Editar(string id)
        {
            var appApreensao = ApreensaoAplicacaoConstrutor.ApreensaoADO();
            var apreensao = appApreensao.ListarPorId(id);

            if (apreensao == null)
            {
                return HttpNotFound();
            }
            return View(apreensao);
        }


        [HttpPost]
        public ActionResult Editar(Apreensao apreensao)
        {
            if (ModelState.IsValid)
            {
                var appApreensao = ApreensaoAplicacaoConstrutor.ApreensaoADO();
                appApreensao.Salvar(apreensao);
                return RedirectToAction("Index");
            }

            return View(apreensao);
        }


        public ActionResult Detalhes(string id)
        {
            var appApreensao = ApreensaoAplicacaoConstrutor.ApreensaoADO();
            var apreensao = appApreensao.ListarPorId(id);

            if (apreensao == null)
            {
                return HttpNotFound();
            }
            return View(apreensao);
        }

        public ActionResult Excluir(string id)
        {
            var appApreensao = ApreensaoAplicacaoConstrutor.ApreensaoADO();
            var apreensao = appApreensao.ListarPorId(id);

            if (apreensao == null)
            {
                return HttpNotFound();
            }
            return View(apreensao);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult ExcluirConfirmado(string id)
        {
            var appApreensao = ApreensaoAplicacaoConstrutor.ApreensaoADO();
            var apreensao = appApreensao.ListarPorId(id);
            appApreensao.Excluir(apreensao);
            return RedirectToAction("Index");
        }





    }
}