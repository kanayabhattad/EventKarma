using System.Data;
using EventKarma.Data.Model;
using NHibernate;

namespace EventKarma.Data.MySql
{
    public class UserRepository : IUserRepository
    {
        private readonly ISession _session;
        private readonly ISqlCommandFactory _sqlCommandFactory;

        public UserRepository(ISession session, ISqlCommandFactory sqlCommandFactory)
        {
            _session = session;
            _sqlCommandFactory = sqlCommandFactory;
        }

        public User GetUser(int userId)
        {
            return _session.Get<User>(userId);
        }

        public void SaveUser(int userId, string firstname, string lastname)
        {
            using (var command = _sqlCommandFactory.GetCommand())
            {
                command.CommandText = "dbo.SaveUser";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@firstname", firstname);
                command.Parameters.AddWithValue("@lastname", lastname);

                command.ExecuteNonQuery();
            }
        }
    }
}
