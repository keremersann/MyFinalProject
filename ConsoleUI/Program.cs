﻿using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
     class Program
    {
        static void Main(string[] args)
        {
            
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach(var prodcuct in productManager.GetAll())
                Console.WriteLine($"Product Names: {prodcuct.ProductName}");
            
        }
    }
}