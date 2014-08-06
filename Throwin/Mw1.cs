using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Throwin {
    public class Mw1 {
        private Func<IDictionary<string, object>, Task> _next;

        public Mw1(Func<IDictionary<string, object>, Task> next) {
            _next = next;
        }

        public async Task Invoke(IDictionary<string, object> env) {
            Console.WriteLine("Mw1");
            await _next.Invoke(env);
        }
    }
}