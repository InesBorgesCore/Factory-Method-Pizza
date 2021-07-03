using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pizza.Pizzas.ChicagoStyle
{
    class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            name = "Chicago style veggie pizza";
            dough = "thick crispy dough";
            sauce = "yellow tomato sauce";
            toppings.Add("corn");
            toppings.Add("mushrooms");
        }
    }
}
