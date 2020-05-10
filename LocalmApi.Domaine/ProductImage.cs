using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LocalmApi.Domaine
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public bool IsActive { get; set; }
        public int ProductId { get; set; }
    }
}
