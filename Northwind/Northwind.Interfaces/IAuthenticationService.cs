using System.ServiceModel;
using Norhwind.Entities;

namespace Northwind.Interfaces
{
    [ServiceContract]
    public interface IAuthenticationService
    {
        [OperationContract]
        User Authenticate(User user);
    }
}