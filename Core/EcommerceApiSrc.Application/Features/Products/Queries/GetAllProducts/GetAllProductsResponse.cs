﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiSrc.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsResponse
    {
        public string Title { get; set; }
        public string Description { get; set; }
       
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}
