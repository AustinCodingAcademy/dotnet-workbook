using Cozy.Domain.Models;
using System.Collections.Generic;

namespace Cozy.Data.Mock
{
    public static class MockLandlord
    {
        public static List<Landlord> list = new List<Landlord>
        {
            new Landlord {Id = 1, FirstName="Frederic", LastName="Chopin", Email="fred@chopin.com"},
            new Landlord {Id = 2, FirstName="Vladimir", LastName="Ashkenazy", Email="vlad@askenazy.com"},
            new Landlord {Id = 3, FirstName="Yundi", LastName="Li", Email="yundi@li.com"},
        };
    }
}
