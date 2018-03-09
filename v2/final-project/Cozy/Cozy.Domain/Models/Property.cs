using System.ComponentModel.DataAnnotations;

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
        public int LandlordId { get; set; }
        public int CurrentTenantId { get; set; }

        // navigation
        public PropertyType Type { get; set; }

    }
}
