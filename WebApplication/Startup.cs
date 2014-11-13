using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.FileSystems;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.AspNet.Routing;
using Microsoft.AspNet.Security.Cookies;
using Microsoft.AspNet.StaticFiles;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;

namespace KWebStartup
{
    public class Startup
    {
    	public void ConfigureServices(IServiceCollection services)
        {
        	services.AddMvc();
        }


        public void Configure(IApplicationBuilder app)
        {

            app.UseMvc();
        }
    }
}