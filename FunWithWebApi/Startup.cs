using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using Owin;
using Swashbuckle.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace FunWithWebApi
{
    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);

            HttpConfiguration config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();

            config
                .EnableSwagger(c => c.SingleApiVersion("v1", "A title for your API"))
                .EnableSwaggerUi();
            //.EnableSwagger(swaggerPath, c =>
            //{
            //    c.RootUrl(req => ComputeHostAsSeenByOriginalClient(req));
            //    c.SingleApiVersion("v1", manager.ProductName);
            //    c.IncludeXmlComments($"{manager.ProductName}.XML");
            //    c.DescribeAllEnumsAsStrings();
            //    c.OperationFilter<MimeTypeOperationFilter>();
            //})
            //.EnableSwaggerUi(swaggerUiPath, c =>
            //{
            //    Assembly containingAssembly = Assembly.GetExecutingAssembly();
            //    c.CustomAsset("index", containingAssembly, "OpenIIoT.Core.Service.WebApi.Swagger.index.html");
            //    c.InjectStylesheet(containingAssembly, "OpenIIoT.Core.Service.WebApi.Swagger.style.css");
            //    c.EnableApiKeySupport(WebApiConstants.ApiKeyHeaderName, "header");
            //    c.DisableValidator();
            //});

            app.UseWebApi(config);

            app.UseFileServer(new FileServerOptions()
            {
                FileSystem = new PhysicalFileSystem("www"),
                RequestPath = PathString.FromUriComponent(""),
            });
        }

    }
}
