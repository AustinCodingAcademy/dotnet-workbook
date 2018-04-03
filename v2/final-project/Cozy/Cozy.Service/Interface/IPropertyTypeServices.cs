using System;
using System.Collections.Generic;
using System.Text;
using Cozy.Domain.Models;

namespace Cozy.Service.Interface
{
    public interface IPropertyTypeServices
    {
        PropertyType GetSinglePropertyById(int id);
    }
}
