using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaliInterface
{
    internal class Gatto : IAnimale
    {
        public void Dormi()
        {
            Console.WriteLine("ZZZZMIAO");
        }

        public void FaiVerso()
        {
            Console.WriteLine("MIAO");
        }
    }
}
