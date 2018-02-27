using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Domain.Models
{
    public class Maintenance
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public int StatusId { get; set; }
        public int PropertyId { get; set; }

        // navigation
        public MaintenanceStatus Status { get; set; }
    }
}
