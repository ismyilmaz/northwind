﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Norhwind.Entities;
using Northwind.Interfaces;

namespace Northwind.WcfLibrary.Concrete
{
    public class ProductService:IProductService
    {
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product Get(int productId)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
