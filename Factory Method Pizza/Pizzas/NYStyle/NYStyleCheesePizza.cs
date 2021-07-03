using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pizza.Pizzas.NYStyle
{
    class NYStyleCheesePizza : Pizza 
    {
        public NYStyleCheesePizza()
        {
            sauce = "tomato sauce";
            dough = "thin crusty dough";
            name = "NY style cheese pizza";
            toppings.Add("Sliced ham");
        }
    }
}
