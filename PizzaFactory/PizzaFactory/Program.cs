using System;

namespace FactoryPatterns
{
    class Program
    {

        static void Main(string[] args)
        {

            PizzaFactory factory = new PizzaFactory();
            PizzaStore store = new PizzaStore(factory);
            store.orderPizza("cheese");

        }
    }
}
