using System;

namespace Sitecore.Demo.Feature.Accounts.Services
{
    public interface IGetRedirectUrlService
    {
        string GetRedirectUrl(AuthenticationStatus status, string returnUrl = null);

        string GetDefaultRedirectUrl(AuthenticationStatus status);
    }
}