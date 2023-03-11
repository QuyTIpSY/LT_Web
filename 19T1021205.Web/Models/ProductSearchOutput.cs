using _19T1021205.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _19T1021205.Web.Models;

namespace _19T1021205.Web.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductSearchOutput : PaginationSearchOutput
    {
        public List<Product> Data { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
    }
}