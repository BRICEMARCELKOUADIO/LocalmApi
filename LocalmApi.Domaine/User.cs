using System;
using System.Collections.Generic;
using System.Text;

namespace LocalmApi.Domaine
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public string RaisonSocial { get; set; }
        public string Siret { get; set; }
        public DateTime BirthDate { get; set; }
        public string LoginId { get; set; }
        public string Civility { get; set; }
    }
}
