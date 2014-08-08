using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Throwin {
    using AppFunc = Func<IDictionary<string, object>, Task>;
    public class Mw2 {
        private AppFunc _next;

        public Mw2(AppFunc next) {
            _next = next;
        }

        public async Task Invoke(IDictionary<string, object> env) {
            Console.WriteLine("Mw2");
            await _next.Invoke(env);
        }
    }
}
