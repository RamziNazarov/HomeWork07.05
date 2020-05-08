using System;

namespace Homework
{
    class Program
    {
        static void Create()
        {
            using(var context = new RamziDBContext())
            {
                Console.Write("Enter Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter lastName: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());
                Customers customers = new Customers();
                customers.Name = name;
                customers.LastName = lastName;
                customers.Age = age;
                context.Customers.Add(customers);
                int a = context.SaveChanges();
                if(a > 0)
                {
                    System.Console.WriteLine("2222");
                }
            }
        }
        static void Update()
        {

        }
        static void Delete()
        {

        }
        static void Read()
        {

        }

        static void Main(string[] args)
        {
            using(var context = new RamziDBContext())
            {
                
            }
            string choice = "1";
            while(choice != "5")
            {
                Console.Clear();
                Console.Write("");
                choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                    Create();
                    Console.ReadKey();
                    break;
                    case "2":
                    Update();
                    break;
                    case "3":
                    Delete();
                    break;
                    case "4":
                    Read();
                    break;
                }
            }
        }
    }
}
