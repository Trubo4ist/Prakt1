using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassIzd arr = new ClassIzd("Шапка Мономаха", "фыв123", 4);
            arr.GetInfo();
            Console.ReadKey();
        }
    }
}
