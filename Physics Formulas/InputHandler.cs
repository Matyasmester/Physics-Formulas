using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics_Formulas
{
    public class InputHandler
    {
        public void handle(string text)
        {
            double inp1, inp2, inp3;
            Formulas f = new Formulas();
            switch (text)
            {
                case "1":
                    Console.WriteLine("Amperage: \n");
                    inp1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("P=" + inp1 + "\n");
                    inp2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("U=" + inp2 + "\n");
                    Console.WriteLine("I=" + f.calculateAmperage(inp1, inp2));
                    Console.Read();
                    break;

                case "2":
                    Console.WriteLine("Electric Work: \n");
                    inp1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("U=" + inp1 + "\n");
                    inp2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("I=" + inp2 + "\n");
                    inp3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("t=" + inp3 + "\n");
                    Console.WriteLine("W=" + f.calculateElectricWork(inp1, inp2, inp3));
                    Console.Read();
                    break;

                case "3":
                    Console.WriteLine("Velocity: \n");
                    inp1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("s=" + inp1 + "\n");
                    inp2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("t=" + inp2 + "\n");
                    Console.WriteLine("v=" + f.calculateVelocity(inp1, inp2));
                    Console.Read();
                    break;
            }
        }
    }
}
