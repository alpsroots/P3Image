using System.Web;
using NHibernate;
using NHibernate.Cfg;

namespace Teste.Models.NHibernate
{
    public class NHIbernateSession
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();
            
            var configurationPath = HttpContext.Current.Server.MapPath(@"~\Models\NHibernate\Configuration\hibernate.cfg.xml");
            configuration.Configure(configurationPath);
            
            var employeeConfigurationFile = HttpContext.Current.Server.MapPath(@"~\Models\NHibernate\Mappings\CategoriaModel.hbm.xml");
            configuration.AddFile(employeeConfigurationFile);
            
            ISessionFactory sessionFactory = configuration.BuildSessionFactory();

            return sessionFactory.OpenSession();
        }
    }
}