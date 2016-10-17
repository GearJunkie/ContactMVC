using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ContactMVC.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string picURL { get; set; }
    }
    public class ContactDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }

}