namespace TelerikDBEntityFrameworkHW
{
    public class Start
    {
        public static void Main()
        {
            // 01. Using the Visual Studio Entity Framework designer create a DbContext for the Northwind database
            var task1 = new NorthwindEntitiesDemoTask1();
            task1.Task1Method();

            // 02. Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers.
            // Write a testing class.

            InsertingModifyingDeletingCustomersTask2.InsertCustomer();
            InsertingModifyingDeletingCustomersTask2.ModifyCustomer();
            InsertingModifyingDeletingCustomersTask2.DeleteCustomer();

            // 03. Write a method that finds all customers who have orders made in 1997 and shipped to Canada.

            OrdersTrackingTask3.FindAllCustomersWithOrdersMadeIn1997AndShippedToCanada();

            // 04. Implement previous by using native SQL query and executing it through the DbContext.

            OrdersTrackingSQLTask4.FindAllCustomersWithOrdersFrom1997AndShippedToCanadaUsingSQL();
        }
    }
}
