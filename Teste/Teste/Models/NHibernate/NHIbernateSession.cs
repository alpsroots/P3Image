using System.Web;
using NHibernate;
using NHibernate.Cfg;

namespace Teste.Models.NHibernate
{
    public class NHibernateSession
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();

            var configurationPath = HttpContext.Current.Server.MapPath(@"~\Models\NHibernate\Configuration\hibernate.cfg.xml");
            configuration.Configure(configurationPath);

            var categoriaFile = HttpContext.Current.Server.MapPath(@"~\Models\NHibernate\Mappings\Categoria.hbm.xml");
            configuration.AddFile(categoriaFile);

            var subCategoriaFile = HttpContext.Current.Server.MapPath(@"~\Models\NHibernate\Mappings\SubCategoria.hbm.xml");
            configuration.AddFile(subCategoriaFile);

            var camposFile = HttpContext.Current.Server.MapPath(@"~\Models\NHibernate\Mappings\Campos.hbm.xml");
            configuration.AddFile(camposFile);

            var listaCamposFile = HttpContext.Current.Server.MapPath(@"~\Models\NHibernate\Mappings\ListaCampos.hbm.xml");
            configuration.AddFile(listaCamposFile);

            ISessionFactory sessionFactory = configuration.BuildSessionFactory();

            return sessionFactory.OpenSession();            
        }
    }
}