using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pizza.Pizzas.ChicagoStyle
{
    class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza()
        {
            name = "Chicago style clam pizza";
            dough = "thick dough";
            sauce = "brown tomato sauce";
            toppings.Add("clams");
            toppings.Add("sea food");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting {0} int square slices!", name);
        }

    }
}
