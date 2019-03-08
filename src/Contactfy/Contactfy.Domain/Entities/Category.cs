using Contactfy.Shared.Models;

namespace Contactfy.Domain.Entities
{
    public class Category: Entity
    {
        public Category(string description)
        {
            Description = description;
        }

        public string Description { get; set; }
    }
}
