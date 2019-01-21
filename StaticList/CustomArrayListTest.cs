﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticList
{
    class CustomArrayListTest
    {
        static void Main()
        {
            CustomArrayList<string> shoppingList =
            new CustomArrayList<string>();
            shoppingList.Add("Milk");
            shoppingList.Add("Honey");
            shoppingList.Add("Olives");
            shoppingList.Add("Water");
            shoppingList.Add("Beer");
            shoppingList.Remove("Olives");
            shoppingList.Insert(1, "Fruits");
            shoppingList.Insert(0, "Cheese");
            shoppingList.Insert(6, "Vegetables");
            shoppingList.RemoveAt(0);
            shoppingList[3] = "A lot of " + shoppingList[3];
            Console.WriteLine("We need to buy:");
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(" - " + shoppingList[i]);
            }
            Console.WriteLine("Position of 'Beer' = {0}",
            shoppingList.IndexOf("Beer"));
            Console.WriteLine("Position of 'Water' = {0}",
            shoppingList.IndexOf("Water"));
            Console.WriteLine("Do we have to buy Bread? " +
                shoppingList.Contains("Bread"));

            Console.ReadKey();
        }
    }
}
