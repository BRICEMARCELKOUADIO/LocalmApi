using System;
using System.Collections.Generic;
using System.Text;

namespace LocalmApi.Domaine
{
    public class ProductLocationType
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool IsReserved { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int LocationTypeId { get; set; }
        public ICollection<LocationCondition> LocationConditions { get; set; }
    }
}
