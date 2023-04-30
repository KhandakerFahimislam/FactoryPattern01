using FactoryMethodDesignPattern.Demo;
using FactoryMethodDesignPattern.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEntityFactory factory = new EntityFactory();
            FactoryController controller = new FactoryController(factory);
            controller.Action();
            Console.ReadLine();
        }
    }
}
