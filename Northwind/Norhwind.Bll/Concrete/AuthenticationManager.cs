using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Norhwind.Entities;
using Northwind.Interfaces;
using Northwind.Dal.Abstract;

namespace Norhwind.Bll.Concrete
{
    public class AuthenticationManager:IAuthenticationService
    {
        private IAuthenticationDal _authenticationDal;

        public AuthenticationManager(IAuthenticationDal authenticationDal)
        {
            _authenticationDal = authenticationDal;
        }

        public User Authenticate(User user)
        {
            return _authenticationDal.Authenticate(user);
        }
    }
}
