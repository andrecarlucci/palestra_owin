using System;
using System.Web.Http;

namespace Throwin {
    public class HomeController : ApiController {
        public int[] GetValues() {
            return new[] { 1, 2, 3, DateTime.Now.Second };
        }
    }
}