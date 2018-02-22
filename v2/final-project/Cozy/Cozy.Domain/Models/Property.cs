namespace Cozy.Domain.Models
{
    public class Property
    {
        // properties
        public int Id { get; set; }
        public string Address { get; set;}
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public int PropertyTypeId { get; set; }
        public string Image { get; set; }

        // navigation
        public PropertyType Type { get; set; }
    }
}
