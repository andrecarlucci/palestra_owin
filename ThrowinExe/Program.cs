using System;
using Microsoft.Owin.Hosting;
using Throwin;

namespace ThrowinExe {
    internal class Program {
        private static void Main(string[] args) {
            var address = "http://localhost:12345";
            using (WebApp.Start<Startup>(address)) {
                Console.WriteLine("Self Host Start: " + address);
                Console.ReadLine();
            }
        }
    }
}