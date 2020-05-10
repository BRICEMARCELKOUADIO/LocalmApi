using System;
using System.Collections.Generic;
using System.Text;

namespace LocalmApi.Domaine
{
    public class Model
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int MarkId { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
