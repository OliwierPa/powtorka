using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powtorka
{
    class Program
    {
        static void Main(string[] args)
        {

            var sloik1 = new Sloik("Walec", "Biały", 4.5, true);

            var sloik2 = new Sloik("Romb", "Czarny", 8.0, false);

            var sloik3 = new Sloik("Walec", "Niebieski", 3.0, true);
                                                                        
            Console.WriteLine(sloik1.ToString());


            Console.ReadLine();
        }
    }
}
