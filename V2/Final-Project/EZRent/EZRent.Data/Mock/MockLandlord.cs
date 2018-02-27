using System;
using System.Collections.Generic;
using System.Text;
using EZRent.Domain.Models;


namespace EZRent.Data.Mock
{
    public static class MockLandlord
    {
        public static List<Landlord> list = new List<Landlord>()
            {
                new Landlord {Id=1, Email="gob@bluthrealty.com", FullName="Gob Bluth" },
                new Landlord {Id=2, Email="georgesr@bluthrealty.com", FullName="George Bluth Sr." },
                new Landlord {Id=3, Email="michaelbluth@bluthrealty.com", FullName="Michael Bluth" },
            };
        }

    }
}
