using System;

namespace Cozy.Domain.Models
{
    public class Maintenance
    {
        // properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Posted { get; set; }
        public int StatusId { get; set; }
        public int PropertyId { get; set; }

        // navigation
        public MaintenanceStatus Status { get; set; }
    }
}
