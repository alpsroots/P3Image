using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHibernate;
using Teste.Models;
using Teste.Models.NHibernate;

namespace Teste.Controllers
{
    public class SubCategoriaController : Controller
    {
        //
        // GET: /SubCategoria/

        public ActionResult Index()
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                IQuery query = session.CreateQuery("from SubCategoriaModel");
                var subCategorias = query.List<SubCategoriaModel>();
                
                return View(subCategorias);
            }            
        }

        public ActionResult Create()
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                IQuery query = session.CreateQuery("from CategoriaModel");
                ViewBag.lstCategoria = query.List<CategoriaModel>();

                return View();
            }
        }

        [HttpPost]
        public ActionResult Create(SubCategoriaModel subCategoria)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (ITransaction tran = session.BeginTransaction())
                    {
                        session.Save(subCategoria);
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
                IQuery query = session.CreateQuery("from CategoriaModel");
                ViewBag.lstCategoria = query.List<CategoriaModel>();

                var subCategoria = session.Get<SubCategoriaModel>(id);

                return View(subCategoria);
            }
        }

        [HttpPost]
        public ActionResult Edit(int id, SubCategoriaModel subCategoria)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (ITransaction tran = session.BeginTransaction())
                    {
                        session.Update(subCategoria);
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
                var subCategoria = session.Get<SubCategoriaModel>(id);

                return View(subCategoria);
            }
        }

        [HttpPost]
        public ActionResult Delete(int id, SubCategoriaModel subCategoria)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (ITransaction tran = session.BeginTransaction())
                    {
                        session.Delete(subCategoria);
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
