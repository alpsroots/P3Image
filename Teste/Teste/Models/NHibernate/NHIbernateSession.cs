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

            var categoriaFile = HttpContext.Current.Server.MapPath(@"~\Models\NHibernate\Mappings\CategoriaModel.hbm.xml");
            configuration.AddFile(categoriaFile);

            var subCategoriaFile = HttpContext.Current.Server.MapPath(@"~\Models\NHibernate\Mappings\SubCategoriaModel.hbm.xml");
            configuration.AddFile(subCategoriaFile);

            ISessionFactory sessionFactory = configuration.BuildSessionFactory();

            return sessionFactory.OpenSession();            
        }
    }
}