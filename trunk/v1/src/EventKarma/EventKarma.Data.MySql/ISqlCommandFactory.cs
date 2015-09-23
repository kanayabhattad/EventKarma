using MySql.Data;
using MySql.Data.MySqlClient;

namespace EventKarma.Data.MySql
{
    public interface ISqlCommandFactory
    {
        MySqlCommand GetCommand();
    }
}
