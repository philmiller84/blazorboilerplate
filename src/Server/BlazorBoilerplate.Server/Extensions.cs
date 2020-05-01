using IdentityServer4.Models;
using Microsoft.AspNetCore.Hosting;
using System;

namespace BlazorBoilerplate.Server
{
    public static class Extensions
    {
        /// <summary>
        /// Checks if the redirect URI is for a native client.
        /// </summary>
        /// <returns></returns>
        public static bool IsNativeClient(this AuthorizationRequest context)
        {
            return !context.RedirectUri.StartsWith("https", StringComparison.Ordinal)
               && !context.RedirectUri.StartsWith("http", StringComparison.Ordinal);
        }

        public static bool IsBlazorServer(this IWebHostEnvironment env)
        {
//-:cnd:noEmit
#if ServerSideBlazor
            return true;
#else
            return false;
#endif
//-:cnd:noEmit
        }
    }
}