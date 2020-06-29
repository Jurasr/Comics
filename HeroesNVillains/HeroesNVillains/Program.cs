using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesNVillains
{
    internal class Batman : IHero
    {
        public double Height { get; set; }
        public bool Gender { get; set; }
        public string Powers { get; set; }

        public void Info()
        {
            Console.WriteLine("NA na na na na");
        }
    }

    internal class Supemenrtas : IHero
    {
        public double Height { get; set; }
        public bool Gender { get; set; }
        public string Powers { get; set; }

        public void Info()
        {
            Console.WriteLine("Hallo");
        }
    }

    internal class Joker : IVillain
    {
        public double Height { get; set; }
        public bool Gender { get; set; }
        public string Powers { get; set; }

        public void Info()
        {
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}