using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pizza.Pizzas.ChicagoStyle
{
    class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Chicago style cheese pizza";
            dough = "purple dough";
            sauce = "avocado sauce";
            toppings.Add("Sliced ham");
            toppings.Add("potatoes");
        }
        
    }
}
