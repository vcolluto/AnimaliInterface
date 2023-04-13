using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaliInterface
{
    internal class Mucca : IAnimale
    {
        public void Dormi()
        {
            Console.WriteLine("ZZZZMUUU");
        }

        public void FaiVerso()
        {
            Console.WriteLine("MUUU");
        }
    }
}
