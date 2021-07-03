using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pizza.Pizzas.NYStyle
{
    class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            name = "NY style pepperoni pizza";
            dough = "violet dough";
            sauce = "blueberry sauce";
            toppings.Add("Extra pepperoni");
            toppings.Add("Extra cheese");
        }
    }
}
