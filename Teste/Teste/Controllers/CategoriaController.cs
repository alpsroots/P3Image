using System;
using System.Web.Mvc;
using NHibernate;
using Teste.Models;
using Teste.Models.NHibernate;

namespace Teste.Controllers
{
    public class CategoriaController : Controller
    {
        //
        // GET: /Categoria/

        public ActionResult Index()
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                IQuery query = session.CreateQuery("from CategoriaModel");
                var categorias = query.List<CategoriaModel>();

                return View(categorias);
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CategoriaModel categoria)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (ITransaction tran = session.BeginTransaction())
                    {
                        session.Save(categoria);
                        tran.Commit();
                    }
                }

                return RedirectToAction("Index");
            }
            catch (Exception exception)
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                var categoria = session.Get<CategoriaModel>(id);

                return View(categoria);
            }            
        }

        [HttpPost]
        public ActionResult Edit(int id, CategoriaModel categoria)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (ITransaction tran = session.BeginTransaction())
                    {
                        session.Update(categoria);
                        tran.Commit();
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                var categoria = session.Get<CategoriaModel>(id);

                return View(categoria);
            }
        }

        [HttpPost]
        public ActionResult Delete(int id, CategoriaModel categoria)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (ITransaction tran = session.BeginTransaction())
                    {
                        session.Delete(categoria);
                        tran.Commit();
                    }
                }

                return RedirectToAction("Index");
            }
            catch (Exception exception)
            {
                return View();
            }
        }
    }
}
