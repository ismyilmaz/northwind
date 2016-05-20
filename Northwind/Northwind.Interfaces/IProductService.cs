﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Norhwind.Entities;

namespace Northwind.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product Get(int productId);
        void Add(Product product);
        void Delete(int productId);
        void Update(Product product);
    }
}
