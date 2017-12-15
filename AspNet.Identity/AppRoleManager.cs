﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNet.Identity
{
    public class AppRoleManager:RoleManager<AppRole>
    {
        public AppRoleManager(RoleStore<AppRole> store):base(store)
        {

        }
        public static AppRoleManager Create(IdentityFactoryOptions<AppRoleManager> options,IOwinContext context)
        {
            return new AppRoleManager(new RoleStore<AppRole>(context.Get<AppIdentityDbContext>()));
        }
    }
}
