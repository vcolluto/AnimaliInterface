using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaliInterface
{
    internal class Mucca : IAnimale, IInteragisci
    {
        public void Accarezza()
        {
            Console.WriteLine("Grazie!");
        }

        public void Dormi()
        {
            Console.WriteLine("ZZZZMUUU");
        }

        public void FaiVerso()
        {
            Console.WriteLine("MUUU");
        }

        public void Saluta()
        {
            Console.WriteLine("Ciao!");
        }
    }
}
