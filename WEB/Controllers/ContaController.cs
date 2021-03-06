﻿using ApreensaoVeiculo.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;
using ApreensaoVeiculo.Dominio;
using ApreensaoVeiculo.Aplicacao;
using WEB.Models;

namespace ApreensaoVeiculo.Web.Controllers
{
    public class ContaController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel login, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            //var achou = UsuarioAplicacaoDAO.ValidarUsuario(login.Usuario, login.Senha);

            //if (achou)
            //{
            //    FormsAuthentication.SetAuthCookie(login.Usuario, login.LembrarMe);
            //    if (Url.IsLocalUrl(returnUrl))
            //    {
            //        return Redirect(returnUrl);
            //    }
            //    else
            //    {
            //        RedirectToAction("Index", "Home");
            //    }
            //}
            //else
            //{
            //    ModelState.AddModelError("", "Login inválido.");
            //}

            return View(login);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}