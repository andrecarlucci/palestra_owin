using System;
using Microsoft.Owin.Hosting;
using Throwin;

namespace ThrowinExe {
    internal class Program {
        private static void Main(string[] args) {
            using (WebApp.Start<Startup>("http://localhost:12345")) {
                Console.WriteLine("Started");
                Console.ReadLine();
            }
        }
    }
}