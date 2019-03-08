using Contactfy.Domain.ValueObjects;
using Contactfy.Shared.Models;
using System.Collections.Generic;

namespace Contactfy.Domain.Entities
{
    public class Contact: Entity
    {
        public Contact(string name, Category category, Email email)
        {
            Name = name;
            Category = category;
            Email = email;
        }

        public string Name { get; set; }
        public Category Category { get; set; }
        public Email Email { get; set; }
        public IList<Phone> Phones { get; set; }

        public void AddPhone(Phone phone)
        {
            Phones.Add(phone);
        }

        public void RemovePhone(Phone phone)
        {
            Phones.Remove(phone);
        }
    }
}
