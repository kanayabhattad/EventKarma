using System.Data;
using MySql.Data.MySqlClient;
using NHibernate;

namespace EventKarma.Data.MySql
{
    public class SqlCommandFactory : ISqlCommandFactory
    {
        private readonly ISession _session;

        public SqlCommandFactory(ISession session)
        {
            _session = session;
        }

        public MySqlCommand GetCommand()
        {
            var connection = GetOpenConnection();
            var command = (MySqlCommand)connection.CreateCommand();

            if (_session.Transaction != null)
            {
                _session.Transaction.Enlist(command);
            }

            return command;
        }

        private IDbConnection GetOpenConnection()
        {
            var connection = _session.Connection;
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            return connection;
        }

    }
}
