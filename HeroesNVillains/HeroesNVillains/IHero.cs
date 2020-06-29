namespace HeroesNVillains
{
    internal interface IHero
    {
        double Height { get; set; }
        bool Gender { get; set; }
        string Powers { get; set; }

        void Info();
    }
}