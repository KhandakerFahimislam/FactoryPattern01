using FactoryMethodDesignPattern.Factories;
using FactoryMethodDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Demo
{
    public class FactoryController
    {
        private readonly IEntityFactory factory;
        public FactoryController(IEntityFactory factory)
        {
            this.factory = factory;
        }
        public void Action()
        {
            var contacts = new[]
            {
                factory.Create<Contact>(1, "Hasan Bhai", "Relatives", "01921XXXXXX", "hasan@gmail.com"),
                factory.Create<Contact>(2, "Jafor Mollah", "Relatives", "01781XXXXXX", "jafor@gmail.com"),
                factory.Create<Contact>(3, "Tanim Ahmed", "Friends", "01881XXXXXX", "tanim@gmail.com")

            };
            Console.WriteLine("Contacts");
            Console.WriteLine("***************************************************************************");
            contacts.ToList()
                .ForEach(c => Console.WriteLine($"{c.Name} Group: {c.Group} Phone: {c.Phone} E-mail: {c.Email}"));
            Console.WriteLine();
            var expenses = new[]
            {
                factory.Create<Expense>(1, DateTime.Parse("2022-09-01"), "Soap", 70.00M, 1),
                factory.Create<Expense>(2, DateTime.Parse("2022-09-01"), "Chair", 350.00M, 1),
                factory.Create<Expense>(3, DateTime.Parse("2022-09-02"), "T-Shirt", 230.00M, 2)
            };
            Console.WriteLine("Exapenses");
            Console.WriteLine("****************************************************************************");
            expenses.ToList()
                .ForEach(e => Console.WriteLine($"{e.Date:dd-MM-yyyy}\t{e.Item}\t{e.UnitPrice:0.00}\t{e.Quantity}\t{(e.Quantity * e.UnitPrice):0.00}"));
        }
    }
}
