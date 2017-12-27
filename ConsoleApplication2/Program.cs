using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {


        public class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
        }
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Car { Make = "A", Model = "Ford" },
                new Car { Make = "D", Model = "Ford" },
                new Car { Make = "C", Model = "Cheese" }
            };

            var results = from c in cars
                          group c by c.Make into g
                          orderby g.Key
                          select g.Key.Max();

        }

        public static bool IsPrime (int input)
        {
            bool isPrime = false;

            for (int checkDigit = 2; checkDigit < input; checkDigit++)
            {
                if (input % checkDigit == 0)
                {
                    isPrime = true;
                    break;
                }
            }

            return isPrime;
        }
    }
}
