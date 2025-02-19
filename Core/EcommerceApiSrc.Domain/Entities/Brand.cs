using EcommerceApiSrc.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiSrc.Domain.Entities
{
    public class Brand:EntityBase
    {
        public Brand()
        {
            
        }
        public Brand(string name)
        {
            this.Name = name;   
        }
        public  string Name { get; set; }
    }
}
