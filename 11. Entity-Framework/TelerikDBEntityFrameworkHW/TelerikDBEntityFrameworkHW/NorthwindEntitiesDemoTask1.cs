using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TelerikDBEntityFrameworkHW
{
    public class NorthwindEntitiesDemoTask1
    {
        public void Task1Method()
        {
            using (var db = new DbEFHomewrokEntities())
            {
                var customerName = db.Customers
                    .Where(c => c.City=="London")
                    .Select(c => c.ContactName);

                Console.WriteLine(string.Join("\n", customerName));
            }
        }
    }
}
