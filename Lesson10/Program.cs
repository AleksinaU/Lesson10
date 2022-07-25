using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        { Corner corner;
            do
            {
                Console.WriteLine("Задайте угол с помощью целочисленных значений");
                int gradus = Convert.ToInt32(Console.ReadLine());
                int min = Convert.ToInt32(Console.ReadLine());
                int sec = Convert.ToInt32(Console.ReadLine());
                corner = new Corner(gradus, min, sec);
            }
            while (corner.isCorrect == false);
            
            double rad = corner.ToRadians();
            Console.WriteLine("Угол в радианах равен {0}", rad);
            Console.ReadKey();
        }
    }
}
