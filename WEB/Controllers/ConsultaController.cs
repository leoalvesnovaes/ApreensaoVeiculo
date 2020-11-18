using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApreensaoVeiculo.Dominio;
using ApreensaoVeiculo.Aplicacao;

namespace WEB.Controllers
{
    public class ConsultaController : Controller
    {
        // GET: Consulta
        public ActionResult Index()
        {
            var consultaDao = ConsultaAplicacaoConstrutor.ConsultaApADO();
            var consulta = consultaDao.ObterConsulta();

            return View(consulta);
        }
    }
}