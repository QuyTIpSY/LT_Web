using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _19T1021205.Web.Models;
using _19T1021205.DomainModels;

namespace _19T1021205.Web.Models
{
    /// <summary>
    /// Lưu trữu thông tin đầu vào dùng để tìm kiếm Mặt hàng, phân trang
    /// </summary>
    public class ProductSearchInput : PaginationSearchInput
    {
        public List<Product> Data { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }

    }
}
