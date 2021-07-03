using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pizza.Pizzas.NYStyle
{
    class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            name = "NY style clam pizza";
            dough = "thin red dough";
            sauce = "banana sauce";
            toppings.Add("Clams");
            toppings.Add("Mushrooms");
            toppings.Add("Onions");
        }
    }
}
