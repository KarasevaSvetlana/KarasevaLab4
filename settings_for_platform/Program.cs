using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace settings_for_platform
{
    abstract class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input name OS:");
            string type = Console.ReadLine();
            switch (type)
            {
                case "ubuntu":
                    client client1 = new client();
                    client1.ubuntuSet();
                    break;
                case "Windows":
                    client client2 = new client();
                    client2.windowsSet();
                    break;
                case "macOS":
                    client client3 = new client();
                    client3.macOSSet();
                    break;
                default:
                    Console.WriteLine("Error!"); break;
            }
                    Console.ReadKey();

        }
    }
}
