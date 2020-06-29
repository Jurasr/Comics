using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesNVillains
{
    interface IHero
    {
        double Height { get; set; }
        bool Gender { get; set; }
        string Powers { get; set; }

        void Info();
        
    }

    interface IVillain
    {
        double Height { get; set; }
        bool Gender { get; set; }
        string Powers { get; set; }

        void Info();

    }

    class Batman : IHero
    {
        public double Height { get; set; }
        public bool Gender { get; set; }
        public string Powers { get; set; }

        public void Info()
        {

        }
    }

    class Joker : IVillain
    {
        public double Height { get; set; }
        public bool Gender { get; set; }
        public string Powers { get; set; }
        public void Info()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
