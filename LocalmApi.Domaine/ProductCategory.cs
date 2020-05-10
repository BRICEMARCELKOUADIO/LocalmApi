using System;
using System.Collections.Generic;
using System.Text;

namespace LocalmApi.Domaine
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
