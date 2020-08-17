using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Pierre's Bakery.");
            Console.WriteLine();
            Dictionary<string,Dictionary<string,int[]>> menu = Order.CreateItemsMenu();
            foreach(KeyValuePair<string,Dictionary<string,int[]>> entry in menu)
            {
                Console.WriteLine("We have the following " + entry.Key + " items.");
                Console.WriteLine("---------------------------------");
                foreach(KeyValuePair<string,int[]> item in entry.Value)
                {
                    Console.WriteLine(item.Key);
                    Console.WriteLine("A single item costs " + item.Value[0] + " dollars.");
                    Console.WriteLine("You can buy " + item.Value[2] + " for " +item.Value[1]);
                    Console.WriteLine();
                }
            }
            Console.WriteLine("-----------------");
            
            while(true)
            {
                Console.WriteLine("Please pick an item by writing the item name. Or write 'Order' to complete your purchase");
                
                string itemName = Console.ReadLine();
                
                if(itemName == "Order")
                {
                    break;
                }
                Console.WriteLine("How many of this item do you want to purchase?");

                try
                {
                    int amount = int.Parse(Console.ReadLine());
                    Order.AddToOrder(itemName, amount);  
                }
                catch(ArgumentException ex){
                    Console.WriteLine();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Be sure to capitalize the item name.");
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("You need to type in a number.");
                    Console.WriteLine();
                }
                    
            }

            int totalAmount =0;
            int totalValue = 0;
            Dictionary<string, Dictionary<string,int[]>> totals = Order.GetTotalsForAllOrder();
            Console.WriteLine();
            Console.WriteLine("Your itemized receipt.");
            Console.WriteLine("------------------");
            foreach(KeyValuePair<string,Dictionary<string,int[]>> entry in totals)
            {
                totalAmount += entry.Value[entry.Key][0];
                totalValue += entry.Value[entry.Key][1];
                Console.WriteLine();
                Console.WriteLine("You purchased " + entry.Value[entry.Key][0] + " " + entry.Key + " items for a total value of " + entry.Value[entry.Key][1] + ".");
                Console.WriteLine("Your itemized " + entry.Key + " purchases are as follows.");
                Console.WriteLine("--------");
                Console.WriteLine();
                foreach(KeyValuePair<string,int[]> item in entry.Value)
                {
                    if(!(item.Key == entry.Key))
                    {
                        Console.WriteLine("You purchased " + item.Value[0] + " " + item.Key + " items for " + item.Value[1] + " dollars." );
                    }
                    
                }
                Console.WriteLine("--------------------")
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("You ordered " + totalAmount +" items in total.");
            Console.WriteLine("Your total purchase value is " + totalValue  + " dollars.");
        }
    }
}