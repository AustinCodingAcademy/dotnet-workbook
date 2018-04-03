using Cozy.Domain.Models;
using System.Collections.Generic;

namespace Cozy.Data.Mock
{
    public static class MockLandlord
    {
        public static List<Landlord> list = new List<Landlord>
        {
            new Landlord {Id = 1, FirstName="Nathan", LastName="Massey", Email="JCDenton46@gmail.com"},
            new Landlord {Id = 2, FirstName="Collin", LastName="Massey", Email="CZM@gmail.com"},
            new Landlord {Id = 3, FirstName="Jarrett", LastName="Austin", Email="JFA@gmail.com"},
        };
    }
}
