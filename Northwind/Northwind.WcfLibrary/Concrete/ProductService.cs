using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Norhwind.Bll.Concrete;
using Norhwind.Entities;
using Northwind.Dal.Concrete.EntitiyFramework;
using Northwind.Interfaces;

namespace Northwind.WcfLibrary.Concrete
{
    public class ProductService : IProductService
    {
        private readonly ProductManager _productManager = new ProductManager(new EfProductDal());
        public List<Product> GetAll()
        {
            return _productManager.GetAll();
        }

        public Product Get(int productId)
        {
            return _productManager.Get(productId);
        }

        public void Add(Product product)
        {
            _productManager.Add(product);
        }

        public void Delete(int productId)
        {
            _productManager.Delete(productId);
        }

        public void Update(Product product)
        {
            _productManager.Update(product);
        }
    }
}
