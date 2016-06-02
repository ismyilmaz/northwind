using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Norhwind.Bll.Concrete;
using Norhwind.Entities;
using Northwind.Dal.Concrete.EntitiyFramework;
using Northwind.Interfaces;

namespace Northwind.WcfLibrary.Concrete
{
    public class AuthenticationService:IAuthenticationService
    {
        
        AuthenticationManager _authenticationManager=new AuthenticationManager(new EfIAuthenticationDal());
        public User Authenticate(User user)
        {
            return _authenticationManager.Authenticate(user);
        }
    }
}
