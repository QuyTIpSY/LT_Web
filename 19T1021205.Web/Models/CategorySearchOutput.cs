﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _19T1021205.DomainModels;

namespace _19T1021205.Web.Models
{
    /// <summary>
    /// Lưu trữ kết quả tìm kiếm, phân trang đối với nhà cung cấp
    /// </summary>
    public class CategorySearchOutput : PaginationSearchOutput
    {
        /// <summary>
        /// 
        /// </summary>
        public List<Category> Data{ get; set; }
    }
}