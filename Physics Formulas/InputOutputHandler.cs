using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics_Formulas
{
    class InputOutputHandler
    {
        public void handle(string text)
        {
            double inp1, inp2, inp3;
            Formulas f = new Formulas();
            switch (text)
            {
                case "1":
                    inp1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("P=" + inp1 + "kilowatt");
                    inp2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("U=" + inp2 + "V");
                    Console.WriteLine("I=" + f.calculateAmperage(inp1, inp2) + "A");
                    Console.Read();
                    break;

                case "2":
                    inp1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("U=" + inp1 + "V");
                    inp2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("I=" + inp2 + "A");
                    inp3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("t=" + inp3 + "h");
                    Console.WriteLine("W=" + f.calculateElectricWork(inp1, inp2, inp3) + "w");
                    Console.Read();
                    break;

                case "3":
                    inp1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("s=" + inp1 + "m");
                    inp2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("t=" + inp2 + "h");
                    Console.WriteLine("v=" + f.calculateVelocity(inp1, inp2) + "km/h");
                    Console.Read();
                    break;
                case "4":
                    inp1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("P=" + inp1 + "kilowatt");
                    inp2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("t=" + inp2 + "h");
                    Console.WriteLine("(delta)E=" + f.calculateElectricPerformance(inp1, inp2) + "kWh");
                    Console.Read();
                    break;
            }
        }
    }
}
