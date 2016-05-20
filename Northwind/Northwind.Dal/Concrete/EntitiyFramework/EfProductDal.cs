using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Norhwind.Entities;
using Northwind.Dal.Abstract;

namespace Northwind.Dal.Concrete.EntitiyFramework
{
    public class EfProductDal:IProductDal
    {
        private NorthwindContext _context = new NorthwindContext();
        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product Get(int productId)
        {
            return _context.Products.FirstOrDefault(p => p.ProductID == productId);
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int productId)
        {
            _context.Products.Remove(_context.Products.FirstOrDefault(p => p.ProductID == productId));
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Products.AddOrUpdate(product);
            _context.SaveChanges();
        }
    }
}
