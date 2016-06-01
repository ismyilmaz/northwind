using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Norhwind.Entities;

namespace Northwind.MVCWebUI.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public PagingInfo PageInfo { get; set; }
    }
}