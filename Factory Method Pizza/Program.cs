using System;
using Factory_Method_Pizza.Stores;

namespace Factory_Method_Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            NYStylePizzaStore nYStylePizzaStore = new NYStylePizzaStore();
            nYStylePizzaStore.orderPizza("cheese");
            Console.ReadKey();

            nYStylePizzaStore.orderPizza("pepperoni");
            Console.ReadKey();

            nYStylePizzaStore.orderPizza("clam");
            Console.ReadKey();

            nYStylePizzaStore.orderPizza("veggie");
            Console.ReadKey();

            ChicagoStylePizzaStore chicagoStylePizzaStore = new ChicagoStylePizzaStore();
            chicagoStylePizzaStore.orderPizza("clam");
            Console.ReadKey();

            chicagoStylePizzaStore.orderPizza("veggie");
            Console.ReadKey();

            chicagoStylePizzaStore.orderPizza("cheese");
            Console.ReadKey();

            chicagoStylePizzaStore.orderPizza("pepperoni");
            Console.ReadKey();

        }
    }
}
