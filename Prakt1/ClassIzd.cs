using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt1
{
    class ClassIzd
    {
        public string Name;
        public string Shifr;
        public int Count;
        private string v1;
        private string v2;
        private int v3;
        public ClassIzd(string v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public ClassIzd()
        {
        }
        public void GetInfo()
        {
            Console.WriteLine($"Название: {Name} Шифр: {Shifr} Количество: {Count} ");
        }
    }
}
