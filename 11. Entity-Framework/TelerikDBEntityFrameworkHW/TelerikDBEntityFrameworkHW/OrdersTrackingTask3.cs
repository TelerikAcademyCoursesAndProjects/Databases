using System;
using System.Linq;

namespace TelerikDBEntityFrameworkHW
{
    public class OrdersTrackingTask3
    {
        public static void FindAllCustomersWithOrdersMadeIn1997AndShippedToCanada()
        {
            Console.WriteLine();
            Console.WriteLine("Task 3 Find all customers who have orders made in 1997 and shipped to Canada\n");

            using (var db = new DbEFHomewrokEntities())
            {
                var findCustomers = db.Orders
                      .Where(o => o.OrderDate >= new DateTime(1997, 1, 1))
                      .Where(o => o.OrderDate <= new DateTime(1997, 12, 31))
                      .Where(o=>o.ShipCountry=="Canada")
                      .Select(o=>o.Customer.ContactName);

                Console.WriteLine(String.Join("\n",findCustomers));
                Console.WriteLine(new String('-', 50));
            }
        }
    }
}
