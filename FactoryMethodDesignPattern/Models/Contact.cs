using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Models
{
    public class Contact : IEntity
    {
        public Contact() { }
        public Contact(int id, string name, string group, string phone, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Group = group;
            this.Phone = phone;
            this.Email = email;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
