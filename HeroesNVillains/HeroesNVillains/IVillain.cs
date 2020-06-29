namespace HeroesNVillains
{
    internal interface IVillain
    {
        double Height { get; set; }
        bool Gender { get; set; }
        string Powers { get; set; }

        void Info();
    }
}