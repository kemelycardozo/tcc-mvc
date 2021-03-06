﻿using Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Identity.Identity
{
    public class AdditionalUserClaimsPrincipalFactory
        : UserClaimsPrincipalFactory<AplicationUser, IdentityRole>
    {
        public AdditionalUserClaimsPrincipalFactory(
            UserManager<AplicationUser> userManager, 
            RoleManager<IdentityRole> roleManager, 
            IOptions<IdentityOptions> options) 
            : base(userManager, roleManager, options)
        {
        }

        public async override Task<ClaimsPrincipal> CreateAsync(AplicationUser user)
        {
            var principal = await base.CreateAsync(user);
            var identity = (ClaimsIdentity)principal.Identity;

            var claims = new List<Claim>();
            if (user.IsAdmin)
            {
                claims.Add(new Claim(ClaimTypes.Role, "AdminBlaster"));
            }
            else
            {
                claims.Add(new Claim(ClaimTypes.Role, "UserBlaster"));
            }

            identity.AddClaims(claims);
            return principal;
        }
    }
}
