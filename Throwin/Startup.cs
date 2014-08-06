using System;
using System.Web.Http;
using Owin;

namespace Throwin {
    public class Startup {
        public void Configuration(IAppBuilder app) {
            app.Use<Mw1>();
            app.Use<Mw2>();
            app.UseErrorPage();

            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute("default", "api/{controller}", new { controller = "home" });
            app.UseWebApi(config);

            app.UseHandlerAsync((req, res) => {
                if (req.Path.Contains("/fail")) {
                    throw new Exception("ho ho ho");
                }
                res.ContentType = "text/plain";
                return res.WriteAsync("Hello TDC");
            });
        }
    }
}