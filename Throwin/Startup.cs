using System;
using System.Web.Http;
using Microsoft.Owin.Diagnostics;
using Owin;

namespace Throwin {
    public class Startup {
        public void Configuration(IAppBuilder app) {
            app.Use<Mw1>();
            app.Use<Mw2>();

            var erroPageOptions = new ErrorPageOptions {
                ShowExceptionDetails = true
            };
            app.UseErrorPage(erroPageOptions);

            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute("default", "api/{controller}", 
                                        new { controller = "home" });
            app.UseWebApi(config);

            app.UseHandlerAsync((req, res) => {
                if (req.Path.Contains("/fail")) {
                    throw new Exception(":(");
                }
                res.ContentType = "text/plain";
                return res.WriteAsync("Hello TDC!");
            });
        }
    }
}