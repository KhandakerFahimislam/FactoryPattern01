using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Models
{
    public class Expense : IEntity
    {
        public Expense() { }
        public Expense(int id, DateTime date, string item, decimal unitPrice, int quantity)
        {
            Id = id;
            Date = date;
            Item = item;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Item { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
