using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARKTribalFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Event_Taming tame001 = new Event_Taming(new Dinosaur("Trike",20));

            tame001.print_taming_dino();
            
            //Just to make the console stay open to see the result.
            Console.Read();
        }

    }
}
