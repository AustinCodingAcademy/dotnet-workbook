using System;
using System.Collections.Generic;
using System.Text;
using EZRent.Domain.Models;

namespace EZRent.Data.Mock
{
    public static class MockTenant
    {
        public static List<Tenant> list = new List<Tenant>()
        {
            new Tenant {Id = 1, DateOfBirth = new DateTime(1980,06,22), Email= "JBlack@bbq.com", FullName = "J. Black", MonthlyIncome = 8000, NumberOfPets = 0, PhoneNumber = "512-000-0000", About = "Pitmaster"},
            new Tenant {Id = 2, DateOfBirth = new DateTime(1960,04,21), Email= "ELagasse@bam.com", FullName = "Emeril Lagasse", MonthlyIncome = 8600, NumberOfPets = 1, PhoneNumber = "617-000-0000", About = "Bam!"},
            new Tenant {Id = 3, DateOfBirth = new DateTime(1954,06,22), Email= "ABrown@foodnetwork.com", FullName = "Alton Brown", MonthlyIncome = 15000, NumberOfPets = 0, PhoneNumber = "203-000-0000", About = "Cutthroat"},
        };
    }
}
