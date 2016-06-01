using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Norhwind.Entities;
using Northwind.Dal.Abstract;
using Northwind.Interfaces;

namespace Norhwind.Bll.Concrete
{
    public class CategoryManager:ICategortService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(
            ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
