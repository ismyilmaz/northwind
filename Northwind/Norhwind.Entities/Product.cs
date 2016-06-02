using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.Build.Framework;

namespace Norhwind.Entities
{
    public class Product
    {
        [HiddenInput(DisplayValue = false)]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public short UnitsInStock { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public int CategoryID { get; set; }
    }
}
