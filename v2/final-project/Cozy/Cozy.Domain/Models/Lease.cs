using System;

namespace Cozy.Domain.Models
{
    public class Lease
    {
        // properties
        public int PropertyId { get; set; }
        public int TenantId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int LeaseTypeId { get; set; }

        // navigation
        public LeaseType Type { get; set; }
    }
}
