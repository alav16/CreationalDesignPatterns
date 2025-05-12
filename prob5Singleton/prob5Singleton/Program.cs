/*
You need to create a PrinterSpooler class that manages printing jobs in the system.
Ensure that only one spooler exists to avoid conflicts between print jobs. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob5Singleton
{
    public class PrinterSpooler
    {
        private static PrinterSpooler instance;

        private PrinterSpooler()
        {
            Console.WriteLine("Instance created");
        }

        public static PrinterSpooler GetInstance()
        {
            if (instance == null)
            {
                instance = new PrinterSpooler();
            }
            return instance;
        }

        public void Show()
        {
            Console.WriteLine("Singleton");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PrinterSpooler obj1 = PrinterSpooler.GetInstance();

            PrinterSpooler obj2 = PrinterSpooler.GetInstance();

            Console.WriteLine(obj1 == obj2);


        }
    }
}
