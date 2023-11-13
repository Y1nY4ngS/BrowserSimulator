/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserSimulator
{
    internal class Simulator
    {
        //membervariable
        private StringStack historyStack = new StringStack();
        private StringStack forwardStack = new StringStack();
        private string currentUrl = "";
        
        public void Run()
        {
            while (true)
            {
                Console.Clear();
                DisplayUrl();
                Console.Write("Please put an URL in:");
                string url = Console.ReadLine();
                switch(url)
                {
                    case "e":
                        Environment.Exit(0);
                        break;
                    
                    case "u":
                        Undo();
                        break;

                    case "f":
                        Redo();
                        break;

                    default:
                        BrowseURL(url);
                        break;
                }    
                
            }
        }

        private void BrowseURL(string url)
        {
            if (!string.IsNullOrEmpty(currentUrl))
            
            {
                historyStack.Push(currentUrl);
                forwardStack.Clear();
            }
            currentUrl = url;
            Console.WriteLine($"Loading... {url}");

        }

        private void Undo()
        {
            if (historyStack.Count > 0)
            {
                forwardStack.Push(currentUrl);
                currentUrl = historyStack.Pop();
            } else
            {
                Console.WriteLine("Diese Funktion ist momentan nicht möglich");
            }

        }

        private void Redo()
        {
            if (forwardStack.Count > 0)
            {
                historyStack.Push(currentUrl);
                currentUrl = forwardStack.Pop();
            }
            else
            {
                Console.WriteLine("Diese Funktion ist momentan nicht möglich");
            }

        }

        private void DisplayUrl()
        {
            Console.WriteLine($"Die Aktuelle URL ist {currentUrl}");
        }
    }
}
*/