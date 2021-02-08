﻿using System;
using Casbin.Rbac;

namespace Casbin.Extensions
{
    public static class RoleMangerExtension
    {
        public static IRoleManager AddMatchingFunc(this IRoleManager roleManager,
            Func<string, string, bool> matchingFunc)
        {
            roleManager.MatchingFunc = matchingFunc;
            return roleManager;
        }

        public static IRoleManager AddDomainMatchingFunc(this IRoleManager roleManager,
            Func<string, string, bool> domainMatchingFunc)
        {
            roleManager.DomainMatchingFunc = domainMatchingFunc;
            return roleManager;
        }
    }
}
