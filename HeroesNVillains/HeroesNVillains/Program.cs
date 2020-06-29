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

    }

    class Batman : IHero
    {
        public double Height { get; set; }
        public bool Gender { get; set; }
        public string Powers { get; set; }
        public int Wings { get; set; }


        public void Info()
        {

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
