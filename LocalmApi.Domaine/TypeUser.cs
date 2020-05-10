using System;
using System.Collections.Generic;
using System.Text;

namespace LocalmApi.Domaine
{
    public class TypeUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
