using ApreensaoVeiculo.Aplicacao;
using ApreensaoVeiculo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEB.Controllers
{
    public class TabelaPrecoController : Controller
    {
        // GET: Aluno
        public ActionResult Index()
        {

            var appTabelaPreco = TabelaPrecoAplicacaoConstrutor.TabelaPrecoApADO();
            var listaTabelaPreco = appTabelaPreco.ListarTodos();
            return View(listaTabelaPreco);
        }

        public ActionResult Cadastrar()
        {


            return View();
        }


        [HttpPost]
        public ActionResult Cadastrar(TabelaPreco tabelapreco)
        {
            if (ModelState.IsValid)
            {
                var appTabelaPreco = TabelaPrecoAplicacaoConstrutor.TabelaPrecoApADO();
                appTabelaPreco.Salvar(tabelapreco);
                return RedirectToAction("Index");
            }

            return View(tabelapreco);
        }

        public ActionResult Editar(string id)
        {
            var appTabelaPreco = TabelaPrecoAplicacaoConstrutor.TabelaPrecoApADO();
            var tabelapreco = appTabelaPreco.ListarPorId(id);

            if (tabelapreco == null)
            {
                return HttpNotFound();
            }
            return View(tabelapreco);
        }


        [HttpPost]
        public ActionResult Editar(TabelaPreco tabelapreco)
        {
            if (ModelState.IsValid)
            {
                var appTabelaPreco = TabelaPrecoAplicacaoConstrutor.TabelaPrecoApADO();
                appTabelaPreco.Salvar(tabelapreco);
                return RedirectToAction("Index");
            }

            return View(tabelapreco);
        }


        public ActionResult Detalhes(string id)
        {
            var appTabelaPreco = TabelaPrecoAplicacaoConstrutor.TabelaPrecoApADO();
            var tabelapreco = appTabelaPreco.ListarPorId(id);

            if (tabelapreco == null)
            {
                return HttpNotFound();
            }
            return View(tabelapreco);
        }

        public ActionResult Excluir(string id)
        {
            var appTabelaPreco = TabelaPrecoAplicacaoConstrutor.TabelaPrecoApADO();
            var tabelapreco = appTabelaPreco.ListarPorId(id);

            if (tabelapreco == null)
            {
                return HttpNotFound();
            }
            return View(tabelapreco);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult ExcluirConfirmado(string id)
        {
            var appTabelaPreco = TabelaPrecoAplicacaoConstrutor.TabelaPrecoApADO();
            var tabelapreco = appTabelaPreco.ListarPorId(id);
            appTabelaPreco.Excluir(tabelapreco);
            return RedirectToAction("Index");
        }

    }
}