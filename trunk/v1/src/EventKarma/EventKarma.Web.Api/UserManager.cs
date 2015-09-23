using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventKarma.Data;
using EventKarma.Web.Api.Model;
using EventKarma.Web.Api.TypeMappers;
using EventKarma.Web.Common.Security;

namespace EventKarma.Web.Api
{
    class UserManager : IUserManager
    {
        private readonly IMembershipInfoProvider _membershipAdapter;
        private readonly IUserRepository _userRepository;
        private readonly IUserMapper _userMapper;

        public UserManager(IMembershipInfoProvider membershipAdapter, IUserRepository userRepository, IUserMapper userMapper)
        {
            _membershipAdapter = membershipAdapter;
            _userRepository = userRepository;
            _userMapper = userMapper;
        }

        public User CreateUser(string username, string password, string firstname, string lastname, string email)
        {
            var wrapper = _membershipAdapter.CreateUser(username, password, email);

            _userRepository.SaveUser(wrapper.UserId, firstname, lastname);

            var user = _userMapper.CreateUser(username, wrapper.UserId);

            return user;
        }
    }
}
