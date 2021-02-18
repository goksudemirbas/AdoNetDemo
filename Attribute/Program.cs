using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//namespace Attribute
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Customer customer = new Customer { id = 1, Lastname = "Goksu", Age = 22 };
//            CustomerDal customerDal = new CustomerDal();
//            customerDal.add(customer);
//            Console.ReadLine();
           

//        }

//    }
//    [ToTable("Customers")]
//    class Customer
//    {
//        public  int id { get; set; }
//        [RequiredProperty]
//        public string Firstname { get; set; }
//        [RequiredProperty]
//        public string Lastname { get; set; }
//        [RequiredProperty]
//        public int Age { get; set; }

//    }
//    class CustomerDal
//    {
//        public void add(Customer customer)
//        {
//            Console.WriteLine("{0},{1},{2},{3} added!", customer.id,customer.Firstname,customer.Lastname,customer.Age);
//        }
//    }
//    class RequiredPropertyAttribute:Attribute
//    {

//    }
//    class ToTableAttribute:Attribute
//    {
//        private string _TableName;
//        public ToTableAttribute(string tablename)
//        {
//            _TableName = tablename;
//        }
//       // [Obsolete("Dont use add")]  uyarabiliriz.
//    }
//}
