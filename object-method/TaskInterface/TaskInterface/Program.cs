using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ClassProduct[] product = new ClassProduct[3];
            product[0] = new ClassProduct("Boeing Business Jet", 500000, 1);
            product[1] = new ClassProduct("Airbus A319CJ", 7500000, 2);
            product[2] = new ClassProduct("Gulfstream", 325000, 6);

            product[0].GetProduct();
            product[0].CountTotalPrice();
            Console.WriteLine();

            product[1].GetProduct();
            product[1].CountTotalPrice();
            Console.WriteLine();

            product[2].GetProduct();
            product[2].CountTotalPrice();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
