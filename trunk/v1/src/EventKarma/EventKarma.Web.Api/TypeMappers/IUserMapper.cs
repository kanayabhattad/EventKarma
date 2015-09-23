using System;
using EventKarma.Web.Api.Model;

namespace EventKarma.Web.Api.TypeMappers
{
    public interface IUserMapper
    {
        User CreateUser(string username, int userId);
        User CreateUser(User modelUser);
    }
}
