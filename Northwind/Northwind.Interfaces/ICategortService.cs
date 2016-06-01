using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Norhwind.Entities;

namespace Northwind.Interfaces
{
    [ServiceContract]
    public interface ICategortService
    {
        [OperationContract]
        List<Category> GetAll();
    }
}
