using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns
{
    public class PizzaFactory
    {
        public Pizza createPizza(String type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza();
            }
           
            return pizza;
        }
    }
}
