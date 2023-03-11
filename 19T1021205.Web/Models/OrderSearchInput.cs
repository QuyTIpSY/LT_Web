using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _19T1021205.Web.Models
{
    public class OrderSearchInput: PaginationSearchInput
    {
        public int Status { get; set; }

        /// <summary>
        /// Giá trị tim kiếm
        /// </summary>
        public string SearchValue { get; set; }
    }
}