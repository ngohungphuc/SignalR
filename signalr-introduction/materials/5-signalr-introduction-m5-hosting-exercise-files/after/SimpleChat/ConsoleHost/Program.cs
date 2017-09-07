using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApplication.Start<Startup>(
                "http://localhost:6789"))
            {
                Console.WriteLine("Hubs running...");
                Console.ReadLine();
            }
        }
    }
}
