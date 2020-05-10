using System;
using System.Collections.Generic;
using System.Text;

namespace LocalmApi.Domaine
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Remise { get; set; }
        public int IsValidate { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
