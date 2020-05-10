using System;
using System.Collections.Generic;
using System.Text;

namespace LocalmApi.Domaine
{
    public class LocationType
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public ICollection<ProductLocationType> ProductLocationTypes { get; set; }
    }
}
