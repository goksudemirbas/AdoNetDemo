using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.topla2());
            //Console.WriteLine(dortIslem.topla(3, 2));
            var tip = typeof(DortIslem);

         // DortIslem dortislem= (DortIslem)Activator.CreateInstance(tip,6,7); //newle aynı şey-çalışma anı
          //Console.WriteLine(dortislem.topla(4, 5));
          //Console.WriteLine(dortislem.topla2());
           var instance = Activator.CreateInstance(tip, 6, 5);
           Console.WriteLine( instance.GetType().GetMethod("topla2").Invoke(instance,null));
            Console.ReadLine();

                
        }
    }
   public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;        
        }


        public int topla2()
        {
            return _sayi1 + _sayi2;

        }
        public int carp2()
        {
            return _sayi1 * _sayi2;

        }
        public int topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;

        }
        public int carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;

        }
    }
}

