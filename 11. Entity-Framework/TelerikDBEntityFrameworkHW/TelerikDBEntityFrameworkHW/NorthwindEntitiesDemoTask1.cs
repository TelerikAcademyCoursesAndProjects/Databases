using System;
using System.Collections.Generic;
using System.Linq;
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
                var employeesFirstName = db.Employees
                    .Select(e => e.FirstName);

                Console.WriteLine(string.Join("\n", employeesFirstName));
            }
        }
    }
}
