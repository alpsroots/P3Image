using System.Collections.Generic;
using System.Web.Mvc;
using NHibernate;
using Teste.Models;
using Teste.Models.NHibernate;

namespace Teste.Controllers
{
    public class FormController : Controller
    {
        //
        // GET: /Form/

        public ActionResult Index()
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                ViewBag.Categorias = session.QueryOver<CategoriaModel>().List();

                return View();
            }
        }

        public JsonResult SubCategoriasList(int idCategoria)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                var subCategorias = session.QueryOver<SubCategoriaModel>()
                    .Where(c => c.Categoria.Id == idCategoria);

                return Json(new SelectList(subCategorias.List(), "Id", "Descricao"), JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Index(FormModel form)
        {
            IList<CamposModel> campos = null;

            using (ISession session = NHibernateSession.OpenSession())
            {
                campos = session.QueryOver<CamposModel>().Where(c => c.IdSubCategoria == form.SubCategoriasID).List();

                ViewBag.Categorias = session.QueryOver<CategoriaModel>().List();
            }

            var model = new FormModel().GerarCampos(new List<CamposModel>(campos));

            return View(model);
        }
    }
}
