using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pizza.Pizzas.ChicagoStyle
{
    class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            name = "Chicago style pepperoni pizza";
            dough = "thick lime dough";
            sauce = "brown potato sauce";
            toppings.Add("extra pepperoni");
            toppings.Add("extra cheese");
        }

    }
}
