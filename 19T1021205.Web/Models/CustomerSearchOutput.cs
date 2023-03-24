using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _19T1021205.DomainModels;

namespace _19T1021205.Web.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerSearchOutput:PaginationSearchOutput
    {
        /// <summary>
        /// 
        /// </summary>
        public List<Customer> Data { get; set; }
    }
}