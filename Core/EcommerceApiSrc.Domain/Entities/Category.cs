using EcommerceApiSrc.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiSrc.Domain.Entities
{
    public class Category:EntityBase,IEntityBase
    {
        public Category()
        {
            
        }
        public Category(string name,int priority,int parentId)
        {
            this.Name = name;
            this.Priority = priority;
            this.ParentId = parentId;
        }
        public  string Name { get; set; }
        public  int Priority { get; set; }
        public  int ParentId { get; set; }
        public ICollection<Detail> Details { get; set; }
        public ICollection<CategoryProduct> CategoryProduct { get; set; }  
       

    }
}
