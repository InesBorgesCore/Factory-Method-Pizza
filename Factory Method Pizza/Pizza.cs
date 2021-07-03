using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pizza
{
    abstract class Pizza
    {
        public String name { get; set; }
        public String dough { get; set; }
        public String sauce { get; set; }
        public List<String> toppings = new List<string>();
        public void prepare()
        {
            Console.WriteLine("Preparing {0}", name);
            Console.WriteLine("Tossing {0}", dough);
            Console.WriteLine("Adding {0}", sauce);
            Console.WriteLine("Putting toppings:");
            foreach(String top in toppings)
            {
                Console.WriteLine("    {0}", top);
            }
        }
        public void bake()
        {
            Console.WriteLine("Baking at 235º for 25 minutes");
        }
        public virtual void cut()
        {
            Console.WriteLine("Cutting pizza into diagonal slices!");
        }
        public void box()
        {
            Console.WriteLine("Boxing {0} into special box!", name);
        }
    }
}
