using System;
using System.Collections.Generic;
using System.Text;

namespace LocalmApi.Domaine
{
    public class Product
    {
        public int Id { get; set; }
        public decimal LocationPrice { get; set; }
        public string Desciption { get; set; }
        public string UserProductReference { get; set; }
        public int ProductCategoryId { get; set; }
        public int ModelId { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
    }
}
