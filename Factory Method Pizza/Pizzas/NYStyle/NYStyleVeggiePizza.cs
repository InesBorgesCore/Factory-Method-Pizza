using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pizza.Pizzas.NYStyle
{
    class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            name = "NY style veggie pizza";
            dough = "yellow dough";
            sauce = "lettuce sauce";
            toppings.Add("corn");
            toppings.Add("brocolli");
            toppings.Add("tofu");
        }
    }
}
