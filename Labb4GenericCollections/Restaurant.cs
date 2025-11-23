using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4GenericCollections
{
    internal class Restaurant
    {
        private List<MenuItem> menu = new List<MenuItem>();
        private Queue<Order> orders = new Queue<Order>();

        //Lägger till en ny maträtt i menyn och loggar detta till konsolen.
        public void AddtoMenu(MenuItem menuItem)
        {

            menu.Add(menuItem);
            Console.WriteLine($"{menuItem.Name} has been added to the menu");
        }
        //Skriver ut alla maträtter i menyn till konsolen.
        public void ShowMenu()
        {
            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Id}. {item.Name} - {item.Price} kr");
            }
            
        }
        //Lägger till en ny beställning i kön och loggar detta till konsolen.
        public void CreateOrder(Order order)
        {
            orders.Enqueue(order);
            Console.WriteLine($"Order {order.OrderId} Has been Queued");
        }
        //Hanterar (tar bort) den första beställningen i kön och loggar detta till konsolen.
        public void HandleOrder()
        {
            Order currentOrder = orders.Peek();
            Console.WriteLine($"Order {currentOrder.OrderId} Has been completed");
            orders.Dequeue();

            Console.WriteLine("");
        }
        //Skriver ut alla beställningar i kön till konsolen.
        public void ShowOrders()
        {
            decimal sumPrice = 0;
            Console.WriteLine("Current Orders:");

            foreach (var order in orders)
            {
                Console.WriteLine($"Order {order.OrderId} (Table {order.TableNumber}):");
                Console.WriteLine("----------------------");
                foreach (var item in order.OrderItems)
                {
                    Console.WriteLine($"- {item.Name} - {item.Price} kr");
                    sumPrice += item.Price;
                }
                Console.WriteLine($"Total Sum of Price: {sumPrice}");
                Console.WriteLine("----------------------");
                Console.WriteLine("");
            }
        }

        //Skriver ut beställningen som är näst i kön till konsolen.
        public void ShowNextOrder()
        {
            //We will check if there is a order, then we get the first order with peek and output information about that first order
            if (orders.Count > 0) 
            {
                decimal sumPrice = 0;
                Console.WriteLine("Next Order");
                Console.WriteLine("______________________");

                Order currentOrder = orders.Peek(); 

                Console.WriteLine($"Order ID: {currentOrder.OrderId} (Table {currentOrder.TableNumber}):");

                foreach (var item in currentOrder.OrderItems) 
                {
                    Console.WriteLine($"- {item.Name} - {item.Price} kr");
                    sumPrice += item.Price;
                }

                Console.WriteLine($"Total Sum of Price: {sumPrice} kr");
                Console.WriteLine("----------------------");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("No orders in the queue.");
            }
        }

        //Skriver ut antalet beställningar i kön till konsolen.
        public void ShowOrderCount()
        {
            if(orders.Count > 0)
            {
                Console.WriteLine($"Order Count: {orders.Count}");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("There are no orders :(");
                Console.WriteLine("");
            }
            
        }
    }
}
