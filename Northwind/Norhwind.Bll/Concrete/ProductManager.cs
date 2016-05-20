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
    public class ProductManager:IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product Get(int productId)
        {
            return _productDal.Get(productId);
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(productId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
