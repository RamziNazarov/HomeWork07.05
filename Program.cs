using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
            using(var context = new RamziDBContext())
            {
                Read();
                Console.Write("Введите id: ");
                int id = int .Parse(Console.ReadLine());
                Customers customer = context.Customers.Find(id);
                if(customer != null)
                {
                    Console.Write("Enter Name: ");
                    customer.Name = Console.ReadLine();
                    Console.Write("Enter LastName: ");
                    customer.LastName = Console.ReadLine();
                    System.Console.Write("Enter age: ");
                    customer.Age = int.Parse(Console.ReadLine());
                    if(context.SaveChanges() > 0)
                    {
                        System.Console.WriteLine("2123");
                    }
                }
            }
        }
        static void Delete()
        {
            Read();
            using(var context = new RamziDBContext())
            {
            Console.Write("Введите id: ");
                int id = int .Parse(Console.ReadLine());
                Customers customer = context.Customers.Find(id);
                if(customer != null )
                {
                    context.Customers.Remove(customer);
                    if(context.SaveChanges() > 0)
                    {
                        System.Console.WriteLine("successfull");
                    }
                }
            }
        }
        static void Read()
        {
            using(var context = new RamziDBContext())
            {
                var customers = context.Customers.ToList();
                foreach(var items in customers)
                {
                    System.Console.WriteLine($"Id = {items.Id} | Name = {items.Name} | LastName = {items.LastName} | Age = {items.Age}");
                }
            }
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
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
