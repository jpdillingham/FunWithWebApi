using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithWebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string URL = "http://*:5000";

            try
            {
                WebApp.Start<Startup>(URL);

                Console.WriteLine("Listening at " + URL);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                Console.ReadKey();
        }
    }
}
