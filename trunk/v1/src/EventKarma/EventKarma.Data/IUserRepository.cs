using System;
using EventKarma.Data.Model;

namespace EventKarma.Data
{
    public interface IUserRepository
    {
        void SaveUser(int userId, string firstname, string lastname);
        User GetUser(int userId);
    }
}
