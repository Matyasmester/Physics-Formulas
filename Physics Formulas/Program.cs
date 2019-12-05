using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics_Formulas
{
    class Program
    {
        static void Main(string[] args)
        {
            InputOutputHandler handler = new InputOutputHandler();

            Console.WriteLine("Choose a formula from below, then input the missing values.");
            Console.WriteLine("[1]: Amperage");
            Console.WriteLine("[2]: Electric work");
            Console.WriteLine("[3]: Velocity");
            Console.WriteLine("[4]: Electric Performance");

            handler.handle(Console.ReadLine());
        }
    }
}
