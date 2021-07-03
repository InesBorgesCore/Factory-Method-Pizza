using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_Method_Pizza.Pizzas.NYStyle;

namespace Factory_Method_Pizza.Stores
{
    class NYStylePizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case "cheese":
                    pizza = new NYStyleCheesePizza();
                    break;
                case "pepperoni":
                    pizza = new NYStylePepperoniPizza();
                    break;
                case "clam":
                    pizza = new NYStyleClamPizza();
                    break;
                case "veggie":
                    pizza = new NYStyleVeggiePizza();
                    break;
            }

            return pizza;
        }
    }
}
