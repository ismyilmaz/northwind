using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Norhwind.Entities;
using Northwind.Dal.Abstract;

namespace Northwind.Dal.Concrete.EntitiyFramework
{
    public class EfIAuthenticationDal:IAuthenticationDal
    {
        public User Authenticate(User user)
        {
            if (user.UserName=="ismail" && user.Password=="1234")
            {
                return user;
            }
            return null;
        }
    }
}
