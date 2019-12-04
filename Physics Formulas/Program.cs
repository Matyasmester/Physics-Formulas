using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics_Formulas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InputHandler handler = new InputHandler();

            Console.WriteLine("Choose a formula from below, then input the two missing values.\n");
            Console.WriteLine("[1]: Amperage\n");
            Console.WriteLine("[2]: Electric work\n");
            Console.WriteLine("[3]: Velocity\n");

            handler.handle(Console.ReadLine());
        }
    }
}
