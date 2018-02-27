﻿using EZRent.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Service.Interface
{
    public interface ITenantServices
    {
        List<Tenant> GetAllTenants();
        Tenant GetSingleTenantById(int id);

        // Create
        Tenant CreateTenant(Tenant newTenant);

        // Update
        Tenant UpdateTenant(Tenant updatedTenant);
        // Delete
        bool DeleteTenant(int id);
    }
}
