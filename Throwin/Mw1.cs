using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Throwin {

    using AppFunc = Func<IDictionary<string, object>, Task>;

    public class Mw1 {
        private AppFunc _next;

        public Mw1(AppFunc next) {
            _next = next;
        }

        public async Task Invoke(IDictionary<string, object> env) {
            Console.WriteLine("Mw1: " + DateTime.Now);
            await _next.Invoke(env);
        }
    }
}