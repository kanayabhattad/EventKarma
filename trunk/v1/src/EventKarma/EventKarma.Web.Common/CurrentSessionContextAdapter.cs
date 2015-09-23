using NHibernate;
using NHibernate.Context;

namespace EventKarma.Web.Common
{
    public class CurrentSessionContextAdapter : ICurrentSessionContextAdapter
    {
        public bool HasBind(ISessionFactory sessionFactory)
        {
            return CurrentSessionContext.HasBind(sessionFactory);
        }

        public ISession Unbind(ISessionFactory sessionFactory)
        {
            return CurrentSessionContext.Unbind(sessionFactory);
        }
    }
}
