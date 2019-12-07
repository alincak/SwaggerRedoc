using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SwaggerDoc.Startup))]

namespace SwaggerDoc
{
   public class Startup
   {
      public void Configuration(IAppBuilder app)
      {
         app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
      }

   }
}
