﻿using Microsoft.AspNetCore.Http;
using Server.Core.Entity;
using Server.Core.Constants;
using System.Linq;

namespace Server.Core.Helpers
{
    public class LoginHelper
    {
        public void Login(HttpContext httpContext, User user, bool remember, string userToken)
        {
            httpContext.Session.SetInt32(SessionConstants.UserIdScheme, user.Id);
            httpContext.Session.SetString(SessionConstants.UserNameScheme, user.UserName);
            if (!string.IsNullOrWhiteSpace(userToken))
            {
                httpContext.Session.SetString(SessionConstants.UserTokenScheme, userToken);
            }
        }

        public async void Logout(HttpContext httpContext)
        {
            httpContext.Session.Clear();
            httpContext.Session.Remove(SessionConstants.UserTokenScheme);
        }

        public bool IsLogin(HttpContext httpContext)
        {
            return httpContext.Session.Keys.Any(x => x == SessionConstants.UserIdScheme);
        }


        public string GetUserToken(HttpContext httpContext)
        {
            return httpContext.Session.GetString(SessionConstants.UserTokenScheme);
        }

        public int GetUserId(HttpContext httpContext)
        {
            return httpContext.Session.GetInt32(SessionConstants.UserIdScheme) ?? 0;
        }

        public string GetUserName(HttpContext httpContext)
        {
            return httpContext.Session.GetString(SessionConstants.UserNameScheme);
        }
    }
}
