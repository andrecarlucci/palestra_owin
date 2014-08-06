using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throwin {
    public class Mw2 {
        private Func<IDictionary<string, object>, Task> _next;

        public Mw2(Func<IDictionary<string, object>, Task> next) {
            _next = next;
        }

        public async Task Invoke(IDictionary<string, object> env) {
            Console.WriteLine("Mw2");
            await _next.Invoke(env);
        }
    }
}
