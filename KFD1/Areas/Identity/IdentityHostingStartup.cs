using System;
using KFD1.Areas.Identity.Data;
using KFD1.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(KFD1.Areas.Identity.IdentityHostingStartup))]
namespace KFD1.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<KFD1Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("KFD1ContextConnection")));

                services.AddDefaultIdentity<KFD1User>()
                    .AddEntityFrameworkStores<KFD1Context>();
            });
        }
    }
}