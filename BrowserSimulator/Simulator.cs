using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserSimulator
{
    internal class Simulator
    {
        public void Run()
        {
            while (true)
            {
                Console.Write("Please put an URL in:");
                string url = Console.ReadLine();
                if (url == "e")
                {
                    break;
                }
                BrowseURL(url);
            }
        }

        public void BrowseURL(string url)
        {
            Console.WriteLine($"Loading... {url}");

        }
    }
}
