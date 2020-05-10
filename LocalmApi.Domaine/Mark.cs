using System;
using System.Collections.Generic;
using System.Text;

namespace LocalmApi.Domaine
{
    public class Mark
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public ICollection<Model> Models { get; set; }
    }
}
