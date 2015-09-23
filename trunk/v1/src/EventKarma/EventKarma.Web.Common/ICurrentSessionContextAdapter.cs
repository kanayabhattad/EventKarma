using NHibernate;

namespace EventKarma.Web.Common
{
    public interface ICurrentSessionContextAdapter
    {
        bool HasBind(ISessionFactory sessionFactory);
        ISession Unbind(ISessionFactory sessionFactory);
    }
}
