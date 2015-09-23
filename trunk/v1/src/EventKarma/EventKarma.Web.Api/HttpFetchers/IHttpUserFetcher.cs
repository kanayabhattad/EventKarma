using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventKarma.Data.Model;

namespace EventKarma.Web.Api.HttpFetchers
{
    public interface IHttpUserFetcher
    {
        User GetUser(int userId);
    }
}
