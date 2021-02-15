using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCC2019;
using TCC2019.Models;

namespace registro.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login lg)
        {
            if (ModelState.IsValid)
            {
                using (loginEntities ue = new loginEntities())
                {
                    var log = ue.cadastro_tbl.Where(a => a.Usuario.Equals(lg.Usuario) && a.Senha.Equals(lg.Senha)).FirstOrDefault();
                    if (log != null)
                    {
                        Session["Usuario"] = log.Usuario;
                        return RedirectToAction("SalaUsuario", "Default");
                    }
                    else
                    {
                        Response.Write("<script>alert('Usuário ou Senha Invalida')</script>");
                    }
                }
            }
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Register r)
        {
            if (ModelState.IsValid)
            {
                using (loginEntities re = new loginEntities())
                {
                    cadastro_tbl rt = new cadastro_tbl();
                    rt.Usuario = r.Usuario;
                    rt.Senha = r.Senha;
                    rt.Nome = r.Nome;
                    rt.Sobrenome = r.Sobrenome;
                    rt.Email = r.Email;
                    rt.NumCel = r.NumCel;
                    re.cadastro_tbl.Add(rt);
                    re.SaveChanges();
                    Response.Write("<script> alert('Cadastrado com sucesso!!!')</script>");
                }
            }
            return View();
        }
        public ActionResult SalaUsuario()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult ContactUsuario()
        {
            return View();
        }
        public ActionResult ServicesUsuario()
        {
            return View();
        }
        public ActionResult AboutUsuario()
        {
            return View();
        }
        public ActionResult teste1()
        {
            return View();
        }
    }
}