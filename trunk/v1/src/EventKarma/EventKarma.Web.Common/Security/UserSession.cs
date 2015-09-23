﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EventKarma.Web.Common.Security
{
    public class UserSession : IUserSession
    {
        public UserSession(ClaimsPrincipal principal)
        {
            UserId = int.Parse(principal.FindFirst(ClaimTypes.Sid).Value);
            Firstname = principal.FindFirst(ClaimTypes.GivenName).Value;
            Lastname = principal.FindFirst(ClaimTypes.Surname).Value;
            Username = principal.FindFirst(ClaimTypes.Name).Value;
            Email = principal.FindFirst(ClaimTypes.Email).Value;
        }

        public int UserId { get; private set; }
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Username { get; private set; }
        public string Email { get; private set; }
    }
}
