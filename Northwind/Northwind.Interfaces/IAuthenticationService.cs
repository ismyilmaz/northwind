using Norhwind.Entities;

namespace Northwind.Interfaces
{
    public interface IAuthenticationService
    {
        User Authenticate(User user);
    }
}