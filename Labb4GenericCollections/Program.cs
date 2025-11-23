using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Labb4GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Restaurant ElBulli = new Restaurant();


            //This will create 4 new menu items :D
            MenuItem kebab = new MenuItem(1, "kebab", 20);
            ElBulli.AddtoMenu(kebab);

            MenuItem Tacos = new MenuItem(2, "Tacos", 75);
            ElBulli.AddtoMenu(Tacos);

            MenuItem PekingDuck = new MenuItem(3, "Peking Duck", 300);
            ElBulli.AddtoMenu(PekingDuck);

            MenuItem Gulach = new MenuItem(4, "Gulach", 5);
            ElBulli.AddtoMenu(Gulach);

            Console.WriteLine("");

            ElBulli.ShowMenu();

            //Table 10 orders. This and the 2 other orders will create a order for a couple of menu items for a specific table 
            // Order number 1
            List<MenuItem> order1Items = new List<MenuItem>();
            order1Items.Add(kebab);
            order1Items.Add(Tacos);
            order1Items.Add(kebab);
            order1Items.Add(kebab);

            Order order1 = new Order(order1Items, 10);

            //Table 6 orders / Order number 2
            List<MenuItem> order2Items = new List<MenuItem>();
            order2Items.Add(Gulach);
            order2Items.Add(Tacos);

            Order order2 = new Order(order2Items, 6);


            //Table 2 orders / Order number 3
            List<MenuItem> order3Items = new List<MenuItem>();
            order3Items.Add(Gulach);
            order3Items.Add(Tacos);
            order3Items.Add(Gulach);
            order3Items.Add(Tacos);

            Order order3 = new Order(order3Items, 2);

            Console.WriteLine("");

            //This will actually create and add the orders to the queue
            ElBulli.CreateOrder(order1);
            ElBulli.CreateOrder(order2);
            ElBulli.CreateOrder(order3);

            Console.WriteLine("");

            //This will show each order and what they want and to what table it goes
            ElBulli.ShowOrders();

            //This will show how many orders there are in total
            ElBulli.ShowOrderCount();

            //Show next order
            ElBulli.ShowNextOrder();

            ElBulli.HandleOrder();

            ElBulli.ShowOrderCount();

            //Table 7 order / Order number 4
            List<MenuItem> order4Items = new List<MenuItem>();
            order4Items.Add(Gulach);

            Order order4 = new Order(order4Items, 2);

            //This is just a bunch of method spam that proves that my code works :D
            ElBulli.CreateOrder(order4);
            Console.WriteLine("");
            ElBulli.ShowOrderCount();

            ElBulli.HandleOrder();
            ElBulli.HandleOrder();

            ElBulli.ShowOrderCount();

            ElBulli.ShowNextOrder();

            ElBulli.HandleOrder();

            ElBulli.ShowOrderCount();

        }
    }
}
