using Cozy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cozy.Data.Mock
{
    public static class MockTenant
    {
        public static List<Tenant> list = new List<Tenant>
        {
            new Tenant { Id =1, Name="Nathan Massey"},
            new Tenant { Id =2, Name="Collin Massey"},
            new Tenant { Id =3, Name="Jarrett Austin"}
        };
    }
}
