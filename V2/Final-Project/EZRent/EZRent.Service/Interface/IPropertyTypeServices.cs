using EZRent.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Service.Interface
{
    public interface IPropertyTypeServices
    {
        List<PropertyType> GetPropertyTypes();
    }
}
