namespace Cozy.Domain.Models
{
    public class Bank
    {   
        // Properties
        public int Id { get; set;  }
        public string Name { get; set; }
        public int Account { get; set; }
        public int RoutingNumber { get; set; }
        public int UserId { get; set; }
    }
}
