using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Norhwind.Entities;
using Northwind.Dal.Abstract;

namespace Northwind.Dal.Concrete.EntitiyFramework
{
    public class EfCategoryDal:ICategoryDal
    {
        readonly NorthwindContext _context = new NorthwindContext();
        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
    }
}
