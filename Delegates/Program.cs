using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);//parametresi olmayan ve void olan delegate.
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();


            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
             //Çağırınca çalışıyor.

            myDelegate -= customerManager.SendMessage;
            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            myDelegate2("hello"); myDelegate();

            matematik matematik = new matematik();
            MyDelegate3 myDelegate3 = matematik.topla;
           var sonuc= myDelegate3(2, 3);
            Console.WriteLine(sonuc);

            // func<int,int,int> add = topla;


            Console.ReadLine();
        }
    }
   public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be Carefull!");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }
   public class matematik
    {
        public int topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
