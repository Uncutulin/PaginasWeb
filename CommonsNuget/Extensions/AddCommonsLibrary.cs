using CommonsNuget.ViewComponents;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System.Reflection;

namespace CommonsNuget.Extensions
{
    public static partial class Extensions
    {
        public static void AddCommonsLibraryViews(this IServiceCollection services)
        {
            /*
            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.FileProviders.Add(new EmbeddedFileProvider(typeof(RegisterCommonsOnlineViewComponent)
                    .GetTypeInfo().Assembly));

                options.FileProviders.Add(new EmbeddedFileProvider(typeof(Class1)
                    .GetTypeInfo().Assembly));
            });
            */
        }

        public static void UseCommonsLibraryScripts(this IApplicationBuilder builder)
        {

            //var embeddedProvider = new EmbeddedFileProvider(typeof(RegisterCommonsOnlineViewComponent)
            //    .GetTypeInfo().Assembly, "CommonsNuget.wwwroot.js");

            //builder.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = embeddedProvider,
            //    RequestPath = new PathString("/js")
            //});

            //embeddedProvider = new EmbeddedFileProvider(typeof(RegisterCommonsOnlineViewComponent)
            //    .GetTypeInfo().Assembly, "CommonsNuget.wwwroot.css");

            //builder.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = embeddedProvider,
            //    RequestPath = new PathString("/css")
            //});

            //embeddedProvider = new EmbeddedFileProvider(typeof(Class1)
            //    .GetTypeInfo().Assembly, "CommonsNuget.wwwroot.js");

            //builder.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = embeddedProvider,
            //    RequestPath = new PathString("/js")
            //});

            //embeddedProvider = new EmbeddedFileProvider(typeof(Class1)
            //    .GetTypeInfo().Assembly, "CommonsNuget.wwwroot.css");

            //builder.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = embeddedProvider,
            //    RequestPath = new PathString("/css")
            //});

        }
    }

}
