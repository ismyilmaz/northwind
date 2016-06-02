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
    public class CategoryService:ICategoryService
    {
        CategoryManager _categoryManager=new CategoryManager(new EfCategoryDal());
        public List<Category> GetAll()
        {
            return _categoryManager.GetAll();
        }
    }
}
