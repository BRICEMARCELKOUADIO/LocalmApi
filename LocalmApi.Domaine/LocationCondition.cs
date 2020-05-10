using System;
using System.Collections.Generic;
using System.Text;

namespace LocalmApi.Domaine
{
    public class LocationCondition
    {
        public int Id { get; set; }
        public string Term { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }
    }
}
