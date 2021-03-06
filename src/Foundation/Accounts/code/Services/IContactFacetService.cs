﻿using Sitecore.Demo.Foundation.Accounts.Models;

namespace Sitecore.Demo.Foundation.Accounts.Services
{
    public interface IContactFacetService
    {
        ContactFacetData GetContactData();

        void UpdateContactFacets(ContactFacetData data);

        string ExportContactData();

        bool DeleteContact();
    }
}
