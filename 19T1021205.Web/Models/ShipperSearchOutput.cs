using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _19T1021205.DomainModels;

namespace _19T1021205.Web.Models
{
    public class ShipperSearchOutput:PaginationSearchOutput
    {
        /// <summary>
        /// Lưu trữ kết quả tìm kiếm phân trang đối với nhà cung cấp
        /// </summary>
        public List<Shipper> Data { set; get; } 
    }
}