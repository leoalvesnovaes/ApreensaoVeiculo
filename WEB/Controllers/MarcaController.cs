using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApreensaoVeiculo.Dominio;
using ApreensaoVeiculo.Aplicacao;



namespace WEB.Controllers
{
    public class MarcaController : Controller
    {


        // GET: Home
        public ActionResult marca(Marca marca)
        {
            var appMarca = MarcaAplicacaoConstrutor.MarcaADO();
            var listaMarca = appMarca.ListarTodos();



            ViewBag.Marca = new MultiSelectList(listaMarca, "codigo", "descricao");
            return View(marca);
        }
    }
}


