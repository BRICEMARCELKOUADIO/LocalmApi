using System;
using System.Collections.Generic;
using System.Text;

namespace LocalmApi.Domaine
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal PriceTotal { get; set; }
        public int IsValidate { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
