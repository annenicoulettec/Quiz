using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using MvcApplication1.Models;

namespace MvcApplication1
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            OAuthWebSecurity.RegisterTwitterClient(
            consumerKey: "ptqocfQaiJKB7FsjWzMuZx3TU",
            consumerSecret: "tHhLT9A0kq5BWjBBEyo8Qmug8nkln5oziuBH16TzIBQg5tvjXp");

            OAuthWebSecurity.RegisterFacebookClient(
            appId: "1603214249915925",
            appSecret: "3601ed75b63e075af4337e8b325e921c");

            //OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
