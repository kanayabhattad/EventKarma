using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventKarma.Web.Api.Model;

namespace EventKarma.Web.Api.TypeMappers
{
    public class UserMapper : IUserMapper
    {
        public User CreateUser(string username,int userId)
        {
            return new User
            {
                Id = userId,
                Username = username,


            };
        }

        public User CreateUser(User modelUser)
        {
            return CreateUser(
                modelUser.Username,
                modelUser.Id);
        }
    }
}
