using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Product harddisk = new Product(50);
            harddisk.ProductName = "hard disk";
            Product gsm = new Product(50);
            gsm.ProductName = "GSM";
            gsm.StockControlEvent += Gsm_StockControlEvent;
            harddisk.StockControlEvent += Harddisk_StockControlEvent;
            for (int i = 0; i <10; i++)
            {
                harddisk.sell(10);
                gsm.sell(10);
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        private static void Harddisk_StockControlEvent()
        {
            Console.WriteLine("Harddisk about the finish");
        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("GSM about the finish");
        }
    }
}
