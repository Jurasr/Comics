using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesNVillains
{
    internal class Batman : IHero
    {
        double Height { get; set; }
        bool Gender { get; set; }
        string Powers { get; set; }
        int Wings { get; set; }

        void Info();

        void Fly();

    }

    interface IVillain
    {
        double Height { get; set; }
        bool Gender { get; set; }
        string Powers { get; set; }

        void Info();
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
        public int Wings { get; set; }


        public void Info()
        {
            Console.WriteLine("Hallo");
        }

        public bool Fly()
        {
            if (Wings > 1)
            {
                return true;
            }

            return false;
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